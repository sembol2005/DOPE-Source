﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass605 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10535;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass605(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, int int_8 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.Id = int_4;
		this.int_3 = int_5;
		this.int_2 = int_6;
		this.int_0 = int_7;
		this.int_1 = int_8;
	}

	public virtual int vmethod_0()
	{
		return 10535;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 8 | U.smethod_0(this.int_1, 24));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 1 | U.smethod_0(this.int_2, 31));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 12 | U.smethod_0(this.int_3, 20));
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 14) | this.Id << 18);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(10535);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		binaryStream_0.smethod_5(15151);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 8) | this.int_1 << 24);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_2, 1) | this.int_2 << 31);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_3, 12) | this.int_3 << 20);
		binaryStream_0.fUeiimuocMk(this.Id << 14 | U.smethod_0(this.Id, 18));
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int Id;
}
