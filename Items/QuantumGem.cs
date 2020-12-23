using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace InfinityChest.Items
{
    class QuantumGem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Quantum Gem");
            Tooltip.SetDefault("A pulsing Gem.");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 99;
            item.rare = 1;
            item.value = Item.sellPrice(0, 1, 0, 0);
        }

        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
    }
}
