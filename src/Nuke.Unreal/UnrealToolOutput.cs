
using System;
using System.Threading;
using System.Text.RegularExpressions;
using System.Collections.Concurrent;
using System.Diagnostics;

using Konsole;
using Nuke.Common.IO;
using static Nuke.Common.ControlFlow;

namespace Nuke.Unreal
{
    public class UnrealToolOutput
    {
        private ConcurrentWriter _out;
        private Process _proc;
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
            AbsolutePath workingDir,
            string arguments,
            bool compactOutput = false,
            bool explicitUnimportance = false
        ) {
            _compactOutput = compactOutput;
            _noOutputProcessingSession = explicitUnimportance;
            _out = new ConcurrentWriter();
            _proc = new Process {
                StartInfo = new ProcessStartInfo {
                    FileName = exePath,
                    Arguments = arguments,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    WorkingDirectory = workingDir,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true
                }
            };
            _proc.OutputDataReceived += HandleOutput;
            _proc.ErrorDataReceived += HandleOutput;
            _outQueueSemaphore = new AutoResetEvent(false);
        }

        public UnrealToolOutput(
            AbsolutePath exePath,
            string arguments,
            bool compactOutput = false,
            bool explicitUnimportance = false,
            AbsolutePath workingDir = null
        ) : this(
            exePath,
            workingDir ?? exePath.Parent,
            arguments,
            compactOutput,
            explicitUnimportance
        ) { }

        public UnrealToolOutput Run()
        {
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
            _out.CursorLeft = _curLeft;
            _out.CursorTop = _curTop;
            _prevLength = line.Length;
            _prevLine = line;
            _out.Write("\r" + line);
            _out.CursorLeft = _curLeft;
            _out.CursorTop = _curTop;
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
                    _out.CursorLeft = _curLeft;
                    _out.CursorTop = _curTop;
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