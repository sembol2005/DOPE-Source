﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass376 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31358;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass376(int int_1 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 31358;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 5) | this.int_0 << 27);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(31358);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(22410);
		binaryStream_0.smethod_4(this.int_0 << 5 | U.smethod_0(this.int_0, 27));
	}

	public int int_0;
}
