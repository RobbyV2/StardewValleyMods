﻿using SpaceCore.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using StardewValley;
using xTile;
using MoreBuildings.SpookyShed;
using StardewValley.Monsters;
using Microsoft.Xna.Framework.Graphics;
using SObject = StardewValley.Object;

namespace MoreBuildings.FishingShack
{
    public class FishingShackLocation : GameLocation
    {
        public FishingShackLocation()
        :   base( "Maps\\FishShack", "FishShack")
        {
            this.waterTiles = new bool[map.Layers[0].LayerWidth, map.Layers[0].LayerHeight];
            for (int xTile = 0; xTile < map.Layers[0].LayerWidth; ++xTile)
            {
                for (int yTile = 0; yTile < map.Layers[0].LayerHeight; ++yTile)
                {
                    if (this.doesTileHaveProperty(xTile, yTile, "Water", "Back") != null)
                    {
                        this.waterTiles[xTile, yTile] = true;
                    }
                }
            }
        }

        public override SObject getFish(float millisecondsAfterNibble, int bait, int waterDepth, StardewValley.Farmer who, double baitPotency, string locationName = null)
        {
            var fish = new int[] { 128, 129, 130, 131, 132, 136, 137, 1338, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 682, 698, 699, 700, 701, 702, 704, 705, 706, 707, 708, 734, 775, 795, 796 };

            return new SObject(Vector2.Zero, fish[ Game1.random.Next( fish.Length ) ], 1);
            //return base.getFish(millisecondsAfterNibble, bait, waterDepth, who, baitPotency, locationName);
        }
    }
}
