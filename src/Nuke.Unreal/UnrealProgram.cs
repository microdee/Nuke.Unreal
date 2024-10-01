using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Nuke.Common.IO;
using Nuke.Common.Tooling;

namespace Nuke.Unreal
{
    public interface IProgramInfo
    {
        RelativePath PathToProject { get; }
    }

    [TypeConverter(typeof(TypeConverter<UnrealProgram>))]
    public abstract class UnrealProgram : Enumeration
    {
        public IProgramInfo GetProgram()
        {
            var programType = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .First(t =>
                    typeof(IProgramInfo).IsAssignableFrom(t)
                    && !t.IsInterface
                    && !t.IsAbstract
                    && t.Name.Equals(Value, StringComparison.InvariantCultureIgnoreCase)
                );
            return (IProgramInfo)Activator.CreateInstance(programType)!;
        }
        
        public static implicit operator string(UnrealProgram configuration)
        {
            return configuration.Value;
        }
        public static TProgramList MakeProgram<TProgramList, TProgram>()
            where TProgramList : UnrealProgram, new()
            where TProgram : IProgramInfo
            {
                return new TProgramList() { Value = typeof(TProgram).Name };
            }
    }
}