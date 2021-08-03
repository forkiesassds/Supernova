/*
    Copyright 2021 Supernova
        
    Dual-licensed under the    Educational Community License, Version 2.0 and
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
using System.Collections.Generic;
using System.Threading;
using Supernova.Commands.World;
using Supernova.Events;
using Supernova.Events.LevelEvents;
using Supernova.Events.PlayerEvents;
using Supernova.Network;
using BlockID = System.UInt16;

namespace Supernova.Games {
    
    public sealed partial class SpleefGame : RoundsGame {
        BufferedBlockSender bulk = new BufferedBlockSender();
        
        protected override void DoRound() {
            bulk.level = Map;
            ResetBoard();
            if (!Running) return;
            DoRoundSpleef(10);
            ResetBoard();
            if (!Running) return;
            
            bulk.Flush();
            if (!Running) return;
            
            SpawnPlayers();
            if (!Running) return;
            
            BeginRound();
            if (!Running) return;
            
            RoundInProgress = true;
            UpdateAllStatus();
            RunRound();
        }
        
        protected override void ContinueOnSameMap() {
            // spleef only modifies board in the map, so it's fine to continue on the same map
            // without needing to reload the entire map
        }
        
        void BeginRound() {
            Map.Message("Starting Spleef");
            
            if (!Running) return;
            Map.Message("GO!!!!!!!");
            Map.Config.Deletable = true;
            Map.UpdateBlockPermissions();
            
            Player[] players = Players.Items;
            Remaining.Clear();
            foreach (Player pl in players) { Remaining.Add(pl); }
        } 

        void RunRound() {
            while (RoundInProgress && Running && Remaining.Count > 0);
        }
                
        void ResetBoard() {
            int maxX = Map.Width - 1, maxZ = Map.Length - 1;
            Cuboid(0, 4, 0, maxX, 4, maxZ, Block.White);
            
            bulk.Flush();
        }        
        
        void Cuboid(int x1, int y1, int z1, int x2, int y2, int z2, BlockID block) {
            for (int y = y1; y <= y2; y++)
                for (int z = z1; z <= z2; z++)
                    for (int x = x1; x <= x2; x++)
            {
                TryChangeBlock(x, y, z, block);
            }
        }
        
        void TryChangeBlock(int x, int y, int z, BlockID block) {
            int index = Map.PosToInt((ushort)x, (ushort)y, (ushort)z);
            if (!Map.DoPhysicsBlockchange(index, block)) return;
            
            bulk.Add(index, block);
        }
        
        void SpawnPlayers() {
            Player[] players = Players.Items;
            int midX = Map.Width / 2, midY = Map.Height / 2, midZ = Map.Length / 2;
            Position pos = Position.FromFeetBlockCoords(midX, midY, midZ);
            pos.X -= 16; pos.Z -= 16;
            
            foreach (Player pl in players) {
                if (pl.level != Map) {
                    pl.Message("Sending you to the correct map.");
                    PlayerActions.ChangeMap(pl, Map.name);
                }
                
                Entities.Spawn(pl, pl, pos, pl.Rot);
                pl.SendPos(Entities.SelfID, pos, pl.Rot);
            }
        }

        void OnPlayerDied(Player p) {
            if (!Remaining.Remove(p) || !RoundInProgress) return;
            Player[] players = Remaining.Items;
            
            switch (players.Length) {
                case 1:
                    Map.Message(players[0].ColoredName + " &Sis the winner!");
                    EndRound(players[0]);
                    break;
                case 2:
                    Map.Message("Only 2 Players left:");
                    Map.Message(players[0].ColoredName + " &Sand " + players[1].ColoredName);
                    break;
                default:
                    Map.Message(players.Length + " players left!");
                    break;
            }
            UpdateAllStatus();
        }
        
        public override void EndRound() { EndRound(null); }
        public void EndRound(Player winner) {
            RoundInProgress = false;
            Map.Config.Deletable = false;
            Map.UpdateBlockPermissions();
            Remaining.Clear();
            UpdateAllStatus();
            
            if (winner != null) {
                winner.Message("Congratulations, you won this round of spleef!");
                PlayerActions.Respawn(winner);
            } else {
                Player[] players = Players.Items;
                foreach (Player pl in players) {
                    PlayerActions.Respawn(pl);
                }
            }
        }
    }
}
