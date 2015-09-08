using System.Windows.Forms;

namespace FactionMissionRunnerDataBound.controls.editors
{
    partial class LabelTextEditor
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
            this.txtLabelEdit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLabelEdit
            // 
            this.txtLabelEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtLabelEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLabelEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLabelEdit.CausesValidation = false;
            this.txtLabelEdit.Location = new System.Drawing.Point(0, 0);
            this.txtLabelEdit.Margin = new System.Windows.Forms.Padding(0);
            this.txtLabelEdit.Name = "txtLabelEdit";
            this.txtLabelEdit.Size = new System.Drawing.Size(333, 13);
            this.txtLabelEdit.TabIndex = 0;
            this.txtLabelEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LabelEdit_KeyDown);
            this.txtLabelEdit.MouseLeave += new System.EventHandler(this.LabelEdit_MouseLeave);
            // 
            // LabelTextEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(366, 219);
            this.ControlBox = false;
            this.Controls.Add(this.txtLabelEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LabelTextEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LabelTextEditor";
            this.TransparencyKey = System.Drawing.SystemColors.HotTrack;
            this.TextChanged += new System.EventHandler(this.LabelEdit_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLabelEdit;
    }
}