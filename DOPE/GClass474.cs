﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass474 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17849;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass474(GClass491 gclass491_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass491_1 == null)
		{
			this.gclass491_0 = new GClass491(0, null, null, null, null, "", "");
			return;
		}
		this.gclass491_0 = gclass491_1;
	}

	public virtual int vmethod_0()
	{
		return 17849;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.gclass491_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass491);
		this.gclass491_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(17849);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass491_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(-8207);
		binaryStream_0.smethod_7(-32295);
	}

	public GClass491 gclass491_0;
}
