using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UltimateQuest.Tiles
{
    public class Uru : ModTile
    {
        public override void SetDefaults()
        {
            TileID.Sets.Ore[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileValue[Type] = 499;
            Main.tileShine2[Type] = true;
            Main.tileShine[Type] = 995;
            Main.tileMergeDirt[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Uru");
            AddMapEntry(new Color(228, 0, 0), name);

            dustType = 84;
            drop = ModContent.ItemType<Items.Placeable.Uru>();
            soundType = SoundID.Tink;
            soundStyle = 1;
            mineResist = 20f;
            minPick = 225;
        }
    }
}