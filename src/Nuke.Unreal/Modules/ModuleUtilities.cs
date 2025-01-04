using System;
using System.Collections.Generic;
using Nuke.Common;
using System.Xml.Serialization;
using System.IO;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using System.Linq;

namespace Nuke.Unreal.Modules;

public static class ModuleUtilities
{
    public static void RuntimeDependencyManifest(
        this UnrealBuild self,
        AbsolutePath modulePath,
        AbsolutePath? destination = null,
        AbsolutePath? pluginFolder = null
    ) {
        pluginFolder ??= modulePath.GetOwningPlugin()!;
        destination ??= pluginFolder / "Binaries" / "ThirdParty";

        var runtimeDeps = (destination / modulePath.Name).GetFiles(depth: 40)
            .Select(f => pluginFolder.GetRelativePathTo(f).ToUnixRelativePath().ToString());

        var dllDeps = (destination / modulePath.Name / self.Platform)
            .GetFiles("*." + self.Platform.DllExtension, depth: 40)
            .Select(f => f.Name);

        var manifest = RuntimeDependencies.Deserialize(modulePath / "RuntimeDeps.xml") ?? new();
        if (manifest.FileDependencies.ContainsKey(self.Platform))
        {
            manifest.FileDependencies[self.Platform].Release = runtimeDeps.ToList();
        }
        else
        {
            manifest.FileDependencies.Add(self.Platform, new()
            {
                Release = runtimeDeps.ToList()
            });
        }

        if (manifest.DllDependencies.ContainsKey(self.Platform))
        {
            manifest.DllDependencies[self.Platform].Release = dllDeps.ToList();
        }
        else
        {
            manifest.DllDependencies.Add(self.Platform, new()
            {
                Release = runtimeDeps.ToList()
            });
        }

        manifest.Serialize(modulePath / "RuntimeDeps.xml");
    }
}