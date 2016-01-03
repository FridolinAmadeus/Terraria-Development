using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace leltestmod.NPCs {
public class guenther : ModNPC
{
    public override bool Autoload(ref string name, ref string texture)
    {
        name = "Stickman";
        return mod.Properties.Autoload;
    }

    public override void SetDefaults()
    {
        npc.name = "Stickman";
        npc.townNPC = true;
        npc.friendly = true;
        npc.width = 18;
        npc.height = 40;
        npc.aiStyle = 7;
        npc.damage = 10;
        npc.defense = 15;
        npc.lifeMax = 250;
        npc.soundHit = 1;
        npc.soundKilled = 1;
        npc.knockBackResist = 0.5f;
        Main.npcFrameCount[npc.type] = 25;
        NPCID.Sets.ExtraFramesCount[npc.type] = 9;
        NPCID.Sets.AttackFrameCount[npc.type] = 4;
        NPCID.Sets.DangerDetectRange[npc.type] = 700;
        NPCID.Sets.AttackType[npc.type] = 0;
        NPCID.Sets.AttackTime[npc.type] = 90;
        NPCID.Sets.AttackAverageChance[npc.type] = 30;
        animationType = NPCID.Guide;
    }

    public override bool CanTownNPCSpawn(int numTownNPCs, int money)
    {
        return true;
    }

    public override string TownNPCName()
    {
        switch(WorldGen.genRand.Next(4))
        {
        case 0:
            return "Günther";
        case 1:
            return "Gystav";
        case 2:
            return "Giesbert";
        default:
            return "Gilbert";
        }
    }

    public override string GetChat()
    {
        switch(Main.rand.Next(4))
        {
        case 0:
            return "Hast du schon den frittierten Autoreifen ausprobiert? Wirklich fandasdisch!";
        case 1:
            return "Ich bin ein Bauer und ich bin dumm.";
        case 2:
            return "Wie, ich hab keine Nase? Schau dich mal an!";
        default:
            return "Und dann sag ich zu ihm, das ist niemals Pferdeleber! Unsinn!";
        }
    }

    public override void SetChatButtons(ref string button, ref string button2)
    {
        button = Lang.inter[28];
    }

    public override void OnChatButtonClicked(bool firstButton, ref bool shop)
    {
        if(firstButton)
        {
            shop = true;
        }
    }

    public override void SetupShop(Chest shop, ref int nextSlot)
    {
        shop.item[nextSlot].SetDefaults(mod.ItemType("dingsbums"));
        nextSlot++;
        shop.item[nextSlot].SetDefaults(mod.ItemType("Railgun"));
        nextSlot++;
        shop.item[nextSlot].SetDefaults(mod.ItemType("Railgunbullet"));
        nextSlot++;
    }

    public override void TownNPCAttackStrength(ref int damage, ref float knockback)
    {
        damage = 20;
        knockback = 4f;
    }

    public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
    {
        cooldown = 30;
        randExtraCooldown = 30;
    }

    public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
    {
        projType = mod.ProjectileType("Railgunbullet");
        attackDelay = 1;
    }

    public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
    {
        multiplier = 12f;
        randomOffset = 2f;
    }

    public virtual bool CheckActive()
    {
        return false;
    }
}}