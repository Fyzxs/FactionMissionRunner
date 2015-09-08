namespace FactionMissionRunnerDataBound.controls.editors
{
    partial class LabelIntegerEditor
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
            this.mxtLabelEdit = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // mxtLabelEdit
            // 
            this.mxtLabelEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.mxtLabelEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mxtLabelEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mxtLabelEdit.CausesValidation = false;
            this.mxtLabelEdit.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.mxtLabelEdit.Location = new System.Drawing.Point(0, 0);
            this.mxtLabelEdit.Margin = new System.Windows.Forms.Padding(0);
            this.mxtLabelEdit.Mask = "99999999";
            this.mxtLabelEdit.Name = "mxtLabelEdit";
            this.mxtLabelEdit.Size = new System.Drawing.Size(50, 13);
            this.mxtLabelEdit.TabIndex = 0;
            this.mxtLabelEdit.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mxtLabelEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LabelEdit_KeyDown);
            this.mxtLabelEdit.MouseLeave += new System.EventHandler(this.LabelEdit_MouseLeave);
            // 
            // LabelIntegerEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(366, 219);
            this.ControlBox = false;
            this.Controls.Add(this.mxtLabelEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LabelIntegerEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LabelIntegerEditor";
            this.TransparencyKey = System.Drawing.SystemColors.HotTrack;
            this.TextChanged += new System.EventHandler(this.LabelEditor_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mxtLabelEdit;
    }
}