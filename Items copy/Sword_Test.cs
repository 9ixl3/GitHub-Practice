using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Test.Items
{
	public class Sword_Test : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Purple Delight"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("It may not look it, but...");
		}

		public override void SetDefaults()
		{
			Item.damage = 750;
			Item.DamageType = DamageClass.Melee;
			Item.width = 120;
			Item.height = 120;
			Item.useTime = 50;
			Item.useAnimation = 50;
			Item.useStyle = 1;
			Item.knockBack = 15;
			Item.value = 100000;
			Item.rare = 8;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;

			Lighting.AddLight(Item.position, 0.75f, 0.75f, 0.75f);

			
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