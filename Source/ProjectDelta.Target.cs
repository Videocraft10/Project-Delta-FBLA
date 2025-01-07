// (c) Videocraft Studios 2025 

using UnrealBuildTool;
using System.Collections.Generic;

public class ProjectDeltaTarget : TargetRules
{
	public ProjectDeltaTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "ProjectDelta" } );
	}
}
