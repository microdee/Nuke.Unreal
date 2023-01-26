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
        public static UnrealTargetType Game = new() { Value = nameof(Game) };
        public static UnrealTargetType Editor = new() { Value = nameof(Editor) };
        public static UnrealTargetType Client = new() { Value = nameof(Client) };
        public static UnrealTargetType Server = new() { Value = nameof(Server) };
        public static UnrealTargetType Program = new() { Value = nameof(Program) };

        public static implicit operator string(UnrealTargetType configuration)
        {
            return configuration.Value;
        }
    }
}