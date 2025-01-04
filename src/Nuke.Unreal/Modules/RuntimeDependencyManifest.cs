using System;
using System.Collections.Generic;
using Nuke.Common;
using System.Xml.Serialization;
using System.IO;
using Nuke.Common.IO;
using Nuke.Common.Tooling;

namespace Nuke.Unreal.Modules;

/// <summary>
/// List of either runtime dependency files or delay-loaded DLL filenames, separated by configuration
/// </summary>
public class RuntimeDependencyPlatformList
{
    public List<string> Release = new();
    public List<string> Debug = new();
};

/// <summary>
/// List of runtime dependency files relative to the root of an Unreal plugin which then can be
/// read by a module rule to work with.
/// </summary>
/// <remarks>
/// XML serialization is done in this fashion because Unreal Module rules must not depend on other
/// data structures than what .NET provides out of the box.
/// </remarks>
public class RuntimeDependencies
{
    /// <summary>
    /// List of runtime dependency files relative to the root of an Unreal plugin which then can be
    /// read by a module rule to work with. Separated for each platform.
    /// </summary>
    public Dictionary<string, RuntimeDependencyPlatformList> FileDependencies = new();

    /// <summary>
    /// List of DLL file names for PublicDelayLoadDLLs, separated for each platform.
    /// </summary>
    public Dictionary<string, RuntimeDependencyPlatformList> DllDependencies = new();

    public void Serialize(TextWriter writer)
    {
        var serializer = new XmlSerializer(GetType());
        serializer.Serialize(writer, this);
    }

    public void Serialize(AbsolutePath file)
    {
        using TextWriter writer = new StreamWriter(file);
        Serialize(writer);
    }
    
    public static RuntimeDependencies? Deserialize(FileStream stream)
    {
        var serializer = new XmlSerializer(typeof(RuntimeDependencies));
        var result = serializer.Deserialize(stream);
        return result as RuntimeDependencies;
    }

    public static RuntimeDependencies? Deserialize(AbsolutePath file)
    {
        if (file == null || !file.FileExists()) return null;
        using var stream = new FileStream(file, FileMode.Open);
        return Deserialize(stream);
    }
}