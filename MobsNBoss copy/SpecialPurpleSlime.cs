using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader.Utilities;
using Terraria.GameContent.ItemDropRules;
using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Test.Materials;

namespace Test.MobsNBoss
{
    public class SpecialPurpleSlime : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Delightfuly Purple Slime");
            Main.npcFrameCount[NPC.type] = Main.npcFrameCount[2];
        }

        public override void SetDefaults()
        {
            NPC.width = 32;
            NPC.height = 15;
            NPC.damage = 11;
            NPC.defense = 20;
            NPC.lifeMax = 2200;
            NPC.value = 50f;
            NPC.aiStyle = 1;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            AIType = NPCID.GreenSlime;
            AnimationType = NPCID.GreenSlime;
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (Main.hardMode)
			{
                return SpawnCondition.OverworldDaySlime.Chance * 1f;
			}
            return 0.0f;
        }

        public override void FindFrame(int frameHeight)
        {
            NPC.frameCounter++;
            if (NPC.frameCounter >= 20)
            {
                NPC.frameCounter = 0;
            }
            NPC.frame.Y = (int)NPC.frameCounter / 10 * frameHeight;
        }

        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            int itemType = ModContent.ItemType<PurpleShard>();
            /*var parameters = new DropOneByOne.Parameters()
            {
                ChanceNumerator = 1,
                ChanceDenominator = 4,
                MinimumStackPerChunkBase = 1,
                MaximumStackPerChunkBase = 1,
                MinimumItemDropsCount = 1,
                MaximumItemDropsCount = 1,
            };*/
        }

        public override void OnKill()
        {
            var rand = new Random();
            Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ItemID.Gel, Main.rand.Next(0, 2));
            if(rand.Next(4) == 1){
            Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ModContent.ItemType<PurpleShard>(), Main.rand.Next(0, 2));
            }
        }

    }
}