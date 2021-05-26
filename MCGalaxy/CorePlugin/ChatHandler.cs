/*
    Copyright 2011 MCForge
        
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
using MCGalaxy.Commands.Chatting;

namespace MCGalaxy.Core {

    internal static class ChatHandler {
        
        internal static void HandleOnChat(ChatScope scope, Player source, string msg, 
                                          object arg, ref ChatMessageFilter filter, bool irc) {
            msg = msg.Replace("λFULL", source.name).Replace("λNICK", source.name);
            LogType logType = LogType.PlayerChat;
            
            if (scope == ChatScope.Perms) {
               logType = LogType.StaffChat;
            } else if (scope == ChatScope.Chatroom || scope == ChatScope.AllChatrooms) {
                logType = LogType.ChatroomChat;
            } else if (scope == ChatScope.Rank) {
                logType = LogType.RankChat;
            }
            
            if (scope != ChatScope.PM) Logger.Log(logType, msg);
        }
    }
}
