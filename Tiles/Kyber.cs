using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UltimateQuest.Tiles
{
    public class Kyber : ModTile
    {
        public override void SetDefaults()
        {
            TileID.Sets.Ore[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileValue[Type] = 420;
            Main.tileShine2[Type] = true;
            Main.tileShine[Type] = 995;
            Main.tileMergeDirt[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Kyber Crystal");
            //Choose new color
            AddMapEntry(new Color(228, 0, 0), name);

            dustType = 84;
            drop = ModContent.ItemType<Items.Placeable.Kyber>();
            soundType = SoundID.Tink;
            soundStyle = 1;
            mineResist = 2f;
            minPick = 65;
        }
    }
}