﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass600 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5917;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass600(int int_0 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.Id = int_0;
	}

	public virtual int vmethod_0()
	{
		return 5917;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 3 | U.smethod_0(this.Id, 29));
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5917);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.Id, 3) | this.Id << 29);
		binaryStream_0.smethod_7(1091);
		binaryStream_0.smethod_7(-31374);
	}

	public int Id;
}
