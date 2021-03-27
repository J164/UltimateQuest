using Terraria;
using Terraria.ModLoader;

namespace UltimateQuest.Items.Accessories.InfinityStones
{
    public abstract class InfinityStone : ModItem
    {
        public override bool CanEquipAccessory(Player player, int slot)
        {
            if (slot > 10)
            {
                return false;
            }
            return base.CanEquipAccessory(player, slot);
        }
    }
}