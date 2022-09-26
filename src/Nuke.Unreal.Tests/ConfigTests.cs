using Xunit;
using Nuke.Unreal.Config;
using System.Linq;
using System;

namespace Nuke.Unreal.Tests;

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
        Assert.Equal(MainConfig, ini.Serialize());
    }

    [Fact]
    public void Merge()
    {
        var mainIni = ConfigIni.Parse(MainConfig);
        var otherIni = ConfigIni.Parse(OtherConfig);
        mainIni.Merge(otherIni);

        Assert.NotNull(mainIni["NewSession"]);
        Assert.NotEmpty(mainIni["SimpleEntries"]?["Empty"].FirstOrDefault().Value);
        Assert.False(mainIni["Collections"]?.Commands.Any(c => c.Value == "A"));
        Assert.False(mainIni["Collections"]?.Commands.Any(c => c.Value == "B"));
    }
}