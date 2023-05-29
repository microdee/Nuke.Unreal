using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using Nuke.Common.Tooling;

namespace Nuke.Unreal
{
    [TypeConverter(typeof(TypeConverter<UnrealTargetType>))]
    public class UnrealTargetType : Enumeration
    {
        public static readonly UnrealTargetType Game = new() { Value = nameof(Game) };
        public static readonly UnrealTargetType Editor = new() { Value = nameof(Editor) };
        public static readonly UnrealTargetType Client = new() { Value = nameof(Client) };
        public static readonly UnrealTargetType Server = new() { Value = nameof(Server) };
        public static readonly UnrealTargetType Program = new() { Value = nameof(Program) };

        public static implicit operator string(UnrealTargetType configuration)
        {
            return configuration.Value;
        }
    }
}