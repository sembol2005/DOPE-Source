﻿using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = true)]
public sealed class GAttribute5 : Attribute
{
	public GAttribute5([GAttribute1] string name)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.Name = name;
	}

	[GAttribute1]
	public string Name { get; private set; }

	[CompilerGenerated]
	private string TbxuZpTfit;
}