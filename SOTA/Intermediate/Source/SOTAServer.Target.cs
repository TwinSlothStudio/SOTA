using UnrealBuildTool;

public class SOTAServerTarget : TargetRules
{
	public SOTAServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("SOTA");
	}
}
