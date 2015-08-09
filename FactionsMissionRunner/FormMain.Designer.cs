namespace FactionsMissionRunner
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
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "P = Party";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "A = Actual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "I = Intel";
            // 
            // lblStatInfo
            // 
            this.lblStatInfo.AutoSize = true;
            this.lblStatInfo.Location = new System.Drawing.Point(255, 32);
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
            // 
            // lstDefaultStats
            // 
            this.lstDefaultStats.DisplayMember = "DisplayText";
            this.lstDefaultStats.FormattingEnabled = true;
            this.lstDefaultStats.Location = new System.Drawing.Point(15, 94);
            this.lstDefaultStats.Name = "lstDefaultStats";
            this.lstDefaultStats.Size = new System.Drawing.Size(299, 511);
            this.lstDefaultStats.TabIndex = 12;
            // 
            // txtForumCode
            // 
            this.txtForumCode.Location = new System.Drawing.Point(699, 11);
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 778);
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
    }
}

