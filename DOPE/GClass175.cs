﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass175 : GClass172, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3379;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass175(string string_1 = "", int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor(string_1, int_3, int_4);
		this.int_2 = int_5;
	}

	public override int vmethod_0()
	{
		return 3379;
	}

	public override int vmethod_1()
	{
		return 24;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 9) | this.int_2 << 23);
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(3379);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(this.int_2 << 9 | U.smethod_0(this.int_2, 23));
		binaryStream_0.smethod_5(-28899);
	}

	public int int_2;
}
