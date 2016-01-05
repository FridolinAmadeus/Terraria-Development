using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace leltestmod.Items.Placeable {
public class Fritteuse : ModItem
{
    public override void SetDefaults()
    {
        item.name = "Fritteuse";
        item.width = 28;
        item.height = 14;
        item.maxStack = 99;
        AddTooltip("Praktisch, wenn man etwas frittieren möchte.");
        item.useTurn = true;
        item.autoReuse = true;
        item.useAnimation = 15;
        item.useTime = 10;
        item.useStyle = 1;
        item.consumable = true;
        item.value = 200;
        item.createTile = mod.TileType("Fritteuse");
    }
}}