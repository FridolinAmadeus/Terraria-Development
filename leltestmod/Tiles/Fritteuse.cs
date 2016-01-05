using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace leltestmod.Tiles {
public class Fritteuse : ModTile
{
    public override void SetDefaults()
    {
        Main.tileSolidTop[Type] = false;
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileTable[Type] = false;
        Main.tileLavaDeath[Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
        TileObjectData.newTile.CoordinateHeights = new int[]{18};
        TileObjectData.addTile(Type);
        AddMapEntry(new Color(200, 200, 200), "Fritteuse");
        adjTiles = new int[]{TileID.WorkBenches};
    }

    public override void KillMultiTile(int i, int j, int frameX, int frameY)
    {
        Item.NewItem(i * 16, j * 16, 32, 16, mod.ItemType("Fritteuse"));
    }
}}