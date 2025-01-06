

using UnrealBuildTool;
using System.Collections.Generic;

public class RaccoonEditorTarget : TargetRules
{
	public RaccoonEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "Raccoon" } );
	}
}
