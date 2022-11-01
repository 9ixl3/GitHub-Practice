using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Test.Accessory
{
	public class PurpleRock : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Purple Rock");
			Tooltip.SetDefault("Melee damage is just better");
			SacrificeTotal = 1;
		}
		public override void SetDefaults()
		{
			Item.width = 15;
			Item.height = 15;
			Item.accessory = true;

			
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetDamage(DamageClass.Melee) += 0.1f;
			player.GetArmorPenetration(DamageClass.Melee) += 10f;

		}
		public void StatusNPC(int type, int i)
		{	
				Main.npc[i].AddBuff(BuffID.ShadowFlame, 300, true);
			
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}