// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class PackagingTarget : TargetRules
{
	public PackagingTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V3;

		ExtraModuleNames.AddRange( new string[] { "Packaging" } );
	}
}
