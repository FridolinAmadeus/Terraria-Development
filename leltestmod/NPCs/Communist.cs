using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace leltestmod.NPCs {
public class Communist : ModNPC
{
    public override bool Autoload(ref string name, ref string texture)
    {
        return mod.Properties.Autoload;
    }

    public override void SetDefaults()
    {
        npc.name = "Communist";
        npc.townNPC = false;
        npc.friendly = false;
        npc.lifeMax = 100;
        npc.damage = 30;
        npc.defense = 10;
        npc.knockBackResist = 0.5f;
        npc.width = 18;
        npc.height = 40;
        npc.aiStyle = 3;
        npc.soundHit = 1;
        npc.soundKilled = 1;
        npc.value = Item.buyPrice(0, 0, 15, 0);
        banner = npc.type;
        bannerItem = mod.ItemType("CommunistBanner");
        animationType = 22;
        Main.npcFrameCount[npc.type] = 25;
    }

    public override float CanSpawn(NPCSpawnInfo spawnInfo)
    {
        return 1;
    }
}}