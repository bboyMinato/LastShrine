// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class LastShrine : ModuleRules
{
	public LastShrine(ReadOnlyTargetRules Target) : base(Target)
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
			"LastShrine",
			"LastShrine/Variant_Platforming",
			"LastShrine/Variant_Platforming/Animation",
			"LastShrine/Variant_Combat",
			"LastShrine/Variant_Combat/AI",
			"LastShrine/Variant_Combat/Animation",
			"LastShrine/Variant_Combat/Gameplay",
			"LastShrine/Variant_Combat/Interfaces",
			"LastShrine/Variant_Combat/UI",
			"LastShrine/Variant_SideScrolling",
			"LastShrine/Variant_SideScrolling/AI",
			"LastShrine/Variant_SideScrolling/Gameplay",
			"LastShrine/Variant_SideScrolling/Interfaces",
			"LastShrine/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
