using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace EnthusiastCouch.Items.Furniture
{
	public class EnthusiastsCouch : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A perfect spot to realax, set a spawn point or entertain millions.");
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 20;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.value = 2000;
			item.createTile = ModContent.TileType<Tiles.Furniture.EnthusiastsCouch>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 8);
			recipe.AddIngredient(ItemID.BlackThread, 5);
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

}
