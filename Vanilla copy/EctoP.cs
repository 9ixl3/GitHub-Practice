using Terraria.ID;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Test.Vanilla
{
	public class EctoP : ModSystem
	{
		public override void AddRecipes()
		{
				Recipe recipe = Recipe.Create(ItemID.Ectoplasm, 100);
				recipe.AddIngredient(ItemID.DirtBlock, 1);
				recipe.AddTile(TileID.WorkBenches);
				recipe.Register();
		}
	}

}
//ItemID.LunarBar
//FragmentSolar
//LunarCraftingStation