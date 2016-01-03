using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace leltestmod.Items
{
	public class trainticket : ModItem
	{
	    public override void SetDefaults()
	    {
            item.name = "Train ticket";
		    item.width = 34;
		    item.height = 26;
		    item.toolTip = "Good Luck";
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.rare = 2;
			item.useSound = 79;
			item.noMelee = true;
		    item.stack = 1;
            item.value = 5000;
			item.mountType = mod.MountType("Train");
	    }
    
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient("Wood", 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

