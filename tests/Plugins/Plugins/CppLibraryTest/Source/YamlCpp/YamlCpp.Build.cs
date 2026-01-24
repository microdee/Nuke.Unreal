// Fill in Copyright info...

using System;
using Microsoft.Extensions.Logging;
using UnrealBuildTool;

public partial class YamlCpp : ModuleRules
{
	bool IsDebug;
	bool PlatformSetup = false;
	bool IncludesSetup = false;
	string LibraryConfig;
	string LibraryPlatform;

	public YamlCpp(ReadOnlyTargetRules target) : base(target)
	{
		// This is the main module file for using yaml-cpp in Unreal Engine.
		// Because each individual platform can carry different requirements for yaml-cpp,
		// includes and lib imports are expressed in platform specific partial classes. These are
		// auto generated when the library is prepared on/for a specific platform.

		Type = ModuleType.External;
		IsDebug = Target.Configuration <= UnrealTargetConfiguration.DebugGame;
		LibraryConfig = IsDebug ? "Debug" : "Release";
		LibraryPlatform = target.Platform.ToString();

		// Write user defined setup here

		// Set up library headers
		SetupLibrary_Includes(target);

		// Optional platform specific library setup:
		
				if (target.Platform == UnrealTargetPlatform.Win64)
					SetupLibrary_Win64(target);
				
				if (target.Platform == UnrealTargetPlatform.Mac)
					SetupLibrary_Mac(target);
				
				if (target.Platform == UnrealTargetPlatform.Linux)
					SetupLibrary_Linux(target);
				
				if (target.Platform == UnrealTargetPlatform.LinuxArm64)
					SetupLibrary_LinuxArm64(target);
				
				if (target.Platform == UnrealTargetPlatform.Android)
					SetupLibrary_Android(target);
				
				if (target.Platform == UnrealTargetPlatform.IOS)
					SetupLibrary_IOS(target);
				
				if (target.Platform == UnrealTargetPlatform.TVOS)
					SetupLibrary_TVOS(target);
				
		if (!PlatformSetup || !IncludesSetup)
		{
			Logger.LogWarning(
				$"yaml-cpp was not set up for {target.Platform}."
				+ $"\n Libraries are prepared for platforms listed in the SupportedTargetPlatforms"
				+ $"\n field in the host .uplugin descriptor. Add {target.Platform} and run:"
				+ $"\n > nuke PrepareYamlCpp"
				+  "\n This library may not compile without that."
			);
		}
	}
	
	partial void SetupLibrary_Includes(ReadOnlyTargetRules target);
	partial void SetupLibrary_Win64(ReadOnlyTargetRules target);
	partial void SetupLibrary_Mac(ReadOnlyTargetRules target);
	partial void SetupLibrary_Linux(ReadOnlyTargetRules target);
	partial void SetupLibrary_LinuxArm64(ReadOnlyTargetRules target);
	partial void SetupLibrary_Android(ReadOnlyTargetRules target);
	partial void SetupLibrary_IOS(ReadOnlyTargetRules target);
	partial void SetupLibrary_TVOS(ReadOnlyTargetRules target);
}