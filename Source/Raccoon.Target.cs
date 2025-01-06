

using UnrealBuildTool;
using System.Collections.Generic;

public class RaccoonTarget : TargetRules
{
	public RaccoonTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "Raccoon" } );
	}
}
