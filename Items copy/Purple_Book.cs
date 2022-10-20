using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Test.Projectiles.Weapons;

namespace Test.Items
{
	public class Purple_Book : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Purple Book of Death"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("It may not look it, but...");
		}

		public override void SetDefaults()
		{
			Item.width = 14;
			Item.height = 15;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.value = 100000;
			Item.rare = 8;

			Item.DamageType = DamageClass.Magic;
			Item.noMelee = true;
			Item.mana = 8;
			Item.damage = 250;
			Item.knockBack = 5;

			Item.useTime = 30;
			Item.useAnimation = 30;
			Item.UseSound = SoundID.Item71;
			Item.shootSpeed = 2;
			Item.shoot = ModContent.ProjectileType<Purple_Bolt>();

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