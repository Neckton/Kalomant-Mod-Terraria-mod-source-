using Terraria.ID;
using Terraria.ModLoader;

namespace Kalomant.Items
{
	public class P_on_a_stick : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("P_on_a_stick"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Awd312 skachivai redemption\nMaterial");
			 
		}

		public override void SetDefaults() 
		{
			item.shoot = ProjectileID.WoodenArrowFriendly;

            item.damage = 18;
			item.melee = true;
			item.width = 40;
			item.height = 60;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.knockBack = 6;
			item.value = 1000;
			item.rare = 2;
			item.UseSound = SoundID.Item3;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}