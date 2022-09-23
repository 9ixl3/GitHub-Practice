using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Test.Items
{
	public class Purple_Bow_Delight : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Delightful Purple Shot"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("It may not look it, but...");
		}

		public override void SetDefaults()
		{
			Item.damage = 500;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 20;
			Item.height = 50;
			Item.useTime = 50;
			Item.useAnimation = 50;
			Item.useStyle = 5;
			Item.knockBack = 15;
			Item.value = 100000;
			Item.rare = 8;
			Item.UseSound = SoundID.Item5;
			Item.autoReuse = true;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.useAmmo = AmmoID.Arrow;
			Item.shoot = ProjectileID.WoodenArrowFriendly;
			Item.shootSpeed = 6;
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