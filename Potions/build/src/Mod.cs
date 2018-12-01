using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DuckGame;
using System.Reflection;

// The title of your mod, as displayed in menus
[assembly: AssemblyTitle("My Custom Mod")]

// The author of the mod
[assembly: AssemblyCompany("Me, The Creator")]

// The description of the mod
[assembly: AssemblyDescription("This Mod Does All The Things!")]

// The mod's version
[assembly: AssemblyVersion("1.0.0.0")]

namespace Potions
{
    public class Potions : Mod
    {
		public override Priority priority
		{
			get { return base.priority; }
		}

		protected override void OnPreInitialize()
		{
			base.OnPreInitialize();
		}

		protected override void OnPostInitialize()
		{
			base.OnPostInitialize();
		}
	}
}
