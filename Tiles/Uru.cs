﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UltimateQuest.Tiles
{
    public class Uru : ModTile
    {
        public override void SetDefaults()
        {
            //how the ore acts when placed
            TileID.Sets.Ore[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileValue[Type] = 710; //Overrides Chlorophyte
            Main.tileShine2[Type] = true;
            Main.tileShine[Type] = 995;
            Main.tileMergeDirt[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;

            //adds the ore to the map
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Uru");
            AddMapEntry(new Color(161, 173, 173), name);

            //What happens when someone mines the ore
            dustType = 84;
            drop = ModContent.ItemType<Items.Placeable.Uru>();
            soundType = SoundID.Tink;
            soundStyle = 1;
            mineResist = 20f;
            minPick = 225;
        }
    }
}