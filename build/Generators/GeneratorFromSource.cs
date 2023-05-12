using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nuke.Common.IO;

namespace build.Generators;

public abstract class GeneratorFromSource : ToolGenerator
{
    protected readonly RelativePath Programs = (RelativePath) "Engine" / "Source" / "Programs";
    protected virtual AbsolutePath[] GetRoots(string engineVersion, UnrealCompatibility compatibility)
    {
        var programs = Unreal.GetInstance(engineVersion, compatibility).Location / Programs;
        var epicShared = programs / "Shared";
        return new []
        {
            programs / "DotNETCommon" / "DotNETUtilities",
            epicShared / "EpicGames.Build",
            epicShared / "EpicGames.Core",
            epicShared / "EpicGames.IoHash",
            epicShared / "EpicGames.Serialization",
            epicShared / "EpicGames.UHT",
            epicShared / "EpicGames.Perforce",
            epicShared / "EpicGames.BuildGraph",
            epicShared / "EpicGames.Jupiter"
        };
    }
    
    private readonly Dictionary<string, ToolModel> _modelCahce = new();
    protected override ToolModel GetToolModelForEngine(string engineVersion, UnrealCompatibility compatibility)
    {
        return _modelCahce.TryGetValue(engineVersion, out var tool) ? tool : null;
    }
}