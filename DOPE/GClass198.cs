﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass198 : GClass187, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5606;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass198(bool bool_0 = false)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.OewwhaaYgk = bool_0;
	}

	public override int vmethod_0()
	{
		return 5606;
	}

	public override int vmethod_1()
	{
		return 1;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.OewwhaaYgk = binaryStream_0.ReadBoolean();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(5606);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.OewwhaaYgk);
	}

	public bool OewwhaaYgk;
}