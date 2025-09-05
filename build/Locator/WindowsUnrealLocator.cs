#nullable enable

using System.Collections.Generic;
using Nuke.Common.IO;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System;
using Nuke.Common;
using System.Linq;
using Nuke.Common.Utilities;

namespace build;

internal class WindowsUnrealLocator : IUnrealLocator
{
    public IEnumerable<UnrealInstance> Instances
    {
        get
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                using (var installed = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\EpicGames\Unreal Engine"))
                {
                    if (installed != null)
                    {
                        foreach (var subKeyName in installed.GetSubKeyNames())
                        {
                            using var subKey = installed.OpenSubKey(subKeyName)!;
                            var candidate = subKey.GetValue("InstalledDirectory") as string;
                            if (candidate == null) continue;

                            var path = AbsolutePath.Create(candidate);
                            if (!path.DirectoryExists()) continue;
                            yield return new(subKeyName, path);
                        }
                    }
                }
                using (var sources = Registry.CurrentUser.OpenSubKey(@"Software\Epic Games\Unreal Engine\Builds"))
                {
                    if (sources != null)
                    {
                        foreach (var valueName in sources.GetValueNames())
                        {
                            var candidate = sources.GetValue(valueName) as string;
                            if (candidate == null) continue;

                            var path = AbsolutePath.Create(candidate);
                            if (!path.DirectoryExists()) continue;
                            yield return new(valueName, path);
                        }
                    }
                }
                yield break;
            }
            else throw new Exception("Trying to use windows implementation of IUnrealLocator on a non-windows platform");
        }
    }

    public AbsolutePath? GetEngine(string name)
    {
        var explicitPath = UnrealLocator.GetExistingUnrealEngine(name);
        if (explicitPath != null) return explicitPath;

        var instance = Instances.FirstOrDefault(i => i.Name.EqualsOrdinalIgnoreCase(name));
        return instance?.Path;
    }
}