using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace leltestmod.Items.Placeable {
public class Autoreifen : ModItem
{
    public override void SetDefaults()
    {
        item.name = "Autoreifen";
        item.width = 30;
        item.height = 30;
        item.maxStack = 99;
        item.useTurn = true;
        item.autoReuse = true;
        item.useAnimation = 15;
        item.useTime = 10;
        item.useStyle = 1;
        item.consumable = true;
        item.value = 100;
        item.createTile = mod.TileType("Autoreifen");
        AddTooltip("Jetzt braucht man noch ein Auto.");
    }
}}