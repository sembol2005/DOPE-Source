﻿using System;
using System.Linq;
using System.Threading;
using DarkorbitAPI;
using DOPE.Common.Models;

public class GClass866 : GClass865
{
	public GClass866(GClass839 gclass839_1)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor(gclass839_1, "DroneRepair");
	}

	public override int Cooldown
	{
		get
		{
			return 120000;
		}
	}

	public void method_2(DarkOrbitWebAPI darkOrbitWebAPI_0)
	{
		GClass49.GClass76 hangar = base.Context.Game.Web.Equipment.Hangar;
		foreach (GClass49.GClass52 gclass in hangar.data.ret.hangars.First<GClass49.GClass54>().GClass53_0.XjiRxaacIQ)
		{
			int num = int.Parse(gclass.HP.TrimEnd(new char[]
			{
				'%'
			}));
			if (num >= 90)
			{
				Thread.Sleep(5000);
				base.Log.Info("Repairing drone at {damage}% damage.", num);
				darkOrbitWebAPI_0.Equipment.RepairDrone(hangar.data, gclass);
			}
		}
	}

	public override void Execute()
	{
		this.method_2(base.Context.Game.Web);
	}

	public override bool vmethod_0()
	{
		AccountSettings account = base.Context.Account;
		return account != null && account.RepairDrones && base.Context.Game.Web.Equipment.Hangar != null;
	}
}
