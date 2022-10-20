using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace Test.Items
{
	public class Purple_Axe : ModItem
	{
		public override void SetStaticDefaults()
		{
			/*DisplayName.SetDefault("Purple Book of Death"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("It may not look it, but...");*/
		}

		public override void SetDefaults()
		{
			Item.width = 48;
			Item.height = 56;

			Item.value = 100000;
			Item.rare = 8;

			Item.useTime = 12;
			Item.useAnimation = 48;
			Item.autoReuse = true;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTurn = true;

			Item.DamageType = DamageClass.Melee;
			Item.damage = 100;
			Item.knockBack = 15f;

			Item.axe = 200;


		}
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			// Add the Onfire buff to the NPC for 1 second when the weapon hits an NPC
			// 60 frames = 1 second
			target.AddBuff(BuffID.ShadowFlame, 300);
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