﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass729 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18400;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass729(int int_3 = 0, int int_4 = 0, string string_3 = "", int int_5 = 0, string string_4 = "", string string_5 = "")
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		base..ctor();
		this.int_2 = int_3;
		this.int_0 = int_4;
		this.string_2 = string_3;
		this.int_1 = int_5;
		this.string_0 = string_4;
		this.string_1 = string_5;
	}

	public virtual int vmethod_0()
	{
		return 18400;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		this.string_2 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 16 | U.smethod_0(this.int_1, 16));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 14 | U.smethod_0(this.int_2, 18));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(18400);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_3(this.string_2);
		binaryStream_0.smethod_4(this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 16) | this.int_1 << 16);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 14) | this.int_2 << 18);
	}

	public string string_0;

	public string string_1;

	public string string_2;

	public int int_0;

	public int int_1;

	public int int_2;
}
