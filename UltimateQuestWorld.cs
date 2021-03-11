using UltimateQuest.Tiles;
using System.Collections.Generic;
using Terraria;
using Terraria.GameContent.Generation;
using Terraria.ModLoader;
using Terraria.World.Generation;

namespace UltimateQuest
{
    public class UltimateQuestWorld : ModWorld
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            //adds ore generation to the world gen process
            int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (ShiniesIndex != -1)
            {
                tasks.Insert(ShiniesIndex + 1, new PassLegacy("Ultimate Quest Ores", UltimateQuestInitialOres));
            }
        }
        public override void ModifyHardmodeTasks(List<GenPass> list)
        {
            list.Add(new PassLegacy("Ultimate Quest Ores", UltimateQuestHardmodeOres));
        }
        private void UltimateQuestHardmodeOres(GenerationProgress progress)
        {
            //What displays during this step when generating the world
            progress.Message = "Generating Ultimate Quest Ores";

            //ore setup for Uru
            for (int k = 0; k < (int)((Main.maxTilesX * Main.maxTilesY) * 4E-05); k++)
            {
                //where on the x axis the ore can generate
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                //where on the y axis the ore can generate
                int y = WorldGen.genRand.Next((int)WorldGen.rockLayerLow, Main.maxTilesY);

                //Set the "Strength" and "Step" of the vein
                WorldGen.TileRunner(x, y, WorldGen.genRand.Next(2, 5), WorldGen.genRand.Next(12, 23), ModContent.TileType<Uru>());
            }
            //ore setup for Beskar
            for (int k = 0; k < (int)((Main.maxTilesX * Main.maxTilesY) * 6E-05); k++)
            {
                //where on the x axis the ore can generate
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                //where on the y axis the ore can generate
                int y = WorldGen.genRand.Next((int)WorldGen.rockLayerLow, Main.maxTilesY);

                //Set the "Strength" (Chance of success) and "Step" (Number of ore attempted to be generated) of the vein
                WorldGen.TileRunner(x, y, WorldGen.genRand.Next(5, 6), WorldGen.genRand.Next(10, 15), ModContent.TileType<Beskar>());
            }
        }
        private void UltimateQuestInitialOres(GenerationProgress progress)
        {
            //ore setup for Kyber
            for (int k = 0; k < (int)((Main.maxTilesX * Main.maxTilesY) * 2E-05); k++)
            {
                //where on the x axis the ore can generate
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                //where on the y axis the ore can generate
                int y = WorldGen.genRand.Next((int)WorldGen.rockLayerLow, Main.maxTilesY);

                //Set the "Strength" (Chance of success) and "Step" (Number of ore attempted to be generated) of the vein
                WorldGen.TileRunner(x, y, WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 3), ModContent.TileType<Kyber>());
            }
        }
    }
}