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
            this.label1 = new System.Windows.Forms.Label();
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
            this.label5 = new System.Windows.Forms.Label();
            this.nudAdditionalSuccessMod = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudMedianPartyLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdditionalSuccessMod)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "P = Party Bonus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "A = Actual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "I = Intel";
            // 
            // lblStatInfo
            // 
            this.lblStatInfo.AutoSize = true;
            this.lblStatInfo.Location = new System.Drawing.Point(229, 32);
            this.lblStatInfo.Name = "lblStatInfo";
            this.lblStatInfo.Size = new System.Drawing.Size(59, 13);
            this.lblStatInfo.TabIndex = 18;
            this.lblStatInfo.Text = "K = Known";
            // 
            // lblMissionName
            // 
            this.lblMissionName.AutoSize = true;
            this.lblMissionName.Location = new System.Drawing.Point(12, 9);
            this.lblMissionName.Name = "lblMissionName";
            this.lblMissionName.Size = new System.Drawing.Size(76, 13);
            this.lblMissionName.TabIndex = 14;
            this.lblMissionName.Text = "Mission Name:";
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Location = new System.Drawing.Point(918, 9);
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
            this.lstDefaultStats.Location = new System.Drawing.Point(15, 94);
            this.lstDefaultStats.Name = "lstDefaultStats";
            this.lstDefaultStats.Size = new System.Drawing.Size(299, 511);
            this.lstDefaultStats.TabIndex = 12;
            this.lstDefaultStats.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstDefaultStats_MouseDoubleClick);
            // 
            // txtForumCode
            // 
            this.txtForumCode.Location = new System.Drawing.Point(780, 32);
            this.txtForumCode.Multiline = true;
            this.txtForumCode.Name = "txtForumCode";
            this.txtForumCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtForumCode.Size = new System.Drawing.Size(213, 122);
            this.txtForumCode.TabIndex = 16;
            // 
            // txtMissionName
            // 
            this.txtMissionName.Location = new System.Drawing.Point(94, 5);
            this.txtMissionName.Name = "txtMissionName";
            this.txtMissionName.Size = new System.Drawing.Size(220, 20);
            this.txtMissionName.TabIndex = 13;
            this.txtMissionName.TextChanged += new System.EventHandler(this.txtMissionName_TextChanged);
            // 
            // lblMissionStats
            // 
            this.lblMissionStats.AutoSize = true;
            this.lblMissionStats.Location = new System.Drawing.Point(12, 74);
            this.lblMissionStats.Name = "lblMissionStats";
            this.lblMissionStats.Size = new System.Drawing.Size(72, 13);
            this.lblMissionStats.TabIndex = 15;
            this.lblMissionStats.Text = "Mission Stats:";
            // 
            // lstNpcs
            // 
            this.lstNpcs.FormattingEnabled = true;
            this.lstNpcs.Location = new System.Drawing.Point(320, 94);
            this.lstNpcs.Name = "lstNpcs";
            this.lstNpcs.Size = new System.Drawing.Size(249, 514);
            this.lstNpcs.TabIndex = 22;
            // 
            // lblNpcs
            // 
            this.lblNpcs.AutoSize = true;
            this.lblNpcs.Location = new System.Drawing.Point(317, 74);
            this.lblNpcs.Name = "lblNpcs";
            this.lblNpcs.Size = new System.Drawing.Size(37, 13);
            this.lblNpcs.TabIndex = 23;
            this.lblNpcs.Text = "NPCs:";
            // 
            // txtMissionResolved
            // 
            this.txtMissionResolved.Location = new System.Drawing.Point(614, 238);
            this.txtMissionResolved.Multiline = true;
            this.txtMissionResolved.Name = "txtMissionResolved";
            this.txtMissionResolved.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMissionResolved.Size = new System.Drawing.Size(379, 367);
            this.txtMissionResolved.TabIndex = 24;
            // 
            // btnCopyResult
            // 
            this.btnCopyResult.Location = new System.Drawing.Point(918, 209);
            this.btnCopyResult.Name = "btnCopyResult";
            this.btnCopyResult.Size = new System.Drawing.Size(75, 23);
            this.btnCopyResult.TabIndex = 25;
            this.btnCopyResult.Text = "To Clipboard";
            this.btnCopyResult.UseVisualStyleBackColor = true;
            this.btnCopyResult.Click += new System.EventHandler(this.btnCopyResult_Click);
            // 
            // btnResolveMission
            // 
            this.btnResolveMission.Location = new System.Drawing.Point(825, 209);
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
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Mission Party Level:";
            // 
            // nudMedianPartyLevel
            // 
            this.nudMedianPartyLevel.Location = new System.Drawing.Point(123, 42);
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
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(611, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Additional Success Modifier:";
            // 
            // nudAdditionalSuccessMod
            // 
            this.nudAdditionalSuccessMod.Location = new System.Drawing.Point(768, 209);
            this.nudAdditionalSuccessMod.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudAdditionalSuccessMod.Name = "nudAdditionalSuccessMod";
            this.nudAdditionalSuccessMod.Size = new System.Drawing.Size(36, 20);
            this.nudAdditionalSuccessMod.TabIndex = 31;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 778);
            this.Controls.Add(this.nudAdditionalSuccessMod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudMedianPartyLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnResolveMission);
            this.Controls.Add(this.btnCopyResult);
            this.Controls.Add(this.txtMissionResolved);
            this.Controls.Add(this.lblNpcs);
            this.Controls.Add(this.lstNpcs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatInfo);
            this.Controls.Add(this.lblMissionName);
            this.Controls.Add(this.btnCopyToClipboard);
            this.Controls.Add(this.lstDefaultStats);
            this.Controls.Add(this.txtForumCode);
            this.Controls.Add(this.txtMissionName);
            this.Controls.Add(this.lblMissionStats);
            this.Name = "FrmMain";
            this.Text = "FACTION MISSION RUNNER";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMedianPartyLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdditionalSuccessMod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudAdditionalSuccessMod;
    }
}

