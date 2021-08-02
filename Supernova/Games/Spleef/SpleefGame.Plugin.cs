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
using Supernova.Events.LevelEvents;
using Supernova.Events.PlayerEvents;

namespace Supernova.Games {
    
    public sealed partial class SpleefGame : RoundsGame {
        
         protected override void HookEventHandlers() {
            OnPlayerSpawningEvent.Register(HandlePlayerSpawning, Priority.High);
            OnJoinedLevelEvent.Register(HandleOnJoinedLevel, Priority.High);
            
            base.HookEventHandlers();
        }
        
        protected override void UnhookEventHandlers() {
            OnPlayerSpawningEvent.Unregister(HandlePlayerSpawning);
            OnJoinedLevelEvent.Unregister(HandleOnJoinedLevel);
            
            base.UnhookEventHandlers();
        }
        
        void HandlePlayerSpawning(Player p, ref Position pos, ref byte yaw, ref byte pitch, bool respawning) {
            if (!respawning || !Remaining.Contains(p)) return;
            Map.Message(p.ColoredName + " &Sis out of spleef!");
            OnPlayerDied(p);
        }
        
        void HandleOnJoinedLevel(Player p, Level prevLevel, Level level, ref bool announce) {
            HandleJoinedCommon(p, prevLevel, level, ref announce);
        }
    }
}
