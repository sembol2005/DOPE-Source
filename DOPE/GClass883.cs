﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

public class GClass883 : Interface0
{
	[CompilerGenerated]
	public Dictionary<string, GClass883.GClass884> method_0()
	{
		return this.dictionary_0;
	}

	public bool imethod_2()
	{
		try
		{
			GClass883.GClass884 gclass = new GClass883.GClass884("69.69.69.69", false);
			gclass.method_1();
			return gclass.method_2(false);
		}
		catch
		{
		}
		return false;
	}

	public void imethod_0(HashSet<string> hashSet_0 = null)
	{
		object obj = this.object_0;
		lock (obj)
		{
			if (hashSet_0 != null)
			{
				using (HashSet<string>.Enumerator enumerator = hashSet_0.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						string text = enumerator.Current;
						GClass883.GClass884 gclass;
						if (!this.method_0().TryGetValue(text, out gclass))
						{
							gclass = new GClass883.GClass884(text, false);
						}
						gclass.method_2(true);
						this.method_0().Remove(text);
					}
					return;
				}
			}
			GClass883.GClass884 gclass2 = new GClass883.GClass884("127.0.0.1", false);
			this.imethod_0(gclass2.method_3());
		}
	}

	public void imethod_1(string[] string_0)
	{
		object obj = this.object_0;
		lock (obj)
		{
			foreach (string text in string_0)
			{
				GClass883.GClass884 gclass;
				if (!this.method_0().TryGetValue(text, out gclass))
				{
					gclass = (this.method_0()[text] = new GClass883.GClass884(text, false));
				}
				if (gclass.bool_0)
				{
					gclass.method_1();
				}
			}
		}
	}

	public GClass883()
	{
		Class13.NP5bWyNzLwONS();
		this.dictionary_0 = new Dictionary<string, GClass883.GClass884>();
		this.object_0 = new object();
		base..ctor();
	}

	[CompilerGenerated]
	private readonly Dictionary<string, GClass883.GClass884> dictionary_0;

	private readonly object object_0;

	public class GClass884
	{
		public GClass884(string string_1, bool bool_1 = false)
		{
			Class13.NP5bWyNzLwONS();
			this.string_0 = "";
			base..ctor();
			this.ipaddress_0 = IPAddress.Parse(string_1);
			this.bool_0 = true;
		}

		~GClass884()
		{
			if (!this.bool_0)
			{
				this.method_2(false);
			}
		}

		public string method_0(string string_1)
		{
			Process process = new Process();
			this.string_0 = "";
			process.StartInfo = new ProcessStartInfo
			{
				FileName = "cmd.exe",
				Arguments = "/c " + string_1,
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				UseShellExecute = false
			};
			process.OutputDataReceived += this.method_5;
			process.Start();
			process.EnableRaisingEvents = true;
			process.BeginOutputReadLine();
			process.WaitForExit();
			return this.string_0;
		}

		public void method_1()
		{
			this.bool_0 = false;
			string text;
			if ((text = this.method_0(string.Concat(new string[]
			{
				"netsh int ip add addr ",
				this.method_4().ToString(),
				" ",
				this.ipaddress_0.ToString(),
				"/32 st=ac sk=tr"
			}))).Length <= 3)
			{
				return;
			}
			if (this.method_2(true))
			{
				this.method_1();
				return;
			}
			text = text.Replace("\n", "").Replace("\r", "");
			if (text.ToLower().Contains("dhcp"))
			{
				this.method_0("netsh interface ip set dns \"Loopback Pseudo - Interface 1\" dhcp");
			}
			throw new Exception("An error ocurred, >" + text + "\n");
		}

		public bool method_2(bool bool_1 = false)
		{
			if (this.bool_0 && !bool_1)
			{
				return true;
			}
			this.bool_0 = true;
			return this.method_0("netsh int ip delete addr " + this.method_4().ToString() + " " + this.ipaddress_0.ToString()).Length <= 3;
		}

		public HashSet<string> method_3()
		{
			HashSet<string> hashSet = new HashSet<string>();
			this.method_0("netsh int ip show ipaddresses " + this.method_4().ToString());
			foreach (object obj in Regex.Matches(this.string_0, "(?:\\d{1,3}\\.){3}\\d{1,3}"))
			{
				string value = ((Match)obj).Groups[0].Value;
				if (!(value == "127.0.0.1") && !value.StartsWith("192.168"))
				{
					hashSet.Add(value);
				}
			}
			return hashSet;
		}

		public int method_4()
		{
			return NetworkInterface.LoopbackInterfaceIndex;
		}

		private void method_5(object sender, DataReceivedEventArgs e)
		{
			this.string_0 = this.string_0 + e.Data + "\n";
		}

		public string string_0;

		public volatile bool bool_0;

		public IPAddress ipaddress_0;
	}
}
