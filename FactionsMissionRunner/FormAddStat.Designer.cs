namespace FactionsMissionRunner
{
    partial class FormAddStat
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
            this.lblKnown = new System.Windows.Forms.Label();
            this.lblIntel = new System.Windows.Forms.Label();
            this.lblStatLabel = new System.Windows.Forms.Label();
            this.lblActual = new System.Windows.Forms.Label();
            this.nudActual = new System.Windows.Forms.NumericUpDown();
            this.nudIntel = new System.Windows.Forms.NumericUpDown();
            this.nudKnown = new System.Windows.Forms.NumericUpDown();
            this.btnAccept = new System.Windows.Forms.Button();
            this.pnlBoarder = new System.Windows.Forms.Panel();
            this.lblPartyBonus = new System.Windows.Forms.Label();
            this.nudPartyBonus = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKnown)).BeginInit();
            this.pnlBoarder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPartyBonus)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKnown
            // 
            this.lblKnown.AutoSize = true;
            this.lblKnown.Location = new System.Drawing.Point(12, 43);
            this.lblKnown.Name = "lblKnown";
            this.lblKnown.Size = new System.Drawing.Size(70, 13);
            this.lblKnown.TabIndex = 0;
            this.lblKnown.Text = "Known Value";
            // 
            // lblIntel
            // 
            this.lblIntel.AutoSize = true;
            this.lblIntel.Location = new System.Drawing.Point(12, 67);
            this.lblIntel.Name = "lblIntel";
            this.lblIntel.Size = new System.Drawing.Size(57, 13);
            this.lblIntel.TabIndex = 1;
            this.lblIntel.Text = "Intel Value";
            // 
            // lblStatLabel
            // 
            this.lblStatLabel.AutoSize = true;
            this.lblStatLabel.Location = new System.Drawing.Point(12, 12);
            this.lblStatLabel.Name = "lblStatLabel";
            this.lblStatLabel.Size = new System.Drawing.Size(79, 13);
            this.lblStatLabel.TabIndex = 2;
            this.lblStatLabel.Text = "{STAT_HERE}";
            // 
            // lblActual
            // 
            this.lblActual.AutoSize = true;
            this.lblActual.Location = new System.Drawing.Point(12, 91);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(67, 13);
            this.lblActual.TabIndex = 3;
            this.lblActual.Text = "Actual Value";
            // 
            // nudActual
            // 
            this.nudActual.Location = new System.Drawing.Point(94, 87);
            this.nudActual.Name = "nudActual";
            this.nudActual.Size = new System.Drawing.Size(34, 20);
            this.nudActual.TabIndex = 4;
            // 
            // nudIntel
            // 
            this.nudIntel.Location = new System.Drawing.Point(94, 63);
            this.nudIntel.Name = "nudIntel";
            this.nudIntel.Size = new System.Drawing.Size(34, 20);
            this.nudIntel.TabIndex = 5;
            // 
            // nudKnown
            // 
            this.nudKnown.Location = new System.Drawing.Point(94, 39);
            this.nudKnown.Name = "nudKnown";
            this.nudKnown.Size = new System.Drawing.Size(34, 20);
            this.nudKnown.TabIndex = 6;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(53, 137);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 7;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // pnlBoarder
            // 
            this.pnlBoarder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBoarder.Controls.Add(this.lblPartyBonus);
            this.pnlBoarder.Controls.Add(this.nudPartyBonus);
            this.pnlBoarder.Controls.Add(this.lblStatLabel);
            this.pnlBoarder.Controls.Add(this.btnAccept);
            this.pnlBoarder.Controls.Add(this.lblKnown);
            this.pnlBoarder.Controls.Add(this.nudKnown);
            this.pnlBoarder.Controls.Add(this.lblIntel);
            this.pnlBoarder.Controls.Add(this.nudIntel);
            this.pnlBoarder.Controls.Add(this.lblActual);
            this.pnlBoarder.Controls.Add(this.nudActual);
            this.pnlBoarder.Location = new System.Drawing.Point(0, 0);
            this.pnlBoarder.Name = "pnlBoarder";
            this.pnlBoarder.Size = new System.Drawing.Size(143, 166);
            this.pnlBoarder.TabIndex = 8;
            // 
            // lblPartyBonus
            // 
            this.lblPartyBonus.AutoSize = true;
            this.lblPartyBonus.Location = new System.Drawing.Point(12, 115);
            this.lblPartyBonus.Name = "lblPartyBonus";
            this.lblPartyBonus.Size = new System.Drawing.Size(64, 13);
            this.lblPartyBonus.TabIndex = 8;
            this.lblPartyBonus.Text = "Party Bonus";
            // 
            // nudPartyBonus
            // 
            this.nudPartyBonus.Location = new System.Drawing.Point(94, 111);
            this.nudPartyBonus.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nudPartyBonus.Name = "nudPartyBonus";
            this.nudPartyBonus.Size = new System.Drawing.Size(34, 20);
            this.nudPartyBonus.TabIndex = 9;
            // 
            // FormAddStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(143, 166);
            this.Controls.Add(this.pnlBoarder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddStat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddStat";
            ((System.ComponentModel.ISupportInitialize)(this.nudActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKnown)).EndInit();
            this.pnlBoarder.ResumeLayout(false);
            this.pnlBoarder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPartyBonus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblKnown;
        private System.Windows.Forms.Label lblIntel;
        private System.Windows.Forms.Label lblStatLabel;
        private System.Windows.Forms.Label lblActual;
        private System.Windows.Forms.NumericUpDown nudActual;
        private System.Windows.Forms.NumericUpDown nudIntel;
        private System.Windows.Forms.NumericUpDown nudKnown;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Panel pnlBoarder;
        private System.Windows.Forms.Label lblPartyBonus;
        private System.Windows.Forms.NumericUpDown nudPartyBonus;
    }
}