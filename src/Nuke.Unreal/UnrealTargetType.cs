using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using Nuke.Common.Tooling;
using Newtonsoft.Json;

namespace Nuke.Unreal
{
    /// <summary>
    /// The regular target types UBT supports
    /// </summary>
    [TypeConverter(typeof(TypeConverter<UnrealTargetType>))]
    [JsonConverter(typeof(EnumerationJsonConverter<UnrealTargetType>))]
    public class UnrealTargetType : Enumeration
    {
        /// <summary>
        /// Can act as both client and server
        /// </summary>
        public static readonly UnrealTargetType Game = new() { Value = nameof(Game) };

        /// <summary>
        /// Editor builds for the project
        /// </summary>
        public static readonly UnrealTargetType Editor = new() { Value = nameof(Editor) };

        /// <summary>
        /// Can only act like a client, cannot host a multiplayer session on its own
        /// </summary>
        public static readonly UnrealTargetType Client = new() { Value = nameof(Client) };

        /// <summary>
        /// Headless version of the game running in dedicated server. (can be built only with
        /// engine source)
        /// </summary>
        public static readonly UnrealTargetType Server = new() { Value = nameof(Server) };

        /// <summary>
        /// Arbitrary extra programs (can be built only with engine source)
        /// </summary>
        public static readonly UnrealTargetType Program = new() { Value = nameof(Program) };

        public static implicit operator string(UnrealTargetType configuration)
        {
            return configuration.Value;
        }
    }
}