using System;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace UltimateQuest.Items.Accessories
{
    public class RealityStone : ModItem
    {
        public override void SetStaticDefaults()
        {
            //Value should be the percent increase of damage
            Tooltip.SetDefault("Reality can be whatever I want.\n- Thanos\n" + Language.GetTextValue("CommonItemTooltip.PercentIncreasedDamage", 200));
        }

        public override void SetDefaults()
        {
            item.accessory = true;
        }

        public override void UpdateInventory(Player player)
        {
            //decreases movement speed and damage while in inventory
            player.moveSpeed /= 2;
            player.accRunSpeed = 0.1f;
            player.allDamage *= 0.75f;
        }

        public override void UpdateVanity(Player player, EquipType type)
        {
            //decreases movement speed and damage while in inventory
            player.moveSpeed /= 2;
            player.accRunSpeed = 0.1f;
            player.allDamage *= 0.75f;
        }

        public override void HoldItem(Player player)
        {
            //decreases movement speed and damage while in inventory
            player.moveSpeed /= 2;
            player.accRunSpeed = 0.1f;
            player.allDamage *= 0.75f;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            //decreases movement speed and damage
            player.moveSpeed /= 3;
            player.accRunSpeed = 0;
            player.allDamage = 0;
            //increases mining range and speed
            player.blockRange = 10;
            player.pickSpeed /= 4;
            if (player.whoAmI == Main.myPlayer)
            {
                Player.tileRangeX += 25;
                Player.tileRangeY += 25;
            }
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
