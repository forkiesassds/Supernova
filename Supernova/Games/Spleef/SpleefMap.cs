/*
    Copyright 2021 Supernova
        
    Dual-licensed under the Educational Community License, Version 2.0 and
    the GNU General Public License, Version 3 (the "Licenses"); you may
    not use this file except in compliance with the Licenses. You may
    obtain a copy of the Licenses at
    
    http://www.opensource.org/licenses/ecl2.php
    http://www.gnu.org/licenses/gpl-3.0.html
    
    Unless required by applicable law or agreed to in writing,
    software distributed under the Licenses are distributed on an "AS IS"
    BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
    or implied. See the Licenses for the specific language governing
    permissions and limitations under the Licenses.
 */
using System;

namespace Supernova.Games {
    
    /// <summary> Generates a map for spleef. </summary>
    public static class SpleefMapGen {
        
        public static Level Generate(int width, int height, int length) {
            Level lvl = new Level("spleef", (ushort)width, (ushort)height, (ushort)length);
            MakeBoundaries(lvl);
            MakeViewAreaRoof(lvl);
            MakeViewAreaWalls(lvl);
            MakeViewAreaFloor(lvl);
            MakeChutesAndElevators(lvl);
            MakeSquares(lvl);
            
            lvl.VisitAccess.Min   = LevelPermission.Guest;
            lvl.BuildAccess.Min   = LevelPermission.Guest; //whole map is op_[block] anyways
            lvl.Config.UseBlockDB = false;
            lvl.Config.Deletable  = true;
            lvl.Config.Buildable  = false;
            lvl.Config.MOTD = "Welcome to the Spleef map! -hax";
            
            lvl.spawnx = (ushort)(lvl.Width / 2);
            lvl.spawny = (ushort)(lvl.Height / 2 + 4);
            lvl.spawnz = (ushort)(lvl.Length / 2);
            return lvl;
        }
        
        static void MakeBoundaries(Level lvl) {
            int maxX = lvl.Width - 1, maxY = lvl.Height - 1, maxZ = lvl.Length - 1;
            Cuboid(0, maxY, 0, maxX, maxY, maxZ, Block.Op_Glass, lvl);
            Cuboid(0, 0, 0, maxX, 0, maxZ, Block.Op_Stone, lvl);
            Cuboid(0, 1, 0, maxX, 1, maxZ, Block.Magma, lvl);
            
            Cuboid(0, 0, 0, maxX, maxY, 0, Block.Op_Stone, lvl);
            Cuboid(0, 0, maxZ, maxX, maxY, maxZ, Block.Op_Stone, lvl);
            Cuboid(0, 0, 0, 0, maxY, maxZ, Block.Op_Stone, lvl);
            Cuboid(maxX, 0, 0, maxX, maxY, maxZ, Block.Op_Stone, lvl);
        }
        
        static void MakeViewAreaRoof(Level lvl) {
            int maxX = lvl.Width - 1, midY = lvl.Height / 2, maxZ = lvl.Length - 1;
            Cuboid(1, midY, 1, maxX - 1, midY, maxZ - 1, Block.Op_Glass, lvl);
            Cuboid(1, midY, 0, 3, midY, maxZ, Block.Op_Stone, lvl);
            Cuboid(maxX - 3, midY, 1, maxX - 1, midY, maxZ, Block.Op_Stone, lvl);
            Cuboid(0, midY, 1, maxX, midY, 3, Block.Op_Stone, lvl);
            Cuboid(0, midY, maxZ - 3, maxX, midY, maxZ - 1, Block.Op_Stone, lvl);
        }
        
        static void MakeViewAreaWalls(Level lvl) {
            int maxX = lvl.Width - 1, maxZ = lvl.Length - 1, maxY = lvl.Height - 1;
            Cuboid(3, 4, 3, 3, maxY / 2, maxZ - 3, Block.Op_Stone, lvl);
            Cuboid(maxX - 3, 4, 3, maxX - 3, maxY / 2, maxZ - 3, Block.Op_Stone, lvl);
            Cuboid(3, 4, 3, maxX - 3, maxY / 2, 3, Block.Op_Stone, lvl);
            Cuboid(3, 4, maxZ - 3, maxX - 3, maxY / 2, maxZ - 3, Block.Op_Stone, lvl);
            
            Cuboid(3, 6, 3, 3, maxY / 2 - 1, maxZ - 3, Block.Op_Glass, lvl);
            Cuboid(maxX - 3, 6, 3, maxX - 3, maxY / 2 - 1, maxZ - 3, Block.Op_Glass, lvl);
            Cuboid(3, 6, 3, maxX - 3, maxY / 2 - 1, 3, Block.Op_Glass, lvl);
            Cuboid(3, 6, maxZ - 3, maxX - 3, maxY / 2 - 1, maxZ - 3, Block.Op_Glass, lvl);
        }
        
        static void MakeViewAreaFloor(Level lvl) {
            int maxX = lvl.Width - 1, maxZ = lvl.Length - 1;
            Cuboid(1, 4, 0, 3, 4, maxZ, Block.Op_Stone, lvl);
            Cuboid(maxX - 3, 4, 1, maxX - 1, 4, maxZ, Block.Op_Stone, lvl);
            Cuboid(0, 4, 1, maxX, 4, 3, Block.Op_Stone, lvl);
            Cuboid(0, 4, maxZ - 3, maxX, 4, maxZ - 1, Block.Op_Stone, lvl);
        }
        
        static void MakeChutesAndElevators(Level lvl) {
            int maxX = lvl.Width - 1, maxY = lvl.Height - 1, maxZ = lvl.Length - 1;
            Cuboid(1, 5, 1, 1, maxY - 1, 1, Block.StillWater, lvl);
            Cuboid(maxX - 1, 5, 1, maxX - 1, maxY - 1, 1, Block.StillWater, lvl);
            Cuboid(1, 5, maxZ - 1, 1, maxY - 1, maxZ - 1, Block.StillWater, lvl);
            Cuboid(maxX - 1, 5, maxZ - 1, maxX - 1, maxY - 1, maxZ - 1, Block.StillWater, lvl);
            
            int midX = lvl.Width / 2, midY = lvl.Height / 2, midZ = lvl.Length / 2;
            Cuboid(midX - 2, midY + 1, midZ - 2, midX + 1, maxY, midZ - 2, Block.Op_Glass, lvl);
            Cuboid(midX - 2, midY + 1, midZ + 1, midX + 1, maxY, midZ + 1, Block.Op_Glass, lvl);
            Cuboid(midX - 2, midY + 1, midZ - 2, midX - 2, maxY, midZ + 1, Block.Op_Glass, lvl);
            Cuboid(midX + 1, midY + 1, midZ - 2, midX + 1, maxY, midZ + 1, Block.Op_Glass, lvl);
            // make some holes in the chutes
            Cuboid(midX - 1, maxY, midZ - 1, midX, maxY, midZ, Block.Air, lvl);
            Cuboid(midX - 1, midY + 1, midZ - 2, midX, midY + 2, midZ - 2, Block.Air, lvl);
            Cuboid(midX - 1, midY + 1, midZ + 1, midX, midY + 2, midZ + 1, Block.Air, lvl);
            Cuboid(midX - 2, midY + 1, midZ - 1, midX - 2, midY + 2, midZ, Block.Air, lvl);
            Cuboid(midX + 1, midY + 1, midZ - 1, midX + 1, midY + 2, midZ, Block.Air, lvl);
        }
        
        static void MakeSquares(Level lvl) {
            int maxX = lvl.Width - 1, maxZ = lvl.Length - 1;
            Cuboid(4, 4, 4, maxX - 4, 4, maxZ - 4, Block.White, lvl);
        }
        
        static void Cuboid(int x1, int y1, int z1, int x2, int y2, int z2, byte block, Level lvl) {
            for (int y = y1; y <= y2; y++)
                for (int z = z1; z <= z2; z++)
                    for (int x = x1; x <= x2; x++)
            {
                lvl.SetTile((ushort)x, (ushort)y, (ushort)z, block);
            }
        }
    }
}
