/*  Copyright 2021 Supernova
        
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
using Supernova.Commands.World;
using Supernova.Games;
using Supernova.Generator;

namespace Supernova.Commands.Fun {
    
    public sealed class CmdSpleef : RoundsGameCmd {
        public override string name { get { return "Spleef"; } }
        public override string shortcut { get { return "spl"; } }
        protected override RoundsGame Game { get { return SpleefGame.Instance; } }
        public override CommandPerm[] ExtraPerms {
            get { return new[] { new CommandPerm(LevelPermission.Operator, "can manage spleef") }; }
        }
        
        public override void Use(Player p, string message, CommandData data) {
            if (message.CaselessEq("join")) {
                HandleJoin(p, SpleefGame.Instance);
            } else {
                base.Use(p, message, data);
            }
        }
        
        void HandleJoin(Player p, SpleefGame game) {
            if (!game.Running) {
                p.Message("Cannot join as spleef is not running.");
            } else if (game.RoundInProgress) {
                p.Message("Cannot join when a round is in progress. Wait until next round.");
            } else {
                game.PlayerJoinedGame(p);
            }
        }

        static string FormatPlayer(Player pl, SpleefGame game) {
            string suffix = game.Remaining.Contains(pl) ? " &a[IN]" : " &c[OUT]";
            return pl.ColoredName + suffix;
        }
        
        protected override void HandleSet(Player p, RoundsGame game_, string[] args) {
            if (args.Length < 4) { Help(p); return; }
            if (game_.Running) {
                p.Message("You must stop Spleef before replacing the map."); return;
            }
            
            ushort x = 0, y = 0, z = 0;
            if (!MapGen.GetDimensions(p, args, 1, ref x, ref y, ref z)) return;
            
            SpleefGame game = (SpleefGame)game_;
            game.GenerateMap(p, x, y, z);
        }        
        
        protected override void HandleStart(Player p, RoundsGame game_, string[] args) {
            if (game_.Running) { p.Message("{0} is already running", game_.GameName); return; }
            
            SpleefGame game = (SpleefGame)game_;
            game.Start(p, "spleef", int.MaxValue);
        }       
        
        public override void Help(Player p) {
            p.Message("&T/Spl set [width] [height] [length]");
            p.Message("&HRe-generates the spleef map (default is 32x32x32)");
            p.Message("&T/Spl start &H- Starts Spleef");
            p.Message("&T/Spl stop &H- Stops Spleef"); 
            p.Message("&T/Spl end &H- Ends current round of Spleef");
            p.Message("&T/Spl join &H- joins the game");
            p.Message("&T/Spl status &H- lists players currently playing");
        }
    }
}
