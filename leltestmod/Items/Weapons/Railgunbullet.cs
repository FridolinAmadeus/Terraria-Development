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
        item.name = "Example Bullet";
        item.damage = 2;
        item.ranged = true;
        item.width = 8;
        item.height = 8;
        item.maxStack = 999;
        item.toolTip = "This is a modded bullet ammo.";
        item.consumable = true;
        item.knockBack = 1.5f;
        item.value = 10;
        item.rare = 2;
        item.shoot = mod.ProjectileType("ExampleBullet");
        item.shootSpeed = 16f;
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