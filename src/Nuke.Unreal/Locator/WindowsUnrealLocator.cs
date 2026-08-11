
using System.Collections.Generic;
using Nuke.Common.IO;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System;
using System.IO;
using Nuke.Common;
using System.Linq;
using Nuke.Common.Utilities;

namespace Nuke.Unreal;

internal class WindowsUnrealLocator : IUnrealLocator
{
    public IEnumerable<UnrealInstance> Instances
    {
        get
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                var discovered = new HashSet<AbsolutePath>();
                var launcherDatRelative = "UnrealEngineLauncher/LauncherInstalled.dat";
                var centralLauncherDat = EnvironmentInfo.SpecialFolder(SpecialFolders.CommonApplicationData) / "Epic" / launcherDatRelative;
                var userLauncherDat = EnvironmentInfo.SpecialFolder(SpecialFolders.LocalApplicationData) / launcherDatRelative;

                foreach (var instance in LauncherInstalledList.FromFile(centralLauncherDat))
                {
                    if (discovered.Add(instance.Path))
                        yield return instance;
                }
                foreach (var instance in LauncherInstalledList.FromFile(userLauncherDat))
                {
                    if (discovered.Add(instance.Path))
                        yield return instance;
                }

                // Engines installed into program files may not be submitted in registry automatically, pure speculation tho
                // var epicGamesProgramFiles = EnvironmentInfo.SpecialFolder(SpecialFolders.ProgramFiles) / "Epic Games";
                // foreach (var engineCandidate in epicGamesProgramFiles.GlobDirectories("UE_*"))
                // {
                //     if ((engineCandidate / "Engine/Build/Build.version").FileExists())
                //     {
                //         var name = engineCandidate.Name.Replace("UE_", "");
                //
                //         if (discovered.Add(engineCandidate))
                //             yield return new (name, engineCandidate);
                //     }
                // }
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

                            if (discovered.Add(path))
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

                            var instanceName = valueName;
                            if (Unreal.IsInstalled(path))
                            {
                                var buildVersion = Unreal.GetBuildVersion(path);
                                instanceName = $"{buildVersion.MajorVersion}.{buildVersion.MinorVersion}";
                            }

                            if (discovered.Add(path))
                                yield return new(instanceName, path);
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
