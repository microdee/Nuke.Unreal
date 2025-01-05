using System;
using System.Collections.Generic;
using Nuke.Common;
using System.Xml.Serialization;
using System.IO;
using System.Linq;
using Nuke.Common.IO;
using Nuke.Common.Tooling;

namespace Nuke.Unreal.Modules;

public class RuntimeDependency
{
    [XmlText]
    public string Value = "";

    [XmlAttribute]
    public string? Platform;

    [XmlAttribute]
    public string? Config;
};

public class RuntimeDependencies
{
    [XmlElement]
    public RuntimeDependency[] RuntimeLibraryPath = [];
    public RuntimeDependency[] Files = [];
    public RuntimeDependency[] Dlls = [];

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