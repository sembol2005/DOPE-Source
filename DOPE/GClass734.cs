﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass734 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15162;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass734(int int_1 = 0, double double_2 = 0.0, double double_3 = 0.0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_0 = int_1;
		this.double_1 = double_2;
		this.double_0 = double_3;
	}

	public virtual int vmethod_0()
	{
		return 15162;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		this.double_0 = (double)binaryStream_0.smethod_8();
		this.double_1 = (double)binaryStream_0.smethod_8();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(15162);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		binaryStream_0.smethod_7(this.double_0);
		binaryStream_0.smethod_7(this.double_1);
		binaryStream_0.smethod_5(-11325);
	}

	public int int_0;

	public double double_0;

	public double double_1;
}