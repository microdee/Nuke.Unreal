using Xunit;
using Nuke.Unreal.Ini;
using System.Linq;
using System;
using Nuke.Common.IO;
using System.Runtime.CompilerServices;
using System.IO;

namespace Nuke.Unreal.Tests;

file static class ThisFile
{
    public static AbsolutePath Path([CallerFilePath] string? path = null) => path ?? "C:\\";
    public static AbsolutePath Folder() => Path().Parent;
}

public class ConfigTests
{
    string MainConfig = @"
[SimpleEntries]
; This is a comment
BoolEntry=True
NumberEntry=1.000
PlainStringEntry=They do unspeakable madness in here
StringWithQuotes=""They do unspeakable madness in here""
Struct=(Path=""foobar"", Name=""wizz"")
Dictionary=((""Key"", ""Value""), (""Second"", ""Thing""))
Collection=(1, 2, 3, 4)
Empty=

[Collections]
+FooList=A
+FooList=B
+FooList=C
+FooList=D
-FooList=E
-FooList=F";

    string OtherConfig = @"
[SimpleEntries]
Empty=nope

[Collections]
-FooList=A
-FooList=B

[NewSession]
Foo=Bar";

    [Fact]
    public void Parse()
    {
        var ini = ConfigIni.Parse(MainConfig);
        Assert.NotNull(ini);
        Assert.Collection(
            ini.Sessions.Values,
            s => Assert.Equal("SimpleEntries", s.Name),
            s => Assert.Equal("Collections", s.Name)
        );

        Assert.NotEmpty(ini["SimpleEntries"]?["BoolEntry"]);
    }

    [Fact]
    public void Serialize()
    {
        var ini = ConfigIni.Parse(MainConfig);
        Assert.NotNull(ini);
        Assert.Equal(MainConfig, ini.Serialize());
    }

    [Fact]
    public void Merge()
    {
        var mainIni = ConfigIni.Parse(MainConfig);
        var otherIni = ConfigIni.Parse(OtherConfig);
        Assert.NotNull(mainIni);
        Assert.NotNull(otherIni);
        mainIni.Merge(otherIni);

        Assert.NotNull(mainIni["NewSession"]);
        Assert.NotEmpty(mainIni["SimpleEntries"]?.GetFirst("Empty").Value);
        Assert.False(mainIni["Collections"]?.Commands.Any(c => c.Value == "A"));
        Assert.False(mainIni["Collections"]?.Commands.Any(c => c.Value == "B"));
    }

    [Fact]
    public void Remove()
    {
        var mainIni = ConfigIni.Parse(MainConfig);
        Assert.NotNull(mainIni);

        var section = mainIni["SimpleEntries"];
        Assert.NotNull(section);

        section.Remove("NumberEntry", "BoolEntry", "PlainStringEntry");
        Console.WriteLine(mainIni.Serialize());
        Assert.All(section.Commands, c => Assert.NotEqual("NumberEntry", c.Name));
        Assert.All(section.Commands, c => Assert.NotEqual("BoolEntry", c.Name));
        Assert.All(section.Commands, c => Assert.NotEqual("PlainStringEntry", c.Name));
    }

    [Fact]
    public void SetCommand()
    {
        var mainIni = ConfigIni.Parse(MainConfig);
        Assert.NotNull(mainIni);

        var section = mainIni["SimpleEntries"];
        Assert.NotNull(section);

        section.Set("NumberEntry", "2");
        Assert.Equal("2", section.GetFirst("NumberEntry").Value);

        section.Set("NonExisting", "yep");
        Assert.NotEmpty(section.GetFirst("NonExisting").Value);

        mainIni.FindOrAdd("NewSection").Set("Foo", "Bar");
        Assert.NotNull(mainIni["NewSection"]);
        Assert.NotEmpty(mainIni["NewSection"].GetFirst("Foo").Value);
    }

    [Fact]
    public void FromEmptyString()
    {
        var mainIni = new ConfigIni();
        Assert.NotNull(mainIni);
        
        mainIni.FindOrAdd("NewSection").Set("NewEntry", "yo");
        Assert.Equal("yo", mainIni["NewSection"].GetFirst("NewEntry").Value);
    }

    [Fact]
    public void LineEndings()
    {
        var mainIni = ConfigIni.Parse(File.ReadAllText(ThisFile.Folder() / "DefaultEngine_LF.ini"));
        Assert.NotNull(mainIni);
        Assert.Equal("False", mainIni["/Script/Engine.RendererSettings"]?.GetFirst("r.ClearCoatNormal").Value);

        mainIni = ConfigIni.Parse(File.ReadAllText(ThisFile.Folder() / "DefaultEngine_UTF16LE.ini"));
        Assert.NotNull(mainIni);
        Assert.Equal("False", mainIni["/Script/Engine.RendererSettings"]?.GetFirst("r.ClearCoatNormal").Value);

        mainIni = ConfigIni.Parse(File.ReadAllText(ThisFile.Folder() / "DefaultEngine_UTF16BE.ini"));
        Assert.NotNull(mainIni);
        Assert.Equal("True", mainIni["/Script/NavigationSystem.NavigationSystemV1"]?.GetFirst("bAllowClientSideNavigation").Value);
    }
}