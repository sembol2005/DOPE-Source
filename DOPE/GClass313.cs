﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass313 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24883;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass313(uint uint_0 = 0U, int int_1 = 0, bool bool_1 = false)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.State = uint_0;
		this.int_0 = int_1;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 24883;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.State = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(24883);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_5(3258);
		binaryStream_0.lwAiiEjwcUm(this.State);
	}

	public int int_0;

	public bool bool_0;

	public uint State;
}
