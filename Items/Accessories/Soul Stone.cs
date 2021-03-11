using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace UltimateQuest.Items.Accessories
{
    public class SoulStone : ModItem
    {
        public override void SetStaticDefaults()
        {
            //Value should be the percent increase of damage
            Tooltip.SetDefault("The stone feels as if it is alive\n" + Language.GetTextValue("CommonItemTooltip.PercentIncreasedDamage", 200));
        }

        public override void SetDefaults()
        {
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            //gives increased maximum life and summon slots
            player.statLifeMax = 500;
            player.maxMinions += 3;
        }

        public override void AddRecipes()
        {
            //Temp recipe for testing
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
