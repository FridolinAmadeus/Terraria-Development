using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace leltestmod {
public class leltestmod : Mod
{
	public override void SetModInfo(out string name, ref ModProperties properties)
	{
		name = "leltestmod";
		properties.Autoload = true;
		properties.AutoloadGores = true;
		properties.AutoloadSounds = true;
	}
}
}