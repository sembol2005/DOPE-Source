﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass418 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24582;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass418(int int_1 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 24582;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 8 | U.smethod_0(this.int_0, 24));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(24582);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 8) | this.int_0 << 24);
	}

	public int int_0;
}
