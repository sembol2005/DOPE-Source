﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using DarkorbitAPI.CommonStructures;
using DarkorbitAPI.Packets.Static;
using DarkorbitAPI.Structures.Pathing;

namespace DarkorbitAPI.Structures
{
	public class Map : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public ConcurrentDictionary<int, Ship> Ships
		{
			[CompilerGenerated]
			get
			{
				return this.<Ships>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Ships>k__BackingField, value))
				{
					return;
				}
				this.<Ships>k__BackingField = value;
				this.method_29(Class5.propertyChangedEventArgs_101);
			}
		}

		public ConcurrentDictionary<string, Collectible> Collectibles
		{
			[CompilerGenerated]
			get
			{
				return this.<Collectibles>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Collectibles>k__BackingField, value))
				{
					return;
				}
				this.<Collectibles>k__BackingField = value;
				this.method_29(Class5.propertyChangedEventArgs_12);
			}
		}

		public ConcurrentDictionary<int, Gate> Gates
		{
			[CompilerGenerated]
			get
			{
				return this.<Gates>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Gates>k__BackingField, value))
				{
					return;
				}
				this.<Gates>k__BackingField = value;
				this.method_29(Class5.propertyChangedEventArgs_27);
			}
		}

		public ConcurrentDictionary<string, ICollidable> Collidables
		{
			[CompilerGenerated]
			get
			{
				return this.<Collidables>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Collidables>k__BackingField, value))
				{
					return;
				}
				this.<Collidables>k__BackingField = value;
				this.method_29(Class5.propertyChangedEventArgs_13);
			}
		}

		public ConcurrentDictionary<int, Asset> Assets
		{
			[CompilerGenerated]
			get
			{
				return this.<Assets>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Assets>k__BackingField, value))
				{
					return;
				}
				this.<Assets>k__BackingField = value;
				this.method_29(Class5.propertyChangedEventArgs_2);
			}
		}

		public Battlestation Battlestation
		{
			[CompilerGenerated]
			get
			{
				return this.<Battlestation>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Battlestation>k__BackingField, value))
				{
					return;
				}
				this.<Battlestation>k__BackingField = value;
				this.method_29(Class5.propertyChangedEventArgs_3);
			}
		}

		public int MapId
		{
			[CompilerGenerated]
			get
			{
				return this.<MapId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<MapId>k__BackingField == value)
				{
					return;
				}
				this.<MapId>k__BackingField = value;
				this.method_29(Class5.propertyChangedEventArgs_42);
				this.method_29(Class5.GG);
				this.method_0();
				this.method_29(Class5.MapId);
			}
		}

		public GameManager Game
		{
			[CompilerGenerated]
			get
			{
				return this.<Game>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Game>k__BackingField, value))
				{
					return;
				}
				this.<Game>k__BackingField = value;
				this.method_29(Class5.Hero);
				this.method_29(Class5.Game);
			}
		}

		public Hero Hero
		{
			get
			{
				return this.Game.Hero;
			}
		}

		public Ship SelectedShip
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedShip>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedShip>k__BackingField, value))
				{
					return;
				}
				this.<SelectedShip>k__BackingField = value;
				this.method_29(Class5.SelectedShip);
			}
		}

		public string MapName
		{
			[CompilerGenerated]
			get
			{
				return this.<MapName>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (string.Equals(this.<MapName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<MapName>k__BackingField = value;
				this.method_29(Class5.MapName);
			}
		}

		public DarkorbitAPI.CommonStructures.Size MapSize
		{
			[CompilerGenerated]
			get
			{
				return this.<MapSize>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<MapSize>k__BackingField == value)
				{
					return;
				}
				this.<MapSize>k__BackingField = value;
				this.method_29(Class5.propertyChangedEventArgs_70);
			}
		}

		public Vector2 Center
		{
			[CompilerGenerated]
			get
			{
				return this.<Center>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<Center>k__BackingField == value)
				{
					return;
				}
				this.<Center>k__BackingField = value;
				this.method_29(Class5.Center);
			}
		}

		public Vector2 RightCorner
		{
			[CompilerGenerated]
			get
			{
				return this.<RightCorner>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<RightCorner>k__BackingField == value)
				{
					return;
				}
				this.<RightCorner>k__BackingField = value;
				this.method_29(Class5.propertyChangedEventArgs_93);
			}
		}

		public Rectangle Rect
		{
			[CompilerGenerated]
			get
			{
				return this.<Rect>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<Rect>k__BackingField == value)
				{
					return;
				}
				this.<Rect>k__BackingField = value;
				this.method_29(Class5.propertyChangedEventArgs_83);
			}
		}

		public List<Rectangle> DefaultWorkArea
		{
			[CompilerGenerated]
			get
			{
				return this.<DefaultWorkArea>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<DefaultWorkArea>k__BackingField, value))
				{
					return;
				}
				this.<DefaultWorkArea>k__BackingField = value;
				this.method_29(Class5.propertyChangedEventArgs_15);
			}
		}

		public bool IsGG
		{
			get
			{
				return MapUtils.smethod_6(this.MapId);
			}
		}

		public GEnum5 GG
		{
			get
			{
				return MapUtils.smethod_10(this.MapId);
			}
		}

		public List<NpcUtils.NpcType> NpcTypes
		{
			[CompilerGenerated]
			get
			{
				return this.<NpcTypes>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<NpcTypes>k__BackingField, value))
				{
					return;
				}
				this.<NpcTypes>k__BackingField = value;
				this.method_29(Class5.propertyChangedEventArgs_75);
			}
		}

		public bool IsX1
		{
			[CompilerGenerated]
			get
			{
				return this.<IsX1>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<IsX1>k__BackingField == value)
				{
					return;
				}
				this.<IsX1>k__BackingField = value;
				this.method_29(Class5.zZaHdPbCydi);
			}
		}

		public void method_0()
		{
			this.IsX1 = MapUtils.IsX1(this);
			this.NpcTypes = NpcUtils.gwxubYhEsF(this.MapId);
			this.MapName = MapUtils.smethod_4(this.MapId);
			this.MapSize = MapUtils.smethod_1(this.MapId);
			this.Center = new Vector2((float)(this.MapSize.Width / 2), (float)(this.MapSize.Height / 2));
			this.RightCorner = new Vector2((float)this.MapSize.Width, (float)this.MapSize.Height);
			this.Rect = new Rectangle(0, 0, this.MapSize.Width, this.MapSize.Height);
			this.DefaultWorkArea = new List<Rectangle>
			{
				this.Rect
			};
			MapGrid grid = this.Grid;
			if (grid == null)
			{
				return;
			}
			grid.method_10();
		}

		public IEnumerable<string> method_1()
		{
			GEnum5 genum = MapUtils.smethod_10(this.MapId);
			if (genum != GEnum5.None)
			{
				int all = 0;
				int done = 0;
				foreach (KeyValuePair<int, Ship> keyValuePair in this.Ships)
				{
					Ship value = keyValuePair.Value;
					if (value.IsNpc)
					{
						int num = all;
						all = num + 1;
						bool flag;
						if (value.HpPercentage < 25f || this.method_8(value, out flag))
						{
							num = done;
							done = num + 1;
						}
					}
				}
				DarkOrbitWebAPI.GalaxyGatesInfo ggInfo = this.Game.Web.GgInfo;
				DarkOrbitWebAPI.jumpgateGate jumpgateGate = (ggInfo != null) ? ggInfo.GetGate(genum) : null;
				string text = string.Format("Wave {0}/{1}", (jumpgateGate != null) ? new int?(jumpgateGate.currentWave) : null, (jumpgateGate != null) ? new int?(jumpgateGate.totalWave) : null);
				if (jumpgateGate != null)
				{
					yield return text;
				}
				yield return string.Format("{0}/{1}", done, all);
			}
			yield break;
		}

		public MapGrid Grid
		{
			[CompilerGenerated]
			get
			{
				return this.<Grid>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Grid>k__BackingField, value))
				{
					return;
				}
				this.<Grid>k__BackingField = value;
				this.method_29(Class5.propertyChangedEventArgs_28);
			}
		}

		public bool method_2(Vector2 vector2_0, int int_0)
		{
			return vector2_0.X < (float)int_0 || vector2_0.Y < (float)int_0 || vector2_0.X > (float)(this.MapSize.Width - int_0) || vector2_0.Y > (float)(this.MapSize.Height - int_0);
		}

		public float method_3(Vector2 vector2_0)
		{
			return Math.Min(Math.Min(Math.Abs(vector2_0.X), Math.Abs(vector2_0.Y)), Math.Min(Math.Abs(vector2_0.X - (float)this.MapSize.Width), Math.Abs(vector2_0.Y - (float)this.MapSize.Height)));
		}

		public Ship method_4(int int_0)
		{
			if (this.Hero.Id == int_0)
			{
				return this.Hero;
			}
			Ship result;
			if (this.Ships.TryGetValue(int_0, out result))
			{
				return result;
			}
			return null;
		}

		public EDaFABwHcEGS6jfkGJ9 method_5<EDaFABwHcEGS6jfkGJ9>(Vector2 vector2_0, Func<EDaFABwHcEGS6jfkGJ9, bool> func_0 = null, Func<EDaFABwHcEGS6jfkGJ9, int> func_1 = null, int int_0 = 0) where EDaFABwHcEGS6jfkGJ9 : Entity
		{
			return this.All<EDaFABwHcEGS6jfkGJ9>(vector2_0, func_0, func_1, int_0).FirstOrDefault<EDaFABwHcEGS6jfkGJ9>();
		}

		public NpcShip method_6(Vector2 vector2_0, Func<NpcShip, bool> func_0 = null, Func<NpcShip, int> func_1 = null, int int_0 = 0)
		{
			Map.<>c__DisplayClass87_0 CS$<>8__locals1 = new Map.<>c__DisplayClass87_0();
			CS$<>8__locals1.priority = func_1;
			CS$<>8__locals1.origin = vector2_0;
			CS$<>8__locals1.now = DateTimeOffset.Now;
			List<NpcShip> list = this.All<NpcShip>(CS$<>8__locals1.origin, func_0, CS$<>8__locals1.priority, int_0).ToList<NpcShip>();
			bool isGG = this.IsGG;
			CS$<>8__locals1.dpsByType = new Dictionary<NpcUtils.NpcType, double>();
			foreach (NpcShip npcShip in list)
			{
				if (npcShip.Type != null)
				{
					if (!CS$<>8__locals1.dpsByType.ContainsKey(npcShip.Type))
					{
						CS$<>8__locals1.dpsByType[npcShip.Type] = 0.0;
					}
					int num = (int)(CS$<>8__locals1.now - npcShip.LastAttackedHero).TotalMilliseconds;
					Dictionary<NpcUtils.NpcType, double> dpsByType = CS$<>8__locals1.dpsByType;
					NpcUtils.NpcType type = npcShip.Type;
					dpsByType[type] += (double)((float)npcShip.LastAttackedHeroDamage / (float)(num / 1000 + 1));
				}
			}
			var source = list.Select(new Func<NpcShip, <>f__AnonymousType2<NpcShip, float, int, int, double>>(CS$<>8__locals1.method_0));
			if (!isGG)
			{
				var <>f__AnonymousType = source.Where(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, bool>(Map.<>c.<>9.method_0)).OrderBy(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, int>(Map.<>c.<>9.method_1)).ThenByDescending(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, int>(Map.<>c.<>9.method_2)).ThenByDescending(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, int>(Map.<>c.<>9.method_3)).ThenByDescending(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, double>(Map.<>c.<>9.method_4)).ThenByDescending(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, float>(Map.<>c.<>9.method_5)).FirstOrDefault();
				if (<>f__AnonymousType == null)
				{
					return null;
				}
				return <>f__AnonymousType.t;
			}
			else
			{
				var <>f__AnonymousType2 = source.OrderByDescending(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, int>(Map.<>c.<>9.method_6)).ThenBy(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, int>(Map.<>c.<>9.method_7)).ThenByDescending(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, double>(Map.<>c.<>9.method_8)).ThenByDescending(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, int>(Map.<>c.<>9.method_9)).ThenByDescending(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, float>(Map.<>c.<>9.method_10)).FirstOrDefault();
				if (<>f__AnonymousType2 == null)
				{
					return null;
				}
				return <>f__AnonymousType2.t;
			}
		}

		[return: TupleElementNames(new string[]
		{
			"obj",
			"dist",
			"priority"
		})]
		public IEnumerable<ValueTuple<REDUugwR85n85QWhBkY, float, int>> method_7<REDUugwR85n85QWhBkY>(Vector2 vector2_0, Func<REDUugwR85n85QWhBkY, bool> func_0 = null, Func<REDUugwR85n85QWhBkY, int> func_1 = null, int int_0 = 0) where REDUugwR85n85QWhBkY : Entity
		{
			Map.<EnumAll>d__88<REDUugwR85n85QWhBkY> <EnumAll>d__ = new Map.<EnumAll>d__88<REDUugwR85n85QWhBkY>(-2);
			<EnumAll>d__.<>4__this = this;
			<EnumAll>d__.<>3__origin = vector2_0;
			<EnumAll>d__.<>3__selector = func_0;
			<EnumAll>d__.<>3__priority = func_1;
			<EnumAll>d__.<>3__predictionMs = int_0;
			return <EnumAll>d__;
		}

		public IEnumerable<T> All<T>(Vector2 origin, Func<T, bool> selector = null, Func<T, int> priority = null, int predictionMs = 0) where T : Entity
		{
			return this.method_7<T>(origin, selector, priority, predictionMs).OrderByDescending(new Func<ValueTuple<T, float, int>, int>(Map.<>c__89<T>.<>9.method_0)).ThenBy(new Func<ValueTuple<T, float, int>, float>(Map.<>c__89<T>.<>9.method_1)).Select(new Func<ValueTuple<T, float, int>, T>(Map.<>c__89<T>.<>9.method_2));
		}

		public static ObjectPool<MapNavigator> Navigators { get; private set; }

		static Map()
		{
			Class13.NP5bWyNzLwONS();
			Map.Navigators = new ObjectPool<MapNavigator>("MapNavigator");
			for (int i = 0; i < 2; i++)
			{
				Map.<Navigators>k__BackingField.method_3(new MapNavigator());
			}
		}

		public Map(GameManager gameManager_0)
		{
			Class13.NP5bWyNzLwONS();
			this.<Ships>k__BackingField = new ConcurrentDictionary<int, Ship>();
			this.<Collectibles>k__BackingField = new ConcurrentDictionary<string, Collectible>();
			this.<Gates>k__BackingField = new ConcurrentDictionary<int, Gate>();
			this.<Collidables>k__BackingField = new ConcurrentDictionary<string, ICollidable>();
			this.<Assets>k__BackingField = new ConcurrentDictionary<int, Asset>();
			base..ctor();
			this.Game = gameManager_0;
			this.Grid = new MapGrid(this);
			this.method_0();
		}

		public void Clear()
		{
			this.Battlestation = null;
			this.Assets.Clear();
			foreach (KeyValuePair<int, Ship> keyValuePair in this.Ships)
			{
				Map.Delegates.ShipUpdateHandler shipDestroyed = this.ShipDestroyed;
				if (shipDestroyed != null)
				{
					shipDestroyed(this, keyValuePair.Value);
				}
			}
			this.Ships.Clear();
			foreach (KeyValuePair<string, Collectible> keyValuePair2 in this.Collectibles)
			{
			}
			this.Collectibles.Clear();
			this.Collidables.Clear();
			this.Grid.method_10();
			foreach (KeyValuePair<int, Gate> keyValuePair3 in this.Gates)
			{
			}
			this.Gates.Clear();
			this.SelectedShip = null;
			this.MapId = 0;
		}

		public bool method_8(Ship ship_0, out bool bool_0)
		{
			bool_0 = false;
			if (!this.IsGG)
			{
				return false;
			}
			DarkorbitAPI.CommonStructures.Size mapSize = this.MapSize;
			Vector2 position = ship_0.Position;
			bool_0 = this.Game.Security.method_3(Vector2.Zero, position, 0);
			return this.Game.Security.method_3(mapSize.Vector, position, 0) | bool_0;
		}

		internal void method_9(GClass181 gclass181_0)
		{
			Collectible collectible_ = new Collectible(gclass181_0.int_0, gclass181_0.int_1, gclass181_0.string_1, gclass181_0.string_0);
			if (MapUtils.smethod_2(this.MapId) == MapGroup.PayloadEscort)
			{
				this.Game.LogManager.Get("Net-Handlers").Info("Spawned box of type {type}", gclass181_0.string_1);
			}
			this.method_11(collectible_);
		}

		internal void method_10(GClass182 gclass182_0)
		{
			Resource collectible_ = new Resource(gclass182_0.int_0, gclass182_0.int_1, gclass182_0.gclass265_0.uint_0, gclass182_0.string_0);
			this.method_11(collectible_);
		}

		internal void method_11(Collectible collectible_0)
		{
			if (this.Game.Security.method_7(collectible_0, true) && this.Collectibles.TryAdd(collectible_0.Hash, collectible_0))
			{
				Map.Delegates.CollectibleCreatedHandler collectibleCreated = this.CollectibleCreated;
				if (collectibleCreated == null)
				{
					return;
				}
				collectibleCreated(this, collectible_0);
			}
		}

		internal void method_12(GClass140 gclass140_0)
		{
			Collectible collectible;
			this.Collectibles.TryRemove(gclass140_0.string_0, out collectible);
			Map.Delegates.CollectibleCollected collectibleCollected = this.CollectibleCollected;
			if (collectibleCollected == null)
			{
				return;
			}
			collectibleCollected(this, gclass140_0.string_0, collectible, gclass140_0.bool_0);
		}

		internal void method_13(GClass191 gclass191_0)
		{
			int int_ = gclass191_0.vector_0.FirstOrDefault<int>();
			Gate gate = new Gate(gclass191_0.int_1, gclass191_0.int_3, int_, gclass191_0.Id, gclass191_0.int_2);
			if (this.Gates.TryAdd(gate.Id, gate))
			{
				Map.Delegates.GateCreatedHandler gateCreated = this.GateCreated;
				if (gateCreated == null)
				{
					return;
				}
				gateCreated(this, gate);
			}
		}

		internal void method_14(GClass192 gclass192_0)
		{
			Gate gate;
			this.Gates.TryRemove(gclass192_0.Id, out gate);
		}

		internal void method_15(GClass269 gclass269_0)
		{
			Ship ship = gclass269_0.bool_0 ? new NpcShip() : new Ship();
			ship.Init(gclass269_0);
			if (this.Ships.TryAdd(ship.Id, ship))
			{
				Map.Delegates.ShipUpdateHandler shipCreated = this.ShipCreated;
				if (shipCreated == null)
				{
					return;
				}
				shipCreated(this, ship);
			}
		}

		internal void method_16(GClass270 gclass270_0)
		{
			Ship ship;
			if (this.Ships.TryRemove(gclass270_0.int_0, out ship))
			{
				if (ship == this.SelectedShip)
				{
					this.SelectedShip = null;
				}
				Map.Delegates.ShipUpdateHandler shipDestroyed = this.ShipDestroyed;
				if (shipDestroyed != null)
				{
					shipDestroyed(this, ship);
				}
				HeroPet heroPet = ship as HeroPet;
				if (heroPet != null)
				{
					heroPet.IsEnabled = false;
				}
			}
		}

		internal void method_17(GClass272 gclass272_0)
		{
			DateTime now = DateTime.Now;
			Ship ship = this.method_4(gclass272_0.int_2);
			if (ship != null)
			{
				ship.Shield = gclass272_0.saujdcFmwL;
				ship.ShieldMax = gclass272_0.int_3;
				ship.Hp = gclass272_0.int_1;
				ship.HpMax = gclass272_0.int_6;
				ship.LastStatUpdate = now;
				this.SelectedShip = ship;
				Map.Delegates.ShipUpdateHandler shipSelected = this.ShipSelected;
				if (shipSelected == null)
				{
					return;
				}
				shipSelected(this, ship);
			}
		}

		internal void method_18(int int_0, int int_1, int int_2, uint uint_0, int int_3, int int_4)
		{
			DateTimeOffset now = DateTimeOffset.Now;
			Ship ship = this.method_4(int_0);
			if (ship != null)
			{
				ship.Hp = int_3;
				ship.Shield = int_4;
				ship.LastTookDamage = now;
				ship.LastTookDamageFrom = int_1;
				if (!(ship is NpcShip))
				{
				}
				if (int_1 == this.Hero.Id)
				{
					ship.LastTookDamageHero = now;
				}
			}
			Ship ship2 = this.method_4(int_1);
			if (ship2 != null)
			{
				ship2.LastAttacked = now;
				if (int_0 == this.Hero.Id)
				{
					ship2.LastAttackedHero = now;
					ship2.LastAttackedHeroDamage = int_2;
				}
			}
			if (ship2 != null && ship != null && !ship2.IsNpc)
			{
				ship.LastTookDamageEnemy = now;
			}
			Map.Delegates.ShipAttackHandler shipAttacked = this.ShipAttacked;
			if (shipAttacked != null)
			{
				shipAttacked(this, ship2, ship, int_2, uint_0);
			}
			if (ship != null)
			{
				ship.method_9(this, ship2, ship, int_2, uint_0);
			}
		}

		internal void method_19(GClass268 gclass268_0)
		{
			this.method_18(gclass268_0.int_1, gclass268_0.int_3, gclass268_0.kmbIjvYlVg, gclass268_0.gclass132_0.uint_0, gclass268_0.int_0, gclass268_0.int_2);
		}

		internal void method_20(GClass179 gclass179_0)
		{
			Ship ship = this.method_4(gclass179_0.int_1);
			if (ship != null)
			{
				ship.HpMax = gclass179_0.int_4;
				ship.ShieldMax = gclass179_0.int_3;
			}
			this.method_18(gclass179_0.int_1, gclass179_0.int_7, gclass179_0.YyNslfukKj, gclass179_0.gclass132_0.uint_0, gclass179_0.int_6, gclass179_0.int_5);
		}

		internal void method_21(GClass187 gclass187_0)
		{
			Ship ship = this.method_4(gclass187_0.int_0);
			if (ship == null)
			{
				return;
			}
			ship.ApplyModifier(gclass187_0);
		}

		internal void method_22(GClass224 gclass224_0)
		{
			this.Hero.Pet.method_13(gclass224_0);
			this.Ships[gclass224_0.int_8] = this.Hero.Pet;
		}

		internal void method_23(GClass259 gclass259_0)
		{
			Pet pet = this.method_4(gclass259_0.int_3) as Pet;
			if (pet == null)
			{
				pet = new Pet();
				pet.method_11(gclass259_0);
				if (this.Ships.TryAdd(gclass259_0.int_3, pet))
				{
					Map.Delegates.ShipUpdateHandler shipCreated = this.ShipCreated;
					if (shipCreated == null)
					{
						return;
					}
					shipCreated(this, pet);
					return;
				}
			}
			else
			{
				pet.method_11(gclass259_0);
			}
		}

		internal void method_24(GClass247 gclass247_0)
		{
			ICollidable collidable = null;
			ICollidable collidable2 = null;
			ICollidable collidable3;
			if (this.Collidables.TryGetValue(gclass247_0.Name, out collidable3))
			{
				collidable3.Active = gclass247_0.bool_0;
				collidable = collidable3;
			}
			if (gclass247_0.Name == "Cage Zone" && this.MapId == 229)
			{
				return;
			}
			CollidableType uint_ = (CollidableType)gclass247_0.gclass141_0.uint_0;
			if (gclass247_0.uint_0 == 2U && (uint_ == CollidableType.Wall || uint_ == CollidableType.Mines))
			{
				int num = Map.smethod_1(gclass247_0.vector_0[0U], gclass247_0.vector_0[2U], gclass247_0.vector_0[4U]);
				int num2 = Map.smethod_2(gclass247_0.vector_0[0U], gclass247_0.vector_0[2U], gclass247_0.vector_0[4U]);
				int num3 = Map.smethod_1(gclass247_0.vector_0[1U], gclass247_0.vector_0[3U], gclass247_0.vector_0[5U]);
				int num4 = Map.smethod_2(gclass247_0.vector_0[1U], gclass247_0.vector_0[3U], gclass247_0.vector_0[5U]);
				if (this.MapId == 93 && uint_ == CollidableType.Mines)
				{
					num4 = this.MapSize.Height - 500;
				}
				collidable2 = new CollidableRect(gclass247_0.Name, gclass247_0.bool_0, num, num3, num2 - num, num4 - num3, uint_);
			}
			else if (gclass247_0.uint_0 == 0U)
			{
				collidable2 = new CollidableSphere(uint_, gclass247_0.Name, new Vector2((float)gclass247_0.vector_0[0U], (float)gclass247_0.vector_0[1U]), gclass247_0.vector_0[2U]);
			}
			if (collidable2 != null)
			{
				if (collidable != null)
				{
					this.Grid.method_8(collidable);
				}
				this.Collidables[gclass247_0.Name] = (Collidable)collidable2;
				this.Grid.method_9(collidable2);
			}
		}

		internal void method_25(GClass249 gclass249_0)
		{
			ICollidable icollidable_;
			if (this.Collidables.TryRemove(gclass249_0.Name, out icollidable_))
			{
				this.Grid.method_8(icollidable_);
			}
		}

		internal void method_26(GClass271 gclass271_0)
		{
			Ship ship;
			if (this.Ships.TryGetValue(gclass271_0.int_2, out ship))
			{
				ship.method_1(gclass271_0.int_0, gclass271_0.int_1, gclass271_0.int_3);
				Map.Delegates.ShipMoveStartedHandler shipMoveStarted = this.ShipMoveStarted;
				if (shipMoveStarted == null)
				{
					return;
				}
				shipMoveStarted(this, ship, gclass271_0);
			}
		}

		internal void method_27(GClass241 gclass241_0)
		{
			DateTimeOffset now = DateTimeOffset.Now;
			Ship ship = this.method_4(gclass241_0.int_2);
			if (ship != null)
			{
				ship.LastTookDamageFrom = gclass241_0.int_3;
				ship.LastTookDamage = DateTimeOffset.Now;
			}
			Ship ship2 = this.method_4(gclass241_0.int_3);
			if (ship2 != null)
			{
				ship2.LastAttacked = now;
				ship2.TargetId = gclass241_0.int_2;
			}
		}

		internal void method_28(GClass250 gclass250_0)
		{
		}

		public event Map.Delegates.CollectibleCreatedHandler CollectibleCreated;

		public event Map.Delegates.GateCreatedHandler GateCreated;

		public event Map.Delegates.ShipUpdateHandler ShipCreated;

		public event Map.Delegates.ShipUpdateHandler ShipDestroyed;

		public event Map.Delegates.ShipUpdateHandler ShipSelected;

		public event Map.Delegates.ShipAttackHandler ShipAttacked;

		public event Map.Delegates.ShipMoveStartedHandler ShipMoveStarted;

		public event Map.Delegates.CollectibleCollected CollectibleCollected;

		[CompilerGenerated]
		internal static ValueTuple<fQrt1IwFin4IuoOST6N, float, int> smethod_0<fQrt1IwFin4IuoOST6N>(Entity entity_0, ref Map.<>c__DisplayClass88_0<fQrt1IwFin4IuoOST6N> <>c__DisplayClass88_0_0) where fQrt1IwFin4IuoOST6N : Entity
		{
			Vector2 value = entity_0.Position;
			if (<>c__DisplayClass88_0_0.predictionMs > 0)
			{
				MovingEntity movingEntity = entity_0 as MovingEntity;
				if (movingEntity != null)
				{
					value = movingEntity.VvOumUkog6(<>c__DisplayClass88_0_0.predictionMs);
				}
			}
			float num = Vector2.Distance(<>c__DisplayClass88_0_0.origin, value);
			int num2 = 0;
			if (<>c__DisplayClass88_0_0.priority != null)
			{
				num2 = <>c__DisplayClass88_0_0.priority(entity_0 as fQrt1IwFin4IuoOST6N);
			}
			return new ValueTuple<fQrt1IwFin4IuoOST6N, float, int>((fQrt1IwFin4IuoOST6N)((object)entity_0), num, num2);
		}

		[CompilerGenerated]
		internal static int smethod_1(int int_0, int int_1, int int_2)
		{
			return Math.Min(int_0, Math.Min(int_1, int_2));
		}

		[CompilerGenerated]
		internal static int smethod_2(int int_0, int int_1, int int_2)
		{
			return Math.Max(int_0, Math.Max(int_1, int_2));
		}

		[DebuggerNonUserCode]
		[GeneratedCode("PropertyChanged.Fody", "3.2.3.0")]
		protected void method_29(PropertyChangedEventArgs propertyChangedEventArgs_0)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, propertyChangedEventArgs_0);
			}
		}

		public sealed class Delegates
		{
			public Delegates()
			{
				Class13.NP5bWyNzLwONS();
				base..ctor();
			}

			public delegate void CollectibleCreatedHandler(Map map, Collectible collectible);

			public delegate void GateCreatedHandler(Map map, Gate gate);

			public delegate void ShipUpdateHandler(Map map, Ship ship);

			public delegate void ShipMoveStartedHandler(Map map, Ship ship, GClass271 move);

			public delegate void ShipAttackHandler(Map map, Ship attacker, Ship target, int damage, uint attackType);

			public delegate void CollectibleCollected(Map map, string hash, Collectible collectible, bool byHero);
		}
	}
}
