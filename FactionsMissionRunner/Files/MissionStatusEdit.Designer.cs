namespace FactionsMissionRunner.Files
{
    partial class MissionStatusEdit
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
            this.lstMissionStatus = new System.Windows.Forms.ListBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lstMissionStatus
            // 
            this.lstMissionStatus.FormattingEnabled = true;
            this.lstMissionStatus.Location = new System.Drawing.Point(0, 0);
            this.lstMissionStatus.Name = "lstMissionStatus";
            this.lstMissionStatus.Size = new System.Drawing.Size(130, 212);
            this.lstMissionStatus.TabIndex = 0;
            this.lstMissionStatus.SelectedIndexChanged += new System.EventHandler(this.lstMissionStatus_SelectedIndexChanged);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(136, 12);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(145, 20);
            this.txtText.TabIndex = 1;
            this.txtText.TextChanged += new System.EventHandler(this.txtText_TextChanged);
            // 
            // nudValue
            // 
            this.nudValue.Location = new System.Drawing.Point(161, 38);
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(120, 20);
            this.nudValue.TabIndex = 2;
            this.nudValue.ValueChanged += new System.EventHandler(this.nudValue_ValueChanged);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(136, 83);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(206, 189);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(136, 112);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // MissionStatusEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 216);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.nudValue);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.lstMissionStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MissionStatusEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MissionStatus";
            this.Load += new System.EventHandler(this.MissionStatusEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMissionStatus;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
    }
}