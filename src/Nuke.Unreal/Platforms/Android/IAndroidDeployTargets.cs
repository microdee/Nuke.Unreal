using System;
using System.Linq;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using Serilog;

namespace Nuke.Unreal.Platforms.Android;

/// <summary>
/// Build component for common tasks debugging an Android app
/// </summary>
[ParameterPrefix("Android")]
public interface IAndroidDeployTargets : IUnrealBuild
{
    /// <summary>
    /// <para>
    /// **NUKE PARAMETER**
    /// </para>
    /// Disable uninstalling before deploying a new APK
    /// </summary>
    [Parameter]
    bool NoUninstall => TryGetValue<bool?>(() => NoUninstall) ?? false;

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Package and install the product on a connected android device.
    /// Only executed when target-platform is set to Android.
    /// <code>
    ///     \--NoUninstall
    ///     \--AppName (adv.)
    /// </code>
    /// </summary>
    Target InstallOnAndroid => _ => _
        .Description(
            """
            |
                | Package and install the product on a connected android device.
                | Only executed when target-platform is set to Android
                |
                | --NoUninstall
                | --AppName (adv.)
            
            """
        )
        .OnlyWhenStatic(this.IsAndroidPlatform)
        .DependsOn(SetupPlatformSdk)
        .After<IPackageTargets>(p => p.Package)
        .After(Build)
        .Executes(() =>
        {
            var adb = this.GetAndroidSdk().GetAdb(this);
            var appName = this.GetAppName();

            var apkFile = this.GetApkFile();
            Assert.True(apkFile.FileExists());

            if (!NoUninstall)
            {
                try
                {
                    Log.Information("Uninstall {0} (failures here are not fatal)", appName);
                    adb($"uninstall {appName}");
                }
                catch (Exception e)
                {
                    Log.Warning(e, "Uninstallation threw errors, but that might not be a problem");
                }
            }

            Log.Information("Installing {0}", apkFile);
            adb($"install {apkFile}");

            var storagePath = adb("shell echo $EXTERNAL_STORAGE")!
                .FirstOrDefault(o => !string.IsNullOrWhiteSpace(o.Text))
                .Text;

            Assert.False(string.IsNullOrWhiteSpace(storagePath), "Couldn't get a storage path from the device");

            if (!NoUninstall)
            {
                try
                {
                    Log.Information("Removing existing assets from device (failures here are not fatal)");
                    adb($"shell rm -r {storagePath}/UE4Game/{ProjectName}");
                    adb($"shell rm -r {storagePath}/UE4Game/UE4CommandLine.txt");
                    adb($"shell rm -r {storagePath}/obb/{appName}");
                    adb($"shell rm -r {storagePath}/Android/obb/{appName}");
                    adb($"shell rm -r {storagePath}/Download/obb/{appName}");
                }
                catch (Exception e)
                {
                    Log.Warning(e, "Removing existing asset files threw errors, but that might not be a problem");
                }
            }

            var obbName = $"main.1.{appName}";
            var obbFile = apkFile.Parent / (obbName + ".obb");

            if (obbFile.FileExists())
            {
                Log.Information("Installing {0}", obbFile);

                adb($"push {obbFile} {storagePath}/obb/{appName}/{obbName}.obb");
            }

            Log.Information("Grant READ_EXTERNAL_STORAGE and WRITE_EXTERNAL_STORAGE to the apk for reading OBB file or game file in external storage.");

            adb($"shell pm grant {appName} android.permission.READ_EXTERNAL_STORAGE");
            adb($"shell pm grant {appName} android.permission.WRITE_EXTERNAL_STORAGE");

            Log.Information("Done installing {0}", appName);
        });

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Launch the product on android but wait for debugger. Only executed when target-platform is set to Android
    /// <code>
    ///     \--AppName (adv.)
    /// </code>
    /// </summary>
    Target DebugOnAndroid => _ => _
        .Description(
            """
            |
                | Launch the product on android but wait for debugger.
                | This requires ADB to be in your PATH and NDK to be correctly configured.
                | Only executed when target-platform is set to Android
                | 
                | --AppName (adv.)
            """
        )
        .OnlyWhenStatic(this.IsAndroidPlatform)
        .DependsOn(SetupPlatformSdk)
        .After(InstallOnAndroid)
        .Executes(() =>
        {
            var adb = this.GetAndroidSdk().GetAdb(this);
            var appName = this.GetAppName();

            Log.Information("Running {0} but wait for a debugger to be attached", appName);
            adb($"shell am start -D -n {appName}/com.epicgames.ue4.GameActivity");
        });
}
