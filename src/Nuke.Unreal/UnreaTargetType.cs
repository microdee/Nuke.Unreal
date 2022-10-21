using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using Nuke.Common.Tooling;

namespace Nuke.Unreal
{
    [TypeConverter(typeof(TypeConverter<UnreaTargetType>))]
    public class UnreaTargetType : Enumeration
    {
        public static UnreaTargetType Game = new() { Value = nameof(Game) };
        public static UnreaTargetType Editor = new() { Value = nameof(Editor) };
        public static UnreaTargetType Client = new() { Value = nameof(Client) };
        public static UnreaTargetType Server = new() { Value = nameof(Server) };
        public static UnreaTargetType Program = new() { Value = nameof(Program) };

        public static implicit operator string(UnreaTargetType configuration)
        {
            return configuration.Value;
        }
    }
}