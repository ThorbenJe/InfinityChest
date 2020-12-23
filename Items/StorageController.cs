using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace InfinityChest.Items
{
    class StorageController : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Storage Controller");
            Tooltip.SetDefault("This is the Heart of a Storage System.");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 26;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.rare = 1;
            item.value = Item.sellPrice(0, 1, 35, 0);
            item.createTile = mod.TileType("StorageController");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "QuantumGem", 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}