﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass244 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1224;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass244(uint uint_0 = 0U)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.Mode = uint_0;
	}

	public virtual int vmethod_0()
	{
		return 1224;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Mode = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(1224);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.lwAiiEjwcUm(this.Mode);
	}

	public uint Mode;
}