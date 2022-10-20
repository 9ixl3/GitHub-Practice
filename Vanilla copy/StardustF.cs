using Terraria.ID;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Test.Vanilla
{
	public class StardustF : ModSystem
	{
		public override void AddRecipes()
		{
				Recipe recipe = Recipe.Create(ItemID.FragmentStardust);
				recipe.AddIngredient(ItemID.MeteoriteBar, 1);
				recipe.AddIngredient(ItemID.Ectoplasm, 8);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.Register();
		}
	}

}
//ItemID.LunarBar
//FragmentSolar
//LunarCraftingStation