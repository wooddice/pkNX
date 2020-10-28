﻿namespace pkNX.WinForms
{
    partial class DumperSWSH
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
            this.TC_Options = new System.Windows.Forms.TabControl();
            this.Tab_General = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.B_ParsePKMDetails = new System.Windows.Forms.Button();
            this.B_DumpTrainers = new System.Windows.Forms.Button();
            this.B_Wild = new System.Windows.Forms.Button();
            this.B_Static = new System.Windows.Forms.Button();
            this.B_Gift = new System.Windows.Forms.Button();
            this.B_Nest = new System.Windows.Forms.Button();
            this.B_Trade = new System.Windows.Forms.Button();
            this.B_ItemInfo = new System.Windows.Forms.Button();
            this.B_Moves = new System.Windows.Forms.Button();
            this.B_BattleTower = new System.Windows.Forms.Button();
            this.B_MaxDens = new System.Windows.Forms.Button();
            this.Tab_PKHeX = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.B_PKText = new System.Windows.Forms.Button();
            this.B_PKLearn = new System.Windows.Forms.Button();
            this.B_PKEggMove = new System.Windows.Forms.Button();
            this.B_PKEvo = new System.Windows.Forms.Button();
            this.B_PKForms = new System.Windows.Forms.Button();
            this.B_PKRibbon = new System.Windows.Forms.Button();
            this.B_Memories = new System.Windows.Forms.Button();
            this.Tab_Misc = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.B_GetDummiedMoveInfo = new System.Windows.Forms.Button();
            this.B_DumpHash = new System.Windows.Forms.Button();
            this.B_GalarDex = new System.Windows.Forms.Button();
            this.B_FlavorText = new System.Windows.Forms.Button();
            this.B_EggMove = new System.Windows.Forms.Button();
            this.Tab_Future = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.B_Distribution_Nests = new System.Windows.Forms.Button();
            this.B_OpenFolder = new System.Windows.Forms.Button();
            this.TC_Options.SuspendLayout();
            this.Tab_General.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.Tab_PKHeX.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.Tab_Misc.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.Tab_Future.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TC_Options
            // 
            this.TC_Options.Controls.Add(this.Tab_General);
            this.TC_Options.Controls.Add(this.Tab_PKHeX);
            this.TC_Options.Controls.Add(this.Tab_Misc);
            this.TC_Options.Controls.Add(this.Tab_Future);
            this.TC_Options.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TC_Options.Location = new System.Drawing.Point(0, 0);
            this.TC_Options.Name = "TC_Options";
            this.TC_Options.SelectedIndex = 0;
            this.TC_Options.Size = new System.Drawing.Size(401, 279);
            this.TC_Options.TabIndex = 0;
            // 
            // Tab_General
            // 
            this.Tab_General.Controls.Add(this.flowLayoutPanel1);
            this.Tab_General.Location = new System.Drawing.Point(4, 22);
            this.Tab_General.Name = "Tab_General";
            this.Tab_General.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_General.Size = new System.Drawing.Size(393, 253);
            this.Tab_General.TabIndex = 0;
            this.Tab_General.Text = "General";
            this.Tab_General.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.B_ParsePKMDetails);
            this.flowLayoutPanel1.Controls.Add(this.B_DumpTrainers);
            this.flowLayoutPanel1.Controls.Add(this.B_Wild);
            this.flowLayoutPanel1.Controls.Add(this.B_Static);
            this.flowLayoutPanel1.Controls.Add(this.B_Gift);
            this.flowLayoutPanel1.Controls.Add(this.B_Nest);
            this.flowLayoutPanel1.Controls.Add(this.B_Trade);
            this.flowLayoutPanel1.Controls.Add(this.B_ItemInfo);
            this.flowLayoutPanel1.Controls.Add(this.B_Moves);
            this.flowLayoutPanel1.Controls.Add(this.B_BattleTower);
            this.flowLayoutPanel1.Controls.Add(this.B_MaxDens);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(387, 247);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // B_ParsePKMDetails
            // 
            this.B_ParsePKMDetails.Location = new System.Drawing.Point(3, 3);
            this.B_ParsePKMDetails.Name = "B_ParsePKMDetails";
            this.B_ParsePKMDetails.Size = new System.Drawing.Size(123, 55);
            this.B_ParsePKMDetails.TabIndex = 1;
            this.B_ParsePKMDetails.Text = "Personal Stats";
            this.B_ParsePKMDetails.UseVisualStyleBackColor = true;
            this.B_ParsePKMDetails.Click += new System.EventHandler(this.B_ParsePKMDetails_Click);
            // 
            // B_DumpTrainers
            // 
            this.B_DumpTrainers.Location = new System.Drawing.Point(132, 3);
            this.B_DumpTrainers.Name = "B_DumpTrainers";
            this.B_DumpTrainers.Size = new System.Drawing.Size(123, 55);
            this.B_DumpTrainers.TabIndex = 2;
            this.B_DumpTrainers.Text = "Trainers";
            this.B_DumpTrainers.UseVisualStyleBackColor = true;
            this.B_DumpTrainers.Click += new System.EventHandler(this.B_DumpTrainers_Click);
            // 
            // B_Wild
            // 
            this.B_Wild.Location = new System.Drawing.Point(261, 3);
            this.B_Wild.Name = "B_Wild";
            this.B_Wild.Size = new System.Drawing.Size(123, 55);
            this.B_Wild.TabIndex = 11;
            this.B_Wild.Text = "Wild Encounters";
            this.B_Wild.UseVisualStyleBackColor = true;
            this.B_Wild.Click += new System.EventHandler(this.B_Wild_Click);
            // 
            // B_Static
            // 
            this.B_Static.Location = new System.Drawing.Point(3, 64);
            this.B_Static.Name = "B_Static";
            this.B_Static.Size = new System.Drawing.Size(123, 55);
            this.B_Static.TabIndex = 10;
            this.B_Static.Text = "Static Encounters";
            this.B_Static.UseVisualStyleBackColor = true;
            this.B_Static.Click += new System.EventHandler(this.B_Static_Click);
            // 
            // B_Gift
            // 
            this.B_Gift.Location = new System.Drawing.Point(132, 64);
            this.B_Gift.Name = "B_Gift";
            this.B_Gift.Size = new System.Drawing.Size(123, 55);
            this.B_Gift.TabIndex = 9;
            this.B_Gift.Text = "Gift Encounters";
            this.B_Gift.UseVisualStyleBackColor = true;
            this.B_Gift.Click += new System.EventHandler(this.B_Gift_Click);
            // 
            // B_Nest
            // 
            this.B_Nest.Location = new System.Drawing.Point(261, 64);
            this.B_Nest.Name = "B_Nest";
            this.B_Nest.Size = new System.Drawing.Size(123, 55);
            this.B_Nest.TabIndex = 13;
            this.B_Nest.Text = "Nest Encounters";
            this.B_Nest.UseVisualStyleBackColor = true;
            this.B_Nest.Click += new System.EventHandler(this.B_Nest_Click);
            // 
            // B_Trade
            // 
            this.B_Trade.Location = new System.Drawing.Point(3, 125);
            this.B_Trade.Name = "B_Trade";
            this.B_Trade.Size = new System.Drawing.Size(123, 55);
            this.B_Trade.TabIndex = 14;
            this.B_Trade.Text = "Trade Encounters";
            this.B_Trade.UseVisualStyleBackColor = true;
            this.B_Trade.Click += new System.EventHandler(this.B_Trade_Click);
            // 
            // B_ItemInfo
            // 
            this.B_ItemInfo.Location = new System.Drawing.Point(132, 125);
            this.B_ItemInfo.Name = "B_ItemInfo";
            this.B_ItemInfo.Size = new System.Drawing.Size(123, 55);
            this.B_ItemInfo.TabIndex = 6;
            this.B_ItemInfo.Text = "Item Info";
            this.B_ItemInfo.UseVisualStyleBackColor = true;
            this.B_ItemInfo.Click += new System.EventHandler(this.B_ItemInfo_Click);
            // 
            // B_Moves
            // 
            this.B_Moves.Location = new System.Drawing.Point(261, 125);
            this.B_Moves.Name = "B_Moves";
            this.B_Moves.Size = new System.Drawing.Size(123, 55);
            this.B_Moves.TabIndex = 7;
            this.B_Moves.Text = "Move Info";
            this.B_Moves.UseVisualStyleBackColor = true;
            this.B_Moves.Click += new System.EventHandler(this.B_Moves_Click);
            // 
            // B_BattleTower
            // 
            this.B_BattleTower.Location = new System.Drawing.Point(3, 186);
            this.B_BattleTower.Name = "B_BattleTower";
            this.B_BattleTower.Size = new System.Drawing.Size(123, 55);
            this.B_BattleTower.TabIndex = 15;
            this.B_BattleTower.Text = "Battle Tower";
            this.B_BattleTower.UseVisualStyleBackColor = true;
            this.B_BattleTower.Click += new System.EventHandler(this.B_BattleTower_Click);
            // 
            // B_MaxDens
            // 
            this.B_MaxDens.Location = new System.Drawing.Point(132, 186);
            this.B_MaxDens.Name = "B_MaxDens";
            this.B_MaxDens.Size = new System.Drawing.Size(123, 55);
            this.B_MaxDens.TabIndex = 16;
            this.B_MaxDens.Text = "Max Dens";
            this.B_MaxDens.UseVisualStyleBackColor = true;
            this.B_MaxDens.Click += new System.EventHandler(this.B_MaxDens_Click);
            // 
            // Tab_PKHeX
            // 
            this.Tab_PKHeX.Controls.Add(this.flowLayoutPanel2);
            this.Tab_PKHeX.Location = new System.Drawing.Point(4, 22);
            this.Tab_PKHeX.Name = "Tab_PKHeX";
            this.Tab_PKHeX.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_PKHeX.Size = new System.Drawing.Size(393, 253);
            this.Tab_PKHeX.TabIndex = 1;
            this.Tab_PKHeX.Text = "PKHeX";
            this.Tab_PKHeX.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.B_PKText);
            this.flowLayoutPanel2.Controls.Add(this.B_PKLearn);
            this.flowLayoutPanel2.Controls.Add(this.B_PKEggMove);
            this.flowLayoutPanel2.Controls.Add(this.B_PKEvo);
            this.flowLayoutPanel2.Controls.Add(this.B_PKForms);
            this.flowLayoutPanel2.Controls.Add(this.B_PKRibbon);
            this.flowLayoutPanel2.Controls.Add(this.B_Memories);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(387, 247);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // B_PKText
            // 
            this.B_PKText.Location = new System.Drawing.Point(3, 3);
            this.B_PKText.Name = "B_PKText";
            this.B_PKText.Size = new System.Drawing.Size(123, 55);
            this.B_PKText.TabIndex = 5;
            this.B_PKText.Text = "Text Files";
            this.B_PKText.UseVisualStyleBackColor = true;
            this.B_PKText.Click += new System.EventHandler(this.B_PKText_Click);
            // 
            // B_PKLearn
            // 
            this.B_PKLearn.Location = new System.Drawing.Point(132, 3);
            this.B_PKLearn.Name = "B_PKLearn";
            this.B_PKLearn.Size = new System.Drawing.Size(123, 55);
            this.B_PKLearn.TabIndex = 6;
            this.B_PKLearn.Text = "Learnset Binary";
            this.B_PKLearn.UseVisualStyleBackColor = true;
            this.B_PKLearn.Click += new System.EventHandler(this.B_PKLearn_Click);
            // 
            // B_PKEggMove
            // 
            this.B_PKEggMove.Location = new System.Drawing.Point(261, 3);
            this.B_PKEggMove.Name = "B_PKEggMove";
            this.B_PKEggMove.Size = new System.Drawing.Size(123, 55);
            this.B_PKEggMove.TabIndex = 7;
            this.B_PKEggMove.Text = "Egg Move Binary";
            this.B_PKEggMove.UseVisualStyleBackColor = true;
            this.B_PKEggMove.Click += new System.EventHandler(this.B_PKEggMove_Click);
            // 
            // B_PKEvo
            // 
            this.B_PKEvo.Location = new System.Drawing.Point(3, 64);
            this.B_PKEvo.Name = "B_PKEvo";
            this.B_PKEvo.Size = new System.Drawing.Size(123, 55);
            this.B_PKEvo.TabIndex = 8;
            this.B_PKEvo.Text = "Evolution Binary";
            this.B_PKEvo.UseVisualStyleBackColor = true;
            this.B_PKEvo.Click += new System.EventHandler(this.B_PKEvo_Click);
            // 
            // B_PKForms
            // 
            this.B_PKForms.Location = new System.Drawing.Point(132, 64);
            this.B_PKForms.Name = "B_PKForms";
            this.B_PKForms.Size = new System.Drawing.Size(123, 55);
            this.B_PKForms.TabIndex = 9;
            this.B_PKForms.Text = "New Form Names";
            this.B_PKForms.UseVisualStyleBackColor = true;
            this.B_PKForms.Click += new System.EventHandler(this.B_PKForms_Click);
            // 
            // B_PKRibbon
            // 
            this.B_PKRibbon.Location = new System.Drawing.Point(261, 64);
            this.B_PKRibbon.Name = "B_PKRibbon";
            this.B_PKRibbon.Size = new System.Drawing.Size(123, 55);
            this.B_PKRibbon.TabIndex = 10;
            this.B_PKRibbon.Text = "New Ribbon Names";
            this.B_PKRibbon.UseVisualStyleBackColor = true;
            this.B_PKRibbon.Click += new System.EventHandler(this.B_PKRibbon_Click);
            // 
            // B_Memories
            // 
            this.B_Memories.Location = new System.Drawing.Point(3, 125);
            this.B_Memories.Name = "B_Memories";
            this.B_Memories.Size = new System.Drawing.Size(123, 55);
            this.B_Memories.TabIndex = 11;
            this.B_Memories.Text = "New Memories";
            this.B_Memories.UseVisualStyleBackColor = true;
            this.B_Memories.Click += new System.EventHandler(this.B_Memories_Click);
            // 
            // Tab_Misc
            // 
            this.Tab_Misc.Controls.Add(this.flowLayoutPanel3);
            this.Tab_Misc.Location = new System.Drawing.Point(4, 22);
            this.Tab_Misc.Name = "Tab_Misc";
            this.Tab_Misc.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Misc.Size = new System.Drawing.Size(393, 253);
            this.Tab_Misc.TabIndex = 2;
            this.Tab_Misc.Text = "Misc";
            this.Tab_Misc.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.B_GetDummiedMoveInfo);
            this.flowLayoutPanel3.Controls.Add(this.B_DumpHash);
            this.flowLayoutPanel3.Controls.Add(this.B_GalarDex);
            this.flowLayoutPanel3.Controls.Add(this.B_FlavorText);
            this.flowLayoutPanel3.Controls.Add(this.B_EggMove);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(387, 247);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // B_GetDummiedMoveInfo
            // 
            this.B_GetDummiedMoveInfo.Location = new System.Drawing.Point(3, 3);
            this.B_GetDummiedMoveInfo.Name = "B_GetDummiedMoveInfo";
            this.B_GetDummiedMoveInfo.Size = new System.Drawing.Size(123, 55);
            this.B_GetDummiedMoveInfo.TabIndex = 13;
            this.B_GetDummiedMoveInfo.Text = "Dummied Moves";
            this.B_GetDummiedMoveInfo.UseVisualStyleBackColor = true;
            this.B_GetDummiedMoveInfo.Click += new System.EventHandler(this.B_GetDummiedMoveInfo_Click);
            // 
            // B_DumpHash
            // 
            this.B_DumpHash.Location = new System.Drawing.Point(132, 3);
            this.B_DumpHash.Name = "B_DumpHash";
            this.B_DumpHash.Size = new System.Drawing.Size(123, 55);
            this.B_DumpHash.TabIndex = 14;
            this.B_DumpHash.Text = "Hash Tables";
            this.B_DumpHash.UseVisualStyleBackColor = true;
            this.B_DumpHash.Click += new System.EventHandler(this.B_DumpHash_Click);
            // 
            // B_GalarDex
            // 
            this.B_GalarDex.Location = new System.Drawing.Point(261, 3);
            this.B_GalarDex.Name = "B_GalarDex";
            this.B_GalarDex.Size = new System.Drawing.Size(123, 55);
            this.B_GalarDex.TabIndex = 15;
            this.B_GalarDex.Text = "Galar Dex";
            this.B_GalarDex.UseVisualStyleBackColor = true;
            this.B_GalarDex.Click += new System.EventHandler(this.B_GalarDex_Click);
            // 
            // B_FlavorText
            // 
            this.B_FlavorText.Location = new System.Drawing.Point(3, 64);
            this.B_FlavorText.Name = "B_FlavorText";
            this.B_FlavorText.Size = new System.Drawing.Size(123, 55);
            this.B_FlavorText.TabIndex = 16;
            this.B_FlavorText.Text = "Flavor Text";
            this.B_FlavorText.UseVisualStyleBackColor = true;
            this.B_FlavorText.Click += new System.EventHandler(this.B_FlavorText_Click);
            // 
            // B_EggMove
            // 
            this.B_EggMove.Location = new System.Drawing.Point(132, 64);
            this.B_EggMove.Name = "B_EggMove";
            this.B_EggMove.Size = new System.Drawing.Size(123, 55);
            this.B_EggMove.TabIndex = 17;
            this.B_EggMove.Text = "Egg Move Entries";
            this.B_EggMove.UseVisualStyleBackColor = true;
            this.B_EggMove.Click += new System.EventHandler(this.B_EggMove_Click);
            // 
            // Tab_Future
            // 
            this.Tab_Future.Controls.Add(this.flowLayoutPanel4);
            this.Tab_Future.Location = new System.Drawing.Point(4, 22);
            this.Tab_Future.Name = "Tab_Future";
            this.Tab_Future.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Future.Size = new System.Drawing.Size(393, 253);
            this.Tab_Future.TabIndex = 3;
            this.Tab_Future.Text = "Future";
            this.Tab_Future.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.B_Distribution_Nests);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(387, 247);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // B_Distribution_Nests
            // 
            this.B_Distribution_Nests.Location = new System.Drawing.Point(3, 3);
            this.B_Distribution_Nests.Name = "B_Distribution_Nests";
            this.B_Distribution_Nests.Size = new System.Drawing.Size(123, 55);
            this.B_Distribution_Nests.TabIndex = 14;
            this.B_Distribution_Nests.Text = "Distribution Nests";
            this.B_Distribution_Nests.UseVisualStyleBackColor = true;
            this.B_Distribution_Nests.Click += new System.EventHandler(this.B_Distribution_Nests_Click);
            // 
            // B_OpenFolder
            // 
            this.B_OpenFolder.Location = new System.Drawing.Point(322, -1);
            this.B_OpenFolder.Name = "B_OpenFolder";
            this.B_OpenFolder.Size = new System.Drawing.Size(75, 23);
            this.B_OpenFolder.TabIndex = 2;
            this.B_OpenFolder.Text = "Open Folder";
            this.B_OpenFolder.UseVisualStyleBackColor = true;
            this.B_OpenFolder.Click += new System.EventHandler(this.B_OpenFolder_Click);
            // 
            // DumperSWSH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 279);
            this.Controls.Add(this.B_OpenFolder);
            this.Controls.Add(this.TC_Options);
            this.MaximizeBox = false;
            this.Name = "DumperSWSH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SWSHDump";
            this.TC_Options.ResumeLayout(false);
            this.Tab_General.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.Tab_PKHeX.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.Tab_Misc.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.Tab_Future.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TC_Options;
        private System.Windows.Forms.TabPage Tab_General;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button B_ParsePKMDetails;
        private System.Windows.Forms.Button B_DumpTrainers;
        private System.Windows.Forms.Button B_ItemInfo;
        private System.Windows.Forms.Button B_Moves;
        private System.Windows.Forms.TabPage Tab_PKHeX;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button B_PKText;
        private System.Windows.Forms.Button B_PKLearn;
        private System.Windows.Forms.Button B_PKEggMove;
        private System.Windows.Forms.Button B_PKEvo;
        private System.Windows.Forms.Button B_Gift;
        private System.Windows.Forms.Button B_Static;
        private System.Windows.Forms.Button B_Wild;
        private System.Windows.Forms.Button B_PKForms;
        private System.Windows.Forms.Button B_PKRibbon;
        private System.Windows.Forms.Button B_Nest;
        private System.Windows.Forms.Button B_Trade;
        private System.Windows.Forms.TabPage Tab_Misc;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button B_GetDummiedMoveInfo;
        private System.Windows.Forms.Button B_DumpHash;
        private System.Windows.Forms.Button B_GalarDex;
        private System.Windows.Forms.Button B_FlavorText;
        private System.Windows.Forms.Button B_EggMove;
        private System.Windows.Forms.Button B_OpenFolder;
        private System.Windows.Forms.Button B_BattleTower;
        private System.Windows.Forms.Button B_Memories;
        private System.Windows.Forms.TabPage Tab_Future;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button B_Distribution_Nests;
        private System.Windows.Forms.Button B_MaxDens;
    }
}