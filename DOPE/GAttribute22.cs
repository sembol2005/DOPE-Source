﻿using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public sealed class GAttribute22 : Attribute
{
	public GAttribute22([GAttribute1] string format)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.String_0 = format;
	}

	[GAttribute1]
	public string String_0 { get; private set; }

	[CompilerGenerated]
	private string string_0;
}
