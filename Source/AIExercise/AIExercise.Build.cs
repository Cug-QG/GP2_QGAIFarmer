// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class AIExercise : ModuleRules
{
	public AIExercise(ReadOnlyTargetRules Target) : base(Target)
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
			"AIExercise",
			"AIExercise/Variant_Platforming",
			"AIExercise/Variant_Platforming/Animation",
			"AIExercise/Variant_Combat",
			"AIExercise/Variant_Combat/AI",
			"AIExercise/Variant_Combat/Animation",
			"AIExercise/Variant_Combat/Gameplay",
			"AIExercise/Variant_Combat/Interfaces",
			"AIExercise/Variant_Combat/UI",
			"AIExercise/Variant_SideScrolling",
			"AIExercise/Variant_SideScrolling/AI",
			"AIExercise/Variant_SideScrolling/Gameplay",
			"AIExercise/Variant_SideScrolling/Interfaces",
			"AIExercise/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
