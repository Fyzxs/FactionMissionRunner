﻿namespace FactionsMissionRunner
{
    partial class FrmMain
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatInfo = new System.Windows.Forms.Label();
            this.lblMissionName = new System.Windows.Forms.Label();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.lstDefaultStats = new System.Windows.Forms.ListBox();
            this.txtForumCode = new System.Windows.Forms.TextBox();
            this.txtMissionName = new System.Windows.Forms.TextBox();
            this.lblMissionStats = new System.Windows.Forms.Label();
            this.lstNpcs = new System.Windows.Forms.CheckedListBox();
            this.lblNpcs = new System.Windows.Forms.Label();
            this.txtMissionResolved = new System.Windows.Forms.TextBox();
            this.btnCopyResult = new System.Windows.Forms.Button();
            this.btnResolveMission = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nudMedianPartyLevel = new System.Windows.Forms.NumericUpDown();
            this.lstStatResults = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMissionNotes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mniEditors = new System.Windows.Forms.ToolStripMenuItem();
            this.missionStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nPCsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.missionResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerHijinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.missionStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lstMissions = new System.Windows.Forms.ListBox();
            this.btnSaveMission = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.nudAdditionalSuccessMod = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNewMission = new System.Windows.Forms.Button();
            this.btnDeleteMission = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMedianPartyLevel)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdditionalSuccessMod)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "P = Party Bonus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "A = Actual";
            // 
            // lblStatInfo
            // 
            this.lblStatInfo.AutoSize = true;
            this.lblStatInfo.Location = new System.Drawing.Point(91, 82);
            this.lblStatInfo.Name = "lblStatInfo";
            this.lblStatInfo.Size = new System.Drawing.Size(59, 13);
            this.lblStatInfo.TabIndex = 18;
            this.lblStatInfo.Text = "K = Known";
            // 
            // lblMissionName
            // 
            this.lblMissionName.AutoSize = true;
            this.lblMissionName.Location = new System.Drawing.Point(12, 36);
            this.lblMissionName.Name = "lblMissionName";
            this.lblMissionName.Size = new System.Drawing.Size(76, 13);
            this.lblMissionName.TabIndex = 14;
            this.lblMissionName.Text = "Mission Name:";
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Location = new System.Drawing.Point(918, 36);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(75, 23);
            this.btnCopyToClipboard.TabIndex = 17;
            this.btnCopyToClipboard.Text = "To Clipboard";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // lstDefaultStats
            // 
            this.lstDefaultStats.DisplayMember = "DisplayText";
            this.lstDefaultStats.FormattingEnabled = true;
            this.lstDefaultStats.Location = new System.Drawing.Point(15, 102);
            this.lstDefaultStats.Name = "lstDefaultStats";
            this.lstDefaultStats.Size = new System.Drawing.Size(299, 394);
            this.lstDefaultStats.Sorted = true;
            this.lstDefaultStats.TabIndex = 12;
            this.lstDefaultStats.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstDefaultStats_MouseDoubleClick);
            // 
            // txtForumCode
            // 
            this.txtForumCode.Location = new System.Drawing.Point(780, 59);
            this.txtForumCode.Multiline = true;
            this.txtForumCode.Name = "txtForumCode";
            this.txtForumCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtForumCode.Size = new System.Drawing.Size(213, 122);
            this.txtForumCode.TabIndex = 16;
            // 
            // txtMissionName
            // 
            this.txtMissionName.Location = new System.Drawing.Point(94, 32);
            this.txtMissionName.Name = "txtMissionName";
            this.txtMissionName.Size = new System.Drawing.Size(220, 20);
            this.txtMissionName.TabIndex = 13;
            this.txtMissionName.TextChanged += new System.EventHandler(this.txtMissionName_TextChanged);
            // 
            // lblMissionStats
            // 
            this.lblMissionStats.AutoSize = true;
            this.lblMissionStats.Location = new System.Drawing.Point(12, 82);
            this.lblMissionStats.Name = "lblMissionStats";
            this.lblMissionStats.Size = new System.Drawing.Size(72, 13);
            this.lblMissionStats.TabIndex = 15;
            this.lblMissionStats.Text = "Mission Stats:";
            // 
            // lstNpcs
            // 
            this.lstNpcs.FormattingEnabled = true;
            this.lstNpcs.Location = new System.Drawing.Point(320, 102);
            this.lstNpcs.Name = "lstNpcs";
            this.lstNpcs.Size = new System.Drawing.Size(249, 394);
            this.lstNpcs.Sorted = true;
            this.lstNpcs.TabIndex = 22;
            this.lstNpcs.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstNpcs_ItemCheck);
            // 
            // lblNpcs
            // 
            this.lblNpcs.AutoSize = true;
            this.lblNpcs.Location = new System.Drawing.Point(317, 82);
            this.lblNpcs.Name = "lblNpcs";
            this.lblNpcs.Size = new System.Drawing.Size(37, 13);
            this.lblNpcs.TabIndex = 23;
            this.lblNpcs.Text = "NPCs:";
            // 
            // txtMissionResolved
            // 
            this.txtMissionResolved.Location = new System.Drawing.Point(803, 251);
            this.txtMissionResolved.Multiline = true;
            this.txtMissionResolved.Name = "txtMissionResolved";
            this.txtMissionResolved.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMissionResolved.Size = new System.Drawing.Size(190, 367);
            this.txtMissionResolved.TabIndex = 24;
            // 
            // btnCopyResult
            // 
            this.btnCopyResult.Location = new System.Drawing.Point(918, 222);
            this.btnCopyResult.Name = "btnCopyResult";
            this.btnCopyResult.Size = new System.Drawing.Size(75, 23);
            this.btnCopyResult.TabIndex = 25;
            this.btnCopyResult.Text = "To Clipboard";
            this.btnCopyResult.UseVisualStyleBackColor = true;
            this.btnCopyResult.Click += new System.EventHandler(this.btnCopyResult_Click);
            // 
            // btnResolveMission
            // 
            this.btnResolveMission.Location = new System.Drawing.Point(803, 222);
            this.btnResolveMission.Name = "btnResolveMission";
            this.btnResolveMission.Size = new System.Drawing.Size(75, 23);
            this.btnResolveMission.TabIndex = 26;
            this.btnResolveMission.Text = "Resolve Mission";
            this.btnResolveMission.UseVisualStyleBackColor = true;
            this.btnResolveMission.Click += new System.EventHandler(this.btnResolveMission_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Mission Party Level:";
            // 
            // nudMedianPartyLevel
            // 
            this.nudMedianPartyLevel.Location = new System.Drawing.Point(123, 55);
            this.nudMedianPartyLevel.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudMedianPartyLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMedianPartyLevel.Name = "nudMedianPartyLevel";
            this.nudMedianPartyLevel.Size = new System.Drawing.Size(36, 20);
            this.nudMedianPartyLevel.TabIndex = 28;
            this.nudMedianPartyLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMedianPartyLevel.ValueChanged += new System.EventHandler(this.nudMedianPartyLevel_ValueChanged);
            // 
            // lstStatResults
            // 
            this.lstStatResults.Enabled = false;
            this.lstStatResults.FormattingEnabled = true;
            this.lstStatResults.Location = new System.Drawing.Point(575, 251);
            this.lstStatResults.Name = "lstStatResults";
            this.lstStatResults.Size = new System.Drawing.Size(222, 364);
            this.lstStatResults.Sorted = true;
            this.lstStatResults.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Stat Results (checked = passed)";
            // 
            // txtMissionNotes
            // 
            this.txtMissionNotes.Location = new System.Drawing.Point(603, 59);
            this.txtMissionNotes.Multiline = true;
            this.txtMissionNotes.Name = "txtMissionNotes";
            this.txtMissionNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMissionNotes.Size = new System.Drawing.Size(171, 122);
            this.txtMissionNotes.TabIndex = 34;
            this.txtMissionNotes.TextChanged += new System.EventHandler(this.txtMissionNotes_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(600, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Mission Notes";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniEditors});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 24);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mniEditors
            // 
            this.mniEditors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.missionStatsToolStripMenuItem,
            this.nPCsToolStripMenuItem,
            this.missionResultsToolStripMenuItem,
            this.playerHijinksToolStripMenuItem,
            this.missionStatusToolStripMenuItem});
            this.mniEditors.Name = "mniEditors";
            this.mniEditors.Size = new System.Drawing.Size(86, 20);
            this.mniEditors.Text = "JSON Editors";
            // 
            // missionStatsToolStripMenuItem
            // 
            this.missionStatsToolStripMenuItem.Name = "missionStatsToolStripMenuItem";
            this.missionStatsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.missionStatsToolStripMenuItem.Text = "Stats";
            this.missionStatsToolStripMenuItem.Click += new System.EventHandler(this.missionStatsToolStripMenuItem_Click);
            // 
            // nPCsToolStripMenuItem
            // 
            this.nPCsToolStripMenuItem.Name = "nPCsToolStripMenuItem";
            this.nPCsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.nPCsToolStripMenuItem.Text = "NPCs";
            this.nPCsToolStripMenuItem.Click += new System.EventHandler(this.nPCsToolStripMenuItem_Click);
            // 
            // missionResultsToolStripMenuItem
            // 
            this.missionResultsToolStripMenuItem.Name = "missionResultsToolStripMenuItem";
            this.missionResultsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.missionResultsToolStripMenuItem.Text = "Mission Results";
            this.missionResultsToolStripMenuItem.Click += new System.EventHandler(this.missionResultsToolStripMenuItem_Click);
            // 
            // playerHijinksToolStripMenuItem
            // 
            this.playerHijinksToolStripMenuItem.Name = "playerHijinksToolStripMenuItem";
            this.playerHijinksToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.playerHijinksToolStripMenuItem.Text = "Player Hijinks";
            this.playerHijinksToolStripMenuItem.Click += new System.EventHandler(this.playerHijinksToolStripMenuItem_Click);
            // 
            // missionStatusToolStripMenuItem
            // 
            this.missionStatusToolStripMenuItem.Name = "missionStatusToolStripMenuItem";
            this.missionStatusToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.missionStatusToolStripMenuItem.Text = "Mission Status";
            this.missionStatusToolStripMenuItem.Click += new System.EventHandler(this.missionStatusToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Missions To Load: (Shut up I\'m just stuffing it in)";
            // 
            // lstMissions
            // 
            this.lstMissions.DisplayMember = "DisplayText";
            this.lstMissions.FormattingEnabled = true;
            this.lstMissions.Location = new System.Drawing.Point(15, 530);
            this.lstMissions.Name = "lstMissions";
            this.lstMissions.Size = new System.Drawing.Size(299, 238);
            this.lstMissions.Sorted = true;
            this.lstMissions.TabIndex = 38;
            this.lstMissions.SelectedIndexChanged += new System.EventHandler(this.lstMissions_SelectedIndexChanged);
            // 
            // btnSaveMission
            // 
            this.btnSaveMission.Location = new System.Drawing.Point(320, 530);
            this.btnSaveMission.Name = "btnSaveMission";
            this.btnSaveMission.Size = new System.Drawing.Size(75, 36);
            this.btnSaveMission.TabIndex = 39;
            this.btnSaveMission.Text = "Save All Missions";
            this.btnSaveMission.UseVisualStyleBackColor = true;
            this.btnSaveMission.Click += new System.EventHandler(this.btnSaveMission_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 569);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "NOTE: The \"Mission Name\" is the identifier.";
            // 
            // nudAdditionalSuccessMod
            // 
            this.nudAdditionalSuccessMod.Location = new System.Drawing.Point(477, 51);
            this.nudAdditionalSuccessMod.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudAdditionalSuccessMod.Name = "nudAdditionalSuccessMod";
            this.nudAdditionalSuccessMod.Size = new System.Drawing.Size(36, 20);
            this.nudAdditionalSuccessMod.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Additional Success Modifier:";
            // 
            // btnNewMission
            // 
            this.btnNewMission.Location = new System.Drawing.Point(401, 530);
            this.btnNewMission.Name = "btnNewMission";
            this.btnNewMission.Size = new System.Drawing.Size(75, 36);
            this.btnNewMission.TabIndex = 43;
            this.btnNewMission.Text = "New Mission";
            this.btnNewMission.UseVisualStyleBackColor = true;
            this.btnNewMission.Click += new System.EventHandler(this.btnNewMission_Click);
            // 
            // btnDeleteMission
            // 
            this.btnDeleteMission.Location = new System.Drawing.Point(323, 599);
            this.btnDeleteMission.Name = "btnDeleteMission";
            this.btnDeleteMission.Size = new System.Drawing.Size(75, 36);
            this.btnDeleteMission.TabIndex = 44;
            this.btnDeleteMission.Text = "Delete Mission";
            this.btnDeleteMission.UseVisualStyleBackColor = true;
            this.btnDeleteMission.Click += new System.EventHandler(this.btnDeleteMission_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 741);
            this.Controls.Add(this.btnDeleteMission);
            this.Controls.Add(this.btnNewMission);
            this.Controls.Add(this.nudAdditionalSuccessMod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSaveMission);
            this.Controls.Add(this.lstMissions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMissionNotes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstStatResults);
            this.Controls.Add(this.nudMedianPartyLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnResolveMission);
            this.Controls.Add(this.btnCopyResult);
            this.Controls.Add(this.txtMissionResolved);
            this.Controls.Add(this.lblNpcs);
            this.Controls.Add(this.lstNpcs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStatInfo);
            this.Controls.Add(this.lblMissionName);
            this.Controls.Add(this.btnCopyToClipboard);
            this.Controls.Add(this.lstDefaultStats);
            this.Controls.Add(this.txtForumCode);
            this.Controls.Add(this.txtMissionName);
            this.Controls.Add(this.lblMissionStats);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FACTION MISSION RUNNER";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMedianPartyLevel)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdditionalSuccessMod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatInfo;
        private System.Windows.Forms.Label lblMissionName;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.ListBox lstDefaultStats;
        private System.Windows.Forms.TextBox txtForumCode;
        private System.Windows.Forms.TextBox txtMissionName;
        private System.Windows.Forms.Label lblMissionStats;
        private System.Windows.Forms.CheckedListBox lstNpcs;
        private System.Windows.Forms.Label lblNpcs;
        private System.Windows.Forms.TextBox txtMissionResolved;
        private System.Windows.Forms.Button btnCopyResult;
        private System.Windows.Forms.Button btnResolveMission;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudMedianPartyLevel;
        private System.Windows.Forms.CheckedListBox lstStatResults;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMissionNotes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniEditors;
        private System.Windows.Forms.ToolStripMenuItem missionStatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nPCsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem missionResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerHijinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem missionStatusToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstMissions;
        private System.Windows.Forms.Button btnSaveMission;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudAdditionalSuccessMod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNewMission;
        private System.Windows.Forms.Button btnDeleteMission;
    }
}

