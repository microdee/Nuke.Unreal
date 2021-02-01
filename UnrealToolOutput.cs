
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

        private ConsoleColor _defaultColor = ConsoleColor.Gray;
        private int _curTop = 0;
        private int _curLeft = 0;
        private string _prevLine = "";
        private int _prevLength = 0;
        private bool _eraseLastLine = false;
        private bool _noOutputProcessingSession = false;

        private readonly ConcurrentQueue<(Action<string> command, string input)> _outQueue = new();
        private AutoResetEvent _outQueueSemaphore;

        public UnrealToolOutput(AbsolutePath exePath, string arguments, bool compactOutput = false, AbsolutePath workingDir = null)
        {
            _out = new ConcurrentWriter();
            _proc = new Process {
                StartInfo = new ProcessStartInfo {
                    FileName = exePath,
                    Arguments = arguments,
                    UseShellExecute = false,
                    WorkingDirectory = workingDir ?? exePath.Parent,
                    RedirectStandardError = compactOutput,
                    RedirectStandardOutput = compactOutput
                }
            };
            _proc.OutputDataReceived += HandleOutput;
            _proc.ErrorDataReceived += HandleOutput;
            _outQueueSemaphore = new AutoResetEvent(false);
        }

        public UnrealToolOutput Run()
        {
            _curLeft = _out.CursorLeft;
            _curTop = _out.CursorTop;
            _out.CursorVisible = false;
            _proc.Start();
            _proc.WaitForExit();
            if(_outQueue.Count > 0)
            {
                _outQueue.Enqueue((_ => _outQueueSemaphore.Set(), ""));
                _outQueueSemaphore.WaitOne();
            }
            _out.ForegroundColor = _defaultColor;
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

            if(IsRunningUnattended()) return;

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
            if(_eraseLastLine)
            {
                _out.Write(new string(' ', _prevLength));
                _out.CursorLeft = _curLeft;
                _out.CursorTop = _curTop;
            }
            _out.WriteLine(line);
            _eraseLastLine = false;
        }

        private void HandleOutput(object sender, DataReceivedEventArgs e)
        {
            string input = e.Data?.Trim() ?? "";
            bool queueWasEmpty = _outQueue.Count == 0;
            _outQueue.Enqueue((new Action<string>(WriteOutput) + Proceed, input));
            if(queueWasEmpty) Proceed(input);
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