using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace leltestmod.Items.Banners {
public class CommunistBanner : ModItem
{
    public override void SetDefaults()
    {
        item.name = "Communist Banner";
        item.width = 10;
        item.height = 24;
        item.maxStack = 99;
        item.useTurn = true;
        item.autoReuse = true;
        item.useAnimation = 15;
        item.useTime = 10;
        item.useStyle = 1;
        item.consumable = true;
        item.rare = 1;
        item.value = Item.buyPrice(0, 0, 10, 0);
        item.createTile = mod.TileType("CommunistBanner");
        item.placeStyle = 0;
    }
}}