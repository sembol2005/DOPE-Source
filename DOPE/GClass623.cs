﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass623 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26485;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass623(int int_0 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.MapId = int_0;
	}

	public virtual int vmethod_0()
	{
		return 26485;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (this.MapId << 2 | U.smethod_0(this.MapId, 30));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(26485);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.MapId, 2) | this.MapId << 30);
	}

	public int MapId;
}
