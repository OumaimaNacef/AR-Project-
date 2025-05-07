using UnrealBuildTool;

public class ARprojectisetnabeulTarget : TargetRules
{
	public ARprojectisetnabeulTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("ARprojectisetnabeul");
	}
}
