using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace leltestmod.Items {
public class Oil : ModItem
{
    public override void SetDefaults()
    {
        item.name = "Seitenbacher Biobasis�l";
        item.holdStyle = 4;
        item.width = 40;
        item.height = 40;
        item.toolTip = "'Biobasis�l von Seitenbacher! Seitenbacher!'";
        item.value = 30;
        item.rare = 2;
        item.maxStack = 99;
    }
}}