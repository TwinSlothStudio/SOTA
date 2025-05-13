using UnrealBuildTool;

public class SOTAClientTarget : TargetRules
{
	public SOTAClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("SOTA");
	}
}
