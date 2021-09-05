/*
    Copyright 2010 MCSharp team (Modified for use with MCZall/MCLawl/Supernova)
    
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
using System.Windows.Forms;

namespace Supernova.Gui
{
    public partial class Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        	this.components = new System.ComponentModel.Container();
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
        	this.tsMap = new System.Windows.Forms.ContextMenuStrip(this.components);
        	this.tsMap_physicsMenu = new System.Windows.Forms.ToolStripMenuItem();
        	this.tsMap_physics0 = new System.Windows.Forms.ToolStripMenuItem();
        	this.tsMap_physics1 = new System.Windows.Forms.ToolStripMenuItem();
        	this.tsMap_physics2 = new System.Windows.Forms.ToolStripMenuItem();
        	this.tsMap_physics3 = new System.Windows.Forms.ToolStripMenuItem();
        	this.tsMap_physics4 = new System.Windows.Forms.ToolStripMenuItem();
        	this.tsMap_physics5 = new System.Windows.Forms.ToolStripMenuItem();
        	this.tsMap_actionsMenu = new System.Windows.Forms.ToolStripMenuItem();
        	this.tsMap_Save = new System.Windows.Forms.ToolStripMenuItem();
        	this.tsMap_Reload = new System.Windows.Forms.ToolStripMenuItem();
        	this.tsMap_Unload = new System.Windows.Forms.ToolStripMenuItem();
        	this.tsMap_moveAll = new System.Windows.Forms.ToolStripMenuItem();
        	this.tsMap_separator = new System.Windows.Forms.ToolStripSeparator();
        	this.tsMap_info = new System.Windows.Forms.ToolStripMenuItem();
        	this.tsPlayer = new System.Windows.Forms.ContextMenuStrip(this.components);
        	this.tsPlayer_whois = new System.Windows.Forms.ToolStripMenuItem();
        	this.tsPlayer_kick = new System.Windows.Forms.ToolStripMenuItem();
        	this.tsPlayer_ban = new System.Windows.Forms.ToolStripMenuItem();
        	this.tsPlayer_voice = new System.Windows.Forms.ToolStripMenuItem();
        	this.tsPlayer_clones = new System.Windows.Forms.ToolStripMenuItem();
        	this.tsPlayer_promote = new System.Windows.Forms.ToolStripMenuItem();
        	this.tsPlayer_demote = new System.Windows.Forms.ToolStripMenuItem();
        	this.icon_context = new System.Windows.Forms.ContextMenuStrip(this.components);
        	this.icon_openConsole = new System.Windows.Forms.ToolStripMenuItem();
        	this.icon_shutdown = new System.Windows.Forms.ToolStripMenuItem();
        	this.icon_restart = new System.Windows.Forms.ToolStripMenuItem();
        	this.main_btnProps = new System.Windows.Forms.Button();
        	this.main_btnClose = new System.Windows.Forms.Button();
        	this.main_btnRestart = new System.Windows.Forms.Button();
        	this.logs_tp = new System.Windows.Forms.TabPage();
        	this.logs_tab = new System.Windows.Forms.TabControl();
        	this.logs_tabErr = new System.Windows.Forms.TabPage();
        	this.logs_txtError = new System.Windows.Forms.TextBox();
        	this.logs_tabGen = new System.Windows.Forms.TabPage();
        	this.logs_lblGeneral = new System.Windows.Forms.Label();
        	this.logs_dateGeneral = new System.Windows.Forms.DateTimePicker();
        	this.logs_txtGeneral = new System.Windows.Forms.RichTextBox();
        	this.tabLog_Sys = new System.Windows.Forms.TabPage();
        	this.logs_txtSystem = new System.Windows.Forms.TextBox();
        	this.tp_Main = new System.Windows.Forms.TabPage();
        	this.main_btnUnloadEmpty = new System.Windows.Forms.Button();
        	this.main_btnKillPhysics = new System.Windows.Forms.Button();
        	this.main_btnSaveAll = new System.Windows.Forms.Button();
        	this.main_Maps = new System.Windows.Forms.DataGridView();
        	this.main_colLvlName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.main_colLvlPlayers = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.main_colLvlPhysics = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.main_txtLog = new Supernova.Gui.Components.ColoredTextBox();
        	this.tsLog_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
        	this.tsLog_night = new System.Windows.Forms.ToolStripMenuItem();
        	this.tsLog_Colored = new System.Windows.Forms.ToolStripMenuItem();
        	this.tsLog_dateStamp = new System.Windows.Forms.ToolStripMenuItem();
        	this.tsLog_autoScroll = new System.Windows.Forms.ToolStripMenuItem();
        	this.tsLog_separator1 = new System.Windows.Forms.ToolStripSeparator();
        	this.tsLog_copySelected = new System.Windows.Forms.ToolStripMenuItem();
        	this.tsLog_copyAll = new System.Windows.Forms.ToolStripMenuItem();
        	this.tsLog_separator2 = new System.Windows.Forms.ToolStripSeparator();
        	this.tsLog_clear = new System.Windows.Forms.ToolStripMenuItem();
        	this.main_txtInput = new System.Windows.Forms.TextBox();
        	this.main_txtUrl = new System.Windows.Forms.TextBox();
        	this.main_Players = new System.Windows.Forms.DataGridView();
        	this.main_colPlName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.main_colPlMap = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.main_colPlRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.tabs = new System.Windows.Forms.TabControl();
        	this.tp_Maps = new System.Windows.Forms.TabPage();
        	this.map_gbProps = new System.Windows.Forms.GroupBox();
        	this.map_pgProps = new Supernova.Gui.HackyPropertyGrid();
        	this.map_gbLoaded = new System.Windows.Forms.GroupBox();
        	this.map_lbLoaded = new System.Windows.Forms.ListBox();
        	this.map_gbUnloaded = new System.Windows.Forms.GroupBox();
        	this.map_btnLoad = new System.Windows.Forms.Button();
        	this.map_lbUnloaded = new System.Windows.Forms.ListBox();
        	this.map_gbNew = new System.Windows.Forms.GroupBox();
        	this.map_btnGen = new System.Windows.Forms.Button();
        	this.map_lblType = new System.Windows.Forms.Label();
        	this.map_lblSeed = new System.Windows.Forms.Label();
        	this.map_lblZ = new System.Windows.Forms.Label();
        	this.map_lblX = new System.Windows.Forms.Label();
        	this.map_lblY = new System.Windows.Forms.Label();
        	this.map_txtSeed = new System.Windows.Forms.TextBox();
        	this.map_cmbType = new System.Windows.Forms.ComboBox();
        	this.map_cmbZ = new System.Windows.Forms.ComboBox();
        	this.map_cmbY = new System.Windows.Forms.ComboBox();
        	this.map_cmbX = new System.Windows.Forms.ComboBox();
        	this.map_lblName = new System.Windows.Forms.Label();
        	this.map_txtName = new System.Windows.Forms.TextBox();
        	this.tp_Players = new System.Windows.Forms.TabPage();
        	this.pl_lblOnline = new System.Windows.Forms.Label();
        	this.pl_gbProps = new System.Windows.Forms.GroupBox();
        	this.pl_pgProps = new Supernova.Gui.HackyPropertyGrid();
        	this.pl_gbOther = new System.Windows.Forms.GroupBox();
        	this.pl_txtImpersonate = new System.Windows.Forms.TextBox();
        	this.pl_btnSendCommand = new System.Windows.Forms.Button();
        	this.pl_txtMessage = new System.Windows.Forms.TextBox();
        	this.pl_btnMessage = new System.Windows.Forms.Button();
        	this.pl_gbActions = new System.Windows.Forms.GroupBox();
        	this.pl_btnKill = new System.Windows.Forms.Button();
        	this.pl_txtUndo = new System.Windows.Forms.TextBox();
        	this.pl_btnWarn = new System.Windows.Forms.Button();
        	this.pl_btnRules = new System.Windows.Forms.Button();
        	this.pl_btnKick = new System.Windows.Forms.Button();
        	this.pl_btnBanIP = new System.Windows.Forms.Button();
        	this.pl_btnUndo = new System.Windows.Forms.Button();
        	this.pl_btnMute = new System.Windows.Forms.Button();
        	this.pl_btnBan = new System.Windows.Forms.Button();
        	this.pl_btnFreeze = new System.Windows.Forms.Button();
        	this.pl_statusBox = new System.Windows.Forms.TextBox();
        	this.pl_listBox = new System.Windows.Forms.ListBox();
        	this.tb_games = new System.Windows.Forms.TabPage();
        	this.tabGames = new System.Windows.Forms.TabControl();
        	this.tabLS = new System.Windows.Forms.TabPage();
        	this.ls_grpControls = new System.Windows.Forms.GroupBox();
        	this.ls_btnEnd = new System.Windows.Forms.Button();
        	this.ls_btnStop = new System.Windows.Forms.Button();
        	this.ls_btnStart = new System.Windows.Forms.Button();
        	this.ls_grpMapSettings = new System.Windows.Forms.GroupBox();
        	this.ls_grpTime = new System.Windows.Forms.GroupBox();
        	this.ls_numFlood = new Supernova.Gui.TimespanUpDown();
        	this.ls_numLayerTime = new Supernova.Gui.TimespanUpDown();
        	this.ls_numRound = new Supernova.Gui.TimespanUpDown();
        	this.ls_lblLayerTime = new System.Windows.Forms.Label();
        	this.ls_lblFlood = new System.Windows.Forms.Label();
        	this.ls_lblRound = new System.Windows.Forms.Label();
        	this.ls_grpLayer = new System.Windows.Forms.GroupBox();
        	this.ls_lblBlocksTall = new System.Windows.Forms.Label();
        	this.ls_numHeight = new System.Windows.Forms.NumericUpDown();
        	this.ls_lblLayersEach = new System.Windows.Forms.Label();
        	this.ls_numCount = new System.Windows.Forms.NumericUpDown();
        	this.ls_numLayer = new System.Windows.Forms.NumericUpDown();
        	this.ls_lblLayer = new System.Windows.Forms.Label();
        	this.ls_grpBlock = new System.Windows.Forms.GroupBox();
        	this.ls_numDestroy = new System.Windows.Forms.NumericUpDown();
        	this.ls_numWater = new System.Windows.Forms.NumericUpDown();
        	this.ls_numFast = new System.Windows.Forms.NumericUpDown();
        	this.ls_numKiller = new System.Windows.Forms.NumericUpDown();
        	this.ls_lblDestroy = new System.Windows.Forms.Label();
        	this.ls_lblFast = new System.Windows.Forms.Label();
        	this.ls_lblWater = new System.Windows.Forms.Label();
        	this.ls_lblKill = new System.Windows.Forms.Label();
        	this.ls_grpSettings = new System.Windows.Forms.GroupBox();
        	this.ls_lblMax = new System.Windows.Forms.Label();
        	this.ls_numMax = new System.Windows.Forms.NumericUpDown();
        	this.ls_cbMain = new System.Windows.Forms.CheckBox();
        	this.ls_cbMap = new System.Windows.Forms.CheckBox();
        	this.ls_cbStart = new System.Windows.Forms.CheckBox();
        	this.ls_grpMaps = new System.Windows.Forms.GroupBox();
        	this.ls_lblNotUsed = new System.Windows.Forms.Label();
        	this.ls_lblUsed = new System.Windows.Forms.Label();
        	this.ls_btnAdd = new System.Windows.Forms.Button();
        	this.ls_btnRemove = new System.Windows.Forms.Button();
        	this.ls_lstNotUsed = new System.Windows.Forms.ListBox();
        	this.ls_lstUsed = new System.Windows.Forms.ListBox();
        	this.tabZS = new System.Windows.Forms.TabPage();
        	this.zs_separator = new System.Windows.Forms.Panel();
        	this.zs_grpInvZombie = new System.Windows.Forms.GroupBox();
        	this.zs_numInvZombieSecs = new Supernova.Gui.TimespanUpDown();
        	this.zs_numInvZombieMax = new System.Windows.Forms.NumericUpDown();
        	this.zs_lblInvZombieDur = new System.Windows.Forms.Label();
        	this.zs_lblInvZombieMax = new System.Windows.Forms.Label();
        	this.zs_grpZombie = new System.Windows.Forms.GroupBox();
        	this.zs_txtModel = new System.Windows.Forms.TextBox();
        	this.zs_txtName = new System.Windows.Forms.TextBox();
        	this.zs_lblModel = new System.Windows.Forms.Label();
        	this.zs_lblName = new System.Windows.Forms.Label();
        	this.zs_grpRevive = new System.Windows.Forms.GroupBox();
        	this.zs_numReviveLimit = new Supernova.Gui.TimespanUpDown();
        	this.zs_lblSuccess = new System.Windows.Forms.Label();
        	this.zs_numSuccess = new System.Windows.Forms.NumericUpDown();
        	this.zs_lblReviveRound = new System.Windows.Forms.Label();
        	this.zs_lblReviveLimitFtr = new System.Windows.Forms.Label();
        	this.zs_lblReviveLimitHdr = new System.Windows.Forms.Label();
        	this.zs_numReviveMax = new System.Windows.Forms.NumericUpDown();
        	this.zs_lblReviveMax = new System.Windows.Forms.Label();
        	this.zs_grpInvHuman = new System.Windows.Forms.GroupBox();
        	this.zs_numInvHumanSecs = new Supernova.Gui.TimespanUpDown();
        	this.zs_numInvHumanMax = new System.Windows.Forms.NumericUpDown();
        	this.zs_lblInvHumanDur = new System.Windows.Forms.Label();
        	this.zs_lblInvHumanMax = new System.Windows.Forms.Label();
        	this.zs_grpControls = new System.Windows.Forms.GroupBox();
        	this.zs_btnEnd = new System.Windows.Forms.Button();
        	this.zs_btnStop = new System.Windows.Forms.Button();
        	this.zs_btnStart = new System.Windows.Forms.Button();
        	this.zs_grpMap = new System.Windows.Forms.GroupBox();
        	this.zs_grpTime = new System.Windows.Forms.GroupBox();
        	this.zs_numFloodTime = new Supernova.Gui.TimespanUpDown();
        	this.zs_numLayerTime = new Supernova.Gui.TimespanUpDown();
        	this.zs_numRoundTime = new Supernova.Gui.TimespanUpDown();
        	this.zs_lblLayerTime = new System.Windows.Forms.Label();
        	this.zs_lblFloodTime = new System.Windows.Forms.Label();
        	this.zs_lblRoundTime = new System.Windows.Forms.Label();
        	this.zs_grpSettings = new System.Windows.Forms.GroupBox();
        	this.zs_cbMain = new System.Windows.Forms.CheckBox();
        	this.zs_cbMap = new System.Windows.Forms.CheckBox();
        	this.zs_cbStart = new System.Windows.Forms.CheckBox();
        	this.zs_grpMaps = new System.Windows.Forms.GroupBox();
        	this.zs_lblNotUsed = new System.Windows.Forms.Label();
        	this.zs_lblUsed = new System.Windows.Forms.Label();
        	this.zs_btnAdd = new System.Windows.Forms.Button();
        	this.zs_btnRemove = new System.Windows.Forms.Button();
        	this.zs_lstNotUsed = new System.Windows.Forms.ListBox();
        	this.zs_lstUsed = new System.Windows.Forms.ListBox();
        	this.tabCTF = new System.Windows.Forms.TabPage();
        	this.ctf_grpControls = new System.Windows.Forms.GroupBox();
        	this.ctf_btnEnd = new System.Windows.Forms.Button();
        	this.ctf_btnStop = new System.Windows.Forms.Button();
        	this.ctf_btnStart = new System.Windows.Forms.Button();
        	this.ctf_grpSettings = new System.Windows.Forms.GroupBox();
        	this.ctf_cbMain = new System.Windows.Forms.CheckBox();
        	this.ctf_cbMap = new System.Windows.Forms.CheckBox();
        	this.ctf_cbStart = new System.Windows.Forms.CheckBox();
        	this.ctf_grpMaps = new System.Windows.Forms.GroupBox();
        	this.ctf_lblNotUsed = new System.Windows.Forms.Label();
        	this.ctf_lblUsed = new System.Windows.Forms.Label();
        	this.ctf_btnAdd = new System.Windows.Forms.Button();
        	this.ctf_btnRemove = new System.Windows.Forms.Button();
        	this.ctf_lstNotUsed = new System.Windows.Forms.ListBox();
        	this.ctf_lstUsed = new System.Windows.Forms.ListBox();
        	this.tabTW = new System.Windows.Forms.TabPage();
        	this.tw_grpControls = new System.Windows.Forms.GroupBox();
        	this.tw_btnEnd = new System.Windows.Forms.Button();
        	this.tw_btnStop = new System.Windows.Forms.Button();
        	this.tw_btnStart = new System.Windows.Forms.Button();
        	this.tw_grpMapSettings = new System.Windows.Forms.GroupBox();
        	this.tw_grpTeams = new System.Windows.Forms.GroupBox();
        	this.tw_cbKills = new System.Windows.Forms.CheckBox();
        	this.tw_cbBalance = new System.Windows.Forms.CheckBox();
        	this.tw_grpGrace = new System.Windows.Forms.GroupBox();
        	this.tw_numGrace = new Supernova.Gui.TimespanUpDown();
        	this.tw_lblGrace = new System.Windows.Forms.Label();
        	this.tw_cbGrace = new System.Windows.Forms.CheckBox();
        	this.tw_grpScores = new System.Windows.Forms.GroupBox();
        	this.tw_lblMulti = new System.Windows.Forms.Label();
        	this.tw_lblAssist = new System.Windows.Forms.Label();
        	this.tw_cbStreaks = new System.Windows.Forms.CheckBox();
        	this.tw_numMultiKills = new System.Windows.Forms.NumericUpDown();
        	this.tw_numScoreAssists = new System.Windows.Forms.NumericUpDown();
        	this.tw_lblScorePerKill = new System.Windows.Forms.Label();
        	this.tw_numScorePerKill = new System.Windows.Forms.NumericUpDown();
        	this.tw_lblScoreLimit = new System.Windows.Forms.Label();
        	this.tw_numScoreLimit = new System.Windows.Forms.NumericUpDown();
        	this.tw_grpSettings = new System.Windows.Forms.GroupBox();
        	this.tw_cmbMode = new System.Windows.Forms.ComboBox();
        	this.tw_cmbDiff = new System.Windows.Forms.ComboBox();
        	this.tw_lblMode = new System.Windows.Forms.Label();
        	this.tw_lblDiff = new System.Windows.Forms.Label();
        	this.tw_cbMain = new System.Windows.Forms.CheckBox();
        	this.tw_cbMap = new System.Windows.Forms.CheckBox();
        	this.tw_cbStart = new System.Windows.Forms.CheckBox();
        	this.tw_gbMaps = new System.Windows.Forms.GroupBox();
        	this.tw_lblInUse = new System.Windows.Forms.Label();
        	this.tw_btnAdd = new System.Windows.Forms.Button();
        	this.tw_btnRemove = new System.Windows.Forms.Button();
        	this.tw_lstNotUsed = new System.Windows.Forms.ListBox();
        	this.tw_lstUsed = new System.Windows.Forms.ListBox();
        	this.tabSPL = new System.Windows.Forms.TabPage();
        	this.spl_grpControls = new System.Windows.Forms.GroupBox();
        	this.spl_btnEnd = new System.Windows.Forms.Button();
        	this.spl_btnStop = new System.Windows.Forms.Button();
        	this.spl_btnStart = new System.Windows.Forms.Button();
        	this.spl_grpSettings = new System.Windows.Forms.GroupBox();
        	this.spl_cbMain = new System.Windows.Forms.CheckBox();
        	this.spl_cbStart = new System.Windows.Forms.CheckBox();
        	this.tabCD = new System.Windows.Forms.TabPage();
        	this.cd_grpControls = new System.Windows.Forms.GroupBox();
        	this.cd_btnEnd = new System.Windows.Forms.Button();
        	this.cd_btnStop = new System.Windows.Forms.Button();
        	this.cd_btnStart = new System.Windows.Forms.Button();
        	this.cd_grpSettings = new System.Windows.Forms.GroupBox();
        	this.cd_cbMain = new System.Windows.Forms.CheckBox();
        	this.cd_cbStart = new System.Windows.Forms.CheckBox();
        	this.toolTip = new System.Windows.Forms.ToolTip(this.components);
        	this.tsMap.SuspendLayout();
        	this.tsPlayer.SuspendLayout();
        	this.icon_context.SuspendLayout();
        	this.logs_tp.SuspendLayout();
        	this.logs_tab.SuspendLayout();
        	this.logs_tabErr.SuspendLayout();
        	this.logs_tabGen.SuspendLayout();
        	this.tabLog_Sys.SuspendLayout();
        	this.tp_Main.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.main_Maps)).BeginInit();
        	this.tsLog_Menu.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.main_Players)).BeginInit();
        	this.tabs.SuspendLayout();
        	this.tp_Maps.SuspendLayout();
        	this.map_gbProps.SuspendLayout();
        	this.map_gbLoaded.SuspendLayout();
        	this.map_gbUnloaded.SuspendLayout();
        	this.map_gbNew.SuspendLayout();
        	this.tp_Players.SuspendLayout();
        	this.pl_gbProps.SuspendLayout();
        	this.pl_gbOther.SuspendLayout();
        	this.pl_gbActions.SuspendLayout();
        	this.tb_games.SuspendLayout();
        	this.tabGames.SuspendLayout();
        	this.tabLS.SuspendLayout();
        	this.ls_grpControls.SuspendLayout();
        	this.ls_grpMapSettings.SuspendLayout();
        	this.ls_grpTime.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.ls_numFlood)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.ls_numLayerTime)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.ls_numRound)).BeginInit();
        	this.ls_grpLayer.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.ls_numHeight)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.ls_numCount)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.ls_numLayer)).BeginInit();
        	this.ls_grpBlock.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.ls_numDestroy)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.ls_numWater)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.ls_numFast)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.ls_numKiller)).BeginInit();
        	this.ls_grpSettings.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.ls_numMax)).BeginInit();
        	this.ls_grpMaps.SuspendLayout();
        	this.tabZS.SuspendLayout();
        	this.zs_grpInvZombie.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.zs_numInvZombieSecs)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.zs_numInvZombieMax)).BeginInit();
        	this.zs_grpZombie.SuspendLayout();
        	this.zs_grpRevive.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.zs_numReviveLimit)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.zs_numSuccess)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.zs_numReviveMax)).BeginInit();
        	this.zs_grpInvHuman.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.zs_numInvHumanSecs)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.zs_numInvHumanMax)).BeginInit();
        	this.zs_grpControls.SuspendLayout();
        	this.zs_grpMap.SuspendLayout();
        	this.zs_grpTime.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.zs_numFloodTime)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.zs_numLayerTime)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.zs_numRoundTime)).BeginInit();
        	this.zs_grpSettings.SuspendLayout();
        	this.zs_grpMaps.SuspendLayout();
        	this.tabCTF.SuspendLayout();
        	this.ctf_grpControls.SuspendLayout();
        	this.ctf_grpSettings.SuspendLayout();
        	this.ctf_grpMaps.SuspendLayout();
        	this.tabTW.SuspendLayout();
        	this.tw_grpControls.SuspendLayout();
        	this.tw_grpMapSettings.SuspendLayout();
        	this.tw_grpTeams.SuspendLayout();
        	this.tw_grpGrace.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.tw_numGrace)).BeginInit();
        	this.tw_grpScores.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.tw_numMultiKills)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.tw_numScoreAssists)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.tw_numScorePerKill)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.tw_numScoreLimit)).BeginInit();
        	this.tw_grpSettings.SuspendLayout();
        	this.tw_gbMaps.SuspendLayout();
        	this.tabSPL.SuspendLayout();
        	this.spl_grpControls.SuspendLayout();
        	this.spl_grpSettings.SuspendLayout();
        	this.tabCD.SuspendLayout();
        	this.cd_grpControls.SuspendLayout();
        	this.cd_grpSettings.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// tsMap
        	// 
        	this.tsMap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tsMap_physicsMenu,
			this.tsMap_actionsMenu,
			this.tsMap_separator,
			this.tsMap_info});
        	this.tsMap.Name = "mapsStrip";
        	this.tsMap.Size = new System.Drawing.Size(144, 76);
        	// 
        	// tsMap_physicsMenu
        	// 
        	this.tsMap_physicsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tsMap_physics0,
			this.tsMap_physics1,
			this.tsMap_physics2,
			this.tsMap_physics3,
			this.tsMap_physics4,
			this.tsMap_physics5});
        	this.tsMap_physicsMenu.Name = "tsMap_physicsMenu";
        	this.tsMap_physicsMenu.Size = new System.Drawing.Size(143, 22);
        	this.tsMap_physicsMenu.Text = "Physics Level";
        	// 
        	// tsMap_physics0
        	// 
        	this.tsMap_physics0.Name = "tsMap_physics0";
        	this.tsMap_physics0.Size = new System.Drawing.Size(135, 22);
        	this.tsMap_physics0.Text = "Off";
        	this.tsMap_physics0.Click += new System.EventHandler(this.tsMap_Physics0_Click);
        	// 
        	// tsMap_physics1
        	// 
        	this.tsMap_physics1.Name = "tsMap_physics1";
        	this.tsMap_physics1.Size = new System.Drawing.Size(135, 22);
        	this.tsMap_physics1.Text = "Normal";
        	this.tsMap_physics1.Click += new System.EventHandler(this.tsMap_Physics1_Click);
        	// 
        	// tsMap_physics2
        	// 
        	this.tsMap_physics2.Name = "tsMap_physics2";
        	this.tsMap_physics2.Size = new System.Drawing.Size(135, 22);
        	this.tsMap_physics2.Text = "Advanced";
        	this.tsMap_physics2.Click += new System.EventHandler(this.tsMap_Physics2_Click);
        	// 
        	// tsMap_physics3
        	// 
        	this.tsMap_physics3.Name = "tsMap_physics3";
        	this.tsMap_physics3.Size = new System.Drawing.Size(135, 22);
        	this.tsMap_physics3.Text = "Hardcore";
        	this.tsMap_physics3.Click += new System.EventHandler(this.tsMap_Physics3_Click);
        	// 
        	// tsMap_physics4
        	// 
        	this.tsMap_physics4.Name = "tsMap_physics4";
        	this.tsMap_physics4.Size = new System.Drawing.Size(135, 22);
        	this.tsMap_physics4.Text = "Instant";
        	this.tsMap_physics4.Click += new System.EventHandler(this.tsMap_Physics4_Click);
        	// 
        	// tsMap_physics5
        	// 
        	this.tsMap_physics5.Name = "tsMap_physics5";
        	this.tsMap_physics5.Size = new System.Drawing.Size(135, 22);
        	this.tsMap_physics5.Text = "Doors-Only";
        	this.tsMap_physics5.Click += new System.EventHandler(this.tsMap_Physics5_Click);
        	// 
        	// tsMap_actionsMenu
        	// 
        	this.tsMap_actionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tsMap_Save,
			this.tsMap_Reload,
			this.tsMap_Unload,
			this.tsMap_moveAll});
        	this.tsMap_actionsMenu.Name = "tsMap_actionsMenu";
        	this.tsMap_actionsMenu.Size = new System.Drawing.Size(143, 22);
        	this.tsMap_actionsMenu.Text = "Actions";
        	// 
        	// tsMap_Save
        	// 
        	this.tsMap_Save.Name = "tsMap_Save";
        	this.tsMap_Save.Size = new System.Drawing.Size(121, 22);
        	this.tsMap_Save.Text = "Save";
        	this.tsMap_Save.Click += new System.EventHandler(this.tsMap_Save_Click);
        	// 
        	// tsMap_Reload
        	// 
        	this.tsMap_Reload.Name = "tsMap_Reload";
        	this.tsMap_Reload.Size = new System.Drawing.Size(121, 22);
        	this.tsMap_Reload.Text = "Reload";
        	this.tsMap_Reload.Click += new System.EventHandler(this.tsMap_Reload_Click);
        	// 
        	// tsMap_Unload
        	// 
        	this.tsMap_Unload.Name = "tsMap_Unload";
        	this.tsMap_Unload.Size = new System.Drawing.Size(121, 22);
        	this.tsMap_Unload.Text = "Unload";
        	this.tsMap_Unload.Click += new System.EventHandler(this.tsMap_Unload_Click);
        	// 
        	// tsMap_moveAll
        	// 
        	this.tsMap_moveAll.Name = "tsMap_moveAll";
        	this.tsMap_moveAll.Size = new System.Drawing.Size(121, 22);
        	this.tsMap_moveAll.Text = "Move All";
        	this.tsMap_moveAll.Click += new System.EventHandler(this.tsMap_MoveAll_Click);
        	// 
        	// tsMap_separator
        	// 
        	this.tsMap_separator.Name = "tsMap_separator";
        	this.tsMap_separator.Size = new System.Drawing.Size(140, 6);
        	// 
        	// tsMap_info
        	// 
        	this.tsMap_info.Name = "tsMap_info";
        	this.tsMap_info.Size = new System.Drawing.Size(143, 22);
        	this.tsMap_info.Text = "Info";
        	this.tsMap_info.Click += new System.EventHandler(this.tsMap_Info_Click);
        	// 
        	// tsPlayer
        	// 
        	this.tsPlayer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tsPlayer_whois,
			this.tsPlayer_kick,
			this.tsPlayer_ban,
			this.tsPlayer_voice,
			this.tsPlayer_clones,
			this.tsPlayer_promote,
			this.tsPlayer_demote});
        	this.tsPlayer.Name = "playerStrip";
        	this.tsPlayer.Size = new System.Drawing.Size(121, 158);
        	// 
        	// tsPlayer_whois
        	// 
        	this.tsPlayer_whois.Name = "tsPlayer_whois";
        	this.tsPlayer_whois.Size = new System.Drawing.Size(120, 22);
        	this.tsPlayer_whois.Text = "Whois";
        	this.tsPlayer_whois.Click += new System.EventHandler(this.tsPlayer_Whois_Click);
        	// 
        	// tsPlayer_kick
        	// 
        	this.tsPlayer_kick.Name = "tsPlayer_kick";
        	this.tsPlayer_kick.Size = new System.Drawing.Size(120, 22);
        	this.tsPlayer_kick.Text = "Kick";
        	this.tsPlayer_kick.Click += new System.EventHandler(this.tsPlayer_Kick_Click);
        	// 
        	// tsPlayer_ban
        	// 
        	this.tsPlayer_ban.Name = "tsPlayer_ban";
        	this.tsPlayer_ban.Size = new System.Drawing.Size(120, 22);
        	this.tsPlayer_ban.Text = "Ban";
        	this.tsPlayer_ban.Click += new System.EventHandler(this.tsPlayer_Ban_Click);
        	// 
        	// tsPlayer_voice
        	// 
        	this.tsPlayer_voice.Name = "tsPlayer_voice";
        	this.tsPlayer_voice.Size = new System.Drawing.Size(120, 22);
        	this.tsPlayer_voice.Text = "Voice";
        	this.tsPlayer_voice.Click += new System.EventHandler(this.tsPlayer_Voice_Click);
        	// 
        	// tsPlayer_clones
        	// 
        	this.tsPlayer_clones.Name = "tsPlayer_clones";
        	this.tsPlayer_clones.Size = new System.Drawing.Size(120, 22);
        	this.tsPlayer_clones.Text = "Clones";
        	this.tsPlayer_clones.Click += new System.EventHandler(this.tsPlayer_Clones_Click);
        	// 
        	// tsPlayer_promote
        	// 
        	this.tsPlayer_promote.Name = "tsPlayer_promote";
        	this.tsPlayer_promote.Size = new System.Drawing.Size(120, 22);
        	this.tsPlayer_promote.Text = "Promote";
        	this.tsPlayer_promote.Click += new System.EventHandler(this.tsPlayer_Promote_Click);
        	// 
        	// tsPlayer_demote
        	// 
        	this.tsPlayer_demote.Name = "tsPlayer_demote";
        	this.tsPlayer_demote.Size = new System.Drawing.Size(120, 22);
        	this.tsPlayer_demote.Text = "Demote";
        	this.tsPlayer_demote.Click += new System.EventHandler(this.tsPlayer_Demote_Click);
        	// 
        	// icon_context
        	// 
        	this.icon_context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.icon_openConsole,
			this.icon_shutdown,
			this.icon_restart});
        	this.icon_context.Name = "iconContext";
        	this.icon_context.Size = new System.Drawing.Size(163, 70);
        	// 
        	// icon_openConsole
        	// 
        	this.icon_openConsole.Name = "icon_openConsole";
        	this.icon_openConsole.Size = new System.Drawing.Size(162, 22);
        	this.icon_openConsole.Text = "Open console";
        	this.icon_openConsole.Click += new System.EventHandler(this.openConsole_Click);
        	// 
        	// icon_shutdown
        	// 
        	this.icon_shutdown.Name = "icon_shutdown";
        	this.icon_shutdown.Size = new System.Drawing.Size(162, 22);
        	this.icon_shutdown.Text = "Shutdown server";
        	this.icon_shutdown.Click += new System.EventHandler(this.shutdownServer_Click);
        	// 
        	// icon_restart
        	// 
        	this.icon_restart.Name = "icon_restart";
        	this.icon_restart.Size = new System.Drawing.Size(162, 22);
        	this.icon_restart.Text = "Restart server";
        	this.icon_restart.Click += new System.EventHandler(this.icon_restart_Click);
        	// 
        	// main_btnProps
        	// 
        	this.main_btnProps.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.main_btnProps.Enabled = false;
        	this.main_btnProps.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.main_btnProps.Location = new System.Drawing.Point(501, 5);
        	this.main_btnProps.Name = "main_btnProps";
        	this.main_btnProps.Size = new System.Drawing.Size(80, 23);
        	this.main_btnProps.TabIndex = 34;
        	this.main_btnProps.Text = "Settings";
        	this.main_btnProps.UseVisualStyleBackColor = true;
        	this.main_btnProps.Click += new System.EventHandler(this.btnProperties_Click);
        	// 
        	// main_btnClose
        	// 
        	this.main_btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.main_btnClose.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.main_btnClose.Location = new System.Drawing.Point(675, 5);
        	this.main_btnClose.Name = "main_btnClose";
        	this.main_btnClose.Size = new System.Drawing.Size(88, 23);
        	this.main_btnClose.TabIndex = 35;
        	this.main_btnClose.Text = "Close";
        	this.main_btnClose.UseVisualStyleBackColor = true;
        	this.main_btnClose.Click += new System.EventHandler(this.btnClose_Click);
        	// 
        	// main_btnRestart
        	// 
        	this.main_btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.main_btnRestart.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.main_btnRestart.Location = new System.Drawing.Point(584, 5);
        	this.main_btnRestart.Name = "main_btnRestart";
        	this.main_btnRestart.Size = new System.Drawing.Size(88, 23);
        	this.main_btnRestart.TabIndex = 36;
        	this.main_btnRestart.Text = "Restart";
        	this.main_btnRestart.UseVisualStyleBackColor = true;
        	this.main_btnRestart.Click += new System.EventHandler(this.main_BtnRestart_Click);
        	// 
        	// logs_tp
        	// 
        	this.logs_tp.BackColor = System.Drawing.SystemColors.Control;
        	this.logs_tp.Controls.Add(this.logs_tab);
        	this.logs_tp.Location = new System.Drawing.Point(4, 22);
        	this.logs_tp.Name = "logs_tp";
        	this.logs_tp.Padding = new System.Windows.Forms.Padding(3);
        	this.logs_tp.Size = new System.Drawing.Size(767, 488);
        	this.logs_tp.TabIndex = 4;
        	this.logs_tp.Text = "Logs";
        	// 
        	// logs_tab
        	// 
        	this.logs_tab.Controls.Add(this.logs_tabErr);
        	this.logs_tab.Controls.Add(this.logs_tabGen);
        	this.logs_tab.Controls.Add(this.tabLog_Sys);
        	this.logs_tab.Location = new System.Drawing.Point(0, 1);
        	this.logs_tab.Name = "logs_tab";
        	this.logs_tab.SelectedIndex = 0;
        	this.logs_tab.Size = new System.Drawing.Size(775, 491);
        	this.logs_tab.TabIndex = 0;
        	// 
        	// logs_tabErr
        	// 
        	this.logs_tabErr.Controls.Add(this.logs_txtError);
        	this.logs_tabErr.Location = new System.Drawing.Point(4, 22);
        	this.logs_tabErr.Name = "logs_tabErr";
        	this.logs_tabErr.Size = new System.Drawing.Size(767, 465);
        	this.logs_tabErr.TabIndex = 2;
        	this.logs_tabErr.Text = "Errors";
        	this.logs_tabErr.UseVisualStyleBackColor = true;
        	// 
        	// logs_txtError
        	// 
        	this.logs_txtError.BackColor = System.Drawing.SystemColors.Window;
        	this.logs_txtError.Cursor = System.Windows.Forms.Cursors.Arrow;
        	this.logs_txtError.Location = new System.Drawing.Point(0, 0);
        	this.logs_txtError.Multiline = true;
        	this.logs_txtError.Name = "logs_txtError";
        	this.logs_txtError.ReadOnly = true;
        	this.logs_txtError.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        	this.logs_txtError.Size = new System.Drawing.Size(765, 465);
        	this.logs_txtError.TabIndex = 2;
        	// 
        	// logs_tabGen
        	// 
        	this.logs_tabGen.Controls.Add(this.logs_lblGeneral);
        	this.logs_tabGen.Controls.Add(this.logs_dateGeneral);
        	this.logs_tabGen.Controls.Add(this.logs_txtGeneral);
        	this.logs_tabGen.Location = new System.Drawing.Point(4, 22);
        	this.logs_tabGen.Name = "logs_tabGen";
        	this.logs_tabGen.Padding = new System.Windows.Forms.Padding(3);
        	this.logs_tabGen.Size = new System.Drawing.Size(767, 465);
        	this.logs_tabGen.TabIndex = 0;
        	this.logs_tabGen.Text = "General";
        	this.logs_tabGen.UseVisualStyleBackColor = true;
        	// 
        	// logs_lblGeneral
        	// 
        	this.logs_lblGeneral.AutoSize = true;
        	this.logs_lblGeneral.Location = new System.Drawing.Point(3, 9);
        	this.logs_lblGeneral.Name = "logs_lblGeneral";
        	this.logs_lblGeneral.Size = new System.Drawing.Size(78, 13);
        	this.logs_lblGeneral.TabIndex = 6;
        	this.logs_lblGeneral.Text = "View logs from:";
        	// 
        	// logs_dateGeneral
        	// 
        	this.logs_dateGeneral.Location = new System.Drawing.Point(87, 4);
        	this.logs_dateGeneral.Name = "logs_dateGeneral";
        	this.logs_dateGeneral.Size = new System.Drawing.Size(200, 21);
        	this.logs_dateGeneral.TabIndex = 5;
        	this.logs_dateGeneral.Value = new System.DateTime(2011, 7, 20, 18, 31, 50, 0);
        	this.logs_dateGeneral.ValueChanged += new System.EventHandler(this.logs_dateGeneral_Changed);
        	// 
        	// logs_txtGeneral
        	// 
        	this.logs_txtGeneral.BackColor = System.Drawing.SystemColors.Window;
        	this.logs_txtGeneral.Location = new System.Drawing.Point(0, 30);
        	this.logs_txtGeneral.Name = "logs_txtGeneral";
        	this.logs_txtGeneral.ReadOnly = true;
        	this.logs_txtGeneral.Size = new System.Drawing.Size(765, 436);
        	this.logs_txtGeneral.TabIndex = 4;
        	this.logs_txtGeneral.Text = "";
        	// 
        	// tabLog_Sys
        	// 
        	this.tabLog_Sys.Controls.Add(this.logs_txtSystem);
        	this.tabLog_Sys.Location = new System.Drawing.Point(4, 22);
        	this.tabLog_Sys.Name = "tabLog_Sys";
        	this.tabLog_Sys.Padding = new System.Windows.Forms.Padding(3);
        	this.tabLog_Sys.Size = new System.Drawing.Size(767, 465);
        	this.tabLog_Sys.TabIndex = 1;
        	this.tabLog_Sys.Text = "System";
        	this.tabLog_Sys.UseVisualStyleBackColor = true;
        	// 
        	// logs_txtSystem
        	// 
        	this.logs_txtSystem.BackColor = System.Drawing.SystemColors.Window;
        	this.logs_txtSystem.Cursor = System.Windows.Forms.Cursors.Arrow;
        	this.logs_txtSystem.Location = new System.Drawing.Point(0, 0);
        	this.logs_txtSystem.Multiline = true;
        	this.logs_txtSystem.Name = "logs_txtSystem";
        	this.logs_txtSystem.ReadOnly = true;
        	this.logs_txtSystem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        	this.logs_txtSystem.Size = new System.Drawing.Size(765, 465);
        	this.logs_txtSystem.TabIndex = 2;
        	// 
        	// tp_Main
        	// 
        	this.tp_Main.BackColor = System.Drawing.SystemColors.Control;
        	this.tp_Main.Controls.Add(this.main_btnUnloadEmpty);
        	this.tp_Main.Controls.Add(this.main_btnKillPhysics);
        	this.tp_Main.Controls.Add(this.main_btnSaveAll);
        	this.tp_Main.Controls.Add(this.main_Maps);
        	this.tp_Main.Controls.Add(this.main_txtLog);
        	this.tp_Main.Controls.Add(this.main_txtInput);
        	this.tp_Main.Controls.Add(this.main_txtUrl);
        	this.tp_Main.Controls.Add(this.main_Players);
        	this.tp_Main.Location = new System.Drawing.Point(4, 22);
        	this.tp_Main.Name = "tp_Main";
        	this.tp_Main.Padding = new System.Windows.Forms.Padding(3);
        	this.tp_Main.Size = new System.Drawing.Size(767, 488);
        	this.tp_Main.TabIndex = 0;
        	this.tp_Main.Text = "Main";
        	// 
        	// main_btnUnloadEmpty
        	// 
        	this.main_btnUnloadEmpty.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.main_btnUnloadEmpty.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.main_btnUnloadEmpty.Location = new System.Drawing.Point(676, 263);
        	this.main_btnUnloadEmpty.Name = "main_btnUnloadEmpty";
        	this.main_btnUnloadEmpty.Size = new System.Drawing.Size(81, 23);
        	this.main_btnUnloadEmpty.TabIndex = 41;
        	this.main_btnUnloadEmpty.Text = "Unload Empty";
        	this.main_btnUnloadEmpty.UseVisualStyleBackColor = true;
        	this.main_btnUnloadEmpty.Click += new System.EventHandler(this.main_BtnUnloadEmpty_Click);
        	// 
        	// main_btnKillPhysics
        	// 
        	this.main_btnKillPhysics.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.main_btnKillPhysics.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.main_btnKillPhysics.Location = new System.Drawing.Point(582, 263);
        	this.main_btnKillPhysics.Name = "main_btnKillPhysics";
        	this.main_btnKillPhysics.Size = new System.Drawing.Size(88, 23);
        	this.main_btnKillPhysics.TabIndex = 40;
        	this.main_btnKillPhysics.Text = "Kill All Physics";
        	this.main_btnKillPhysics.UseVisualStyleBackColor = true;
        	this.main_btnKillPhysics.Click += new System.EventHandler(this.main_BtnKillPhysics_Click);
        	// 
        	// main_btnSaveAll
        	// 
        	this.main_btnSaveAll.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.main_btnSaveAll.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.main_btnSaveAll.Location = new System.Drawing.Point(513, 263);
        	this.main_btnSaveAll.Name = "main_btnSaveAll";
        	this.main_btnSaveAll.Size = new System.Drawing.Size(63, 23);
        	this.main_btnSaveAll.TabIndex = 39;
        	this.main_btnSaveAll.Text = "Save All";
        	this.main_btnSaveAll.UseVisualStyleBackColor = true;
        	this.main_btnSaveAll.Click += new System.EventHandler(this.main_BtnSaveAll_Click);
        	// 
        	// main_Maps
        	// 
        	this.main_Maps.AllowUserToAddRows = false;
        	this.main_Maps.AllowUserToDeleteRows = false;
        	this.main_Maps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        	this.main_Maps.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
        	this.main_Maps.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        	this.main_Maps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.main_Maps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.main_colLvlName,
			this.main_colLvlPlayers,
			this.main_colLvlPhysics});
        	this.main_Maps.ContextMenuStrip = this.tsMap;
        	this.main_Maps.Location = new System.Drawing.Point(512, 292);
        	this.main_Maps.MultiSelect = false;
        	this.main_Maps.Name = "main_Maps";
        	this.main_Maps.ReadOnly = true;
        	this.main_Maps.RowHeadersVisible = false;
        	this.main_Maps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.main_Maps.Size = new System.Drawing.Size(246, 150);
        	this.main_Maps.TabIndex = 38;
        	// 
        	// main_colLvlName
        	// 
        	this.main_colLvlName.HeaderText = "Name";
        	this.main_colLvlName.Name = "main_colLvlName";
        	this.main_colLvlName.ReadOnly = true;
        	// 
        	// main_colLvlPlayers
        	// 
        	this.main_colLvlPlayers.FillWeight = 70F;
        	this.main_colLvlPlayers.HeaderText = "Players";
        	this.main_colLvlPlayers.Name = "main_colLvlPlayers";
        	this.main_colLvlPlayers.ReadOnly = true;
        	// 
        	// main_colLvlPhysics
        	// 
        	this.main_colLvlPhysics.FillWeight = 70F;
        	this.main_colLvlPhysics.HeaderText = "Physics";
        	this.main_colLvlPhysics.Name = "main_colLvlPhysics";
        	this.main_colLvlPhysics.ReadOnly = true;
        	// 
        	// main_txtLog
        	// 
        	this.main_txtLog.BackColor = System.Drawing.SystemColors.Window;
        	this.main_txtLog.ContextMenuStrip = this.tsLog_Menu;
        	this.main_txtLog.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.main_txtLog.Location = new System.Drawing.Point(8, 38);
        	this.main_txtLog.Name = "main_txtLog";
        	this.main_txtLog.ReadOnly = true;
        	this.main_txtLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
        	this.main_txtLog.Size = new System.Drawing.Size(498, 404);
        	this.main_txtLog.TabIndex = 0;
        	this.main_txtLog.Text = "";
        	// 
        	// tsLog_Menu
        	// 
        	this.tsLog_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tsLog_night,
			this.tsLog_Colored,
			this.tsLog_dateStamp,
			this.tsLog_autoScroll,
			this.tsLog_separator1,
			this.tsLog_copySelected,
			this.tsLog_copyAll,
			this.tsLog_separator2,
			this.tsLog_clear});
        	this.tsLog_Menu.Name = "txtLogMenuStrip";
        	this.tsLog_Menu.Size = new System.Drawing.Size(150, 170);
        	// 
        	// tsLog_night
        	// 
        	this.tsLog_night.Name = "tsLog_night";
        	this.tsLog_night.Size = new System.Drawing.Size(149, 22);
        	this.tsLog_night.Text = "Night Theme";
        	this.tsLog_night.Click += new System.EventHandler(this.tsLog_Night_Click);
        	// 
        	// tsLog_Colored
        	// 
        	this.tsLog_Colored.Checked = true;
        	this.tsLog_Colored.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.tsLog_Colored.Name = "tsLog_Colored";
        	this.tsLog_Colored.Size = new System.Drawing.Size(149, 22);
        	this.tsLog_Colored.Text = "Colors";
        	this.tsLog_Colored.Click += new System.EventHandler(this.tsLog_Colored_Click);
        	// 
        	// tsLog_dateStamp
        	// 
        	this.tsLog_dateStamp.Checked = true;
        	this.tsLog_dateStamp.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.tsLog_dateStamp.Name = "tsLog_dateStamp";
        	this.tsLog_dateStamp.Size = new System.Drawing.Size(149, 22);
        	this.tsLog_dateStamp.Text = "Date Stamp";
        	this.tsLog_dateStamp.Click += new System.EventHandler(this.tsLog_DateStamp_Click);
        	// 
        	// tsLog_autoScroll
        	// 
        	this.tsLog_autoScroll.Checked = true;
        	this.tsLog_autoScroll.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.tsLog_autoScroll.Name = "tsLog_autoScroll";
        	this.tsLog_autoScroll.Size = new System.Drawing.Size(149, 22);
        	this.tsLog_autoScroll.Text = "Auto Scroll";
        	this.tsLog_autoScroll.Click += new System.EventHandler(this.tsLog_AutoScroll_Click);
        	// 
        	// tsLog_separator1
        	// 
        	this.tsLog_separator1.Name = "tsLog_separator1";
        	this.tsLog_separator1.Size = new System.Drawing.Size(146, 6);
        	// 
        	// tsLog_copySelected
        	// 
        	this.tsLog_copySelected.Name = "tsLog_copySelected";
        	this.tsLog_copySelected.Size = new System.Drawing.Size(149, 22);
        	this.tsLog_copySelected.Text = "Copy Selected";
        	this.tsLog_copySelected.Click += new System.EventHandler(this.tsLog_CopySelected_Click);
        	// 
        	// tsLog_copyAll
        	// 
        	this.tsLog_copyAll.Name = "tsLog_copyAll";
        	this.tsLog_copyAll.Size = new System.Drawing.Size(149, 22);
        	this.tsLog_copyAll.Text = "Copy All";
        	this.tsLog_copyAll.Click += new System.EventHandler(this.tsLog_CopyAll_Click);
        	// 
        	// tsLog_separator2
        	// 
        	this.tsLog_separator2.Name = "tsLog_separator2";
        	this.tsLog_separator2.Size = new System.Drawing.Size(146, 6);
        	// 
        	// tsLog_clear
        	// 
        	this.tsLog_clear.Name = "tsLog_clear";
        	this.tsLog_clear.Size = new System.Drawing.Size(149, 22);
        	this.tsLog_clear.Text = "Clear";
        	this.tsLog_clear.Click += new System.EventHandler(this.tsLog_Clear_Click);
        	// 
        	// main_txtInput
        	// 
        	this.main_txtInput.BackColor = System.Drawing.SystemColors.Window;
        	this.main_txtInput.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.main_txtInput.Location = new System.Drawing.Point(8, 454);
        	this.main_txtInput.Name = "main_txtInput";
        	this.main_txtInput.Size = new System.Drawing.Size(750, 21);
        	this.main_txtInput.TabIndex = 27;
        	this.toolTip.SetToolTip(this.main_txtInput, "To send chat to players, just type the message in.\nTo enter a command, put a / be" +
		"fore it. (e.g. /help commands)");
        	this.main_txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.main_TxtInput_KeyDown);
        	// 
        	// main_txtUrl
        	// 
        	this.main_txtUrl.Cursor = System.Windows.Forms.Cursors.Default;
        	this.main_txtUrl.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.main_txtUrl.Location = new System.Drawing.Point(8, 7);
        	this.main_txtUrl.Name = "main_txtUrl";
        	this.main_txtUrl.ReadOnly = true;
        	this.main_txtUrl.Size = new System.Drawing.Size(498, 21);
        	this.main_txtUrl.TabIndex = 25;
        	this.main_txtUrl.Text = "Finding classicube.net url..";
        	this.main_txtUrl.DoubleClick += new System.EventHandler(this.main_TxtUrl_DoubleClick);
        	// 
        	// main_Players
        	// 
        	this.main_Players.AllowUserToAddRows = false;
        	this.main_Players.AllowUserToDeleteRows = false;
        	this.main_Players.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
        	this.main_Players.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        	this.main_Players.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.main_Players.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.main_colPlName,
			this.main_colPlMap,
			this.main_colPlRank});
        	this.main_Players.ContextMenuStrip = this.tsPlayer;
        	this.main_Players.Location = new System.Drawing.Point(512, 7);
        	this.main_Players.MultiSelect = false;
        	this.main_Players.Name = "main_Players";
        	this.main_Players.ReadOnly = true;
        	this.main_Players.RowHeadersVisible = false;
        	this.main_Players.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.main_Players.Size = new System.Drawing.Size(246, 250);
        	this.main_Players.TabIndex = 37;
        	this.main_Players.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.main_players_RowPrePaint);
        	// 
        	// main_colPlName
        	// 
        	this.main_colPlName.HeaderText = "Name";
        	this.main_colPlName.Name = "main_colPlName";
        	this.main_colPlName.ReadOnly = true;
        	// 
        	// main_colPlMap
        	// 
        	this.main_colPlMap.HeaderText = "Map";
        	this.main_colPlMap.Name = "main_colPlMap";
        	this.main_colPlMap.ReadOnly = true;
        	// 
        	// main_colPlRank
        	// 
        	this.main_colPlRank.HeaderText = "Rank";
        	this.main_colPlRank.Name = "main_colPlRank";
        	this.main_colPlRank.ReadOnly = true;
        	// 
        	// tabs
        	// 
        	this.tabs.Controls.Add(this.tp_Main);
        	this.tabs.Controls.Add(this.logs_tp);
        	this.tabs.Controls.Add(this.tp_Maps);
        	this.tabs.Controls.Add(this.tp_Players);
        	this.tabs.Controls.Add(this.tb_games);
        	this.tabs.Cursor = System.Windows.Forms.Cursors.Default;
        	this.tabs.Font = new System.Drawing.Font("Calibri", 8.25F);
        	this.tabs.Location = new System.Drawing.Point(1, 11);
        	this.tabs.Name = "tabs";
        	this.tabs.SelectedIndex = 0;
        	this.tabs.Size = new System.Drawing.Size(775, 514);
        	this.tabs.TabIndex = 2;
        	this.tabs.Click += new System.EventHandler(this.tabs_Click);
        	// 
        	// tp_Maps
        	// 
        	this.tp_Maps.BackColor = System.Drawing.SystemColors.Control;
        	this.tp_Maps.Controls.Add(this.map_gbProps);
        	this.tp_Maps.Controls.Add(this.map_gbLoaded);
        	this.tp_Maps.Controls.Add(this.map_gbUnloaded);
        	this.tp_Maps.Controls.Add(this.map_gbNew);
        	this.tp_Maps.Location = new System.Drawing.Point(4, 22);
        	this.tp_Maps.Name = "tp_Maps";
        	this.tp_Maps.Size = new System.Drawing.Size(767, 488);
        	this.tp_Maps.TabIndex = 9;
        	this.tp_Maps.Text = "Maps";
        	// 
        	// map_gbProps
        	// 
        	this.map_gbProps.Controls.Add(this.map_pgProps);
        	this.map_gbProps.Location = new System.Drawing.Point(415, 3);
        	this.map_gbProps.Name = "map_gbProps";
        	this.map_gbProps.Size = new System.Drawing.Size(343, 349);
        	this.map_gbProps.TabIndex = 5;
        	this.map_gbProps.TabStop = false;
        	this.map_gbProps.Text = "Properties for (none selected)";
        	// 
        	// map_pgProps
        	// 
        	this.map_pgProps.Location = new System.Drawing.Point(7, 20);
        	this.map_pgProps.Name = "map_pgProps";
        	this.map_pgProps.Size = new System.Drawing.Size(330, 323);
        	this.map_pgProps.TabIndex = 0;
        	this.map_pgProps.ToolbarVisible = false;
        	// 
        	// map_gbLoaded
        	// 
        	this.map_gbLoaded.Controls.Add(this.map_lbLoaded);
        	this.map_gbLoaded.Location = new System.Drawing.Point(7, 3);
        	this.map_gbLoaded.Name = "map_gbLoaded";
        	this.map_gbLoaded.Size = new System.Drawing.Size(390, 221);
        	this.map_gbLoaded.TabIndex = 4;
        	this.map_gbLoaded.TabStop = false;
        	this.map_gbLoaded.Text = "Loaded levels";
        	// 
        	// map_lbLoaded
        	// 
        	this.map_lbLoaded.BackColor = System.Drawing.SystemColors.Window;
        	this.map_lbLoaded.FormattingEnabled = true;
        	this.map_lbLoaded.Location = new System.Drawing.Point(5, 15);
        	this.map_lbLoaded.MultiColumn = true;
        	this.map_lbLoaded.Name = "map_lbLoaded";
        	this.map_lbLoaded.Size = new System.Drawing.Size(379, 199);
        	this.map_lbLoaded.TabIndex = 0;
        	this.map_lbLoaded.SelectedIndexChanged += new System.EventHandler(this.Map_UpdateSelected);
        	// 
        	// map_gbUnloaded
        	// 
        	this.map_gbUnloaded.Controls.Add(this.map_btnLoad);
        	this.map_gbUnloaded.Controls.Add(this.map_lbUnloaded);
        	this.map_gbUnloaded.Location = new System.Drawing.Point(7, 227);
        	this.map_gbUnloaded.Name = "map_gbUnloaded";
        	this.map_gbUnloaded.Size = new System.Drawing.Size(390, 258);
        	this.map_gbUnloaded.TabIndex = 3;
        	this.map_gbUnloaded.TabStop = false;
        	this.map_gbUnloaded.Text = "Unloaded levels";
        	// 
        	// map_btnLoad
        	// 
        	this.map_btnLoad.Location = new System.Drawing.Point(150, 230);
        	this.map_btnLoad.Name = "map_btnLoad";
        	this.map_btnLoad.Size = new System.Drawing.Size(75, 23);
        	this.map_btnLoad.TabIndex = 1;
        	this.map_btnLoad.Text = "Load map";
        	this.map_btnLoad.UseVisualStyleBackColor = true;
        	this.map_btnLoad.Click += new System.EventHandler(this.map_BtnLoad_Click);
        	// 
        	// map_lbUnloaded
        	// 
        	this.map_lbUnloaded.BackColor = System.Drawing.SystemColors.Window;
        	this.map_lbUnloaded.FormattingEnabled = true;
        	this.map_lbUnloaded.Location = new System.Drawing.Point(5, 15);
        	this.map_lbUnloaded.MultiColumn = true;
        	this.map_lbUnloaded.Name = "map_lbUnloaded";
        	this.map_lbUnloaded.Size = new System.Drawing.Size(379, 212);
        	this.map_lbUnloaded.TabIndex = 0;
        	// 
        	// map_gbNew
        	// 
        	this.map_gbNew.Controls.Add(this.map_btnGen);
        	this.map_gbNew.Controls.Add(this.map_lblType);
        	this.map_gbNew.Controls.Add(this.map_lblSeed);
        	this.map_gbNew.Controls.Add(this.map_lblZ);
        	this.map_gbNew.Controls.Add(this.map_lblX);
        	this.map_gbNew.Controls.Add(this.map_lblY);
        	this.map_gbNew.Controls.Add(this.map_txtSeed);
        	this.map_gbNew.Controls.Add(this.map_cmbType);
        	this.map_gbNew.Controls.Add(this.map_cmbZ);
        	this.map_gbNew.Controls.Add(this.map_cmbY);
        	this.map_gbNew.Controls.Add(this.map_cmbX);
        	this.map_gbNew.Controls.Add(this.map_lblName);
        	this.map_gbNew.Controls.Add(this.map_txtName);
        	this.map_gbNew.Location = new System.Drawing.Point(415, 358);
        	this.map_gbNew.Name = "map_gbNew";
        	this.map_gbNew.Size = new System.Drawing.Size(343, 127);
        	this.map_gbNew.TabIndex = 0;
        	this.map_gbNew.TabStop = false;
        	this.map_gbNew.Text = "Create new map";
        	// 
        	// map_btnGen
        	// 
        	this.map_btnGen.Location = new System.Drawing.Point(150, 99);
        	this.map_btnGen.Name = "map_btnGen";
        	this.map_btnGen.Size = new System.Drawing.Size(75, 23);
        	this.map_btnGen.TabIndex = 17;
        	this.map_btnGen.Text = "Generate";
        	this.map_btnGen.UseVisualStyleBackColor = true;
        	this.map_btnGen.Click += new System.EventHandler(this.map_BtnGen_Click);
        	// 
        	// map_lblType
        	// 
        	this.map_lblType.AutoSize = true;
        	this.map_lblType.Location = new System.Drawing.Point(13, 78);
        	this.map_lblType.Name = "map_lblType";
        	this.map_lblType.Size = new System.Drawing.Size(32, 13);
        	this.map_lblType.TabIndex = 16;
        	this.map_lblType.Text = "Type:";
        	// 
        	// map_lblSeed
        	// 
        	this.map_lblSeed.AutoSize = true;
        	this.map_lblSeed.Location = new System.Drawing.Point(192, 78);
        	this.map_lblSeed.Name = "map_lblSeed";
        	this.map_lblSeed.Size = new System.Drawing.Size(33, 13);
        	this.map_lblSeed.TabIndex = 15;
        	this.map_lblSeed.Text = "Seed:";
        	// 
        	// map_lblZ
        	// 
        	this.map_lblZ.AutoSize = true;
        	this.map_lblZ.Location = new System.Drawing.Point(231, 51);
        	this.map_lblZ.Name = "map_lblZ";
        	this.map_lblZ.Size = new System.Drawing.Size(42, 13);
        	this.map_lblZ.TabIndex = 14;
        	this.map_lblZ.Text = "Length:";
        	// 
        	// map_lblX
        	// 
        	this.map_lblX.AutoSize = true;
        	this.map_lblX.Location = new System.Drawing.Point(7, 51);
        	this.map_lblX.Name = "map_lblX";
        	this.map_lblX.Size = new System.Drawing.Size(39, 13);
        	this.map_lblX.TabIndex = 13;
        	this.map_lblX.Text = "Width:";
        	// 
        	// map_lblY
        	// 
        	this.map_lblY.AutoSize = true;
        	this.map_lblY.Location = new System.Drawing.Point(118, 51);
        	this.map_lblY.Name = "map_lblY";
        	this.map_lblY.Size = new System.Drawing.Size(41, 13);
        	this.map_lblY.TabIndex = 12;
        	this.map_lblY.Text = "Height:";
        	// 
        	// map_txtSeed
        	// 
        	this.map_txtSeed.BackColor = System.Drawing.SystemColors.Window;
        	this.map_txtSeed.Location = new System.Drawing.Point(231, 75);
        	this.map_txtSeed.Name = "map_txtSeed";
        	this.map_txtSeed.Size = new System.Drawing.Size(107, 21);
        	this.map_txtSeed.TabIndex = 11;
        	// 
        	// map_cmbType
        	// 
        	this.map_cmbType.BackColor = System.Drawing.SystemColors.Window;
        	this.map_cmbType.FormattingEnabled = true;
        	this.map_cmbType.Location = new System.Drawing.Point(51, 75);
        	this.map_cmbType.Name = "map_cmbType";
        	this.map_cmbType.Size = new System.Drawing.Size(121, 21);
        	this.map_cmbType.TabIndex = 10;
        	// 
        	// map_cmbZ
        	// 
        	this.map_cmbZ.BackColor = System.Drawing.SystemColors.Window;
        	this.map_cmbZ.FormattingEnabled = true;
        	this.map_cmbZ.Items.AddRange(new object[] {
			"16",
			"32",
			"64",
			"128",
			"256",
			"512",
			"1024"});
        	this.map_cmbZ.Location = new System.Drawing.Point(279, 48);
        	this.map_cmbZ.Name = "map_cmbZ";
        	this.map_cmbZ.Size = new System.Drawing.Size(60, 21);
        	this.map_cmbZ.TabIndex = 9;
        	// 
        	// map_cmbY
        	// 
        	this.map_cmbY.BackColor = System.Drawing.SystemColors.Window;
        	this.map_cmbY.FormattingEnabled = true;
        	this.map_cmbY.Items.AddRange(new object[] {
			"16",
			"32",
			"64",
			"128",
			"256",
			"512",
			"1024"});
        	this.map_cmbY.Location = new System.Drawing.Point(165, 48);
        	this.map_cmbY.Name = "map_cmbY";
        	this.map_cmbY.Size = new System.Drawing.Size(60, 21);
        	this.map_cmbY.TabIndex = 8;
        	// 
        	// map_cmbX
        	// 
        	this.map_cmbX.BackColor = System.Drawing.SystemColors.Window;
        	this.map_cmbX.FormattingEnabled = true;
        	this.map_cmbX.Items.AddRange(new object[] {
			"16",
			"32",
			"64",
			"128",
			"256",
			"512",
			"1024"});
        	this.map_cmbX.Location = new System.Drawing.Point(52, 48);
        	this.map_cmbX.Name = "map_cmbX";
        	this.map_cmbX.Size = new System.Drawing.Size(60, 21);
        	this.map_cmbX.TabIndex = 7;
        	// 
        	// map_lblName
        	// 
        	this.map_lblName.AutoSize = true;
        	this.map_lblName.Location = new System.Drawing.Point(7, 24);
        	this.map_lblName.Name = "map_lblName";
        	this.map_lblName.Size = new System.Drawing.Size(38, 13);
        	this.map_lblName.TabIndex = 6;
        	this.map_lblName.Text = "Name:";
        	// 
        	// map_txtName
        	// 
        	this.map_txtName.BackColor = System.Drawing.SystemColors.Window;
        	this.map_txtName.Location = new System.Drawing.Point(51, 21);
        	this.map_txtName.Name = "map_txtName";
        	this.map_txtName.Size = new System.Drawing.Size(287, 21);
        	this.map_txtName.TabIndex = 0;
        	// 
        	// tp_Players
        	// 
        	this.tp_Players.Controls.Add(this.pl_lblOnline);
        	this.tp_Players.Controls.Add(this.pl_gbProps);
        	this.tp_Players.Controls.Add(this.pl_gbOther);
        	this.tp_Players.Controls.Add(this.pl_gbActions);
        	this.tp_Players.Controls.Add(this.pl_statusBox);
        	this.tp_Players.Controls.Add(this.pl_listBox);
        	this.tp_Players.Location = new System.Drawing.Point(4, 22);
        	this.tp_Players.Name = "tp_Players";
        	this.tp_Players.Padding = new System.Windows.Forms.Padding(3);
        	this.tp_Players.Size = new System.Drawing.Size(767, 488);
        	this.tp_Players.TabIndex = 7;
        	this.tp_Players.Text = "Players";
        	// 
        	// pl_lblOnline
        	// 
        	this.pl_lblOnline.AutoSize = true;
        	this.pl_lblOnline.Location = new System.Drawing.Point(8, 9);
        	this.pl_lblOnline.Name = "pl_lblOnline";
        	this.pl_lblOnline.Size = new System.Drawing.Size(78, 13);
        	this.pl_lblOnline.TabIndex = 68;
        	this.pl_lblOnline.Text = "Online players:";
        	// 
        	// pl_gbProps
        	// 
        	this.pl_gbProps.Controls.Add(this.pl_pgProps);
        	this.pl_gbProps.Location = new System.Drawing.Point(147, 9);
        	this.pl_gbProps.Name = "pl_gbProps";
        	this.pl_gbProps.Size = new System.Drawing.Size(363, 380);
        	this.pl_gbProps.TabIndex = 67;
        	this.pl_gbProps.TabStop = false;
        	this.pl_gbProps.Text = "Properties for (none selected)";
        	// 
        	// pl_pgProps
        	// 
        	this.pl_pgProps.HelpVisible = false;
        	this.pl_pgProps.Location = new System.Drawing.Point(6, 18);
        	this.pl_pgProps.Name = "pl_pgProps";
        	this.pl_pgProps.Size = new System.Drawing.Size(351, 356);
        	this.pl_pgProps.TabIndex = 64;
        	this.pl_pgProps.ToolbarVisible = false;
        	// 
        	// pl_gbOther
        	// 
        	this.pl_gbOther.Controls.Add(this.pl_txtImpersonate);
        	this.pl_gbOther.Controls.Add(this.pl_btnSendCommand);
        	this.pl_gbOther.Controls.Add(this.pl_txtMessage);
        	this.pl_gbOther.Controls.Add(this.pl_btnMessage);
        	this.pl_gbOther.Location = new System.Drawing.Point(147, 395);
        	this.pl_gbOther.Name = "pl_gbOther";
        	this.pl_gbOther.Size = new System.Drawing.Size(614, 78);
        	this.pl_gbOther.TabIndex = 66;
        	this.pl_gbOther.TabStop = false;
        	this.pl_gbOther.Text = "Other";
        	// 
        	// pl_txtImpersonate
        	// 
        	this.pl_txtImpersonate.BackColor = System.Drawing.SystemColors.Window;
        	this.pl_txtImpersonate.Location = new System.Drawing.Point(115, 50);
        	this.pl_txtImpersonate.Name = "pl_txtImpersonate";
        	this.pl_txtImpersonate.Size = new System.Drawing.Size(485, 21);
        	this.pl_txtImpersonate.TabIndex = 38;
        	this.pl_txtImpersonate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pl_txtImpersonate_KeyDown);
        	// 
        	// pl_btnSendCommand
        	// 
        	this.pl_btnSendCommand.Location = new System.Drawing.Point(6, 48);
        	this.pl_btnSendCommand.Name = "pl_btnSendCommand";
        	this.pl_btnSendCommand.Size = new System.Drawing.Size(98, 23);
        	this.pl_btnSendCommand.TabIndex = 37;
        	this.pl_btnSendCommand.Text = "Do command:";
        	this.pl_btnSendCommand.UseVisualStyleBackColor = true;
        	this.pl_btnSendCommand.Click += new System.EventHandler(this.pl_BtnSendCommand_Click);
        	// 
        	// pl_txtMessage
        	// 
        	this.pl_txtMessage.BackColor = System.Drawing.SystemColors.Window;
        	this.pl_txtMessage.Location = new System.Drawing.Point(115, 18);
        	this.pl_txtMessage.Name = "pl_txtMessage";
        	this.pl_txtMessage.Size = new System.Drawing.Size(485, 21);
        	this.pl_txtMessage.TabIndex = 8;
        	this.pl_txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pl_txtMessage_KeyDown);
        	// 
        	// pl_btnMessage
        	// 
        	this.pl_btnMessage.Location = new System.Drawing.Point(6, 16);
        	this.pl_btnMessage.Name = "pl_btnMessage";
        	this.pl_btnMessage.Size = new System.Drawing.Size(98, 23);
        	this.pl_btnMessage.TabIndex = 9;
        	this.pl_btnMessage.Text = "Send message:";
        	this.pl_btnMessage.UseVisualStyleBackColor = true;
        	this.pl_btnMessage.Click += new System.EventHandler(this.pl_BtnMessage_Click);
        	// 
        	// pl_gbActions
        	// 
        	this.pl_gbActions.Controls.Add(this.pl_btnKill);
        	this.pl_gbActions.Controls.Add(this.pl_txtUndo);
        	this.pl_gbActions.Controls.Add(this.pl_btnWarn);
        	this.pl_gbActions.Controls.Add(this.pl_btnRules);
        	this.pl_gbActions.Controls.Add(this.pl_btnKick);
        	this.pl_gbActions.Controls.Add(this.pl_btnBanIP);
        	this.pl_gbActions.Controls.Add(this.pl_btnUndo);
        	this.pl_gbActions.Controls.Add(this.pl_btnMute);
        	this.pl_gbActions.Controls.Add(this.pl_btnBan);
        	this.pl_gbActions.Controls.Add(this.pl_btnFreeze);
        	this.pl_gbActions.Location = new System.Drawing.Point(529, 9);
        	this.pl_gbActions.Name = "pl_gbActions";
        	this.pl_gbActions.Size = new System.Drawing.Size(228, 186);
        	this.pl_gbActions.TabIndex = 65;
        	this.pl_gbActions.TabStop = false;
        	this.pl_gbActions.Text = "Actions";
        	// 
        	// pl_btnKill
        	// 
        	this.pl_btnKill.Location = new System.Drawing.Point(8, 105);
        	this.pl_btnKill.Name = "pl_btnKill";
        	this.pl_btnKill.Size = new System.Drawing.Size(98, 23);
        	this.pl_btnKill.TabIndex = 43;
        	this.pl_btnKill.Text = "Kill";
        	this.pl_btnKill.UseVisualStyleBackColor = true;
        	this.pl_btnKill.Click += new System.EventHandler(this.pl_BtnKill_Click);
        	// 
        	// pl_txtUndo
        	// 
        	this.pl_txtUndo.BackColor = System.Drawing.SystemColors.Window;
        	this.pl_txtUndo.Location = new System.Drawing.Point(122, 150);
        	this.pl_txtUndo.Name = "pl_txtUndo";
        	this.pl_txtUndo.Size = new System.Drawing.Size(98, 21);
        	this.pl_txtUndo.TabIndex = 42;
        	this.pl_txtUndo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pl_txtUndo_KeyDown);
        	// 
        	// pl_btnWarn
        	// 
        	this.pl_btnWarn.Location = new System.Drawing.Point(8, 18);
        	this.pl_btnWarn.Name = "pl_btnWarn";
        	this.pl_btnWarn.Size = new System.Drawing.Size(98, 23);
        	this.pl_btnWarn.TabIndex = 10;
        	this.pl_btnWarn.Text = "Warn";
        	this.pl_btnWarn.UseVisualStyleBackColor = true;
        	this.pl_btnWarn.Click += new System.EventHandler(this.pl_BtnWarn_Click);
        	// 
        	// pl_btnRules
        	// 
        	this.pl_btnRules.Location = new System.Drawing.Point(122, 105);
        	this.pl_btnRules.Name = "pl_btnRules";
        	this.pl_btnRules.Size = new System.Drawing.Size(98, 23);
        	this.pl_btnRules.TabIndex = 39;
        	this.pl_btnRules.Text = "Send Rules";
        	this.pl_btnRules.UseVisualStyleBackColor = true;
        	this.pl_btnRules.Click += new System.EventHandler(this.pl_BtnRules_Click);
        	// 
        	// pl_btnKick
        	// 
        	this.pl_btnKick.Location = new System.Drawing.Point(122, 18);
        	this.pl_btnKick.Name = "pl_btnKick";
        	this.pl_btnKick.Size = new System.Drawing.Size(98, 23);
        	this.pl_btnKick.TabIndex = 4;
        	this.pl_btnKick.Text = "Kick";
        	this.pl_btnKick.UseVisualStyleBackColor = true;
        	this.pl_btnKick.Click += new System.EventHandler(this.pl_BtnKick_Click);
        	// 
        	// pl_btnBanIP
        	// 
        	this.pl_btnBanIP.Location = new System.Drawing.Point(122, 47);
        	this.pl_btnBanIP.Name = "pl_btnBanIP";
        	this.pl_btnBanIP.Size = new System.Drawing.Size(98, 23);
        	this.pl_btnBanIP.TabIndex = 6;
        	this.pl_btnBanIP.Text = "IP Ban";
        	this.pl_btnBanIP.UseVisualStyleBackColor = true;
        	this.pl_btnBanIP.Click += new System.EventHandler(this.pl_BtnIPBan_Click);
        	// 
        	// pl_btnUndo
        	// 
        	this.pl_btnUndo.Location = new System.Drawing.Point(8, 148);
        	this.pl_btnUndo.Name = "pl_btnUndo";
        	this.pl_btnUndo.Size = new System.Drawing.Size(98, 23);
        	this.pl_btnUndo.TabIndex = 41;
        	this.pl_btnUndo.Text = "Undo:";
        	this.pl_btnUndo.UseVisualStyleBackColor = true;
        	this.pl_btnUndo.Click += new System.EventHandler(this.pl_BtnUndo_Click);
        	// 
        	// pl_btnMute
        	// 
        	this.pl_btnMute.Location = new System.Drawing.Point(8, 76);
        	this.pl_btnMute.Name = "pl_btnMute";
        	this.pl_btnMute.Size = new System.Drawing.Size(98, 23);
        	this.pl_btnMute.TabIndex = 40;
        	this.pl_btnMute.Text = "Mute";
        	this.pl_btnMute.UseVisualStyleBackColor = true;
        	this.pl_btnMute.Click += new System.EventHandler(this.pl_BtnMute_Click);
        	// 
        	// pl_btnBan
        	// 
        	this.pl_btnBan.Location = new System.Drawing.Point(8, 47);
        	this.pl_btnBan.Name = "pl_btnBan";
        	this.pl_btnBan.Size = new System.Drawing.Size(98, 23);
        	this.pl_btnBan.TabIndex = 5;
        	this.pl_btnBan.Text = "Ban";
        	this.pl_btnBan.UseVisualStyleBackColor = true;
        	this.pl_btnBan.Click += new System.EventHandler(this.pl_BtnBan_Click);
        	// 
        	// pl_btnFreeze
        	// 
        	this.pl_btnFreeze.Location = new System.Drawing.Point(122, 76);
        	this.pl_btnFreeze.Name = "pl_btnFreeze";
        	this.pl_btnFreeze.Size = new System.Drawing.Size(98, 23);
        	this.pl_btnFreeze.TabIndex = 36;
        	this.pl_btnFreeze.Text = "Freeze";
        	this.pl_btnFreeze.UseVisualStyleBackColor = true;
        	this.pl_btnFreeze.Click += new System.EventHandler(this.pl_BtnFreeze_Click);
        	// 
        	// pl_statusBox
        	// 
        	this.pl_statusBox.BackColor = System.Drawing.SystemColors.Window;
        	this.pl_statusBox.Cursor = System.Windows.Forms.Cursors.Default;
        	this.pl_statusBox.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.pl_statusBox.Location = new System.Drawing.Point(529, 201);
        	this.pl_statusBox.Multiline = true;
        	this.pl_statusBox.Name = "pl_statusBox";
        	this.pl_statusBox.ReadOnly = true;
        	this.pl_statusBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        	this.pl_statusBox.Size = new System.Drawing.Size(232, 188);
        	this.pl_statusBox.TabIndex = 63;
        	// 
        	// pl_listBox
        	// 
        	this.pl_listBox.BackColor = System.Drawing.SystemColors.Window;
        	this.pl_listBox.FormattingEnabled = true;
        	this.pl_listBox.Location = new System.Drawing.Point(8, 27);
        	this.pl_listBox.Name = "pl_listBox";
        	this.pl_listBox.Size = new System.Drawing.Size(123, 446);
        	this.pl_listBox.TabIndex = 62;
        	this.pl_listBox.Click += new System.EventHandler(this.pl_listBox_Click);
        	// 
        	// tb_games
        	// 
        	this.tb_games.BackColor = System.Drawing.SystemColors.Control;
        	this.tb_games.Controls.Add(this.tabGames);
        	this.tb_games.Location = new System.Drawing.Point(4, 22);
        	this.tb_games.Name = "tb_games";
        	this.tb_games.Size = new System.Drawing.Size(767, 488);
        	this.tb_games.TabIndex = 10;
        	this.tb_games.Text = "Games";
        	// 
        	// tabGames
        	// 
        	this.tabGames.Controls.Add(this.tabLS);
        	this.tabGames.Controls.Add(this.tabZS);
        	this.tabGames.Controls.Add(this.tabCTF);
        	this.tabGames.Controls.Add(this.tabTW);
        	this.tabGames.Controls.Add(this.tabSPL);
        	this.tabGames.Controls.Add(this.tabCD);
        	this.tabGames.Location = new System.Drawing.Point(3, 3);
        	this.tabGames.Name = "tabGames";
        	this.tabGames.SelectedIndex = 0;
        	this.tabGames.Size = new System.Drawing.Size(761, 515);
        	this.tabGames.TabIndex = 1;
        	// 
        	// tabLS
        	// 
        	this.tabLS.BackColor = System.Drawing.SystemColors.Control;
        	this.tabLS.Controls.Add(this.ls_grpControls);
        	this.tabLS.Controls.Add(this.ls_grpMapSettings);
        	this.tabLS.Controls.Add(this.ls_grpSettings);
        	this.tabLS.Controls.Add(this.ls_grpMaps);
        	this.tabLS.Location = new System.Drawing.Point(4, 22);
        	this.tabLS.Name = "tabLS";
        	this.tabLS.Padding = new System.Windows.Forms.Padding(3);
        	this.tabLS.Size = new System.Drawing.Size(753, 489);
        	this.tabLS.TabIndex = 7;
        	this.tabLS.Text = "Lava Survival";
        	// 
        	// ls_grpControls
        	// 
        	this.ls_grpControls.Controls.Add(this.ls_btnEnd);
        	this.ls_grpControls.Controls.Add(this.ls_btnStop);
        	this.ls_grpControls.Controls.Add(this.ls_btnStart);
        	this.ls_grpControls.Location = new System.Drawing.Point(216, 6);
        	this.ls_grpControls.Name = "ls_grpControls";
        	this.ls_grpControls.Size = new System.Drawing.Size(279, 51);
        	this.ls_grpControls.TabIndex = 4;
        	this.ls_grpControls.TabStop = false;
        	this.ls_grpControls.Text = "Controls";
        	// 
        	// ls_btnEnd
        	// 
        	this.ls_btnEnd.Location = new System.Drawing.Point(190, 19);
        	this.ls_btnEnd.Name = "ls_btnEnd";
        	this.ls_btnEnd.Size = new System.Drawing.Size(80, 23);
        	this.ls_btnEnd.TabIndex = 2;
        	this.ls_btnEnd.Text = "End Round";
        	this.ls_btnEnd.UseVisualStyleBackColor = true;
        	// 
        	// ls_btnStop
        	// 
        	this.ls_btnStop.Location = new System.Drawing.Point(100, 19);
        	this.ls_btnStop.Name = "ls_btnStop";
        	this.ls_btnStop.Size = new System.Drawing.Size(80, 23);
        	this.ls_btnStop.TabIndex = 1;
        	this.ls_btnStop.Text = "Stop Game";
        	this.ls_btnStop.UseVisualStyleBackColor = true;
        	// 
        	// ls_btnStart
        	// 
        	this.ls_btnStart.Location = new System.Drawing.Point(10, 19);
        	this.ls_btnStart.Name = "ls_btnStart";
        	this.ls_btnStart.Size = new System.Drawing.Size(80, 23);
        	this.ls_btnStart.TabIndex = 0;
        	this.ls_btnStart.Text = "Start Game";
        	this.ls_btnStart.UseVisualStyleBackColor = true;
        	// 
        	// ls_grpMapSettings
        	// 
        	this.ls_grpMapSettings.Controls.Add(this.ls_grpTime);
        	this.ls_grpMapSettings.Controls.Add(this.ls_grpLayer);
        	this.ls_grpMapSettings.Controls.Add(this.ls_grpBlock);
        	this.ls_grpMapSettings.Enabled = false;
        	this.ls_grpMapSettings.Location = new System.Drawing.Point(6, 202);
        	this.ls_grpMapSettings.Name = "ls_grpMapSettings";
        	this.ls_grpMapSettings.Size = new System.Drawing.Size(296, 258);
        	this.ls_grpMapSettings.TabIndex = 3;
        	this.ls_grpMapSettings.TabStop = false;
        	this.ls_grpMapSettings.Text = "Map Settings";
        	// 
        	// ls_grpTime
        	// 
        	this.ls_grpTime.Controls.Add(this.ls_numFlood);
        	this.ls_grpTime.Controls.Add(this.ls_numLayerTime);
        	this.ls_grpTime.Controls.Add(this.ls_numRound);
        	this.ls_grpTime.Controls.Add(this.ls_lblLayerTime);
        	this.ls_grpTime.Controls.Add(this.ls_lblFlood);
        	this.ls_grpTime.Controls.Add(this.ls_lblRound);
        	this.ls_grpTime.Location = new System.Drawing.Point(6, 180);
        	this.ls_grpTime.Name = "ls_grpTime";
        	this.ls_grpTime.Size = new System.Drawing.Size(284, 71);
        	this.ls_grpTime.TabIndex = 39;
        	this.ls_grpTime.TabStop = false;
        	this.ls_grpTime.Text = "Time settings";
        	// 
        	// ls_numFlood
        	// 
        	this.ls_numFlood.BackColor = System.Drawing.SystemColors.Window;
        	this.ls_numFlood.Location = new System.Drawing.Point(69, 43);
        	this.ls_numFlood.Name = "ls_numFlood";
        	this.ls_numFlood.Seconds = ((long)(300));
        	this.ls_numFlood.Size = new System.Drawing.Size(62, 21);
        	this.ls_numFlood.TabIndex = 38;
        	this.ls_numFlood.Text = "5m";
        	this.ls_numFlood.Value = System.TimeSpan.Parse("00:05:00");
        	// 
        	// ls_numLayerTime
        	// 
        	this.ls_numLayerTime.BackColor = System.Drawing.SystemColors.Window;
        	this.ls_numLayerTime.Location = new System.Drawing.Point(216, 16);
        	this.ls_numLayerTime.Name = "ls_numLayerTime";
        	this.ls_numLayerTime.Seconds = ((long)(120));
        	this.ls_numLayerTime.Size = new System.Drawing.Size(62, 21);
        	this.ls_numLayerTime.TabIndex = 37;
        	this.ls_numLayerTime.Text = "2m";
        	this.ls_numLayerTime.Value = System.TimeSpan.Parse("00:02:00");
        	// 
        	// ls_numRound
        	// 
        	this.ls_numRound.BackColor = System.Drawing.SystemColors.Window;
        	this.ls_numRound.Location = new System.Drawing.Point(69, 16);
        	this.ls_numRound.Name = "ls_numRound";
        	this.ls_numRound.Seconds = ((long)(900));
        	this.ls_numRound.Size = new System.Drawing.Size(62, 21);
        	this.ls_numRound.TabIndex = 36;
        	this.ls_numRound.Text = "15m";
        	this.ls_numRound.Value = System.TimeSpan.Parse("00:15:00");
        	// 
        	// ls_lblLayerTime
        	// 
        	this.ls_lblLayerTime.AutoSize = true;
        	this.ls_lblLayerTime.Location = new System.Drawing.Point(154, 20);
        	this.ls_lblLayerTime.Name = "ls_lblLayerTime";
        	this.ls_lblLayerTime.Size = new System.Drawing.Size(59, 13);
        	this.ls_lblLayerTime.TabIndex = 35;
        	this.ls_lblLayerTime.Text = "Layer time:";
        	// 
        	// ls_lblFlood
        	// 
        	this.ls_lblFlood.AutoSize = true;
        	this.ls_lblFlood.Location = new System.Drawing.Point(8, 46);
        	this.ls_lblFlood.Name = "ls_lblFlood";
        	this.ls_lblFlood.Size = new System.Drawing.Size(59, 13);
        	this.ls_lblFlood.TabIndex = 34;
        	this.ls_lblFlood.Text = "Flood time:";
        	// 
        	// ls_lblRound
        	// 
        	this.ls_lblRound.AutoSize = true;
        	this.ls_lblRound.Location = new System.Drawing.Point(5, 20);
        	this.ls_lblRound.Name = "ls_lblRound";
        	this.ls_lblRound.Size = new System.Drawing.Size(63, 13);
        	this.ls_lblRound.TabIndex = 34;
        	this.ls_lblRound.Text = "Round time:";
        	// 
        	// ls_grpLayer
        	// 
        	this.ls_grpLayer.Controls.Add(this.ls_lblBlocksTall);
        	this.ls_grpLayer.Controls.Add(this.ls_numHeight);
        	this.ls_grpLayer.Controls.Add(this.ls_lblLayersEach);
        	this.ls_grpLayer.Controls.Add(this.ls_numCount);
        	this.ls_grpLayer.Controls.Add(this.ls_numLayer);
        	this.ls_grpLayer.Controls.Add(this.ls_lblLayer);
        	this.ls_grpLayer.Location = new System.Drawing.Point(6, 100);
        	this.ls_grpLayer.Name = "ls_grpLayer";
        	this.ls_grpLayer.Size = new System.Drawing.Size(284, 74);
        	this.ls_grpLayer.TabIndex = 1;
        	this.ls_grpLayer.TabStop = false;
        	this.ls_grpLayer.Text = "Layer flood settings";
        	// 
        	// ls_lblBlocksTall
        	// 
        	this.ls_lblBlocksTall.AutoSize = true;
        	this.ls_lblBlocksTall.Location = new System.Drawing.Point(183, 48);
        	this.ls_lblBlocksTall.Name = "ls_lblBlocksTall";
        	this.ls_lblBlocksTall.Size = new System.Drawing.Size(55, 13);
        	this.ls_lblBlocksTall.TabIndex = 38;
        	this.ls_lblBlocksTall.Text = "blocks tall";
        	// 
        	// ls_numHeight
        	// 
        	this.ls_numHeight.BackColor = System.Drawing.SystemColors.Window;
        	this.ls_numHeight.Location = new System.Drawing.Point(128, 44);
        	this.ls_numHeight.Maximum = new decimal(new int[] {
			1000000,
			0,
			0,
			0});
        	this.ls_numHeight.Name = "ls_numHeight";
        	this.ls_numHeight.Size = new System.Drawing.Size(52, 21);
        	this.ls_numHeight.TabIndex = 37;
        	this.ls_numHeight.Value = new decimal(new int[] {
			3,
			0,
			0,
			0});
        	// 
        	// ls_lblLayersEach
        	// 
        	this.ls_lblLayersEach.AutoSize = true;
        	this.ls_lblLayersEach.Location = new System.Drawing.Point(62, 48);
        	this.ls_lblLayersEach.Name = "ls_lblLayersEach";
        	this.ls_lblLayersEach.Size = new System.Drawing.Size(64, 13);
        	this.ls_lblLayersEach.TabIndex = 36;
        	this.ls_lblLayersEach.Text = "layers, each";
        	// 
        	// ls_numCount
        	// 
        	this.ls_numCount.BackColor = System.Drawing.SystemColors.Window;
        	this.ls_numCount.Location = new System.Drawing.Point(7, 44);
        	this.ls_numCount.Maximum = new decimal(new int[] {
			1000000,
			0,
			0,
			0});
        	this.ls_numCount.Name = "ls_numCount";
        	this.ls_numCount.Size = new System.Drawing.Size(52, 21);
        	this.ls_numCount.TabIndex = 35;
        	this.ls_numCount.Value = new decimal(new int[] {
			10,
			0,
			0,
			0});
        	// 
        	// ls_numLayer
        	// 
        	this.ls_numLayer.BackColor = System.Drawing.SystemColors.Window;
        	this.ls_numLayer.Location = new System.Drawing.Point(128, 16);
        	this.ls_numLayer.Name = "ls_numLayer";
        	this.ls_numLayer.Size = new System.Drawing.Size(52, 21);
        	this.ls_numLayer.TabIndex = 34;
        	// 
        	// ls_lblLayer
        	// 
        	this.ls_lblLayer.AutoSize = true;
        	this.ls_lblLayer.Location = new System.Drawing.Point(28, 20);
        	this.ls_lblLayer.Name = "ls_lblLayer";
        	this.ls_lblLayer.Size = new System.Drawing.Size(98, 13);
        	this.ls_lblLayer.TabIndex = 34;
        	this.ls_lblLayer.Text = "Layer flood chance:";
        	// 
        	// ls_grpBlock
        	// 
        	this.ls_grpBlock.Controls.Add(this.ls_numDestroy);
        	this.ls_grpBlock.Controls.Add(this.ls_numWater);
        	this.ls_grpBlock.Controls.Add(this.ls_numFast);
        	this.ls_grpBlock.Controls.Add(this.ls_numKiller);
        	this.ls_grpBlock.Controls.Add(this.ls_lblDestroy);
        	this.ls_grpBlock.Controls.Add(this.ls_lblFast);
        	this.ls_grpBlock.Controls.Add(this.ls_lblWater);
        	this.ls_grpBlock.Controls.Add(this.ls_lblKill);
        	this.ls_grpBlock.Location = new System.Drawing.Point(6, 20);
        	this.ls_grpBlock.Name = "ls_grpBlock";
        	this.ls_grpBlock.Size = new System.Drawing.Size(284, 74);
        	this.ls_grpBlock.TabIndex = 0;
        	this.ls_grpBlock.TabStop = false;
        	this.ls_grpBlock.Text = "Flood block type";
        	// 
        	// ls_numDestroy
        	// 
        	this.ls_numDestroy.BackColor = System.Drawing.SystemColors.Window;
        	this.ls_numDestroy.Location = new System.Drawing.Point(226, 45);
        	this.ls_numDestroy.Name = "ls_numDestroy";
        	this.ls_numDestroy.Size = new System.Drawing.Size(52, 21);
        	this.ls_numDestroy.TabIndex = 33;
        	// 
        	// ls_numWater
        	// 
        	this.ls_numWater.BackColor = System.Drawing.SystemColors.Window;
        	this.ls_numWater.Location = new System.Drawing.Point(226, 20);
        	this.ls_numWater.Name = "ls_numWater";
        	this.ls_numWater.Size = new System.Drawing.Size(52, 21);
        	this.ls_numWater.TabIndex = 32;
        	// 
        	// ls_numFast
        	// 
        	this.ls_numFast.BackColor = System.Drawing.SystemColors.Window;
        	this.ls_numFast.Location = new System.Drawing.Point(79, 45);
        	this.ls_numFast.Name = "ls_numFast";
        	this.ls_numFast.Size = new System.Drawing.Size(52, 21);
        	this.ls_numFast.TabIndex = 31;
        	// 
        	// ls_numKiller
        	// 
        	this.ls_numKiller.BackColor = System.Drawing.SystemColors.Window;
        	this.ls_numKiller.Location = new System.Drawing.Point(79, 20);
        	this.ls_numKiller.Name = "ls_numKiller";
        	this.ls_numKiller.Size = new System.Drawing.Size(52, 21);
        	this.ls_numKiller.TabIndex = 27;
        	this.ls_numKiller.Value = new decimal(new int[] {
			100,
			0,
			0,
			0});
        	// 
        	// ls_lblDestroy
        	// 
        	this.ls_lblDestroy.AutoSize = true;
        	this.ls_lblDestroy.Location = new System.Drawing.Point(135, 48);
        	this.ls_lblDestroy.Name = "ls_lblDestroy";
        	this.ls_lblDestroy.Size = new System.Drawing.Size(88, 13);
        	this.ls_lblDestroy.TabIndex = 30;
        	this.ls_lblDestroy.Text = "Destroys chance:";
        	// 
        	// ls_lblFast
        	// 
        	this.ls_lblFast.AutoSize = true;
        	this.ls_lblFast.Location = new System.Drawing.Point(11, 48);
        	this.ls_lblFast.Name = "ls_lblFast";
        	this.ls_lblFast.Size = new System.Drawing.Size(66, 13);
        	this.ls_lblFast.TabIndex = 29;
        	this.ls_lblFast.Text = "Fast chance:";
        	// 
        	// ls_lblWater
        	// 
        	this.ls_lblWater.AutoSize = true;
        	this.ls_lblWater.Location = new System.Drawing.Point(147, 23);
        	this.ls_lblWater.Name = "ls_lblWater";
        	this.ls_lblWater.Size = new System.Drawing.Size(76, 13);
        	this.ls_lblWater.TabIndex = 28;
        	this.ls_lblWater.Text = "Water chance:";
        	// 
        	// ls_lblKill
        	// 
        	this.ls_lblKill.AutoSize = true;
        	this.ls_lblKill.Location = new System.Drawing.Point(6, 23);
        	this.ls_lblKill.Name = "ls_lblKill";
        	this.ls_lblKill.Size = new System.Drawing.Size(71, 13);
        	this.ls_lblKill.TabIndex = 27;
        	this.ls_lblKill.Text = "Killer chance:";
        	// 
        	// ls_grpSettings
        	// 
        	this.ls_grpSettings.Controls.Add(this.ls_lblMax);
        	this.ls_grpSettings.Controls.Add(this.ls_numMax);
        	this.ls_grpSettings.Controls.Add(this.ls_cbMain);
        	this.ls_grpSettings.Controls.Add(this.ls_cbMap);
        	this.ls_grpSettings.Controls.Add(this.ls_cbStart);
        	this.ls_grpSettings.Location = new System.Drawing.Point(6, 63);
        	this.ls_grpSettings.Name = "ls_grpSettings";
        	this.ls_grpSettings.Size = new System.Drawing.Size(296, 119);
        	this.ls_grpSettings.TabIndex = 2;
        	this.ls_grpSettings.TabStop = false;
        	this.ls_grpSettings.Text = "Settings";
        	// 
        	// ls_lblMax
        	// 
        	this.ls_lblMax.AutoSize = true;
        	this.ls_lblMax.Location = new System.Drawing.Point(14, 92);
        	this.ls_lblMax.Name = "ls_lblMax";
        	this.ls_lblMax.Size = new System.Drawing.Size(54, 13);
        	this.ls_lblMax.TabIndex = 26;
        	this.ls_lblMax.Text = "Max lives:";
        	// 
        	// ls_numMax
        	// 
        	this.ls_numMax.BackColor = System.Drawing.SystemColors.Window;
        	this.ls_numMax.Location = new System.Drawing.Point(71, 89);
        	this.ls_numMax.Maximum = new decimal(new int[] {
			1000000,
			0,
			0,
			0});
        	this.ls_numMax.Name = "ls_numMax";
        	this.ls_numMax.Size = new System.Drawing.Size(52, 21);
        	this.ls_numMax.TabIndex = 25;
        	this.ls_numMax.Value = new decimal(new int[] {
			3,
			0,
			0,
			0});
        	// 
        	// ls_cbMain
        	// 
        	this.ls_cbMain.AutoSize = true;
        	this.ls_cbMain.Location = new System.Drawing.Point(11, 66);
        	this.ls_cbMain.Name = "ls_cbMain";
        	this.ls_cbMain.Size = new System.Drawing.Size(112, 17);
        	this.ls_cbMain.TabIndex = 24;
        	this.ls_cbMain.Text = "Change main level";
        	this.ls_cbMain.UseVisualStyleBackColor = true;
        	// 
        	// ls_cbMap
        	// 
        	this.ls_cbMap.AutoSize = true;
        	this.ls_cbMap.Location = new System.Drawing.Point(11, 43);
        	this.ls_cbMap.Name = "ls_cbMap";
        	this.ls_cbMap.Size = new System.Drawing.Size(136, 17);
        	this.ls_cbMap.TabIndex = 23;
        	this.ls_cbMap.Text = "Map name in server list";
        	this.ls_cbMap.UseVisualStyleBackColor = true;
        	// 
        	// ls_cbStart
        	// 
        	this.ls_cbStart.AutoSize = true;
        	this.ls_cbStart.Location = new System.Drawing.Point(11, 20);
        	this.ls_cbStart.Name = "ls_cbStart";
        	this.ls_cbStart.Size = new System.Drawing.Size(139, 17);
        	this.ls_cbStart.TabIndex = 22;
        	this.ls_cbStart.Text = "Start when server starts";
        	this.ls_cbStart.UseVisualStyleBackColor = true;
        	// 
        	// ls_grpMaps
        	// 
        	this.ls_grpMaps.Controls.Add(this.ls_lblNotUsed);
        	this.ls_grpMaps.Controls.Add(this.ls_lblUsed);
        	this.ls_grpMaps.Controls.Add(this.ls_btnAdd);
        	this.ls_grpMaps.Controls.Add(this.ls_btnRemove);
        	this.ls_grpMaps.Controls.Add(this.ls_lstNotUsed);
        	this.ls_grpMaps.Controls.Add(this.ls_lstUsed);
        	this.ls_grpMaps.Location = new System.Drawing.Point(316, 63);
        	this.ls_grpMaps.Name = "ls_grpMaps";
        	this.ls_grpMaps.Size = new System.Drawing.Size(170, 397);
        	this.ls_grpMaps.TabIndex = 1;
        	this.ls_grpMaps.TabStop = false;
        	this.ls_grpMaps.Text = "Maps";
        	// 
        	// ls_lblNotUsed
        	// 
        	this.ls_lblNotUsed.AutoSize = true;
        	this.ls_lblNotUsed.Location = new System.Drawing.Point(187, 17);
        	this.ls_lblNotUsed.Name = "ls_lblNotUsed";
        	this.ls_lblNotUsed.Size = new System.Drawing.Size(83, 13);
        	this.ls_lblNotUsed.TabIndex = 6;
        	this.ls_lblNotUsed.Text = "Maps Not In Use";
        	// 
        	// ls_lblUsed
        	// 
        	this.ls_lblUsed.AutoSize = true;
        	this.ls_lblUsed.Location = new System.Drawing.Point(6, 17);
        	this.ls_lblUsed.Name = "ls_lblUsed";
        	this.ls_lblUsed.Size = new System.Drawing.Size(38, 13);
        	this.ls_lblUsed.TabIndex = 5;
        	this.ls_lblUsed.Text = "In use:";
        	// 
        	// ls_btnAdd
        	// 
        	this.ls_btnAdd.Location = new System.Drawing.Point(6, 188);
        	this.ls_btnAdd.Name = "ls_btnAdd";
        	this.ls_btnAdd.Size = new System.Drawing.Size(77, 23);
        	this.ls_btnAdd.TabIndex = 4;
        	this.ls_btnAdd.Text = "<< Add";
        	this.ls_btnAdd.UseVisualStyleBackColor = true;
        	// 
        	// ls_btnRemove
        	// 
        	this.ls_btnRemove.Location = new System.Drawing.Point(89, 188);
        	this.ls_btnRemove.Name = "ls_btnRemove";
        	this.ls_btnRemove.Size = new System.Drawing.Size(75, 23);
        	this.ls_btnRemove.TabIndex = 3;
        	this.ls_btnRemove.Text = "Remove >>";
        	this.ls_btnRemove.UseVisualStyleBackColor = true;
        	// 
        	// ls_lstNotUsed
        	// 
        	this.ls_lstNotUsed.BackColor = System.Drawing.SystemColors.Window;
        	this.ls_lstNotUsed.FormattingEnabled = true;
        	this.ls_lstNotUsed.Location = new System.Drawing.Point(6, 219);
        	this.ls_lstNotUsed.Name = "ls_lstNotUsed";
        	this.ls_lstNotUsed.Size = new System.Drawing.Size(158, 173);
        	this.ls_lstNotUsed.TabIndex = 2;
        	// 
        	// ls_lstUsed
        	// 
        	this.ls_lstUsed.BackColor = System.Drawing.SystemColors.Window;
        	this.ls_lstUsed.FormattingEnabled = true;
        	this.ls_lstUsed.Location = new System.Drawing.Point(6, 33);
        	this.ls_lstUsed.Name = "ls_lstUsed";
        	this.ls_lstUsed.Size = new System.Drawing.Size(158, 147);
        	this.ls_lstUsed.TabIndex = 0;
        	// 
        	// tabZS
        	// 
        	this.tabZS.BackColor = System.Drawing.SystemColors.Control;
        	this.tabZS.Controls.Add(this.zs_separator);
        	this.tabZS.Controls.Add(this.zs_grpInvZombie);
        	this.tabZS.Controls.Add(this.zs_grpZombie);
        	this.tabZS.Controls.Add(this.zs_grpRevive);
        	this.tabZS.Controls.Add(this.zs_grpInvHuman);
        	this.tabZS.Controls.Add(this.zs_grpControls);
        	this.tabZS.Controls.Add(this.zs_grpMap);
        	this.tabZS.Controls.Add(this.zs_grpSettings);
        	this.tabZS.Controls.Add(this.zs_grpMaps);
        	this.tabZS.Location = new System.Drawing.Point(4, 22);
        	this.tabZS.Name = "tabZS";
        	this.tabZS.Padding = new System.Windows.Forms.Padding(3);
        	this.tabZS.Size = new System.Drawing.Size(753, 489);
        	this.tabZS.TabIndex = 6;
        	this.tabZS.Text = "Zombie Survival";
        	// 
        	// zs_separator
        	// 
        	this.zs_separator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.zs_separator.Location = new System.Drawing.Point(257, 72);
        	this.zs_separator.Name = "zs_separator";
        	this.zs_separator.Size = new System.Drawing.Size(1, 451);
        	this.zs_separator.TabIndex = 45;
        	// 
        	// zs_grpInvZombie
        	// 
        	this.zs_grpInvZombie.Controls.Add(this.zs_numInvZombieSecs);
        	this.zs_grpInvZombie.Controls.Add(this.zs_numInvZombieMax);
        	this.zs_grpInvZombie.Controls.Add(this.zs_lblInvZombieDur);
        	this.zs_grpInvZombie.Controls.Add(this.zs_lblInvZombieMax);
        	this.zs_grpInvZombie.Location = new System.Drawing.Point(6, 212);
        	this.zs_grpInvZombie.Name = "zs_grpInvZombie";
        	this.zs_grpInvZombie.Size = new System.Drawing.Size(245, 49);
        	this.zs_grpInvZombie.TabIndex = 43;
        	this.zs_grpInvZombie.TabStop = false;
        	this.zs_grpInvZombie.Text = "Zombie invisibility settings";
        	// 
        	// zs_numInvZombieSecs
        	// 
        	this.zs_numInvZombieSecs.BackColor = System.Drawing.SystemColors.Window;
        	this.zs_numInvZombieSecs.Location = new System.Drawing.Point(186, 20);
        	this.zs_numInvZombieSecs.Name = "zs_numInvZombieSecs";
        	this.zs_numInvZombieSecs.Seconds = ((long)(0));
        	this.zs_numInvZombieSecs.Size = new System.Drawing.Size(52, 21);
        	this.zs_numInvZombieSecs.TabIndex = 47;
        	this.zs_numInvZombieSecs.Text = "0s";
        	this.zs_numInvZombieSecs.Value = System.TimeSpan.Parse("00:00:00");
        	// 
        	// zs_numInvZombieMax
        	// 
        	this.zs_numInvZombieMax.BackColor = System.Drawing.SystemColors.Window;
        	this.zs_numInvZombieMax.Location = new System.Drawing.Point(35, 20);
        	this.zs_numInvZombieMax.Name = "zs_numInvZombieMax";
        	this.zs_numInvZombieMax.Size = new System.Drawing.Size(52, 21);
        	this.zs_numInvZombieMax.TabIndex = 27;
        	this.toolTip.SetToolTip(this.zs_numInvZombieMax, "Maximum number of times a human can use /buy invisibility in a round");
        	// 
        	// zs_lblInvZombieDur
        	// 
        	this.zs_lblInvZombieDur.AutoSize = true;
        	this.zs_lblInvZombieDur.Location = new System.Drawing.Point(87, 22);
        	this.zs_lblInvZombieDur.Name = "zs_lblInvZombieDur";
        	this.zs_lblInvZombieDur.Size = new System.Drawing.Size(101, 13);
        	this.zs_lblInvZombieDur.TabIndex = 28;
        	this.zs_lblInvZombieDur.Text = "times, which last for";
        	// 
        	// zs_lblInvZombieMax
        	// 
        	this.zs_lblInvZombieMax.AutoSize = true;
        	this.zs_lblInvZombieMax.Location = new System.Drawing.Point(7, 23);
        	this.zs_lblInvZombieMax.Name = "zs_lblInvZombieMax";
        	this.zs_lblInvZombieMax.Size = new System.Drawing.Size(27, 13);
        	this.zs_lblInvZombieMax.TabIndex = 27;
        	this.zs_lblInvZombieMax.Text = "Max";
        	// 
        	// zs_grpZombie
        	// 
        	this.zs_grpZombie.Controls.Add(this.zs_txtModel);
        	this.zs_grpZombie.Controls.Add(this.zs_txtName);
        	this.zs_grpZombie.Controls.Add(this.zs_lblModel);
        	this.zs_grpZombie.Controls.Add(this.zs_lblName);
        	this.zs_grpZombie.Location = new System.Drawing.Point(6, 376);
        	this.zs_grpZombie.Name = "zs_grpZombie";
        	this.zs_grpZombie.Size = new System.Drawing.Size(245, 77);
        	this.zs_grpZombie.TabIndex = 44;
        	this.zs_grpZombie.TabStop = false;
        	this.zs_grpZombie.Text = "Zombie settings";
        	// 
        	// zs_txtModel
        	// 
        	this.zs_txtModel.BackColor = System.Drawing.SystemColors.Window;
        	this.zs_txtModel.Location = new System.Drawing.Point(49, 46);
        	this.zs_txtModel.Name = "zs_txtModel";
        	this.zs_txtModel.Size = new System.Drawing.Size(188, 21);
        	this.zs_txtModel.TabIndex = 39;
        	this.toolTip.SetToolTip(this.zs_txtModel, "Model to use for infected players.\nIf left blank, then \'zombie\' model is used.");
        	// 
        	// zs_txtName
        	// 
        	this.zs_txtName.BackColor = System.Drawing.SystemColors.Window;
        	this.zs_txtName.Location = new System.Drawing.Point(49, 19);
        	this.zs_txtName.Name = "zs_txtName";
        	this.zs_txtName.Size = new System.Drawing.Size(188, 21);
        	this.zs_txtName.TabIndex = 38;
        	this.toolTip.SetToolTip(this.zs_txtName, "Name to show above head of infected players.\nIf left blank, then the player\'s nam" +
		"e is shown instead.");
        	// 
        	// zs_lblModel
        	// 
        	this.zs_lblModel.AutoSize = true;
        	this.zs_lblModel.Location = new System.Drawing.Point(5, 49);
        	this.zs_lblModel.Name = "zs_lblModel";
        	this.zs_lblModel.Size = new System.Drawing.Size(40, 13);
        	this.zs_lblModel.TabIndex = 35;
        	this.zs_lblModel.Text = "Model:";
        	// 
        	// zs_lblName
        	// 
        	this.zs_lblName.AutoSize = true;
        	this.zs_lblName.Location = new System.Drawing.Point(5, 22);
        	this.zs_lblName.Name = "zs_lblName";
        	this.zs_lblName.Size = new System.Drawing.Size(38, 13);
        	this.zs_lblName.TabIndex = 34;
        	this.zs_lblName.Text = "Name:";
        	// 
        	// zs_grpRevive
        	// 
        	this.zs_grpRevive.Controls.Add(this.zs_numReviveLimit);
        	this.zs_grpRevive.Controls.Add(this.zs_lblSuccess);
        	this.zs_grpRevive.Controls.Add(this.zs_numSuccess);
        	this.zs_grpRevive.Controls.Add(this.zs_lblReviveRound);
        	this.zs_grpRevive.Controls.Add(this.zs_lblReviveLimitFtr);
        	this.zs_grpRevive.Controls.Add(this.zs_lblReviveLimitHdr);
        	this.zs_grpRevive.Controls.Add(this.zs_numReviveMax);
        	this.zs_grpRevive.Controls.Add(this.zs_lblReviveMax);
        	this.zs_grpRevive.Location = new System.Drawing.Point(6, 263);
        	this.zs_grpRevive.Name = "zs_grpRevive";
        	this.zs_grpRevive.Size = new System.Drawing.Size(245, 107);
        	this.zs_grpRevive.TabIndex = 42;
        	this.zs_grpRevive.TabStop = false;
        	this.zs_grpRevive.Text = "Revive settings";
        	// 
        	// zs_numReviveLimit
        	// 
        	this.zs_numReviveLimit.BackColor = System.Drawing.SystemColors.Window;
        	this.zs_numReviveLimit.Location = new System.Drawing.Point(109, 44);
        	this.zs_numReviveLimit.Name = "zs_numReviveLimit";
        	this.zs_numReviveLimit.Seconds = ((long)(10));
        	this.zs_numReviveLimit.Size = new System.Drawing.Size(52, 21);
        	this.zs_numReviveLimit.TabIndex = 48;
        	this.zs_numReviveLimit.Text = "10s";
        	this.zs_numReviveLimit.Value = System.TimeSpan.Parse("00:00:10");
        	// 
        	// zs_lblSuccess
        	// 
        	this.zs_lblSuccess.AutoSize = true;
        	this.zs_lblSuccess.Location = new System.Drawing.Point(62, 77);
        	this.zs_lblSuccess.Name = "zs_lblSuccess";
        	this.zs_lblSuccess.Size = new System.Drawing.Size(76, 13);
        	this.zs_lblSuccess.TabIndex = 45;
        	this.zs_lblSuccess.Text = "% success rate";
        	// 
        	// zs_numSuccess
        	// 
        	this.zs_numSuccess.BackColor = System.Drawing.SystemColors.Window;
        	this.zs_numSuccess.Location = new System.Drawing.Point(10, 73);
        	this.zs_numSuccess.Maximum = new decimal(new int[] {
			1000000,
			0,
			0,
			0});
        	this.zs_numSuccess.Name = "zs_numSuccess";
        	this.zs_numSuccess.Size = new System.Drawing.Size(52, 21);
        	this.zs_numSuccess.TabIndex = 44;
        	this.toolTip.SetToolTip(this.zs_numSuccess, "Likelihood that /buy revive will disinfect a zombie");
        	this.zs_numSuccess.Value = new decimal(new int[] {
			3,
			0,
			0,
			0});
        	// 
        	// zs_lblReviveRound
        	// 
        	this.zs_lblReviveRound.AutoSize = true;
        	this.zs_lblReviveRound.Location = new System.Drawing.Point(88, 19);
        	this.zs_lblReviveRound.Name = "zs_lblReviveRound";
        	this.zs_lblReviveRound.Size = new System.Drawing.Size(81, 13);
        	this.zs_lblReviveRound.TabIndex = 34;
        	this.zs_lblReviveRound.Text = "times per round";
        	// 
        	// zs_lblReviveLimitFtr
        	// 
        	this.zs_lblReviveLimitFtr.AutoSize = true;
        	this.zs_lblReviveLimitFtr.Location = new System.Drawing.Point(161, 46);
        	this.zs_lblReviveLimitFtr.Name = "zs_lblReviveLimitFtr";
        	this.zs_lblReviveLimitFtr.Size = new System.Drawing.Size(59, 13);
        	this.zs_lblReviveLimitFtr.TabIndex = 38;
        	this.zs_lblReviveLimitFtr.Text = "of infection";
        	// 
        	// zs_lblReviveLimitHdr
        	// 
        	this.zs_lblReviveLimitHdr.AutoSize = true;
        	this.zs_lblReviveLimitHdr.Location = new System.Drawing.Point(7, 46);
        	this.zs_lblReviveLimitHdr.Name = "zs_lblReviveLimitHdr";
        	this.zs_lblReviveLimitHdr.Size = new System.Drawing.Size(102, 13);
        	this.zs_lblReviveLimitHdr.TabIndex = 36;
        	this.zs_lblReviveLimitHdr.Text = "Must be used within";
        	// 
        	// zs_numReviveMax
        	// 
        	this.zs_numReviveMax.BackColor = System.Drawing.SystemColors.Window;
        	this.zs_numReviveMax.Location = new System.Drawing.Point(35, 17);
        	this.zs_numReviveMax.Name = "zs_numReviveMax";
        	this.zs_numReviveMax.Size = new System.Drawing.Size(52, 21);
        	this.zs_numReviveMax.TabIndex = 34;
        	// 
        	// zs_lblReviveMax
        	// 
        	this.zs_lblReviveMax.AutoSize = true;
        	this.zs_lblReviveMax.Location = new System.Drawing.Point(6, 20);
        	this.zs_lblReviveMax.Name = "zs_lblReviveMax";
        	this.zs_lblReviveMax.Size = new System.Drawing.Size(27, 13);
        	this.zs_lblReviveMax.TabIndex = 34;
        	this.zs_lblReviveMax.Text = "Max";
        	// 
        	// zs_grpInvHuman
        	// 
        	this.zs_grpInvHuman.Controls.Add(this.zs_numInvHumanSecs);
        	this.zs_grpInvHuman.Controls.Add(this.zs_numInvHumanMax);
        	this.zs_grpInvHuman.Controls.Add(this.zs_lblInvHumanDur);
        	this.zs_grpInvHuman.Controls.Add(this.zs_lblInvHumanMax);
        	this.zs_grpInvHuman.Location = new System.Drawing.Point(6, 157);
        	this.zs_grpInvHuman.Name = "zs_grpInvHuman";
        	this.zs_grpInvHuman.Size = new System.Drawing.Size(245, 49);
        	this.zs_grpInvHuman.TabIndex = 41;
        	this.zs_grpInvHuman.TabStop = false;
        	this.zs_grpInvHuman.Text = "Human invisibility settings";
        	// 
        	// zs_numInvHumanSecs
        	// 
        	this.zs_numInvHumanSecs.BackColor = System.Drawing.SystemColors.Window;
        	this.zs_numInvHumanSecs.Location = new System.Drawing.Point(186, 20);
        	this.zs_numInvHumanSecs.Name = "zs_numInvHumanSecs";
        	this.zs_numInvHumanSecs.Seconds = ((long)(0));
        	this.zs_numInvHumanSecs.Size = new System.Drawing.Size(52, 21);
        	this.zs_numInvHumanSecs.TabIndex = 46;
        	this.zs_numInvHumanSecs.Text = "0s";
        	this.zs_numInvHumanSecs.Value = System.TimeSpan.Parse("00:00:00");
        	// 
        	// zs_numInvHumanMax
        	// 
        	this.zs_numInvHumanMax.BackColor = System.Drawing.SystemColors.Window;
        	this.zs_numInvHumanMax.Location = new System.Drawing.Point(35, 20);
        	this.zs_numInvHumanMax.Name = "zs_numInvHumanMax";
        	this.zs_numInvHumanMax.Size = new System.Drawing.Size(52, 21);
        	this.zs_numInvHumanMax.TabIndex = 27;
        	this.toolTip.SetToolTip(this.zs_numInvHumanMax, "Maximum number of times a human can use /buy invisibility in a round");
        	// 
        	// zs_lblInvHumanDur
        	// 
        	this.zs_lblInvHumanDur.AutoSize = true;
        	this.zs_lblInvHumanDur.Location = new System.Drawing.Point(87, 22);
        	this.zs_lblInvHumanDur.Name = "zs_lblInvHumanDur";
        	this.zs_lblInvHumanDur.Size = new System.Drawing.Size(101, 13);
        	this.zs_lblInvHumanDur.TabIndex = 28;
        	this.zs_lblInvHumanDur.Text = "times, which last for";
        	// 
        	// zs_lblInvHumanMax
        	// 
        	this.zs_lblInvHumanMax.AutoSize = true;
        	this.zs_lblInvHumanMax.Location = new System.Drawing.Point(7, 23);
        	this.zs_lblInvHumanMax.Name = "zs_lblInvHumanMax";
        	this.zs_lblInvHumanMax.Size = new System.Drawing.Size(27, 13);
        	this.zs_lblInvHumanMax.TabIndex = 27;
        	this.zs_lblInvHumanMax.Text = "Max";
        	// 
        	// zs_grpControls
        	// 
        	this.zs_grpControls.Controls.Add(this.zs_btnEnd);
        	this.zs_grpControls.Controls.Add(this.zs_btnStop);
        	this.zs_grpControls.Controls.Add(this.zs_btnStart);
        	this.zs_grpControls.Location = new System.Drawing.Point(196, 5);
        	this.zs_grpControls.Name = "zs_grpControls";
        	this.zs_grpControls.Size = new System.Drawing.Size(279, 51);
        	this.zs_grpControls.TabIndex = 4;
        	this.zs_grpControls.TabStop = false;
        	this.zs_grpControls.Text = "Controls";
        	// 
        	// zs_btnEnd
        	// 
        	this.zs_btnEnd.Location = new System.Drawing.Point(190, 19);
        	this.zs_btnEnd.Name = "zs_btnEnd";
        	this.zs_btnEnd.Size = new System.Drawing.Size(80, 23);
        	this.zs_btnEnd.TabIndex = 2;
        	this.zs_btnEnd.Text = "End Round";
        	this.zs_btnEnd.UseVisualStyleBackColor = true;
        	// 
        	// zs_btnStop
        	// 
        	this.zs_btnStop.Location = new System.Drawing.Point(100, 19);
        	this.zs_btnStop.Name = "zs_btnStop";
        	this.zs_btnStop.Size = new System.Drawing.Size(80, 23);
        	this.zs_btnStop.TabIndex = 1;
        	this.zs_btnStop.Text = "Stop Game";
        	this.zs_btnStop.UseVisualStyleBackColor = true;
        	// 
        	// zs_btnStart
        	// 
        	this.zs_btnStart.Location = new System.Drawing.Point(10, 19);
        	this.zs_btnStart.Name = "zs_btnStart";
        	this.zs_btnStart.Size = new System.Drawing.Size(80, 23);
        	this.zs_btnStart.TabIndex = 0;
        	this.zs_btnStart.Text = "Start Game";
        	this.zs_btnStart.UseVisualStyleBackColor = true;
        	// 
        	// zs_grpMap
        	// 
        	this.zs_grpMap.Controls.Add(this.zs_grpTime);
        	this.zs_grpMap.Enabled = false;
        	this.zs_grpMap.Location = new System.Drawing.Point(440, 65);
        	this.zs_grpMap.Name = "zs_grpMap";
        	this.zs_grpMap.Size = new System.Drawing.Size(307, 97);
        	this.zs_grpMap.TabIndex = 3;
        	this.zs_grpMap.TabStop = false;
        	this.zs_grpMap.Text = "Settings for (none selected)";
        	// 
        	// zs_grpTime
        	// 
        	this.zs_grpTime.Controls.Add(this.zs_numFloodTime);
        	this.zs_grpTime.Controls.Add(this.zs_numLayerTime);
        	this.zs_grpTime.Controls.Add(this.zs_numRoundTime);
        	this.zs_grpTime.Controls.Add(this.zs_lblLayerTime);
        	this.zs_grpTime.Controls.Add(this.zs_lblFloodTime);
        	this.zs_grpTime.Controls.Add(this.zs_lblRoundTime);
        	this.zs_grpTime.Location = new System.Drawing.Point(6, 16);
        	this.zs_grpTime.Name = "zs_grpTime";
        	this.zs_grpTime.Size = new System.Drawing.Size(295, 71);
        	this.zs_grpTime.TabIndex = 39;
        	this.zs_grpTime.TabStop = false;
        	this.zs_grpTime.Text = "Time settings";
        	// 
        	// zs_numFloodTime
        	// 
        	this.zs_numFloodTime.BackColor = System.Drawing.SystemColors.Window;
        	this.zs_numFloodTime.Location = new System.Drawing.Point(69, 43);
        	this.zs_numFloodTime.Name = "zs_numFloodTime";
        	this.zs_numFloodTime.Seconds = ((long)(300));
        	this.zs_numFloodTime.Size = new System.Drawing.Size(62, 21);
        	this.zs_numFloodTime.TabIndex = 38;
        	this.zs_numFloodTime.Text = "5m";
        	this.zs_numFloodTime.Value = System.TimeSpan.Parse("00:05:00");
        	// 
        	// zs_numLayerTime
        	// 
        	this.zs_numLayerTime.BackColor = System.Drawing.SystemColors.Window;
        	this.zs_numLayerTime.Location = new System.Drawing.Point(225, 16);
        	this.zs_numLayerTime.Name = "zs_numLayerTime";
        	this.zs_numLayerTime.Seconds = ((long)(120));
        	this.zs_numLayerTime.Size = new System.Drawing.Size(62, 21);
        	this.zs_numLayerTime.TabIndex = 37;
        	this.zs_numLayerTime.Text = "2m";
        	this.zs_numLayerTime.Value = System.TimeSpan.Parse("00:02:00");
        	// 
        	// zs_numRoundTime
        	// 
        	this.zs_numRoundTime.BackColor = System.Drawing.SystemColors.Window;
        	this.zs_numRoundTime.Location = new System.Drawing.Point(69, 16);
        	this.zs_numRoundTime.Name = "zs_numRoundTime";
        	this.zs_numRoundTime.Seconds = ((long)(900));
        	this.zs_numRoundTime.Size = new System.Drawing.Size(62, 21);
        	this.zs_numRoundTime.TabIndex = 36;
        	this.zs_numRoundTime.Text = "15m";
        	this.zs_numRoundTime.Value = System.TimeSpan.Parse("00:15:00");
        	// 
        	// zs_lblLayerTime
        	// 
        	this.zs_lblLayerTime.AutoSize = true;
        	this.zs_lblLayerTime.Location = new System.Drawing.Point(160, 20);
        	this.zs_lblLayerTime.Name = "zs_lblLayerTime";
        	this.zs_lblLayerTime.Size = new System.Drawing.Size(59, 13);
        	this.zs_lblLayerTime.TabIndex = 35;
        	this.zs_lblLayerTime.Text = "Layer time:";
        	// 
        	// zs_lblFloodTime
        	// 
        	this.zs_lblFloodTime.AutoSize = true;
        	this.zs_lblFloodTime.Location = new System.Drawing.Point(8, 46);
        	this.zs_lblFloodTime.Name = "zs_lblFloodTime";
        	this.zs_lblFloodTime.Size = new System.Drawing.Size(59, 13);
        	this.zs_lblFloodTime.TabIndex = 34;
        	this.zs_lblFloodTime.Text = "Flood time:";
        	// 
        	// zs_lblRoundTime
        	// 
        	this.zs_lblRoundTime.AutoSize = true;
        	this.zs_lblRoundTime.Location = new System.Drawing.Point(5, 20);
        	this.zs_lblRoundTime.Name = "zs_lblRoundTime";
        	this.zs_lblRoundTime.Size = new System.Drawing.Size(63, 13);
        	this.zs_lblRoundTime.TabIndex = 34;
        	this.zs_lblRoundTime.Text = "Round time:";
        	// 
        	// zs_grpSettings
        	// 
        	this.zs_grpSettings.Controls.Add(this.zs_cbMain);
        	this.zs_grpSettings.Controls.Add(this.zs_cbMap);
        	this.zs_grpSettings.Controls.Add(this.zs_cbStart);
        	this.zs_grpSettings.Location = new System.Drawing.Point(3, 65);
        	this.zs_grpSettings.Name = "zs_grpSettings";
        	this.zs_grpSettings.Size = new System.Drawing.Size(248, 88);
        	this.zs_grpSettings.TabIndex = 2;
        	this.zs_grpSettings.TabStop = false;
        	this.zs_grpSettings.Text = "General settings";
        	// 
        	// zs_cbMain
        	// 
        	this.zs_cbMain.AutoSize = true;
        	this.zs_cbMain.Location = new System.Drawing.Point(11, 66);
        	this.zs_cbMain.Name = "zs_cbMain";
        	this.zs_cbMain.Size = new System.Drawing.Size(112, 17);
        	this.zs_cbMain.TabIndex = 24;
        	this.zs_cbMain.Text = "Change main level";
        	this.zs_cbMain.UseVisualStyleBackColor = true;
        	// 
        	// zs_cbMap
        	// 
        	this.zs_cbMap.AutoSize = true;
        	this.zs_cbMap.Location = new System.Drawing.Point(11, 43);
        	this.zs_cbMap.Name = "zs_cbMap";
        	this.zs_cbMap.Size = new System.Drawing.Size(136, 17);
        	this.zs_cbMap.TabIndex = 23;
        	this.zs_cbMap.Text = "Map name in server list";
        	this.zs_cbMap.UseVisualStyleBackColor = true;
        	// 
        	// zs_cbStart
        	// 
        	this.zs_cbStart.AutoSize = true;
        	this.zs_cbStart.Location = new System.Drawing.Point(11, 20);
        	this.zs_cbStart.Name = "zs_cbStart";
        	this.zs_cbStart.Size = new System.Drawing.Size(139, 17);
        	this.zs_cbStart.TabIndex = 22;
        	this.zs_cbStart.Text = "Start when server starts";
        	this.zs_cbStart.UseVisualStyleBackColor = true;
        	// 
        	// zs_grpMaps
        	// 
        	this.zs_grpMaps.Controls.Add(this.zs_lblNotUsed);
        	this.zs_grpMaps.Controls.Add(this.zs_lblUsed);
        	this.zs_grpMaps.Controls.Add(this.zs_btnAdd);
        	this.zs_grpMaps.Controls.Add(this.zs_btnRemove);
        	this.zs_grpMaps.Controls.Add(this.zs_lstNotUsed);
        	this.zs_grpMaps.Controls.Add(this.zs_lstUsed);
        	this.zs_grpMaps.Location = new System.Drawing.Point(264, 65);
        	this.zs_grpMaps.Name = "zs_grpMaps";
        	this.zs_grpMaps.Size = new System.Drawing.Size(170, 388);
        	this.zs_grpMaps.TabIndex = 1;
        	this.zs_grpMaps.TabStop = false;
        	this.zs_grpMaps.Text = "Maps";
        	// 
        	// zs_lblNotUsed
        	// 
        	this.zs_lblNotUsed.AutoSize = true;
        	this.zs_lblNotUsed.Location = new System.Drawing.Point(187, 17);
        	this.zs_lblNotUsed.Name = "zs_lblNotUsed";
        	this.zs_lblNotUsed.Size = new System.Drawing.Size(83, 13);
        	this.zs_lblNotUsed.TabIndex = 6;
        	this.zs_lblNotUsed.Text = "Maps Not In Use";
        	// 
        	// zs_lblUsed
        	// 
        	this.zs_lblUsed.AutoSize = true;
        	this.zs_lblUsed.Location = new System.Drawing.Point(6, 17);
        	this.zs_lblUsed.Name = "zs_lblUsed";
        	this.zs_lblUsed.Size = new System.Drawing.Size(38, 13);
        	this.zs_lblUsed.TabIndex = 5;
        	this.zs_lblUsed.Text = "In use:";
        	// 
        	// zs_btnAdd
        	// 
        	this.zs_btnAdd.Location = new System.Drawing.Point(6, 188);
        	this.zs_btnAdd.Name = "zs_btnAdd";
        	this.zs_btnAdd.Size = new System.Drawing.Size(77, 23);
        	this.zs_btnAdd.TabIndex = 4;
        	this.zs_btnAdd.Text = "<< Add";
        	this.zs_btnAdd.UseVisualStyleBackColor = true;
        	// 
        	// zs_btnRemove
        	// 
        	this.zs_btnRemove.Location = new System.Drawing.Point(89, 188);
        	this.zs_btnRemove.Name = "zs_btnRemove";
        	this.zs_btnRemove.Size = new System.Drawing.Size(75, 23);
        	this.zs_btnRemove.TabIndex = 3;
        	this.zs_btnRemove.Text = "Remove >>";
        	this.zs_btnRemove.UseVisualStyleBackColor = true;
        	// 
        	// zs_lstNotUsed
        	// 
        	this.zs_lstNotUsed.BackColor = System.Drawing.SystemColors.Window;
        	this.zs_lstNotUsed.FormattingEnabled = true;
        	this.zs_lstNotUsed.Location = new System.Drawing.Point(6, 219);
        	this.zs_lstNotUsed.Name = "zs_lstNotUsed";
        	this.zs_lstNotUsed.Size = new System.Drawing.Size(158, 160);
        	this.zs_lstNotUsed.TabIndex = 2;
        	// 
        	// zs_lstUsed
        	// 
        	this.zs_lstUsed.BackColor = System.Drawing.SystemColors.Window;
        	this.zs_lstUsed.FormattingEnabled = true;
        	this.zs_lstUsed.Location = new System.Drawing.Point(6, 33);
        	this.zs_lstUsed.Name = "zs_lstUsed";
        	this.zs_lstUsed.Size = new System.Drawing.Size(158, 147);
        	this.zs_lstUsed.TabIndex = 0;
        	// 
        	// tabCTF
        	// 
        	this.tabCTF.BackColor = System.Drawing.SystemColors.Control;
        	this.tabCTF.Controls.Add(this.ctf_grpControls);
        	this.tabCTF.Controls.Add(this.ctf_grpSettings);
        	this.tabCTF.Controls.Add(this.ctf_grpMaps);
        	this.tabCTF.Location = new System.Drawing.Point(4, 22);
        	this.tabCTF.Name = "tabCTF";
        	this.tabCTF.Size = new System.Drawing.Size(753, 489);
        	this.tabCTF.TabIndex = 8;
        	this.tabCTF.Text = "CTF";
        	// 
        	// ctf_grpControls
        	// 
        	this.ctf_grpControls.Controls.Add(this.ctf_btnEnd);
        	this.ctf_grpControls.Controls.Add(this.ctf_btnStop);
        	this.ctf_grpControls.Controls.Add(this.ctf_btnStart);
        	this.ctf_grpControls.Location = new System.Drawing.Point(227, 3);
        	this.ctf_grpControls.Name = "ctf_grpControls";
        	this.ctf_grpControls.Size = new System.Drawing.Size(279, 51);
        	this.ctf_grpControls.TabIndex = 7;
        	this.ctf_grpControls.TabStop = false;
        	this.ctf_grpControls.Text = "Controls";
        	// 
        	// ctf_btnEnd
        	// 
        	this.ctf_btnEnd.Location = new System.Drawing.Point(190, 19);
        	this.ctf_btnEnd.Name = "ctf_btnEnd";
        	this.ctf_btnEnd.Size = new System.Drawing.Size(80, 23);
        	this.ctf_btnEnd.TabIndex = 2;
        	this.ctf_btnEnd.Text = "End Round";
        	this.ctf_btnEnd.UseVisualStyleBackColor = true;
        	// 
        	// ctf_btnStop
        	// 
        	this.ctf_btnStop.Location = new System.Drawing.Point(100, 19);
        	this.ctf_btnStop.Name = "ctf_btnStop";
        	this.ctf_btnStop.Size = new System.Drawing.Size(80, 23);
        	this.ctf_btnStop.TabIndex = 1;
        	this.ctf_btnStop.Text = "Stop Game";
        	this.ctf_btnStop.UseVisualStyleBackColor = true;
        	// 
        	// ctf_btnStart
        	// 
        	this.ctf_btnStart.Location = new System.Drawing.Point(10, 19);
        	this.ctf_btnStart.Name = "ctf_btnStart";
        	this.ctf_btnStart.Size = new System.Drawing.Size(80, 23);
        	this.ctf_btnStart.TabIndex = 0;
        	this.ctf_btnStart.Text = "Start Game";
        	this.ctf_btnStart.UseVisualStyleBackColor = true;
        	// 
        	// ctf_grpSettings
        	// 
        	this.ctf_grpSettings.Controls.Add(this.ctf_cbMain);
        	this.ctf_grpSettings.Controls.Add(this.ctf_cbMap);
        	this.ctf_grpSettings.Controls.Add(this.ctf_cbStart);
        	this.ctf_grpSettings.Location = new System.Drawing.Point(182, 59);
        	this.ctf_grpSettings.Name = "ctf_grpSettings";
        	this.ctf_grpSettings.Size = new System.Drawing.Size(296, 89);
        	this.ctf_grpSettings.TabIndex = 6;
        	this.ctf_grpSettings.TabStop = false;
        	this.ctf_grpSettings.Text = "Settings";
        	// 
        	// ctf_cbMain
        	// 
        	this.ctf_cbMain.AutoSize = true;
        	this.ctf_cbMain.Location = new System.Drawing.Point(11, 66);
        	this.ctf_cbMain.Name = "ctf_cbMain";
        	this.ctf_cbMain.Size = new System.Drawing.Size(112, 17);
        	this.ctf_cbMain.TabIndex = 24;
        	this.ctf_cbMain.Text = "Change main level";
        	this.ctf_cbMain.UseVisualStyleBackColor = true;
        	// 
        	// ctf_cbMap
        	// 
        	this.ctf_cbMap.AutoSize = true;
        	this.ctf_cbMap.Location = new System.Drawing.Point(11, 43);
        	this.ctf_cbMap.Name = "ctf_cbMap";
        	this.ctf_cbMap.Size = new System.Drawing.Size(136, 17);
        	this.ctf_cbMap.TabIndex = 23;
        	this.ctf_cbMap.Text = "Map name in server list";
        	this.ctf_cbMap.UseVisualStyleBackColor = true;
        	// 
        	// ctf_cbStart
        	// 
        	this.ctf_cbStart.AutoSize = true;
        	this.ctf_cbStart.Location = new System.Drawing.Point(11, 20);
        	this.ctf_cbStart.Name = "ctf_cbStart";
        	this.ctf_cbStart.Size = new System.Drawing.Size(139, 17);
        	this.ctf_cbStart.TabIndex = 22;
        	this.ctf_cbStart.Text = "Start when server starts";
        	this.ctf_cbStart.UseVisualStyleBackColor = true;
        	// 
        	// ctf_grpMaps
        	// 
        	this.ctf_grpMaps.Controls.Add(this.ctf_lblNotUsed);
        	this.ctf_grpMaps.Controls.Add(this.ctf_lblUsed);
        	this.ctf_grpMaps.Controls.Add(this.ctf_btnAdd);
        	this.ctf_grpMaps.Controls.Add(this.ctf_btnRemove);
        	this.ctf_grpMaps.Controls.Add(this.ctf_lstNotUsed);
        	this.ctf_grpMaps.Controls.Add(this.ctf_lstUsed);
        	this.ctf_grpMaps.Location = new System.Drawing.Point(6, 59);
        	this.ctf_grpMaps.Name = "ctf_grpMaps";
        	this.ctf_grpMaps.Size = new System.Drawing.Size(170, 401);
        	this.ctf_grpMaps.TabIndex = 5;
        	this.ctf_grpMaps.TabStop = false;
        	this.ctf_grpMaps.Text = "Maps";
        	// 
        	// ctf_lblNotUsed
        	// 
        	this.ctf_lblNotUsed.AutoSize = true;
        	this.ctf_lblNotUsed.Location = new System.Drawing.Point(187, 17);
        	this.ctf_lblNotUsed.Name = "ctf_lblNotUsed";
        	this.ctf_lblNotUsed.Size = new System.Drawing.Size(83, 13);
        	this.ctf_lblNotUsed.TabIndex = 6;
        	this.ctf_lblNotUsed.Text = "Maps Not In Use";
        	// 
        	// ctf_lblUsed
        	// 
        	this.ctf_lblUsed.AutoSize = true;
        	this.ctf_lblUsed.Location = new System.Drawing.Point(6, 17);
        	this.ctf_lblUsed.Name = "ctf_lblUsed";
        	this.ctf_lblUsed.Size = new System.Drawing.Size(38, 13);
        	this.ctf_lblUsed.TabIndex = 5;
        	this.ctf_lblUsed.Text = "In use:";
        	// 
        	// ctf_btnAdd
        	// 
        	this.ctf_btnAdd.Location = new System.Drawing.Point(6, 188);
        	this.ctf_btnAdd.Name = "ctf_btnAdd";
        	this.ctf_btnAdd.Size = new System.Drawing.Size(77, 23);
        	this.ctf_btnAdd.TabIndex = 4;
        	this.ctf_btnAdd.Text = "<< Add";
        	this.ctf_btnAdd.UseVisualStyleBackColor = true;
        	// 
        	// ctf_btnRemove
        	// 
        	this.ctf_btnRemove.Location = new System.Drawing.Point(89, 188);
        	this.ctf_btnRemove.Name = "ctf_btnRemove";
        	this.ctf_btnRemove.Size = new System.Drawing.Size(75, 23);
        	this.ctf_btnRemove.TabIndex = 3;
        	this.ctf_btnRemove.Text = "Remove >>";
        	this.ctf_btnRemove.UseVisualStyleBackColor = true;
        	// 
        	// ctf_lstNotUsed
        	// 
        	this.ctf_lstNotUsed.BackColor = System.Drawing.SystemColors.Window;
        	this.ctf_lstNotUsed.FormattingEnabled = true;
        	this.ctf_lstNotUsed.Location = new System.Drawing.Point(6, 219);
        	this.ctf_lstNotUsed.Name = "ctf_lstNotUsed";
        	this.ctf_lstNotUsed.Size = new System.Drawing.Size(158, 173);
        	this.ctf_lstNotUsed.TabIndex = 2;
        	// 
        	// ctf_lstUsed
        	// 
        	this.ctf_lstUsed.BackColor = System.Drawing.SystemColors.Window;
        	this.ctf_lstUsed.FormattingEnabled = true;
        	this.ctf_lstUsed.Location = new System.Drawing.Point(6, 33);
        	this.ctf_lstUsed.Name = "ctf_lstUsed";
        	this.ctf_lstUsed.Size = new System.Drawing.Size(158, 147);
        	this.ctf_lstUsed.TabIndex = 0;
        	// 
        	// tabTW
        	// 
        	this.tabTW.BackColor = System.Drawing.SystemColors.Control;
        	this.tabTW.Controls.Add(this.tw_grpControls);
        	this.tabTW.Controls.Add(this.tw_grpMapSettings);
        	this.tabTW.Controls.Add(this.tw_grpSettings);
        	this.tabTW.Controls.Add(this.tw_gbMaps);
        	this.tabTW.Location = new System.Drawing.Point(4, 22);
        	this.tabTW.Name = "tabTW";
        	this.tabTW.Size = new System.Drawing.Size(753, 489);
        	this.tabTW.TabIndex = 9;
        	this.tabTW.Text = "TNT Wars";
        	// 
        	// tw_grpControls
        	// 
        	this.tw_grpControls.Controls.Add(this.tw_btnEnd);
        	this.tw_grpControls.Controls.Add(this.tw_btnStop);
        	this.tw_grpControls.Controls.Add(this.tw_btnStart);
        	this.tw_grpControls.Location = new System.Drawing.Point(231, 3);
        	this.tw_grpControls.Name = "tw_grpControls";
        	this.tw_grpControls.Size = new System.Drawing.Size(279, 51);
        	this.tw_grpControls.TabIndex = 8;
        	this.tw_grpControls.TabStop = false;
        	this.tw_grpControls.Text = "Controls";
        	// 
        	// tw_btnEnd
        	// 
        	this.tw_btnEnd.Location = new System.Drawing.Point(190, 19);
        	this.tw_btnEnd.Name = "tw_btnEnd";
        	this.tw_btnEnd.Size = new System.Drawing.Size(80, 23);
        	this.tw_btnEnd.TabIndex = 2;
        	this.tw_btnEnd.Text = "End Round";
        	this.tw_btnEnd.UseVisualStyleBackColor = true;
        	// 
        	// tw_btnStop
        	// 
        	this.tw_btnStop.Location = new System.Drawing.Point(100, 19);
        	this.tw_btnStop.Name = "tw_btnStop";
        	this.tw_btnStop.Size = new System.Drawing.Size(80, 23);
        	this.tw_btnStop.TabIndex = 1;
        	this.tw_btnStop.Text = "Stop Game";
        	this.tw_btnStop.UseVisualStyleBackColor = true;
        	// 
        	// tw_btnStart
        	// 
        	this.tw_btnStart.Location = new System.Drawing.Point(10, 19);
        	this.tw_btnStart.Name = "tw_btnStart";
        	this.tw_btnStart.Size = new System.Drawing.Size(80, 23);
        	this.tw_btnStart.TabIndex = 0;
        	this.tw_btnStart.Text = "Start Game";
        	this.tw_btnStart.UseVisualStyleBackColor = true;
        	// 
        	// tw_grpMapSettings
        	// 
        	this.tw_grpMapSettings.Controls.Add(this.tw_grpTeams);
        	this.tw_grpMapSettings.Controls.Add(this.tw_grpGrace);
        	this.tw_grpMapSettings.Controls.Add(this.tw_grpScores);
        	this.tw_grpMapSettings.Enabled = false;
        	this.tw_grpMapSettings.Location = new System.Drawing.Point(182, 213);
        	this.tw_grpMapSettings.Name = "tw_grpMapSettings";
        	this.tw_grpMapSettings.Size = new System.Drawing.Size(296, 207);
        	this.tw_grpMapSettings.TabIndex = 7;
        	this.tw_grpMapSettings.TabStop = false;
        	this.tw_grpMapSettings.Text = "Map Settings";
        	// 
        	// tw_grpTeams
        	// 
        	this.tw_grpTeams.Controls.Add(this.tw_cbKills);
        	this.tw_grpTeams.Controls.Add(this.tw_cbBalance);
        	this.tw_grpTeams.Location = new System.Drawing.Point(172, 125);
        	this.tw_grpTeams.Name = "tw_grpTeams";
        	this.tw_grpTeams.Size = new System.Drawing.Size(118, 73);
        	this.tw_grpTeams.TabIndex = 8;
        	this.tw_grpTeams.TabStop = false;
        	this.tw_grpTeams.Text = "Teams:";
        	// 
        	// tw_cbKills
        	// 
        	this.tw_cbKills.AutoSize = true;
        	this.tw_cbKills.Location = new System.Drawing.Point(6, 43);
        	this.tw_cbKills.Name = "tw_cbKills";
        	this.tw_cbKills.Size = new System.Drawing.Size(81, 17);
        	this.tw_cbKills.TabIndex = 2;
        	this.tw_cbKills.Text = "Team killing";
        	this.tw_cbKills.UseVisualStyleBackColor = true;
        	// 
        	// tw_cbBalance
        	// 
        	this.tw_cbBalance.AutoSize = true;
        	this.tw_cbBalance.Checked = true;
        	this.tw_cbBalance.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.tw_cbBalance.Location = new System.Drawing.Point(6, 20);
        	this.tw_cbBalance.Name = "tw_cbBalance";
        	this.tw_cbBalance.Size = new System.Drawing.Size(96, 17);
        	this.tw_cbBalance.TabIndex = 1;
        	this.tw_cbBalance.Text = "Balance teams";
        	this.tw_cbBalance.UseVisualStyleBackColor = true;
        	// 
        	// tw_grpGrace
        	// 
        	this.tw_grpGrace.Controls.Add(this.tw_numGrace);
        	this.tw_grpGrace.Controls.Add(this.tw_lblGrace);
        	this.tw_grpGrace.Controls.Add(this.tw_cbGrace);
        	this.tw_grpGrace.Location = new System.Drawing.Point(6, 125);
        	this.tw_grpGrace.Name = "tw_grpGrace";
        	this.tw_grpGrace.Size = new System.Drawing.Size(160, 73);
        	this.tw_grpGrace.TabIndex = 7;
        	this.tw_grpGrace.TabStop = false;
        	this.tw_grpGrace.Text = "Grace Period";
        	// 
        	// tw_numGrace
        	// 
        	this.tw_numGrace.BackColor = System.Drawing.SystemColors.Window;
        	this.tw_numGrace.Location = new System.Drawing.Point(59, 41);
        	this.tw_numGrace.Name = "tw_numGrace";
        	this.tw_numGrace.Seconds = ((long)(30));
        	this.tw_numGrace.Size = new System.Drawing.Size(66, 21);
        	this.tw_numGrace.TabIndex = 35;
        	this.tw_numGrace.Text = "30s";
        	this.tw_numGrace.Value = System.TimeSpan.Parse("00:00:30");
        	// 
        	// tw_lblGrace
        	// 
        	this.tw_lblGrace.AutoSize = true;
        	this.tw_lblGrace.Location = new System.Drawing.Point(23, 44);
        	this.tw_lblGrace.Name = "tw_lblGrace";
        	this.tw_lblGrace.Size = new System.Drawing.Size(33, 13);
        	this.tw_lblGrace.TabIndex = 2;
        	this.tw_lblGrace.Text = "Time:";
        	// 
        	// tw_cbGrace
        	// 
        	this.tw_cbGrace.AutoSize = true;
        	this.tw_cbGrace.Checked = true;
        	this.tw_cbGrace.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.tw_cbGrace.Location = new System.Drawing.Point(6, 20);
        	this.tw_cbGrace.Name = "tw_cbGrace";
        	this.tw_cbGrace.Size = new System.Drawing.Size(64, 17);
        	this.tw_cbGrace.TabIndex = 0;
        	this.tw_cbGrace.Text = "Enabled";
        	this.tw_cbGrace.UseVisualStyleBackColor = true;
        	// 
        	// tw_grpScores
        	// 
        	this.tw_grpScores.Controls.Add(this.tw_lblMulti);
        	this.tw_grpScores.Controls.Add(this.tw_lblAssist);
        	this.tw_grpScores.Controls.Add(this.tw_cbStreaks);
        	this.tw_grpScores.Controls.Add(this.tw_numMultiKills);
        	this.tw_grpScores.Controls.Add(this.tw_numScoreAssists);
        	this.tw_grpScores.Controls.Add(this.tw_lblScorePerKill);
        	this.tw_grpScores.Controls.Add(this.tw_numScorePerKill);
        	this.tw_grpScores.Controls.Add(this.tw_lblScoreLimit);
        	this.tw_grpScores.Controls.Add(this.tw_numScoreLimit);
        	this.tw_grpScores.Location = new System.Drawing.Point(6, 20);
        	this.tw_grpScores.Name = "tw_grpScores";
        	this.tw_grpScores.Size = new System.Drawing.Size(284, 99);
        	this.tw_grpScores.TabIndex = 6;
        	this.tw_grpScores.TabStop = false;
        	this.tw_grpScores.Text = "Scores";
        	// 
        	// tw_lblMulti
        	// 
        	this.tw_lblMulti.AutoSize = true;
        	this.tw_lblMulti.Location = new System.Drawing.Point(157, 47);
        	this.tw_lblMulti.Name = "tw_lblMulti";
        	this.tw_lblMulti.Size = new System.Drawing.Size(79, 13);
        	this.tw_lblMulti.TabIndex = 10;
        	this.tw_lblMulti.Text = "Multikill bonus:";
        	// 
        	// tw_lblAssist
        	// 
        	this.tw_lblAssist.AutoSize = true;
        	this.tw_lblAssist.Location = new System.Drawing.Point(168, 20);
        	this.tw_lblAssist.Name = "tw_lblAssist";
        	this.tw_lblAssist.Size = new System.Drawing.Size(69, 13);
        	this.tw_lblAssist.TabIndex = 9;
        	this.tw_lblAssist.Text = "Assist bonus:";
        	// 
        	// tw_cbStreaks
        	// 
        	this.tw_cbStreaks.AutoSize = true;
        	this.tw_cbStreaks.Checked = true;
        	this.tw_cbStreaks.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.tw_cbStreaks.Location = new System.Drawing.Point(11, 72);
        	this.tw_cbStreaks.Name = "tw_cbStreaks";
        	this.tw_cbStreaks.Size = new System.Drawing.Size(61, 17);
        	this.tw_cbStreaks.TabIndex = 0;
        	this.tw_cbStreaks.Text = "Streaks";
        	this.tw_cbStreaks.UseVisualStyleBackColor = true;
        	// 
        	// tw_numMultiKills
        	// 
        	this.tw_numMultiKills.BackColor = System.Drawing.SystemColors.Window;
        	this.tw_numMultiKills.Location = new System.Drawing.Point(240, 44);
        	this.tw_numMultiKills.Maximum = new decimal(new int[] {
			100000,
			0,
			0,
			0});
        	this.tw_numMultiKills.Name = "tw_numMultiKills";
        	this.tw_numMultiKills.Size = new System.Drawing.Size(38, 21);
        	this.tw_numMultiKills.TabIndex = 7;
        	this.tw_numMultiKills.Value = new decimal(new int[] {
			5,
			0,
			0,
			0});
        	// 
        	// tw_numScoreAssists
        	// 
        	this.tw_numScoreAssists.BackColor = System.Drawing.SystemColors.Window;
        	this.tw_numScoreAssists.Location = new System.Drawing.Point(240, 17);
        	this.tw_numScoreAssists.Maximum = new decimal(new int[] {
			100000,
			0,
			0,
			0});
        	this.tw_numScoreAssists.Name = "tw_numScoreAssists";
        	this.tw_numScoreAssists.Size = new System.Drawing.Size(38, 21);
        	this.tw_numScoreAssists.TabIndex = 4;
        	this.tw_numScoreAssists.Value = new decimal(new int[] {
			5,
			0,
			0,
			0});
        	// 
        	// tw_lblScorePerKill
        	// 
        	this.tw_lblScorePerKill.AutoSize = true;
        	this.tw_lblScorePerKill.Location = new System.Drawing.Point(9, 46);
        	this.tw_lblScorePerKill.Name = "tw_lblScorePerKill";
        	this.tw_lblScorePerKill.Size = new System.Drawing.Size(70, 13);
        	this.tw_lblScorePerKill.TabIndex = 3;
        	this.tw_lblScorePerKill.Text = "Score per kill:";
        	// 
        	// tw_numScorePerKill
        	// 
        	this.tw_numScorePerKill.BackColor = System.Drawing.SystemColors.Window;
        	this.tw_numScorePerKill.Location = new System.Drawing.Point(82, 44);
        	this.tw_numScorePerKill.Maximum = new decimal(new int[] {
			100000,
			0,
			0,
			0});
        	this.tw_numScorePerKill.Name = "tw_numScorePerKill";
        	this.tw_numScorePerKill.Size = new System.Drawing.Size(50, 21);
        	this.tw_numScorePerKill.TabIndex = 2;
        	this.tw_numScorePerKill.Value = new decimal(new int[] {
			10,
			0,
			0,
			0});
        	// 
        	// tw_lblScoreLimit
        	// 
        	this.tw_lblScoreLimit.AutoSize = true;
        	this.tw_lblScoreLimit.Location = new System.Drawing.Point(5, 19);
        	this.tw_lblScoreLimit.Name = "tw_lblScoreLimit";
        	this.tw_lblScoreLimit.Size = new System.Drawing.Size(74, 13);
        	this.tw_lblScoreLimit.TabIndex = 1;
        	this.tw_lblScoreLimit.Text = "Score needed:";
        	// 
        	// tw_numScoreLimit
        	// 
        	this.tw_numScoreLimit.BackColor = System.Drawing.SystemColors.Window;
        	this.tw_numScoreLimit.Location = new System.Drawing.Point(82, 17);
        	this.tw_numScoreLimit.Maximum = new decimal(new int[] {
			100000,
			0,
			0,
			0});
        	this.tw_numScoreLimit.Name = "tw_numScoreLimit";
        	this.tw_numScoreLimit.Size = new System.Drawing.Size(50, 21);
        	this.tw_numScoreLimit.TabIndex = 0;
        	this.tw_numScoreLimit.Value = new decimal(new int[] {
			150,
			0,
			0,
			0});
        	// 
        	// tw_grpSettings
        	// 
        	this.tw_grpSettings.Controls.Add(this.tw_cmbMode);
        	this.tw_grpSettings.Controls.Add(this.tw_cmbDiff);
        	this.tw_grpSettings.Controls.Add(this.tw_lblMode);
        	this.tw_grpSettings.Controls.Add(this.tw_lblDiff);
        	this.tw_grpSettings.Controls.Add(this.tw_cbMain);
        	this.tw_grpSettings.Controls.Add(this.tw_cbMap);
        	this.tw_grpSettings.Controls.Add(this.tw_cbStart);
        	this.tw_grpSettings.Location = new System.Drawing.Point(182, 59);
        	this.tw_grpSettings.Name = "tw_grpSettings";
        	this.tw_grpSettings.Size = new System.Drawing.Size(296, 148);
        	this.tw_grpSettings.TabIndex = 6;
        	this.tw_grpSettings.TabStop = false;
        	this.tw_grpSettings.Text = "Settings";
        	// 
        	// tw_cmbMode
        	// 
        	this.tw_cmbMode.BackColor = System.Drawing.SystemColors.Window;
        	this.tw_cmbMode.FormattingEnabled = true;
        	this.tw_cmbMode.Items.AddRange(new object[] {
			"FFA",
			"TDM"});
        	this.tw_cmbMode.Location = new System.Drawing.Point(74, 116);
        	this.tw_cmbMode.Name = "tw_cmbMode";
        	this.tw_cmbMode.Size = new System.Drawing.Size(76, 21);
        	this.tw_cmbMode.TabIndex = 29;
        	// 
        	// tw_cmbDiff
        	// 
        	this.tw_cmbDiff.BackColor = System.Drawing.SystemColors.Window;
        	this.tw_cmbDiff.FormattingEnabled = true;
        	this.tw_cmbDiff.Items.AddRange(new object[] {
			"Easy",
			"Normal",
			"Hard",
			"Extreme"});
        	this.tw_cmbDiff.Location = new System.Drawing.Point(74, 89);
        	this.tw_cmbDiff.Name = "tw_cmbDiff";
        	this.tw_cmbDiff.Size = new System.Drawing.Size(76, 21);
        	this.tw_cmbDiff.TabIndex = 28;
        	this.toolTip.SetToolTip(this.tw_cmbDiff, resources.GetString("tw_cmbDiff.ToolTip"));
        	// 
        	// tw_lblMode
        	// 
        	this.tw_lblMode.AutoSize = true;
        	this.tw_lblMode.Location = new System.Drawing.Point(8, 119);
        	this.tw_lblMode.Name = "tw_lblMode";
        	this.tw_lblMode.Size = new System.Drawing.Size(65, 13);
        	this.tw_lblMode.TabIndex = 27;
        	this.tw_lblMode.Text = "Gamemode:";
        	// 
        	// tw_lblDiff
        	// 
        	this.tw_lblDiff.AutoSize = true;
        	this.tw_lblDiff.Location = new System.Drawing.Point(21, 94);
        	this.tw_lblDiff.Name = "tw_lblDiff";
        	this.tw_lblDiff.Size = new System.Drawing.Size(52, 13);
        	this.tw_lblDiff.TabIndex = 26;
        	this.tw_lblDiff.Text = "Difficulty:";
        	// 
        	// tw_cbMain
        	// 
        	this.tw_cbMain.AutoSize = true;
        	this.tw_cbMain.Location = new System.Drawing.Point(11, 66);
        	this.tw_cbMain.Name = "tw_cbMain";
        	this.tw_cbMain.Size = new System.Drawing.Size(112, 17);
        	this.tw_cbMain.TabIndex = 24;
        	this.tw_cbMain.Text = "Change main level";
        	this.tw_cbMain.UseVisualStyleBackColor = true;
        	// 
        	// tw_cbMap
        	// 
        	this.tw_cbMap.AutoSize = true;
        	this.tw_cbMap.Location = new System.Drawing.Point(11, 43);
        	this.tw_cbMap.Name = "tw_cbMap";
        	this.tw_cbMap.Size = new System.Drawing.Size(136, 17);
        	this.tw_cbMap.TabIndex = 23;
        	this.tw_cbMap.Text = "Map name in server list";
        	this.tw_cbMap.UseVisualStyleBackColor = true;
        	// 
        	// tw_cbStart
        	// 
        	this.tw_cbStart.AutoSize = true;
        	this.tw_cbStart.Location = new System.Drawing.Point(11, 20);
        	this.tw_cbStart.Name = "tw_cbStart";
        	this.tw_cbStart.Size = new System.Drawing.Size(139, 17);
        	this.tw_cbStart.TabIndex = 22;
        	this.tw_cbStart.Text = "Start when server starts";
        	this.tw_cbStart.UseVisualStyleBackColor = true;
        	// 
        	// tw_gbMaps
        	// 
        	this.tw_gbMaps.Controls.Add(this.tw_lblInUse);
        	this.tw_gbMaps.Controls.Add(this.tw_btnAdd);
        	this.tw_gbMaps.Controls.Add(this.tw_btnRemove);
        	this.tw_gbMaps.Controls.Add(this.tw_lstNotUsed);
        	this.tw_gbMaps.Controls.Add(this.tw_lstUsed);
        	this.tw_gbMaps.Location = new System.Drawing.Point(6, 59);
        	this.tw_gbMaps.Name = "tw_gbMaps";
        	this.tw_gbMaps.Size = new System.Drawing.Size(170, 401);
        	this.tw_gbMaps.TabIndex = 5;
        	this.tw_gbMaps.TabStop = false;
        	this.tw_gbMaps.Text = "Maps";
        	// 
        	// tw_lblInUse
        	// 
        	this.tw_lblInUse.AutoSize = true;
        	this.tw_lblInUse.Location = new System.Drawing.Point(6, 17);
        	this.tw_lblInUse.Name = "tw_lblInUse";
        	this.tw_lblInUse.Size = new System.Drawing.Size(38, 13);
        	this.tw_lblInUse.TabIndex = 5;
        	this.tw_lblInUse.Text = "In use:";
        	// 
        	// tw_btnAdd
        	// 
        	this.tw_btnAdd.Location = new System.Drawing.Point(6, 188);
        	this.tw_btnAdd.Name = "tw_btnAdd";
        	this.tw_btnAdd.Size = new System.Drawing.Size(77, 23);
        	this.tw_btnAdd.TabIndex = 4;
        	this.tw_btnAdd.Text = "<< Add";
        	this.tw_btnAdd.UseVisualStyleBackColor = true;
        	// 
        	// tw_btnRemove
        	// 
        	this.tw_btnRemove.Location = new System.Drawing.Point(89, 188);
        	this.tw_btnRemove.Name = "tw_btnRemove";
        	this.tw_btnRemove.Size = new System.Drawing.Size(75, 23);
        	this.tw_btnRemove.TabIndex = 3;
        	this.tw_btnRemove.Text = "Remove >>";
        	this.tw_btnRemove.UseVisualStyleBackColor = true;
        	// 
        	// tw_lstNotUsed
        	// 
        	this.tw_lstNotUsed.BackColor = System.Drawing.SystemColors.Window;
        	this.tw_lstNotUsed.FormattingEnabled = true;
        	this.tw_lstNotUsed.Location = new System.Drawing.Point(6, 219);
        	this.tw_lstNotUsed.Name = "tw_lstNotUsed";
        	this.tw_lstNotUsed.Size = new System.Drawing.Size(158, 173);
        	this.tw_lstNotUsed.TabIndex = 2;
        	// 
        	// tw_lstUsed
        	// 
        	this.tw_lstUsed.BackColor = System.Drawing.SystemColors.Window;
        	this.tw_lstUsed.FormattingEnabled = true;
        	this.tw_lstUsed.Location = new System.Drawing.Point(6, 33);
        	this.tw_lstUsed.Name = "tw_lstUsed";
        	this.tw_lstUsed.Size = new System.Drawing.Size(158, 147);
        	this.tw_lstUsed.TabIndex = 0;
        	// 
        	// tabSPL
        	// 
        	this.tabSPL.BackColor = System.Drawing.SystemColors.Control;
        	this.tabSPL.Controls.Add(this.spl_grpControls);
        	this.tabSPL.Controls.Add(this.spl_grpSettings);
        	this.tabSPL.Location = new System.Drawing.Point(4, 22);
        	this.tabSPL.Name = "tabSPL";
        	this.tabSPL.Padding = new System.Windows.Forms.Padding(3);
        	this.tabSPL.Size = new System.Drawing.Size(753, 489);
        	this.tabSPL.TabIndex = 10;
        	this.tabSPL.Text = "Spleef";
        	// 
        	// spl_grpControls
        	// 
        	this.spl_grpControls.Controls.Add(this.spl_btnEnd);
        	this.spl_grpControls.Controls.Add(this.spl_btnStop);
        	this.spl_grpControls.Controls.Add(this.spl_btnStart);
        	this.spl_grpControls.Location = new System.Drawing.Point(6, 6);
        	this.spl_grpControls.Name = "spl_grpControls";
        	this.spl_grpControls.Size = new System.Drawing.Size(279, 51);
        	this.spl_grpControls.TabIndex = 10;
        	this.spl_grpControls.TabStop = false;
        	this.spl_grpControls.Text = "Controls";
        	// 
        	// spl_btnEnd
        	// 
        	this.spl_btnEnd.Location = new System.Drawing.Point(190, 19);
        	this.spl_btnEnd.Name = "spl_btnEnd";
        	this.spl_btnEnd.Size = new System.Drawing.Size(80, 23);
        	this.spl_btnEnd.TabIndex = 2;
        	this.spl_btnEnd.Text = "End Round";
        	this.spl_btnEnd.UseVisualStyleBackColor = true;
        	// 
        	// spl_btnStop
        	// 
        	this.spl_btnStop.Location = new System.Drawing.Point(100, 19);
        	this.spl_btnStop.Name = "spl_btnStop";
        	this.spl_btnStop.Size = new System.Drawing.Size(80, 23);
        	this.spl_btnStop.TabIndex = 1;
        	this.spl_btnStop.Text = "Stop Game";
        	this.spl_btnStop.UseVisualStyleBackColor = true;
        	// 
        	// spl_btnStart
        	// 
        	this.spl_btnStart.Location = new System.Drawing.Point(10, 19);
        	this.spl_btnStart.Name = "spl_btnStart";
        	this.spl_btnStart.Size = new System.Drawing.Size(80, 23);
        	this.spl_btnStart.TabIndex = 0;
        	this.spl_btnStart.Text = "Start Game";
        	this.spl_btnStart.UseVisualStyleBackColor = true;
        	// 
        	// spl_grpSettings
        	// 
        	this.spl_grpSettings.Controls.Add(this.spl_cbMain);
        	this.spl_grpSettings.Controls.Add(this.spl_cbStart);
        	this.spl_grpSettings.Location = new System.Drawing.Point(6, 63);
        	this.spl_grpSettings.Name = "spl_grpSettings";
        	this.spl_grpSettings.Size = new System.Drawing.Size(296, 64);
        	this.spl_grpSettings.TabIndex = 9;
        	this.spl_grpSettings.TabStop = false;
        	this.spl_grpSettings.Text = "Settings";
        	// 
        	// spl_cbMain
        	// 
        	this.spl_cbMain.AutoSize = true;
        	this.spl_cbMain.Location = new System.Drawing.Point(11, 43);
        	this.spl_cbMain.Name = "spl_cbMain";
        	this.spl_cbMain.Size = new System.Drawing.Size(112, 17);
        	this.spl_cbMain.TabIndex = 24;
        	this.spl_cbMain.Text = "Change main level";
        	this.spl_cbMain.UseVisualStyleBackColor = true;
        	// 
        	// spl_cbStart
        	// 
        	this.spl_cbStart.AutoSize = true;
        	this.spl_cbStart.Location = new System.Drawing.Point(11, 20);
        	this.spl_cbStart.Name = "spl_cbStart";
        	this.spl_cbStart.Size = new System.Drawing.Size(139, 17);
        	this.spl_cbStart.TabIndex = 22;
        	this.spl_cbStart.Text = "Start when server starts";
        	this.spl_cbStart.UseVisualStyleBackColor = true;
        	// 
        	// tabCD
        	// 
        	this.tabCD.BackColor = System.Drawing.SystemColors.Control;
        	this.tabCD.Controls.Add(this.cd_grpControls);
        	this.tabCD.Controls.Add(this.cd_grpSettings);
        	this.tabCD.Location = new System.Drawing.Point(4, 22);
        	this.tabCD.Name = "tabCD";
        	this.tabCD.Padding = new System.Windows.Forms.Padding(3);
        	this.tabCD.Size = new System.Drawing.Size(753, 489);
        	this.tabCD.TabIndex = 10;
        	this.tabCD.Text = "Countdown";
        	// 
        	// cd_grpControls
        	// 
        	this.cd_grpControls.Controls.Add(this.cd_btnEnd);
        	this.cd_grpControls.Controls.Add(this.cd_btnStop);
        	this.cd_grpControls.Controls.Add(this.cd_btnStart);
        	this.cd_grpControls.Location = new System.Drawing.Point(6, 6);
        	this.cd_grpControls.Name = "cd_grpControls";
        	this.cd_grpControls.Size = new System.Drawing.Size(279, 51);
        	this.cd_grpControls.TabIndex = 12;
        	this.cd_grpControls.TabStop = false;
        	this.cd_grpControls.Text = "Controls";
        	// 
        	// cd_btnEnd
        	// 
        	this.cd_btnEnd.Location = new System.Drawing.Point(190, 19);
        	this.cd_btnEnd.Name = "cd_btnEnd";
        	this.cd_btnEnd.Size = new System.Drawing.Size(80, 23);
        	this.cd_btnEnd.TabIndex = 2;
        	this.cd_btnEnd.Text = "End Round";
        	this.cd_btnEnd.UseVisualStyleBackColor = true;
        	// 
        	// cd_btnStop
        	// 
        	this.cd_btnStop.Location = new System.Drawing.Point(100, 19);
        	this.cd_btnStop.Name = "cd_btnStop";
        	this.cd_btnStop.Size = new System.Drawing.Size(80, 23);
        	this.cd_btnStop.TabIndex = 1;
        	this.cd_btnStop.Text = "Stop Game";
        	this.cd_btnStop.UseVisualStyleBackColor = true;
        	// 
        	// cd_btnStart
        	// 
        	this.cd_btnStart.Location = new System.Drawing.Point(10, 19);
        	this.cd_btnStart.Name = "cd_btnStart";
        	this.cd_btnStart.Size = new System.Drawing.Size(80, 23);
        	this.cd_btnStart.TabIndex = 0;
        	this.cd_btnStart.Text = "Start Game";
        	this.cd_btnStart.UseVisualStyleBackColor = true;
        	// 
        	// cd_grpSettings
        	// 
        	this.cd_grpSettings.Controls.Add(this.cd_cbMain);
        	this.cd_grpSettings.Controls.Add(this.cd_cbStart);
        	this.cd_grpSettings.Location = new System.Drawing.Point(6, 63);
        	this.cd_grpSettings.Name = "cd_grpSettings";
        	this.cd_grpSettings.Size = new System.Drawing.Size(296, 64);
        	this.cd_grpSettings.TabIndex = 11;
        	this.cd_grpSettings.TabStop = false;
        	this.cd_grpSettings.Text = "Settings";
        	// 
        	// cd_cbMain
        	// 
        	this.cd_cbMain.AutoSize = true;
        	this.cd_cbMain.Location = new System.Drawing.Point(11, 43);
        	this.cd_cbMain.Name = "cd_cbMain";
        	this.cd_cbMain.Size = new System.Drawing.Size(112, 17);
        	this.cd_cbMain.TabIndex = 24;
        	this.cd_cbMain.Text = "Change main level";
        	this.cd_cbMain.UseVisualStyleBackColor = true;
        	// 
        	// cd_cbStart
        	// 
        	this.cd_cbStart.AutoSize = true;
        	this.cd_cbStart.Location = new System.Drawing.Point(11, 20);
        	this.cd_cbStart.Name = "cd_cbStart";
        	this.cd_cbStart.Size = new System.Drawing.Size(139, 17);
        	this.cd_cbStart.TabIndex = 22;
        	this.cd_cbStart.Text = "Start when server starts";
        	this.cd_cbStart.UseVisualStyleBackColor = true;
        	// 
        	// toolTip
        	// 
        	this.toolTip.AutoPopDelay = 8000;
        	this.toolTip.InitialDelay = 500;
        	this.toolTip.IsBalloon = true;
        	this.toolTip.ReshowDelay = 100;
        	this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
        	this.toolTip.ToolTipTitle = "Information";
        	// 
        	// Window
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(775, 523);
        	this.Controls.Add(this.main_btnClose);
        	this.Controls.Add(this.main_btnProps);
        	this.Controls.Add(this.main_btnRestart);
        	this.Controls.Add(this.tabs);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        	this.MaximizeBox = false;
        	this.Name = "Window";
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Window_FormClosing);
        	this.Load += new System.EventHandler(this.Window_Load);
        	this.Resize += new System.EventHandler(this.Window_Resize);
        	this.tsMap.ResumeLayout(false);
        	this.tsPlayer.ResumeLayout(false);
        	this.icon_context.ResumeLayout(false);
        	this.logs_tp.ResumeLayout(false);
        	this.logs_tab.ResumeLayout(false);
        	this.logs_tabErr.ResumeLayout(false);
        	this.logs_tabErr.PerformLayout();
        	this.logs_tabGen.ResumeLayout(false);
        	this.logs_tabGen.PerformLayout();
        	this.tabLog_Sys.ResumeLayout(false);
        	this.tabLog_Sys.PerformLayout();
        	this.tp_Main.ResumeLayout(false);
        	this.tp_Main.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.main_Maps)).EndInit();
        	this.tsLog_Menu.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.main_Players)).EndInit();
        	this.tabs.ResumeLayout(false);
        	this.tp_Maps.ResumeLayout(false);
        	this.map_gbProps.ResumeLayout(false);
        	this.map_gbLoaded.ResumeLayout(false);
        	this.map_gbUnloaded.ResumeLayout(false);
        	this.map_gbNew.ResumeLayout(false);
        	this.map_gbNew.PerformLayout();
        	this.tp_Players.ResumeLayout(false);
        	this.tp_Players.PerformLayout();
        	this.pl_gbProps.ResumeLayout(false);
        	this.pl_gbOther.ResumeLayout(false);
        	this.pl_gbOther.PerformLayout();
        	this.pl_gbActions.ResumeLayout(false);
        	this.pl_gbActions.PerformLayout();
        	this.tb_games.ResumeLayout(false);
        	this.tabGames.ResumeLayout(false);
        	this.tabLS.ResumeLayout(false);
        	this.ls_grpControls.ResumeLayout(false);
        	this.ls_grpMapSettings.ResumeLayout(false);
        	this.ls_grpTime.ResumeLayout(false);
        	this.ls_grpTime.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.ls_numFlood)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.ls_numLayerTime)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.ls_numRound)).EndInit();
        	this.ls_grpLayer.ResumeLayout(false);
        	this.ls_grpLayer.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.ls_numHeight)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.ls_numCount)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.ls_numLayer)).EndInit();
        	this.ls_grpBlock.ResumeLayout(false);
        	this.ls_grpBlock.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.ls_numDestroy)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.ls_numWater)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.ls_numFast)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.ls_numKiller)).EndInit();
        	this.ls_grpSettings.ResumeLayout(false);
        	this.ls_grpSettings.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.ls_numMax)).EndInit();
        	this.ls_grpMaps.ResumeLayout(false);
        	this.ls_grpMaps.PerformLayout();
        	this.tabZS.ResumeLayout(false);
        	this.zs_grpInvZombie.ResumeLayout(false);
        	this.zs_grpInvZombie.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.zs_numInvZombieSecs)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.zs_numInvZombieMax)).EndInit();
        	this.zs_grpZombie.ResumeLayout(false);
        	this.zs_grpZombie.PerformLayout();
        	this.zs_grpRevive.ResumeLayout(false);
        	this.zs_grpRevive.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.zs_numReviveLimit)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.zs_numSuccess)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.zs_numReviveMax)).EndInit();
        	this.zs_grpInvHuman.ResumeLayout(false);
        	this.zs_grpInvHuman.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.zs_numInvHumanSecs)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.zs_numInvHumanMax)).EndInit();
        	this.zs_grpControls.ResumeLayout(false);
        	this.zs_grpMap.ResumeLayout(false);
        	this.zs_grpTime.ResumeLayout(false);
        	this.zs_grpTime.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.zs_numFloodTime)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.zs_numLayerTime)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.zs_numRoundTime)).EndInit();
        	this.zs_grpSettings.ResumeLayout(false);
        	this.zs_grpSettings.PerformLayout();
        	this.zs_grpMaps.ResumeLayout(false);
        	this.zs_grpMaps.PerformLayout();
        	this.tabCTF.ResumeLayout(false);
        	this.ctf_grpControls.ResumeLayout(false);
        	this.ctf_grpSettings.ResumeLayout(false);
        	this.ctf_grpSettings.PerformLayout();
        	this.ctf_grpMaps.ResumeLayout(false);
        	this.ctf_grpMaps.PerformLayout();
        	this.tabTW.ResumeLayout(false);
        	this.tw_grpControls.ResumeLayout(false);
        	this.tw_grpMapSettings.ResumeLayout(false);
        	this.tw_grpTeams.ResumeLayout(false);
        	this.tw_grpTeams.PerformLayout();
        	this.tw_grpGrace.ResumeLayout(false);
        	this.tw_grpGrace.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.tw_numGrace)).EndInit();
        	this.tw_grpScores.ResumeLayout(false);
        	this.tw_grpScores.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.tw_numMultiKills)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.tw_numScoreAssists)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.tw_numScorePerKill)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.tw_numScoreLimit)).EndInit();
        	this.tw_grpSettings.ResumeLayout(false);
        	this.tw_grpSettings.PerformLayout();
        	this.tw_gbMaps.ResumeLayout(false);
        	this.tw_gbMaps.PerformLayout();
        	this.tabSPL.ResumeLayout(false);
        	this.spl_grpControls.ResumeLayout(false);
        	this.spl_grpSettings.ResumeLayout(false);
        	this.spl_grpSettings.PerformLayout();
        	this.tabCD.ResumeLayout(false);
        	this.cd_grpControls.ResumeLayout(false);
        	this.cd_grpSettings.ResumeLayout(false);
        	this.cd_grpSettings.PerformLayout();
        	this.ResumeLayout(false);

        }
        private Supernova.Gui.TimespanUpDown zs_numInvHumanSecs;
        private Supernova.Gui.TimespanUpDown zs_numReviveLimit;
        private Supernova.Gui.TimespanUpDown zs_numInvZombieSecs;
        private System.Windows.Forms.Panel zs_separator;
        private System.Windows.Forms.Label zs_lblInvZombieMax;
        private System.Windows.Forms.Label zs_lblInvZombieDur;
        private System.Windows.Forms.NumericUpDown zs_numInvZombieMax;
        private System.Windows.Forms.GroupBox zs_grpInvZombie;
        private System.Windows.Forms.NumericUpDown zs_numSuccess;
        private System.Windows.Forms.Label zs_lblSuccess;
        private System.Windows.Forms.ListBox zs_lstUsed;
        private System.Windows.Forms.ListBox zs_lstNotUsed;
        private System.Windows.Forms.Button zs_btnRemove;
        private System.Windows.Forms.Button zs_btnAdd;
        private System.Windows.Forms.Label zs_lblUsed;
        private System.Windows.Forms.Label zs_lblNotUsed;
        private System.Windows.Forms.GroupBox zs_grpMaps;
        private System.Windows.Forms.CheckBox zs_cbStart;
        private System.Windows.Forms.Label zs_lblInvHumanMax;
        private System.Windows.Forms.Label zs_lblInvHumanDur;
        private System.Windows.Forms.NumericUpDown zs_numInvHumanMax;
        private System.Windows.Forms.GroupBox zs_grpInvHuman;
        private System.Windows.Forms.CheckBox zs_cbMap;
        private System.Windows.Forms.CheckBox zs_cbMain;
        private System.Windows.Forms.Label zs_lblReviveMax;
        private System.Windows.Forms.NumericUpDown zs_numReviveMax;
        private System.Windows.Forms.Label zs_lblReviveLimitHdr;
        private System.Windows.Forms.Label zs_lblReviveLimitFtr;
        private System.Windows.Forms.Label zs_lblReviveRound;
        private System.Windows.Forms.GroupBox zs_grpRevive;
        private System.Windows.Forms.Label zs_lblName;
        private System.Windows.Forms.Label zs_lblModel;
        private System.Windows.Forms.TextBox zs_txtName;
        private System.Windows.Forms.TextBox zs_txtModel;
        private System.Windows.Forms.GroupBox zs_grpZombie;
        private System.Windows.Forms.GroupBox zs_grpSettings;
        private System.Windows.Forms.Label zs_lblRoundTime;
        private System.Windows.Forms.Label zs_lblFloodTime;
        private System.Windows.Forms.Label zs_lblLayerTime;
        private Supernova.Gui.TimespanUpDown zs_numRoundTime;
        private Supernova.Gui.TimespanUpDown zs_numLayerTime;
        private Supernova.Gui.TimespanUpDown zs_numFloodTime;
        private System.Windows.Forms.GroupBox zs_grpTime;
        private System.Windows.Forms.GroupBox zs_grpMap;
        private System.Windows.Forms.Button zs_btnStart;
        private System.Windows.Forms.Button zs_btnStop;
        private System.Windows.Forms.Button zs_btnEnd;
        private System.Windows.Forms.GroupBox zs_grpControls;
        private System.Windows.Forms.TabPage tabZS;
        private System.Windows.Forms.TabPage tabLS;
                private System.Windows.Forms.GroupBox ls_grpControls;
        private System.Windows.Forms.Button ls_btnEnd;
        private System.Windows.Forms.Button ls_btnStop;
        private System.Windows.Forms.Button ls_btnStart;
        private System.Windows.Forms.GroupBox ls_grpMapSettings;
        private System.Windows.Forms.GroupBox ls_grpTime;
        private Supernova.Gui.TimespanUpDown ls_numFlood;
        private Supernova.Gui.TimespanUpDown ls_numLayerTime;
        private Supernova.Gui.TimespanUpDown ls_numRound;
        private System.Windows.Forms.Label ls_lblLayerTime;
        private System.Windows.Forms.Label ls_lblFlood;
        private System.Windows.Forms.Label ls_lblRound;
        private System.Windows.Forms.GroupBox ls_grpLayer;
        private System.Windows.Forms.Label ls_lblBlocksTall;
        private System.Windows.Forms.NumericUpDown ls_numHeight;
        private System.Windows.Forms.Label ls_lblLayersEach;
        private System.Windows.Forms.NumericUpDown ls_numCount;
        private System.Windows.Forms.NumericUpDown ls_numLayer;
        private System.Windows.Forms.Label ls_lblLayer;
        private System.Windows.Forms.GroupBox ls_grpBlock;
        private System.Windows.Forms.NumericUpDown ls_numDestroy;
        private System.Windows.Forms.NumericUpDown ls_numWater;
        private System.Windows.Forms.NumericUpDown ls_numFast;
        private System.Windows.Forms.NumericUpDown ls_numKiller;
        private System.Windows.Forms.Label ls_lblDestroy;
        private System.Windows.Forms.Label ls_lblFast;
        private System.Windows.Forms.Label ls_lblWater;
        private System.Windows.Forms.Label ls_lblKill;
        private System.Windows.Forms.GroupBox ls_grpSettings;
        private System.Windows.Forms.Label ls_lblMax;
        private System.Windows.Forms.NumericUpDown ls_numMax;
        private System.Windows.Forms.CheckBox ls_cbMain;
        private System.Windows.Forms.CheckBox ls_cbMap;
        private System.Windows.Forms.CheckBox ls_cbStart;
        private System.Windows.Forms.GroupBox ls_grpMaps;
        private System.Windows.Forms.Label ls_lblNotUsed;
        private System.Windows.Forms.Label ls_lblUsed;
        private System.Windows.Forms.Button ls_btnAdd;
        private System.Windows.Forms.Button ls_btnRemove;
        private System.Windows.Forms.ListBox ls_lstNotUsed;
        private System.Windows.Forms.ListBox ls_lstUsed;
        private System.Windows.Forms.TabControl tabGames;
        private System.Windows.Forms.TabPage tb_games;
        private System.Windows.Forms.DataGridViewTextBoxColumn main_colPlName;
        private System.Windows.Forms.DataGridViewTextBoxColumn main_colPlMap;
        private System.Windows.Forms.DataGridViewTextBoxColumn main_colPlRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn main_colLvlPhysics;
        private System.Windows.Forms.DataGridViewTextBoxColumn main_colLvlPlayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn main_colLvlName;
        private System.Windows.Forms.Label pl_lblOnline;
        private System.Windows.Forms.GroupBox pl_gbProps;
        private System.Windows.Forms.GroupBox pl_gbActions;
        private System.Windows.Forms.GroupBox pl_gbOther;
        private Supernova.Gui.HackyPropertyGrid pl_pgProps;
        private System.Windows.Forms.TextBox map_txtName;
        private System.Windows.Forms.Label map_lblName;
        private System.Windows.Forms.ComboBox map_cmbX;
        private System.Windows.Forms.ComboBox map_cmbY;
        private System.Windows.Forms.ComboBox map_cmbZ;
        private System.Windows.Forms.ComboBox map_cmbType;
        private System.Windows.Forms.TextBox map_txtSeed;
        private System.Windows.Forms.Label map_lblY;
        private System.Windows.Forms.Label map_lblX;
        private System.Windows.Forms.Label map_lblZ;
        private System.Windows.Forms.Label map_lblSeed;
        private System.Windows.Forms.Label map_lblType;
        private System.Windows.Forms.Button map_btnGen;
        private System.Windows.Forms.GroupBox map_gbNew;
        private System.Windows.Forms.ListBox map_lbUnloaded;
        private System.Windows.Forms.Button map_btnLoad;
        private System.Windows.Forms.GroupBox map_gbUnloaded;
        private System.Windows.Forms.ListBox map_lbLoaded;
        private System.Windows.Forms.GroupBox map_gbLoaded;
        private Supernova.Gui.HackyPropertyGrid map_pgProps;
        private System.Windows.Forms.GroupBox map_gbProps;
        private System.Windows.Forms.TabPage tp_Main;
        private System.Windows.Forms.TabPage tabLog_Sys;
        private System.Windows.Forms.TabPage logs_tabErr;
        private System.Windows.Forms.TabPage logs_tabGen;
        private System.Windows.Forms.TabControl logs_tab;

        #endregion

        private Button main_btnClose;
        private ContextMenuStrip icon_context;
        private ToolStripMenuItem icon_openConsole;
        private ToolStripMenuItem icon_shutdown;
        private ContextMenuStrip tsPlayer;
        private ToolStripMenuItem tsPlayer_whois;
        private ToolStripMenuItem tsPlayer_kick;
        private ToolStripMenuItem tsPlayer_ban;
        private ToolStripMenuItem tsPlayer_voice;
        private ContextMenuStrip tsMap;
        private ToolStripMenuItem tsPlayer_clones;
        private Button main_btnRestart;
        private ToolStripMenuItem icon_restart;
        private TabPage logs_tp;
        private Label logs_lblGeneral;
        private TextBox logs_txtError;
        private TextBox logs_txtSystem;
        private TabPage tp_Maps;
        private DataGridView main_Maps;
        private TextBox main_txtInput;
        private TextBox main_txtUrl;
        private DataGridView main_Players;
        private TabControl tabs;
        private ToolStripMenuItem tsPlayer_promote;
        private ToolStripMenuItem tsPlayer_demote;
        private TabPage tp_Players;
        internal RichTextBox logs_txtGeneral;
        private DateTimePicker logs_dateGeneral;
        private Button pl_btnBanIP;
        private Button pl_btnBan;
        private Button pl_btnKick;
        private Button pl_btnMessage;
        private TextBox pl_txtMessage;
        private Button pl_btnWarn;
        private Button pl_btnFreeze;
        private TextBox pl_txtImpersonate;
        private Button pl_btnSendCommand;
        private Button pl_btnKill;
        private TextBox pl_txtUndo;
        private Button pl_btnUndo;
        private Button pl_btnMute;
        private Button pl_btnRules;
        private TextBox pl_statusBox;
        private ListBox pl_listBox;
        private Button main_btnSaveAll;
        private Button main_btnUnloadEmpty;
        private Button main_btnKillPhysics;
        private ToolStripMenuItem tsMap_info;
        private ToolStripMenuItem tsMap_actionsMenu;
        private ToolStripMenuItem tsMap_Save;
        private ToolStripMenuItem tsMap_Unload;
        private ToolStripMenuItem tsMap_moveAll;
        private ToolStripMenuItem tsMap_Reload;
        private ToolStripMenuItem tsMap_physicsMenu;
        private ToolStripMenuItem tsMap_physics0;
        private ToolStripMenuItem tsMap_physics1;
        private ToolStripMenuItem tsMap_physics2;
        private ToolStripMenuItem tsMap_physics3;
        private ToolStripMenuItem tsMap_physics4;
        private ToolStripMenuItem tsMap_physics5;
        private ToolStripSeparator tsMap_separator;
        private Components.ColoredTextBox main_txtLog;
        private ContextMenuStrip tsLog_Menu;
        private ToolStripMenuItem tsLog_night;
        private ToolStripMenuItem tsLog_Colored;
        private ToolStripSeparator tsLog_separator1;
        private ToolStripMenuItem tsLog_copySelected;
        private ToolStripMenuItem tsLog_copyAll;
        private ToolStripSeparator tsLog_separator2;
        private ToolStripMenuItem tsLog_clear;
        private ToolStripMenuItem tsLog_dateStamp;
        private ToolStripMenuItem tsLog_autoScroll;
        private Button main_btnProps;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabPage tabCTF;
        private System.Windows.Forms.GroupBox ctf_grpControls;
        private System.Windows.Forms.Button ctf_btnEnd;
        private System.Windows.Forms.Button ctf_btnStop;
        private System.Windows.Forms.Button ctf_btnStart;
        private System.Windows.Forms.GroupBox ctf_grpSettings;
        private System.Windows.Forms.CheckBox ctf_cbMain;
        private System.Windows.Forms.CheckBox ctf_cbMap;
        private System.Windows.Forms.CheckBox ctf_cbStart;
        private System.Windows.Forms.GroupBox ctf_grpMaps;
        private System.Windows.Forms.Label ctf_lblNotUsed;
        private System.Windows.Forms.Label ctf_lblUsed;
        private System.Windows.Forms.Button ctf_btnAdd;
        private System.Windows.Forms.Button ctf_btnRemove;
        private System.Windows.Forms.ListBox ctf_lstNotUsed;
        private System.Windows.Forms.ListBox ctf_lstUsed;
        private System.Windows.Forms.TabPage tabTW;
        private System.Windows.Forms.GroupBox tw_grpControls;
        private System.Windows.Forms.Button tw_btnEnd;
        private System.Windows.Forms.Button tw_btnStop;
        private System.Windows.Forms.Button tw_btnStart;
        private System.Windows.Forms.GroupBox tw_grpMapSettings;
        private System.Windows.Forms.GroupBox tw_grpTeams;
        private System.Windows.Forms.CheckBox tw_cbKills;
        private System.Windows.Forms.CheckBox tw_cbBalance;
        private System.Windows.Forms.GroupBox tw_grpGrace;
        private Supernova.Gui.TimespanUpDown tw_numGrace;
        private System.Windows.Forms.Label tw_lblGrace;
        private System.Windows.Forms.CheckBox tw_cbGrace;
        private System.Windows.Forms.GroupBox tw_grpScores;
        private System.Windows.Forms.Label tw_lblMulti;
        private System.Windows.Forms.Label tw_lblAssist;
        private System.Windows.Forms.CheckBox tw_cbStreaks;
        private System.Windows.Forms.NumericUpDown tw_numMultiKills;
        private System.Windows.Forms.NumericUpDown tw_numScoreAssists;
        private System.Windows.Forms.Label tw_lblScorePerKill;
        private System.Windows.Forms.NumericUpDown tw_numScorePerKill;
        private System.Windows.Forms.Label tw_lblScoreLimit;
        private System.Windows.Forms.NumericUpDown tw_numScoreLimit;
        private System.Windows.Forms.GroupBox tw_grpSettings;
        private System.Windows.Forms.ComboBox tw_cmbMode;
        private System.Windows.Forms.ComboBox tw_cmbDiff;
        private System.Windows.Forms.Label tw_lblMode;
        private System.Windows.Forms.Label tw_lblDiff;
        private System.Windows.Forms.CheckBox tw_cbMain;
        private System.Windows.Forms.CheckBox tw_cbMap;
        private System.Windows.Forms.CheckBox tw_cbStart;
        private System.Windows.Forms.GroupBox tw_gbMaps;
        private System.Windows.Forms.Label tw_lblInUse;
        private System.Windows.Forms.Button tw_btnAdd;
        private System.Windows.Forms.Button tw_btnRemove;
        private System.Windows.Forms.ListBox tw_lstNotUsed;
        private System.Windows.Forms.ListBox tw_lstUsed;
        private System.Windows.Forms.TabPage tabSPL;
        private System.Windows.Forms.TabPage tabCD;
        private System.Windows.Forms.GroupBox spl_grpControls;
        private System.Windows.Forms.Button spl_btnEnd;
        private System.Windows.Forms.Button spl_btnStop;
        private System.Windows.Forms.Button spl_btnStart;
        private System.Windows.Forms.GroupBox spl_grpSettings;
        private System.Windows.Forms.CheckBox spl_cbMain;
        private System.Windows.Forms.CheckBox spl_cbStart;
        private System.Windows.Forms.GroupBox cd_grpControls;
        private System.Windows.Forms.Button cd_btnEnd;
        private System.Windows.Forms.Button cd_btnStop;
        private System.Windows.Forms.Button cd_btnStart;
        private System.Windows.Forms.GroupBox cd_grpSettings;
        private System.Windows.Forms.CheckBox cd_cbMain;
        private System.Windows.Forms.CheckBox cd_cbStart;
    }
}
