// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class DSV_ArtifactEditorTarget : TargetRules
{
	public DSV_ArtifactEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "DSV_Artifact" } );
	}
}
