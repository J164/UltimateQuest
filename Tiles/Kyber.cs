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
            //how the ore acts when placed
            TileID.Sets.Ore[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileValue[Type] = 320; //Overrides crimtane but not meteorite
            Main.tileShine2[Type] = true;
            Main.tileShine[Type] = 995;
            Main.tileMergeDirt[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;

            //adds ore to the map
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Kyber Crystal");
            AddMapEntry(new Color(232, 255, 255), name);

            //What happens when someone mines the ore
            dustType = 84;
            drop = ModContent.ItemType<Items.Placeable.Kyber>();
            soundType = SoundID.Tink;
            soundStyle = 1;
            mineResist = 2f;
            minPick = 80;
        }
    }
}