using System;
using System.IO;

namespace UnrealBuildTool.Rules
{
	public class SpinePlugin : ModuleRules
	{
		public SpinePlugin(ReadOnlyTargetRules Target) : base(Target)
		{
            PrivatePCHHeaderFile = "Private/SpinePluginPrivatePCH.h";

            PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Public"));
			PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Public/spine-cpp/include"));

			PrivateIncludePaths.Add(Path.Combine(ModuleDirectory, "Private"));
			PrivateIncludePaths.Add(Path.Combine(ModuleDirectory, "Public/spine-cpp/include"));

            PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "RHI", "RenderCore", "ShaderCore", "ProceduralMeshComponent", "UMG", "Slate", "SlateCore" });
			PublicDefinitions.Add("SPINE_UE4");
		}
	}
}
