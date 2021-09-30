
using System.Runtime.CompilerServices;
using System;
using System.Threading;
using System.Text.RegularExpressions;
using System.Collections.Concurrent;
using System.Diagnostics;

using Konsole;
using Nuke.Common.IO;
using static Nuke.Common.ControlFlow;
using static Nuke.Common.Logger;

namespace Nuke.Unreal
{
    public class UnrealToolOutput
    {

        private ConcurrentWriter _out;

        private void SafeSetCursor(int top, int left)
        {
            try
            {
                _out.CursorTop = top;
                _out.CursorLeft = left;
            }
            catch {}
        }

        private Process _proc;
        private ProcessStartInfo _procStartInfo;
        private bool _compactOutput;
        private bool _cannotDisplayUnimportantOutput = false;

        private ConsoleColor _defaultColor = ConsoleColor.Gray;
        private int _curTop = 0;
        private int _curLeft = 0;
        private string _prevLine = "";
        private int _prevLength = 0;
        private bool _eraseLastLine = false;
        private bool _noOutputProcessingSession;

        private readonly ConcurrentQueue<(Action<string> command, string input)> _outQueue = new();
        private AutoResetEvent _outQueueSemaphore;
        
        public UnrealToolOutput(
            string exePath,
            string arguments
        ) {
            _out = new ConcurrentWriter();
            _procStartInfo = new ProcessStartInfo {
                FileName = exePath,
                Arguments = arguments,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            _outQueueSemaphore = new AutoResetEvent(false);
        }
        
        public UnrealToolOutput WithOnlyResults()
        {
            _compactOutput = true;
            _noOutputProcessingSession = false;
            return this;
        }
        public UnrealToolOutput WithoutUnimportant()
        {
            _compactOutput = true;
            _noOutputProcessingSession = true;
            return this;
        }

        public UnrealToolOutput WithWorkingDir(AbsolutePath workingDir)
        {
            _procStartInfo.WorkingDirectory = workingDir;
            return this;
        }

        public UnrealToolOutput Run()
        {
            Normal($"Running: {_procStartInfo.FileName}");
            Normal("         " + string.Join(' ', _procStartInfo.Arguments));
            
            try
            {
                _curLeft = _out.CursorLeft;
                _curTop = _out.CursorTop;
                _out.CursorVisible = false;
                _defaultColor = _out.ForegroundColor;
            }
            catch
            {
                _cannotDisplayUnimportantOutput = true;
            }

            _proc = new Process
            {
                StartInfo = _procStartInfo
            };
            _proc.OutputDataReceived += HandleOutput;
            _proc.ErrorDataReceived += HandleOutput;
            _proc.Start();
            _proc.BeginOutputReadLine();
            _proc.BeginErrorReadLine();
            _proc.WaitForExit();
            if(_outQueue.Count > 0)
            {
                _outQueue.Enqueue((_ => _outQueueSemaphore.Set(), ""));
                _outQueueSemaphore.WaitOne();
            }
            if(!_cannotDisplayUnimportantOutput)
            {
                _out.ForegroundColor = _defaultColor;
            }
            _out.WriteLine("Unreal Task completed");

            Assert(_proc.ExitCode == 0, "Unreal Task exited with a non-zero exit code.");
            return this;
        }

        private bool IsRunningUnattended() =>
            // Test if running in Gitlab CI/CD
            Environment.GetEnvironmentVariable("CI_BUILD_REF_SLUG") != null;

        private void WriteUnimportant(string line)
        {
            // TODO: writelog

            if(IsRunningUnattended() || _cannotDisplayUnimportantOutput) return;

            if(!_eraseLastLine)
            {
                _prevLength = 0;
                _prevLine = "";
                _curLeft = _out.CursorLeft;
                _curTop = _out.CursorTop;
            }
            if(line == _prevLine)
                return;

            _out.Write(new string(' ', _prevLength));
            SafeSetCursor(_curTop, _curLeft);
            _prevLength = line.Length;
            _prevLine = line;
            _out.Write("\r" + line);
            SafeSetCursor(_curTop, _curLeft);
            _eraseLastLine = true;
        }

        private void WriteImportant(string line)
        {
            if(_cannotDisplayUnimportantOutput)
            {
                _out.WriteLine(line);
            }
            else
            {
                if(_eraseLastLine)
                {
                    _out.Write(new string(' ', _prevLength));
                    SafeSetCursor(_curTop, _curLeft);
                }
                _out.WriteLine(line);
                _eraseLastLine = false;
            }
        }

        private void HandleOutput(object sender, DataReceivedEventArgs e)
        {
            string input = e.Data?.Trim() ?? "";
            if(_compactOutput)
            {
                bool queueWasEmpty = _outQueue.Count == 0;
                _outQueue.Enqueue((new Action<string>(WriteOutput) + Proceed, input));
                if(queueWasEmpty) Proceed(input);
            }
            else
            {
                _out.WriteLine(input);
            }
        }

        private void Proceed(string _)
        {
            if(_outQueue.TryDequeue(out var next))
            {
                next.command(next.input);
            }
        }
        
        bool Contains(string line, string text) => line.Contains(text, StringComparison.InvariantCultureIgnoreCase);

        private void WriteOutput(string input)
        {
            _out.ForegroundColor = _defaultColor;

            // VS building step
            if(Regex.IsMatch(input, @"\[\d+?\/\d+?\]\s"))
            {
                WriteUnimportant(input);
                return;
            }

            // VS Creating library
            if(input.StartsWith("Creating library", StringComparison.InvariantCultureIgnoreCase))
            {
                WriteUnimportant(input);
                return;
            }

            // VS building end
            if(Contains(input, "Total execution time:"))
            {
                _noOutputProcessingSession = false;
                WriteImportant(input);
                return;
            }

            // VS building end
            if(Contains(input, "BUILD COMMAND COMPLETED"))
            {
                _noOutputProcessingSession = false;
                return;
            }

            if(Contains(input, "warning"))
                _out.ForegroundColor = ConsoleColor.Yellow;
            
            if(Contains(input, "error") || Contains(input, "fail"))
            {
                _out.ForegroundColor = ConsoleColor.Red;
                WriteImportant(input);
                return;
            }

            if(_noOutputProcessingSession)
            {
                WriteImportant(input);
                return;
            }

            // VS Building begin
            if(Contains(input, "Creating makefile for"))
            {
                _noOutputProcessingSession = true;
                WriteImportant(input);
                return;
            }

            // VS Building begin
            if(Contains(input, "BUILD COMMAND STARTED"))
                _noOutputProcessingSession = true;

            // UE session start
            if(input.StartsWith("****"))
            {
                _out.ForegroundColor = ConsoleColor.Green;
                WriteImportant(input);
                return;
            }

            // don't keep flushing shader jobs
            if(Contains(input, "Flushing Shader Jobs"))
            {
                WriteUnimportant(input);
                return;
            }

            // Keep Cook results
            if(Contains(input, "LogCookCommandlet"))
            {
                WriteImportant(input);
                return;
            }

            // Keep Cook results
            if(Contains(input, "LogInit: Display:"))
            {
                WriteImportant(input);
                return;
            }

            // Keep tool finish
            if(Contains(input, "ExitCode"))
            {
                WriteImportant(input);
                return;
            }

            // Keep BUILD SUCCESSFUL
            if(Contains(input, "BUILD SUCCESSFUL"))
            {
                _out.ForegroundColor = ConsoleColor.Green;
                WriteImportant(input);
                return;
            }

            // nothing else is considered to be "important"
            WriteUnimportant(input);
        }
    }
}