using UnrealBuildTool;

public class SOTAEditorTarget : TargetRules
{
	public SOTAEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("SOTA");
	}
}
