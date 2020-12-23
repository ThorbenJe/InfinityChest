using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace InfinityChest.Items
{
    class QuantumGemDrop : GlobalNPC
    {

        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.BlueSlime ||
                npc.type == NPCID.RedSlime ||
                npc.type == NPCID.YellowSlime ||
                npc.type == NPCID.GreenSlime)
            {
                DropDiamond(npc, 1);
            }
        }

        private void DropDiamond(NPC npc, int stack)
        {
            Item.NewItem(npc.position, npc.width, npc.height, mod.ItemType("QuantumGem"), stack);
        }
    }
}
