using Terraria.ID;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Test.Vanilla
{
	public class LB : ModSystem
	{
		public override void AddRecipes()
		{
				Recipe recipe = Recipe.Create(ItemID.LunarBar);
				recipe.AddIngredient(ItemID.MeteoriteBar, 1);
				recipe.AddIngredient(ItemID.Ectoplasm, 12);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
		}
	}

}
//ItemID.LunarBar
//FragmentSolar
//LunarCraftingStation