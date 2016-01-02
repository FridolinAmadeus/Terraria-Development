using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace leltestmod.Tiles {
public class dingsbums : ModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileLavaDeath[Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
        TileObjectData.newTile.StyleHorizontal = true;
        TileObjectData.newTile.StyleWrapLimit = 24;
        TileObjectData.addTile(Type);
        dustType = 7;
        AddMapEntry(new Color(120, 85, 60), "Frittierter Autoreifen");
    }

    public override void KillMultiTile(int i, int j, int frameX, int frameY)
    {
        if(frameX == 0)
        {
            Item.NewItem(i * 16, j * 16, 32, 32, mod.ItemType("dingsbums"));
        }
    }
}}