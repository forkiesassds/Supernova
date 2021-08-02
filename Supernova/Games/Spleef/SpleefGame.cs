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

    public sealed class SpleefConfig : RoundsGameConfig {
        public override bool AllowAutoload { get { return true; } }
        protected override string GameName { get { return "Spleef"; } }
        protected override string PropsPath { get { return "properties/spleef.properties"; } }
        
        public override void Load() {
            base.Load();
            if (Maps.Count == 0) Maps.Add("spleef");
        }
    }
    
    public sealed partial class SpleefGame : RoundsGame {
        public VolatileArray<Player> Players = new VolatileArray<Player>();
        public VolatileArray<Player> Remaining = new VolatileArray<Player>();
        
        public static SpleefConfig Config = new SpleefConfig();
        public override string GameName { get { return "Spleef"; } }
        public override RoundsGameConfig GetConfig() { return Config; }
        
        public int Interval;
        
        public static SpleefGame Instance = new SpleefGame();
        public SpleefGame() { Picker = new LevelPicker(); }
        
        public override void UpdateMapConfig() { }
        
        protected override List<Player> GetPlayers() {
            List<Player> playing = new List<Player>();
            playing.AddRange(Players.Items);
            return playing;
        }
        
        public override void OutputStatus(Player p) {
            Player[] players = Players.Items;            
            p.Message("Players in spleef:");
            
            if (RoundInProgress) {               
                p.Message(players.Join(pl => FormatPlayer(pl)));
            } else {
                p.Message(players.Join(pl => pl.ColoredName));
            }
        }
        
        string FormatPlayer(Player pl) {
            string suffix = Remaining.Contains(pl) ? " &a[IN]" : " &c[OUT]";
            return pl.ColoredName + suffix;
        }
        
        protected override string GetStartMap(Player p, string forcedMap) {
            if (!LevelInfo.MapExists("spleef")) {
                p.Message("Spleef level not found, generating..");
                GenerateMap(p, 32, 32, 32);
            }
            return "spleef";
        }

        protected override void StartGame() { }
        protected override void EndGame() {
            Players.Clear();
            Remaining.Clear();
        }
        
        public void GenerateMap(Player p, int width, int height, int length) {
            Level lvl = SpleefMapGen.Generate(width, height, length);
            Level cur = LevelInfo.FindExact("spleef");
            if (cur != null) LevelActions.Replace(cur, lvl);
            else LevelInfo.Add(lvl);
            
            lvl.Save();
            Map = lvl;
            
            const string format = "Generated map ({0}x{1}x{2}), sending you to it..";
            p.Message(format, width, height, length);
            PlayerActions.ChangeMap(p, "spleef");
        }
        
        public override void PlayerJoinedGame(Player p) {
            if (!Players.Contains(p)) {
                if (p.level != Map && !PlayerActions.ChangeMap(p, "spleef")) return;
                Players.Add(p);
                p.Message("You've joined spleef!");
                Chat.MessageFrom(p, "λNICK &Sjoined spleef!");              
            } else {
                p.Message("You've already joined spleef. To leave, go to another map.");
            }
        }
        
        public override void PlayerLeftGame(Player p) {
            Players.Remove(p);
            OnPlayerDied(p);
        }
        
        protected override string FormatStatus1(Player p) {
            return RoundInProgress ? Remaining.Count + " players left" : "";
        }
    }
}
