using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace UltimateQuest.Items.Accessories.InfinityStones
{
    public class TimeStone : InfinityStone
    {
        public override void SetStaticDefaults()
        {
            //Update tooltip to reflect actual stat changes
            Tooltip.SetDefault("The Power of the Universe Contained in a Single Nugget\nIt's power is too great for any mortal to contain\n" + Language.GetTextValue("CommonItemTooltip.PercentIncreasedDamage", 200));
        }

        public override void SetDefaults()
        {
            item.accessory = true;
        }

        public override void UpdateInventory(Player player)
        {
            //Add a negative effect
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            //Add a negative effect
            //Make use speed faster
            //Act as enchanted sundial?
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