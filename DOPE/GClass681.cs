﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass681 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6059;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass681()
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
	}

	public virtual int vmethod_0()
	{
		return 6059;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(6059);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(-29678);
	}
}
