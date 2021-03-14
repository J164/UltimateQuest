using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UltimateQuest.Items
{
    public class TorturedPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The Pickaxe cries out at every swing\nCan mine Kyber");
        }
        public override void SetDefaults()
        {
            item.damage = 15;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            //item.useTime corrosponds with the tool speed of the pickaxe
            item.useTime = 15;
            //item.useAnimation corrosponds with the use time of the pickaxe (visual only)
            item.useAnimation = 20;
            //item.pick corrosponds with pickaxe power (%)
            item.pick = 80;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 3.5f;
            item.value = 5000;
            item.rare = ItemRarityID.LightRed;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Bone, 20);
            recipe.AddIngredient(ItemID.Spike, 10);
            recipe.AddTile(TileID.BoneWelder);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.NextBool(10))
            {
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Blood);
            }
        }
    }
}