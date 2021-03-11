using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UltimateQuest.Tiles
{
    public class Beskar : ModTile
    {
        public override void SetDefaults()
        {
            //how the ore acts when placed
            TileID.Sets.Ore[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileValue[Type] = 660; //Overrides titanium but not Chlorophyte
            Main.tileShine2[Type] = true;
            Main.tileShine[Type] = 995;
            Main.tileMergeDirt[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;

            //adds ore to the map
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Beskar Ore");
            AddMapEntry(new Color(145, 145, 145), name);

            //What happens when someone mines the ore
            dustType = 84;
            drop = ModContent.ItemType<Items.Placeable.Beskar>();
            soundType = SoundID.Tink;
            soundStyle = 1;
            mineResist = 2f;
            minPick = 95;
        }
    }
}