﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass249 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1818;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass249(string string_0 = "")
	{
		Class13.NP5bWyNzLwONS();
		this.Name = "";
		base..ctor();
		this.Name = string_0;
	}

	public virtual int vmethod_0()
	{
		return 1818;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.Name = binaryStream_0.smethod_2();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1818);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.Name);
	}

	public string Name;
}
