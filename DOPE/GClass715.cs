﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass715 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10964;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass715(int int_2 = 0, int int_3 = 0, double double_1 = 0.0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.int_1 = int_2;
		this.int_0 = int_3;
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 10964;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.double_0 = (double)binaryStream_0.smethod_10();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 15) | this.int_1 << 17);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(10964);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-30918);
		binaryStream_0.smethod_7(-26362);
		binaryStream_0.smethod_9(this.double_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		binaryStream_0.smethod_4(this.int_1 << 15 | U.smethod_0(this.int_1, 17));
	}

	public double double_0;

	public int int_0;

	public int int_1;
}
