﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass438 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32258;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass438(int int_2 = 0, int int_3 = 0, int int_4 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.MapId = int_2;
		this.int_1 = int_3;
		this.int_0 = int_4;
	}

	public virtual int vmethod_0()
	{
		return 32258;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 4) | this.MapId << 28);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 16 | U.smethod_0(this.int_1, 16));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(32258);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(17019);
		binaryStream_0.smethod_4(this.MapId << 4 | U.smethod_0(this.MapId, 28));
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		binaryStream_0.smethod_7(11160);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 16) | this.int_1 << 16);
	}

	public int MapId;

	public int int_0;

	public int int_1;
}
