using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nuke.Common.Tooling;
using Nuke.Common.IO;
using System.Collections.Concurrent;
using System.Reflection;
using System.IO;
using System.Runtime.InteropServices;
using build.Generators;
using System.Runtime.Loader;
using Nuke.Common;
using Serilog;

namespace build;

public class UnrealDotnetAssemblies
{
    public interface IDlls
    {
        AbsolutePath DotNETUtilities { get; }
        AbsolutePath UnrealBuildTool { get; }
    }
    public class Dlls4 : IDlls
    {
        public Dlls4(AbsolutePath location) => _engineDotnetPath = location / "Engine" / "Binaries" / "DotNET";

        private readonly AbsolutePath _engineDotnetPath;
    
        public AbsolutePath DotNETUtilities => _engineDotnetPath / "DotNETUtilities.dll";
        public AbsolutePath UnrealBuildTool => _engineDotnetPath / "UnrealBuildTool.exe";
    }

    public class Dlls5 : IDlls
    {
        public Dlls5(AbsolutePath location) => _engineDotnetPath = location / "Engine" / "Binaries" / "DotNET";

        private readonly AbsolutePath _engineDotnetPath;
    
        public AbsolutePath DotNETUtilities => _engineDotnetPath / "UnrealBuildTool" / "EpicGames.Core.dll";
        public AbsolutePath UnrealBuildTool => _engineDotnetPath / "UnrealBuildTool" / "UnrealBuildTool.dll";
    }

    public UnrealDotnetAssemblies(AbsolutePath location, UnrealCompatibility compatibility)
    {
        if((compatibility & UnrealCompatibility.UE_5) > 0)
        {
            DllPaths = new Dlls5(location);
        }
        else
        {
            DllPaths = new Dlls4(location);
        }
        Context = new AssemblyLoadContext(compatibility.ToString(), true);
    }

    public readonly IDlls DllPaths;

    public readonly AssemblyLoadContext Context;

    private Assembly LoadAssembly(AbsolutePath file)
    {
        var result = Context.LoadFromAssemblyPath(file);
        // var result = Assembly.LoadFrom(file);
        var xmlPath = file.Parent / (file.NameWithoutExtension + ".xml");
        if (xmlPath.FileExists())
        {
            Towel.Meta.LoadXmlDocumentation(File.ReadAllText(xmlPath));
        }
        return result;
    }
    
    private Assembly _dotNetUtilities;
    public  Assembly  DotNETUtilities  => _dotNetUtilities ??= LoadAssembly(DllPaths.DotNETUtilities);
    private Assembly _unrealBuildTool;
    public  Assembly  UnrealBuildTool  => _unrealBuildTool ??= LoadAssembly(DllPaths.UnrealBuildTool);
}

public record UnrealEngineInstance(string Version, AbsolutePath Location, UnrealDotnetAssemblies Assemblies);

public static class Unreal
{
    public static AbsolutePath GetEnginePath(string engineAssociation)
    {
        IUnrealLocator locator = RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
            ? new WindowsUnrealLocator()
            : new GenericUnrealLocator();

        Log.Debug("Looking for Unreal Engine installation {0}", engineAssociation);

        var path = locator.GetEngine(engineAssociation);
        path.NotNull("Couldn't find Unreal Engine with that association");

        Log.Debug("Found at: {0}", path!);
        return path!;
    }

    private static readonly ConcurrentDictionary<string, UnrealEngineInstance> Instances = new();

    public static UnrealEngineInstance GetInstance(string version, UnrealCompatibility compatibility) => Instances.GetOrAdd(version, v =>
    {
        var location = GetEnginePath(version);
        return new(v, location, new(location, compatibility));
    });
}