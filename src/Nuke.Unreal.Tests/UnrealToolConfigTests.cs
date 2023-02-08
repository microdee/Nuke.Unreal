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
        var result = new UnrealBuildToolConfig()
            .ProjectFiles()
            .Project("A:/path.uproject")
            .Game()
            .Progress()
            .Gather();
        Assert.Equal("-ProjectFiles A:/path.uproject -game -Progress", result);
        Assert.Throws<ArgumentException>(() => {
            var faulty = new UnrealBuildToolConfig()
                .ProjectFiles()
                .Project("A:/path")
                .Game()
                .Progress()
                .Gather();
        });
    }

    [Fact]
    public void UbtBuild()
    {
        var result = new UnrealBuildToolConfig()
            .Target("RW1", "RW1" + UnrealTargetType.Editor, "SomeOther")
            .Platform(UnrealPlatform.Win64, UnrealPlatform.Android)
            .Configuration(
                UnrealConfig.Development,
                UnrealConfig.DebugGame,
                UnrealConfig.Shipping
            )
            .Project("A:/path.uproject")
            .Gather();
        Assert.Equal(
            "RW1+RW1Editor+SomeOther Win64+Android Development+DebugGame+Shipping A:/path.uproject",
            result
        );
    }
}