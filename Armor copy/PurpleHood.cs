using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace Test.Armor
{
	// The AutoloadEquip attribute automatically attaches an equip texture to this item.
	// Providing the EquipType.Head value here will result in TML expecting a X_Head.png file to be placed next to the item's main texture.
	[AutoloadEquip(EquipType.Head)]
	public class PurpleHood : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("This is a modded hood.");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 22; // Width of the item
			Item.height = 20; // Height of the item
			Item.value = Item.sellPrice(gold: 10); // How many coins the item is worth
			Item.rare = ItemRarityID.Yellow; // The rarity of the item
			Item.defense = 8; // The amount of defense the item will give when equipped
		}

		// IsArmorSet determines what armor pieces are needed for the setbonus to take effect
		public override bool IsArmorSet(Item head, Item body, Item legs) {
			//return body.type == ModContent.ItemType<PurplePlate>() && legs.type == ModContent.ItemType<PurpleLegs>();
			bool bodyMatch = body.type == ModContent.ItemType<PurplePlate>();
			bool legsMatch = legs.type == ModContent.ItemType<PurpleLegs>();
			return bodyMatch && legsMatch;
		}

		// UpdateArmorSet allows you to give set bonuses to the armor.
		public override void UpdateArmorSet(Player player) {
			player.setBonus = "reduces mana cost by 20%";  // This is the setbonus tooltip
			player.manaCost -= 0.2f; // Reduces mana cost by 10%
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}
