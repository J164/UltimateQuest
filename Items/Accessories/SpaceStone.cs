﻿using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace UltimateQuest.Items.Accessories
{
    public class SpaceStone : InfinityStone
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Your focus is drawn to the endless stores of energy deep within the stone\nThe entire universe is now accessable\n");
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
