using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace leltestmod.Items.Weapons {
public class Railgun : ModItem
{
    public override void SetDefaults()
    {
        item.name = "Railgun";
        item.damage = 5;
        item.ranged = true;
        item.width = 60;
        item.height = 20;
        item.toolTip = "Head shot!!!";
        item.useTime = 20;
        item.useAnimation = 20;
        item.useStyle = 5;
        item.noMelee = true; //so the item's animation doesn't do damage
        item.knockBack = 100;
        item.value = 10000;
        item.rare = 2;
        item.useSound = 11;
        item.autoReuse = true;
        item.shoot = 10; //idk why but all the guns in the vanilla source have this
        item.shootSpeed = 3f;
        item.useAmmo = ProjectileID.Bullet;
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient("Wood", 1);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
	
}}