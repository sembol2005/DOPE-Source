﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass130 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17756;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass130(double double_1 = 0.0, Vector<GClass315> vector_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.double_0 = double_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass315>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 17756;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass315 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass315;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(17756);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass315 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_5(-15514);
	}

	public double double_0;

	public Vector<GClass315> vector_0;
}