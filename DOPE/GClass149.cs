﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass149 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32081;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass149()
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
	}

	public virtual int vmethod_0()
	{
		return 32081;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(32081);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6830);
		binaryStream_0.smethod_7(-26057);
	}
}
