﻿using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class GAttribute61 : Attribute
{
	public GAttribute61([GAttribute1] string name)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.Name = name;
	}

	[GAttribute1]
	public string Name { get; private set; }

	[CompilerGenerated]
	private string string_0;
}
