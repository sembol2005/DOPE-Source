﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass403 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16733;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass403(int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_1 = int_3;
		this.int_2 = int_4;
		this.int_0 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 16733;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 7) | this.int_1 << 25);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 6) | this.int_2 << 26);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(16733);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		binaryStream_0.fUeiimuocMk(this.int_1 << 7 | U.smethod_0(this.int_1, 25));
		binaryStream_0.fUeiimuocMk(this.int_2 << 6 | U.smethod_0(this.int_2, 26));
	}

	public int int_0;

	public int int_1;

	public int int_2;
}