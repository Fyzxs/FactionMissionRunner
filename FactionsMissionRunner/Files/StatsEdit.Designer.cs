namespace FactionsMissionRunner.Files
{
    partial class StatsEdit
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
            this.lstItems = new System.Windows.Forms.ListBox();
            this.txtString = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtFailureFlavor = new System.Windows.Forms.TextBox();
            this.lblFailureFlavor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstItems
            // 
            this.lstItems.DisplayMember = "StatName";
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(-2, 12);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(185, 251);
            this.lstItems.TabIndex = 0;
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstHijinks_SelectedIndexChanged);
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(189, 12);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(245, 20);
            this.txtString.TabIndex = 1;
            this.txtString.TextChanged += new System.EventHandler(this.txtText_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(189, 203);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(189, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(189, 174);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtFailureFlavor
            // 
            this.txtFailureFlavor.Location = new System.Drawing.Point(285, 38);
            this.txtFailureFlavor.Multiline = true;
            this.txtFailureFlavor.Name = "txtFailureFlavor";
            this.txtFailureFlavor.Size = new System.Drawing.Size(142, 225);
            this.txtFailureFlavor.TabIndex = 10;
            this.txtFailureFlavor.TextChanged += new System.EventHandler(this.txtFailureFlavor_TextChanged);
            // 
            // lblFailureFlavor
            // 
            this.lblFailureFlavor.AutoSize = true;
            this.lblFailureFlavor.Location = new System.Drawing.Point(209, 38);
            this.lblFailureFlavor.Name = "lblFailureFlavor";
            this.lblFailureFlavor.Size = new System.Drawing.Size(70, 13);
            this.lblFailureFlavor.TabIndex = 11;
            this.lblFailureFlavor.Text = "Failure Flavor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "one per line";
            // 
            // StatsEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 283);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFailureFlavor);
            this.Controls.Add(this.txtFailureFlavor);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.lstItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StatsEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stats Edit";
            this.Load += new System.EventHandler(this.StatsEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtFailureFlavor;
        private System.Windows.Forms.Label lblFailureFlavor;
        private System.Windows.Forms.Label label1;
    }
}