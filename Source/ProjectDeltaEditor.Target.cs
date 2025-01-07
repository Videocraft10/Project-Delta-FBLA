// (c) Videocraft Studios 2025 

using UnrealBuildTool;
using System.Collections.Generic;

public class ProjectDeltaEditorTarget : TargetRules
{
	public ProjectDeltaEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "ProjectDelta" } );
	}
}
