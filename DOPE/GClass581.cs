﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass581 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22606;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass581(string string_3 = "", string string_4 = "", string string_5 = "")
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		base..ctor();
		this.string_2 = string_3;
		this.string_1 = string_4;
		this.string_0 = string_5;
	}

	public virtual int vmethod_0()
	{
		return 22606;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		this.string_2 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(22606);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_3(this.string_2);
		binaryStream_0.smethod_5(-27203);
	}

	public string string_0;

	public string string_1;

	public string string_2;
}
