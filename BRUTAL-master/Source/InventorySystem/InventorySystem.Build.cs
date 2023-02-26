// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;
public class InventorySystem : ModuleRules
{
	public InventorySystem(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;


        //string ProjectRoot = Path.GetFullPath(Path.Combine(ModuleDirectory, "../../"));
        //string PluginDir = Path.Combine(ProjectRoot, "Plugins/Runtime");
        //PublicIncludePaths.Add(PluginDir);
        //string projectroot1 = path.getfullpath(path.combine(moduledirectory, "../../"));
        //string plugindir1 = path.combine(projectroot1, "source/inventorysystem/ui");
        //publicincludepaths.add(plugindir1);
        //string projectroot2 = path.getfullpath(path.combine(moduledirectory, "../../"));
        //string plugindir2 = path.combine(projectroot2, "source/inventorysystem/util");
        //publicincludepaths.add(plugindir2);
        //string projectroot3 = path.getfullpath(path.combine(moduledirectory, "../../"));
        //string plugindir3 = path.combine(projectroot3, "source/inventorysystem/vehicles");
        //publicincludepaths.add(plugindir3);
        //string projectroot4 = path.getfullpath(path.combine(moduledirectory, "../../"));
        //string plugindir4 = path.combine(projectroot4, "source/inventorysystem/character");
        //publicincludepaths.add(plugindir4);
        //string projectroot5 = path.getfullpath(path.combine(moduledirectory, "../../"));
        //string plugindir5 = path.combine(projectroot5, "source/inventorysystem/camera");
        //publicincludepaths.add(plugindir5);
        //string projectroot6 = path.getfullpath(path.combine(moduledirectory, "../../"));
        //string plugindir6 = path.combine(projectroot6, "source/inventorysystem/game");
        //publicincludepaths.add(plugindir6);
        PublicDependencyModuleNames.AddRange(new string[] { 
			"Core",
			"CoreUObject",
			"Engine", 
			"InputCore",
            "Slate",
            "NetCore",
            "SlateCore",
			"OnlineSubsystem",
            "OnlineSubsystemUtils",
            "CinematicCamera",
            "OnlineSubsystemEOS",
			"Networking",
			"Sockets",
            "Foliage",
            "Niagara",
            "EnhancedInput",
             "MotionWarping",
             "ContextualAnimation",
             "Media",
             "MediaUtils",
             "MediaAssets",
             "AudioMixer",
            "GeometryCollectionEngine",
            "AnimToTexture",
            "ModularGameplay",
            "NetworkPrediction",
            "ZoneGraph",
            "AnimGraphRuntime",
            "DeveloperSettings",
            "RenderCore",
            "MoviePlayer",
            "Gauntlet",
            "ChaosVehiclesCore", 
			"ChaosVehicles" });

		PrivateDependencyModuleNames.AddRange(new string[] { });

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });
		
		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
