using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace UltimateQuest.Items.Accessories
{
    public class PowerStone : ModItem
    {
        public override void SetStaticDefaults()
        {
            //Value should be the percent increase of damage
            Tooltip.SetDefault("The Power of the Universe Contained in a Single Nugget\nIt's power is too great for any mortal to contain\n" + Language.GetTextValue("CommonItemTooltip.PercentIncreasedDamage", 200));
        }

        public override void SetDefaults()
        {
            item.accessory = true;
        }

        public override void UpdateInventory(Player player)
        {
            //decreases life regen when item is in inventory
            player.lifeRegen -= 20;
        }

        public override void UpdateVanity(Player player, EquipType type)
        {
            //decreases life regen when item is in vanity slots
            player.lifeRegen -= 20;
        }

        public override void HoldItem(Player player)
        {
            //decreases life regen when item is in vanity slots
            player.lifeRegen -= 20;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            //increase damage by 4 times
            player.allDamage += 2f;
            //decrease life regen by 4 hp/s
            player.lifeRegen -= 75;
        }

        public override void AddRecipes()
        {
            //Temp recipe for testing
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}