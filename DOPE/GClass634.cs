﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass634 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23863;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass634(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, int int_8 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.Id = int_4;
		this.int_0 = int_5;
		this.int_1 = int_6;
		this.int_3 = int_7;
		this.int_2 = int_8;
	}

	public virtual int vmethod_0()
	{
		return 23863;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 15) | this.Id << 17);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 13) | this.int_1 << 19);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 8 | U.smethod_0(this.int_2, 24));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 8 | U.smethod_0(this.int_3, 24));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(23863);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		binaryStream_0.smethod_4(this.Id << 15 | U.smethod_0(this.Id, 17));
		binaryStream_0.smethod_4(this.int_1 << 13 | U.smethod_0(this.int_1, 19));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 8) | this.int_2 << 24);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 8) | this.int_3 << 24);
	}

	public int int_0;

	public int Id;

	public int int_1;

	public int int_2;

	public int int_3;
}
