﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass608 : GClass602, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23889;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass608(string string_1 = "", string string_2 = "")
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		base..ctor(string_1);
		this.string_0 = string_2;
	}

	public override int vmethod_0()
	{
		return 23889;
	}

	public override int vmethod_1()
	{
		return 6;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(23889);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
	}

	public string string_0;
}
