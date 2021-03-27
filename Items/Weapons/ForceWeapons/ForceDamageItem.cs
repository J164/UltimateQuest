﻿using Terraria;
using Terraria.ModLoader;

namespace UltimateQuest.Items.Weapons.ForceWeapons
{
    abstract class ForceDamageItem : ModItem
    {
        public int forceResourceCost = 0;

        //Subclasses should override this method rather than SetDefaults() (This ensures we don't accidentally enable vanilla damage types)
        public virtual void SafeSetDefaults()
        {

        }

        public sealed override void SetDefaults()
        {
            SafeSetDefaults();
            item.melee = false;
            item.ranged = false;
            item.magic = false;
            item.thrown = false;
            item.summon = false;
        }

        public override void ModifyWeaponDamage(Player player, ref float add, ref float mult, ref float flat)
        {
            add += UltimateQuestPlayer.ModPlayer(player).forceDamageAdd;
            mult *= UltimateQuestPlayer.ModPlayer(player).forceDamageMult;
        }

        public override void GetWeaponKnockback(Player player, ref float knockback)
        {
            knockback += UltimateQuestPlayer.ModPlayer(player).forceDamageKnockback;
        }

        public override void GetWeaponCrit(Player player, ref int crit)
        {
            crit += UltimateQuestPlayer.ModPlayer(player).forceDamageCrit;
        }

        public override bool CanUseItem(Player player)
        {
            var UltimateQuestPlayer = player.GetModPlayer<UltimateQuestPlayer>();

            if (UltimateQuestPlayer.forceResourceCurrent >= forceResourceCost)
            {
                UltimateQuestPlayer.forceResourceCurrent -= forceResourceCost;
                return true;
            }
            return false;
        }
    }
}
