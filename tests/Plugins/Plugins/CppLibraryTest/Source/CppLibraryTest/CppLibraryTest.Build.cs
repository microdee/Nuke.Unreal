// Fill in Copyright info...

using UnrealBuildTool;

public class CppLibraryTest : ModuleRules
{
	public CppLibraryTest(ReadOnlyTargetRules Target) : base(Target)
	{
		PublicDependencyModuleNames.AddRange(new[] {
			"Core",
		});
			
		
		PrivateDependencyModuleNames.AddRange(new[] {
			"CoreUObject",
		});
	}
}