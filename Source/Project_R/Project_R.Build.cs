// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Project_R : ModuleRules
{
	public Project_R(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Project_R",
			"Project_R/Variant_Platforming",
			"Project_R/Variant_Platforming/Animation",
			"Project_R/Variant_Combat",
			"Project_R/Variant_Combat/AI",
			"Project_R/Variant_Combat/Animation",
			"Project_R/Variant_Combat/Gameplay",
			"Project_R/Variant_Combat/Interfaces",
			"Project_R/Variant_Combat/UI",
			"Project_R/Variant_SideScrolling",
			"Project_R/Variant_SideScrolling/AI",
			"Project_R/Variant_SideScrolling/Gameplay",
			"Project_R/Variant_SideScrolling/Interfaces",
			"Project_R/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
