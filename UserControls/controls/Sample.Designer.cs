namespace UserControls.controls
{
    partial class Sample
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTextEdit1 = new FactionMissionRunnerDataBound.controls.labels.LabelTextEdit();
            this.labelIntegerEdit1 = new FactionMissionRunnerDataBound.controls.labels.LabelIntegerEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTextEdit1
            // 
            this.labelTextEdit1.AutoSize = true;
            this.labelTextEdit1.Location = new System.Drawing.Point(0, 0);
            this.labelTextEdit1.Name = "labelTextEdit1";
            this.labelTextEdit1.Size = new System.Drawing.Size(74, 13);
            this.labelTextEdit1.TabIndex = 0;
            this.labelTextEdit1.Text = "labelTextEdit1";
            // 
            // labelIntegerEdit1
            // 
            this.labelIntegerEdit1.AutoSize = true;
            this.labelIntegerEdit1.Location = new System.Drawing.Point(3, 21);
            this.labelIntegerEdit1.Name = "labelIntegerEdit1";
            this.labelIntegerEdit1.Size = new System.Drawing.Size(86, 13);
            this.labelIntegerEdit1.TabIndex = 1;
            this.labelIntegerEdit1.Text = "labelIntegerEdit1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Sample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelIntegerEdit1);
            this.Controls.Add(this.labelTextEdit1);
            this.Name = "Sample";
            this.Size = new System.Drawing.Size(150, 62);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FactionMissionRunnerDataBound.controls.labels.LabelTextEdit labelTextEdit1;
        private FactionMissionRunnerDataBound.controls.labels.LabelIntegerEdit labelIntegerEdit1;
        private System.Windows.Forms.Button button1;
    }
}
