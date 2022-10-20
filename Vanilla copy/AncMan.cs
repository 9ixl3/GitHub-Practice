using Terraria.ID;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Test.Vanilla
{
	public class AncMan : ModSystem
	{
		public override void AddRecipes()
		{
				Recipe recipe = Recipe.Create(ItemID.LunarCraftingStation);
				recipe.AddIngredient(ItemID.MeteoriteBar, 4);
				recipe.AddIngredient(ItemID.Ectoplasm, 5);
				//recipe.AddTile(TileID.WorkBenches);
				recipe.Register();
		}
	}

}
//ItemID.LunarBar
//FragmentSolar
//LunarCraftingStation