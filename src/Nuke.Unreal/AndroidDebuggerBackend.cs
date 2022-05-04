using System;
using System.ComponentModel;
using System.Linq;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Tooling;

namespace Nuke.Unreal
{
    [TypeConverter(typeof(TypeConverter<AndroidDebuggerBackend>))]
    public class AndroidDebuggerBackend : Enumeration
    {
        public static AndroidDebuggerBackend LLDB = new()
        {
            Value = nameof(LLDB),
            ServerProgramName = "lldb-server",
            ServerProgramPath = cpu => (RelativePath) "toolchains" / "llvm" / "prebuilt" / "windows-x86_64" / "lib64" / "clang" / "9.0.9" / "lib" / "linux" / cpu.AltName,
            LaunchArguments = (port, pid) => $"platform --listen *:{port}"
        };
        public static AndroidDebuggerBackend GDB = new()
        {
            Value = nameof(GDB),
            ServerProgramName = "gdbserver",
            ServerProgramPath = cpu => (RelativePath) "prebuilt" / $"android-{cpu.ToString().ToLower()}" / "gdbserver" / "gdbserver",
            LaunchArguments = (port, pid) => $":{port} --attach {pid}"
        };

        public string ServerProgramName { get; init; }
        public Func<AndroidProcessorArchitecture /* cpu */, RelativePath /* -> pathInNdk */> ServerProgramPath { get; init; }
        public Func<int /* port */, int /* pid */, string /* -> args */> LaunchArguments { get; init; }
        
        public static implicit operator string(AndroidDebuggerBackend configuration)
        {
            return configuration.Value;
        }
    }
}