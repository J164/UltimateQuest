using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace UltimateQuest.Items.Accessories.InfinityStones
{
    public class MindStone : InfinityStone
    {
        public override void SetStaticDefaults()
        {
            //Update tooltip to reflect actual stat changes
            Tooltip.SetDefault("You feel a conscience reach out to you" + Language.GetTextValue("CommonItemTooltip.PercentIncreasedDamage", 200));
        }

        public override void SetDefaults()
        {
            item.accessory = true;
        }

        public override void UpdateInventory(Player player)
        {
            //decreases life regen when item is in inventory
            player.AddBuff(BuffID.Confused, 1);
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddBuff(BuffID.Cursed, 1);
            //Add a unique confused debuff
            //Add a visual effect for confusion aura
            foreach (NPC npc in Main.npc)
            {
                if (npc.active && !npc.friendly && !npc.boss && npc.Distance(player.Center) < 300)
                {
                    npc.AddBuff(BuffID.Confused, 5);
                }
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