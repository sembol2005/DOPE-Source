﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass201 : GClass198, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9508;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass201(int int_1 = 0, string string_1 = "")
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		base..ctor();
		this.int_0 = int_1;
		this.string_0 = string_1;
	}

	public override int vmethod_0()
	{
		return 9508;
	}

	public override int vmethod_1()
	{
		return 6;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 4) | this.int_0 << 28);
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9508);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(6872);
		binaryStream_0.smethod_4(this.int_0 << 4 | U.smethod_0(this.int_0, 28));
	}

	public string string_0;

	public int int_0;
}
