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
            MakePlayAreaWalls(lvl);
            MakePlayArea(lvl);
            
            lvl.VisitAccess.Min   = LevelPermission.Guest;
            lvl.BuildAccess.Min   = LevelPermission.Guest; //whole map is op_[block] anyways
            lvl.Config.UseBlockDB = false;
            lvl.Config.Deletable  = false;
            lvl.Config.Buildable  = false;
            lvl.Config.Drawing    = false;
            lvl.Config.MOTD = "Welcome to the Spleef map! -hax";
            
            lvl.spawnx = (ushort)(lvl.Width / 2);
            lvl.spawny = (ushort)(lvl.Height / 2 + 4);
            lvl.spawnz = (ushort)(lvl.Length / 2);
            return lvl;
        }
        
        static void MakeBoundaries(Level lvl) {
            int maxX = lvl.Width - 1, maxZ = lvl.Length - 1;
            Cuboid(0, 1, 0, maxX, 1, maxZ, Block.Magma, lvl);
        }
        
        static void MakeViewAreaRoof(Level lvl) {
            int maxX = lvl.Width - 1, midY = lvl.Height / 2, maxZ = lvl.Length - 1;
            Cuboid(0, midY, 0, maxX, midY, maxZ, Block.Op_Glass, lvl);
        }
        
        static void MakePlayAreaWalls(Level lvl) {
            int maxX = lvl.Width - 1, maxZ = lvl.Length - 1, maxY = lvl.Height - 1;
            Cuboid(0, 4, 0, 0, maxY / 2 + 1, maxZ, Block.Op_Stone, lvl);
            Cuboid(maxX, 4, 0, maxX, maxY / 2 + 1, maxZ, Block.Op_Stone, lvl);
            Cuboid(0, 4, 0, maxX, maxY / 2 + 1, 0, Block.Op_Stone, lvl);
            Cuboid(0, 4, maxZ, maxX, maxY / 2  + 1, maxZ, Block.Op_Stone, lvl);
        }
        
        static void MakePlayArea(Level lvl) {
            int maxX = lvl.Width - 1, maxZ = lvl.Length - 1;
            Cuboid(0, 4, 0, maxX, 4, maxZ, Block.White, lvl);
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
