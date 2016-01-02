using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace leltestmod.Items.Placeable {
public class dingsbums : ModItem
{
    public override void SetDefaults()
    {
        item.name = "Frittierter Autoreifen";
        item.width = 30;
        item.height = 30;
        item.maxStack = 99;
        item.useTurn = true;
        item.autoReuse = true;
        item.useAnimation = 15;
        item.useTime = 10;
        item.useStyle = 1;
        item.consumable = true;
        item.value = 50000;
        item.createTile = mod.TileType("dingsbums");
        item.placeStyle = 0;
        AddTooltip("Wirklich fandasdisch!");
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient("Wood", 10);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}