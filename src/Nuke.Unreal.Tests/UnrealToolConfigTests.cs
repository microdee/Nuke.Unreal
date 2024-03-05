using Xunit;
using Nuke.Unreal.Tools;
using System.Linq;
using System;

namespace Nuke.Unreal.Tests;

public class UnrealToolConfigTests
{
    [Fact]
    public void UbtGenerate()
    {
        var result = new UbtConfig()
            .ProjectFiles()
            .Project("A:/path.uproject")
            .Game()
            .Progress()
            .Gather(new EngineVersion("4.27"));
        Assert.Equal("-ProjectFiles A:/path.uproject -game -Progress", result);
        Assert.Throws<ArgumentException>(() => {
            var faulty = new UbtConfig()
                .ProjectFiles()
                .Project("A:/path")
                .Game()
                .Progress()
                .Gather(new EngineVersion("4.27"));
        });
    }

    [Fact]
    public void UbtBuild()
    {
        var result = new UbtConfig()
            .Targets("RW1", "RW1" + UnrealTargetType.Editor, "SomeOther")
            .Platforms(UnrealPlatform.Win64, UnrealPlatform.Android)
            .Configurations(
                UnrealConfig.Development,
                UnrealConfig.DebugGame,
                UnrealConfig.Shipping
            )
            .Project("A:/path.uproject")
            .Append("-Key=Value with spaces", "-OtherKey")
            .AppendRaw("-just -some--raw -arguments", "-more -here")
            .Gather(new EngineVersion("4.27"));
        Assert.Equal(
            "RW1+RW1Editor+SomeOther -Platforms=Win64+Android Development+DebugGame+Shipping A:/path.uproject"
            + " \"-Key=Value with spaces\" -OtherKey -just -some--raw -arguments -more -here",
            result
        );
    }
}