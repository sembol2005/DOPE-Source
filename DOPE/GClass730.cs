﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass730 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28683;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 25;
		}
	}

	public GClass730(int int_5 = 0, int int_6 = 0, string string_2 = "", string string_3 = "", GClass191 gclass191_1 = null, GClass537 gclass537_0 = null, GClass710 gclass710_1 = null, int int_7 = 0, int int_8 = 0, int int_9 = 0, bool bool_1 = false)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.int_2 = int_5;
		this.int_3 = int_6;
		this.string_0 = string_2;
		this.string_1 = string_3;
		if (gclass191_1 == null)
		{
			this.gclass191_0 = new GClass191(0U);
		}
		else
		{
			this.gclass191_0 = gclass191_1;
		}
		if (gclass537_0 == null)
		{
			this.State = new GClass537(0, 0, "", false, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, null, false);
		}
		else
		{
			this.State = gclass537_0;
		}
		if (gclass710_1 == null)
		{
			this.gclass710_0 = new GClass710(null);
		}
		else
		{
			this.gclass710_0 = gclass710_1;
		}
		this.int_0 = int_7;
		this.int_4 = int_8;
		this.int_1 = int_9;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 28683;
	}

	public virtual int vmethod_1()
	{
		return 25;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 2 | U.smethod_0(this.int_1, 30));
		this.gclass710_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass710);
		this.gclass710_0.imethod_1(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 12 | U.smethod_0(this.int_2, 20));
		binaryStream_0.smethod_1();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 1 | U.smethod_0(this.int_3, 31));
		this.gclass191_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass191);
		this.gclass191_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.State = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass537);
		this.State.imethod_1(binaryStream_0);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 16) | this.int_4 << 16);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(28683);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 2) | this.int_1 << 30);
		this.gclass710_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_2, 12) | this.int_2 << 20);
		binaryStream_0.smethod_5(-9542);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_3, 1) | this.int_3 << 31);
		this.gclass191_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(6666);
		this.State.imethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(this.int_4 << 16 | U.smethod_0(this.int_4, 16));
	}

	public int int_0;

	public int int_1;

	public GClass710 gclass710_0;

	public string string_0;

	public string string_1;

	public bool bool_0;

	public int int_2;

	public int int_3;

	public GClass191 gclass191_0;

	public GClass537 State;

	public int int_4;
}
