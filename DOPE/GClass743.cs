﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass743 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18751;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass743(uint uint_1 = 0U)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 18751;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(18751);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
		binaryStream_0.smethod_5(-16451);
		binaryStream_0.smethod_5(15771);
	}

	public uint uint_0;
}
