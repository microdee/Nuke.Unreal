namespace Nuke.Unreal.Plugins;

public enum LocalizationTargetDescriptorLoadingPolicy
{	Never,
	Always,
	Editor,
	Game,
	PropertyNames,
	ToolTips,
};

public record LocalizationTargetDescriptor(string Name, LocalizationTargetDescriptorLoadingPolicy LoadingPolicy);
