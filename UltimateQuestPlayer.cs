using Terraria;
using Terraria.ModLoader;

namespace UltimateQuest
{
    class UltimateQuestPlayer : ModPlayer
    {
        public static UltimateQuestPlayer ModPlayer(Player player)
        {
            return player.GetModPlayer<UltimateQuestPlayer>();
        }

        public float forceDamageAdd;
        public float forceDamageMult = 1f;
        public float forceDamageKnockback;
        public int forceDamageCrit;

        public float quantumDamageAdd;
        public float quantumDamageMult = 1f;
        public float quantumDamageKnockback;
        public int quantumDamageCrit;

        //should act similarly to mana and regen rate should decrease as you take damage
        public int forceResourceCurrent;
        public const int forceResourceMaxDefault = 100;
        public int forceResourceMax;
        public int forceResourceMax2;
        public float forceResourceRegenRate;
        internal int forceResourceRegenTimer = 0;

        //should increase as the player gets successful hits and then be spent
        public int quantumResourceCurrent;
        public const int quantumResourceMaxDefault = 50;
        public int quantumResourceMax;
        public int quantumResourceMax2;

        public override void Initialize()
        {
            forceResourceMax = forceResourceMaxDefault;
            quantumResourceMax = quantumResourceMaxDefault;
        }

        private void ResetVariables()
        {
            forceDamageAdd = 0f;
            forceDamageMult = 1f;
            forceDamageKnockback = 0f;
            forceDamageCrit = 0;
            forceResourceRegenRate = 1f;
            forceResourceMax2 = forceResourceMax;
            quantumDamageAdd = 0f;
            quantumDamageMult = 1f;
            quantumDamageKnockback = 0f;
            quantumDamageCrit = 0;
        }

        public override void ResetEffects()
        {
            ResetVariables();
        }

        public override void UpdateDead()
        {
            ResetVariables();
        }

    }
}
