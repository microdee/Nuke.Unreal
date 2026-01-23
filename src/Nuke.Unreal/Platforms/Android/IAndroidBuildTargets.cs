using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Tooling;

namespace Nuke.Unreal.Platforms.Android;

[ParameterPrefix("Android")]
public interface IAndroidBuildTargets : INukeBuild
{
    [Parameter("Specify the full qualified android app name")]
    string AppName => TryGetValue(() => AppName) ?? this.GetAppNameFromConfig();

    [Parameter]
    int? Jdk => TryGetValue<int?>(() => Jdk);

    [Parameter]
    int? Sdk => TryGetValue<int?>(() => Sdk);
    
    [Parameter("Processor architecture of your target hardware")]
    AndroidProcessorArchitecture Cpu => TryGetValue(() => Cpu) ?? AndroidProcessorArchitecture.Arm64;

    Target CleanIntermediateAndroid => _ => _
        .Description("Clean up the Android folder inside Intermediate")
        .OnlyWhenStatic(this.IsAndroidPlatform)
        .DependentFor<UnrealBuild>(u => u.Build)
        .DependentFor<IPackageTargets>(p => p.Package)
        .Executes(() =>
        {
            var self = (UnrealBuild) this;
            (self.ProjectFolder / "Intermediate" / "Android").DeleteDirectory();
        });

    Target SignApk => _ => _
        .Description("Sign the output APK")
        .OnlyWhenStatic(this.IsAndroidPlatform)
        .DependsOn<UnrealBuild>(u => u.SetupPlatformSdk)
        .TriggeredBy<IPackageTargets>(p => p.Package)
        // .Before(InstallOnAndroid, DebugOnAndroid)
        .After<UnrealBuild>(u => u.Build)
        .Executes(() =>
        {
            var self = (UnrealBuild) this;
            var androidRuntimeSettings = self.ReadIniHierarchy("Engine")?["/Script/AndroidRuntimeSettings.AndroidRuntimeSettings"];
            var keyStore = androidRuntimeSettings?.GetFirst("KeyStore").Value;
            var password = androidRuntimeSettings?.GetFirst("KeyStorePassword").Value;
            var keystorePath = self.ProjectFolder / "Build" / "Android" / keyStore;

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

            var sdk = self.GetAndroidSdk();
            sdk.GetApkSigner(this)(
                $"sign --ks \"{keystorePath}\" --ks-pass \"file:{kspassFile}\" \"{this.GetApkFile()}\""
            );
        });
}
