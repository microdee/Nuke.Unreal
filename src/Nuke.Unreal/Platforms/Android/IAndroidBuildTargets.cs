using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Tooling;

namespace Nuke.Unreal.Platforms.Android;

/// <summary>
/// Build component for common tasks related to building an Android app
/// </summary>
[ParameterPrefix("Android")]
public interface IAndroidBuildTargets : IUnrealBuild
{
    /// <summary>
    /// <para>
    /// **NUKE PARAMETER**
    /// </para>
    /// Specify the full qualified android app name
    /// </summary>
    [Parameter]
    string AppName => TryGetValue(() => AppName) ?? this.GetAppNameFromConfig();

    /// <summary>
    /// <para>
    /// **NUKE PARAMETER**
    /// </para>
    /// Temporarily override the major JDK version used for Android tasks
    /// </summary>
    [Parameter]
    int? Jdk => TryGetValue<int?>(() => Jdk);

    /// <summary>
    /// <para>
    /// **NUKE PARAMETER**
    /// </para>
    /// Temporarily override the major Android SDK version used for Android tasks
    /// </summary>
    [Parameter]
    int? Sdk => TryGetValue<int?>(() => Sdk);

    /// <summary>
    /// <para>
    /// **NUKE PARAMETER**
    /// </para>
    /// Processor architecture of your target hardware
    /// </summary>
    [Parameter]
    AndroidProcessorArchitecture Cpu => TryGetValue(() => Cpu) ?? AndroidProcessorArchitecture.Arm64;

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Clean up the Android folder inside Intermediate
    /// </summary>
    Target CleanIntermediateAndroid => _ => _
        .Description(
            """
            |
                | Clean up the Android folder inside Intermediate
            
            """
        )
        .OnlyWhenStatic(this.IsAndroidPlatform)
        .DependentFor(Build)
        .DependentFor<IPackageTargets>(p => p.Package)
        .Executes(() =>
        {
            (ProjectFolder / "Intermediate" / "Android").DeleteDirectory();
        });

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Sign the output APK
    /// </summary>
    Target SignApk => _ => _
        .Description(
            """
            |
                | Sign the output APK
            
            """
        )
        .OnlyWhenStatic(this.IsAndroidPlatform)
        .DependsOn(SetupPlatformSdk)
        .TriggeredBy<IPackageTargets>(p => p.Package)
        // .Before(InstallOnAndroid, DebugOnAndroid)
        .After(Build)
        .Executes(() =>
        {
            var androidRuntimeSettings = ReadIniHierarchy("Engine")?["/Script/AndroidRuntimeSettings.AndroidRuntimeSettings"];
            var keyStore = androidRuntimeSettings?.GetFirst("KeyStore").Value;
            var password = androidRuntimeSettings?.GetFirst("KeyStorePassword").Value;
            var keystorePath = ProjectFolder / "Build" / "Android" / keyStore;

            Assert.False(string.IsNullOrWhiteSpace(keyStore), "There was no keystore specified");
            Assert.True(keystorePath.FileExists(), "Specified keystore was not found");

            if (string.IsNullOrWhiteSpace(password))
                password = androidRuntimeSettings?.GetFirst("KeyPassword").Value;

            Assert.False(string.IsNullOrWhiteSpace(password), "There was no keystore password specified");

            // save the password in a temporary file so special characters not appreciated by batch will not cause trouble
            var kspassFile = TemporaryDirectory / "Android" / "kspass";
            if (!kspassFile.Parent.DirectoryExists())
            {
                kspassFile.Parent.CreateDirectory();
            }
            kspassFile.WriteAllText(password);

            var sdk = this.GetAndroidSdk();
            sdk.GetApkSigner(this)(
                $"sign --ks \"{keystorePath}\" --ks-pass \"file:{kspassFile}\" \"{this.GetApkFile()}\""
            );
        });
}
