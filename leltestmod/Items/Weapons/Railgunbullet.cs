using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace leltestmod.Items.Weapons {
public class Railgunbullet : ModItem
{
    public override void SetDefaults()
    {
        item.name = "Railgun bullet";
        item.damage = 2;
        item.ranged = true;
        item.width = 8;
        item.height = 8;
        item.maxStack = 999;
        item.toolTip = "Used for railguns";
        item.consumable = true;
        item.knockBack = 1.5f;
        item.value = 10;
        item.rare = 2;
        item.shoot = 14;
        item.shootSpeed = 5f;
        item.ammo = ProjectileID.Bullet;
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient("Wood", 1);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}