﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass503 : GClass500, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26944;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass503(bool bool_1 = false)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.bool_0 = bool_1;
	}

	public override int vmethod_0()
	{
		return 26944;
	}

	public override int vmethod_1()
	{
		return 1;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(26944);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_7(9000);
	}

	public bool bool_0;
}
