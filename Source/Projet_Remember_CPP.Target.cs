// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Projet_Remember_CPPTarget : TargetRules
{
	public Projet_Remember_CPPTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "Projet_Remember_CPP" } );
	}
}
