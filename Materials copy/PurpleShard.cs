using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Test.Materials
{

	//internal class PurpleShard : ModItem
	public class PurpleShard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Purple Shard");
			Tooltip.SetDefault(("A shard, that is pruple, and looks purple."));
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
		}

		public override void SetDefaults()
		{
			Item.width = 12;
			Item.width = 12;
			Item.rare = ItemRarityID.Yellow;
			Item.maxStack = 9999;
			Item.value = Item.buyPrice(gold: 1); 
		}

		/*public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}*/
	}
}