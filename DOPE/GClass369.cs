﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass369 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24014;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass369(int int_1 = 0, int int_2 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.MapId = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 24014;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (this.MapId << 12 | U.smethod_0(this.MapId, 20));
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 5) | this.int_0 << 27);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(24014);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.MapId, 12) | this.MapId << 20);
		binaryStream_0.smethod_4(this.int_0 << 5 | U.smethod_0(this.int_0, 27));
	}

	public int MapId;

	public int int_0;
}
