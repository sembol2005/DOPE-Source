﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass143 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16152;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass143(int int_2 = 0, int int_3 = 0, int int_4 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.Id = int_2;
		this.int_0 = int_3;
		this.int_1 = int_4;
	}

	public virtual int vmethod_0()
	{
		return 16152;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 3) | this.Id << 29);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 7) | this.int_1 << 25);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16152);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		binaryStream_0.smethod_4(this.Id << 3 | U.smethod_0(this.Id, 29));
		binaryStream_0.smethod_4(this.int_1 << 7 | U.smethod_0(this.int_1, 25));
		binaryStream_0.smethod_7(30298);
	}

	public int int_0;

	public int Id;

	public int int_1;
}
