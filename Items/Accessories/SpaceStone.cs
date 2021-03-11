using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace UltimateQuest.Items.Accessories
{
    public class SpaceStone : ModItem
    {
        public override void SetStaticDefaults()
        {
            //Value should be the percent increase of damage
            Tooltip.SetDefault("You feel endless stores of energy deep withing the stone\nThe entire universe is now accessable\n" + Language.GetTextValue("CommonItemTooltip.PercentIncreasedDamage", 200));
        }

        public override void SetDefaults()
        {
            item.accessory = true;
            item.defense = 20;
        }

        public override void UpdateInventory(Player player)
        {
            //gives darkness debuff
            player.AddBuff(22, 1);
        }

        public override void UpdateVanity(Player player, EquipType type)
        {
            //gives darkness debuff
            player.AddBuff(22, 1);
        }

        public override void HoldItem(Player player)
        {
            //gives darkness debuff
            player.AddBuff(22, 1);
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            //gives obstructed and darkness debuff
            player.AddBuff(163, 1);
            player.AddBuff(22, 1);
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
