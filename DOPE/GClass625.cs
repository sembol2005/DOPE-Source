﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass625 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3154;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass625(GClass752 gclass752_1 = null, int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass752_1 == null)
		{
			this.gclass752_0 = new GClass752(0U);
		}
		else
		{
			this.gclass752_0 = gclass752_1;
		}
		this.int_2 = int_3;
		this.int_0 = int_4;
		this.int_1 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 3154;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		this.gclass752_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass752);
		this.gclass752_0.imethod_1(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 8 | U.smethod_0(this.int_1, 24));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 13) | this.int_2 << 19);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(3154);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		this.gclass752_0.imethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 8) | this.int_1 << 24);
		binaryStream_0.fUeiimuocMk(this.int_2 << 13 | U.smethod_0(this.int_2, 19));
	}

	public int int_0;

	public GClass752 gclass752_0;

	public int int_1;

	public int int_2;
}
