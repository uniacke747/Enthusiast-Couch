using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Microsoft.Xna.Framework;
using Terraria.Localization;
using Terraria.ID;

namespace EnthusiastCouch.Tiles.Furniture
{
	public class EnthusiastCouch : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileLavaDeath[Type] = true;
			
			TileObjectData.newTile.CopyFrom(TileObjectData.Style4x2); //this style already takes care of direction for us
			TileObjectData.newTile.CoordinateHeights = new[] { 16, 18 };
			TileObjectData.addTile(Type);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Enthusiasts Couch");
			AddMapEntry(new Color(200, 200, 200), name);
			adjTiles = new int[] { TileID.Beds };
			disableSmartCursor = true;
			
			bed = true;
		}

		public override bool HasSmartInteract()
		{
			return true;
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 16, j * 16, 64, 32, ModContent.ItemType<Items.Furniture.EnthusiastsCouch>());
		}

		public override bool NewRightClick(int i, int j)
		{
			Player player = Main.LocalPlayer;
			Tile tile = Main.tile[i, j];
			int spawnX = i - tile.frameX / 18;
			int spawnY = j + 2;
			spawnX += tile.frameX >= 72 ? 5 : 2;
			if (tile.frameY % 38 != 0)
			{
				spawnY--;
			}
			player.FindSpawn();
			if (player.SpawnX == spawnX && player.SpawnY == spawnY)
			{
				player.RemoveSpawn();
				Main.NewText("Enthusiasts Spawn Point Removed!", 255, 240, 20, false);
			}
			else if (Player.CheckSpawn(spawnX, spawnY))
			{
				player.ChangeSpawn(spawnX, spawnY);
				Main.NewText("Enthusiasts Spawn Point Set!", 255, 240, 20, false);
			}
			return true;
		}
	}
}
