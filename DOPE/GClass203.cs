﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass203 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23710;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass203(int int_2 = 0, int int_3 = 0, uint uint_1 = 0U)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_0 = int_2;
		this.int_1 = int_3;
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 23710;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 10) | this.int_1 << 22);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(23710);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
		binaryStream_0.smethod_5(-13869);
		binaryStream_0.fUeiimuocMk(this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		binaryStream_0.fUeiimuocMk(this.int_1 << 10 | U.smethod_0(this.int_1, 22));
	}

	public uint uint_0;

	public int int_0;

	public int int_1;
}