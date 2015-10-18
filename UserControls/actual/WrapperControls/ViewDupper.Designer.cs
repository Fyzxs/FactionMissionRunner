using System.Windows.Forms;
using UserControls.actual.mission;

namespace UserControls.actual.WrapperControls
{
    partial class ViewDupper<TDisplayList, TDisplayView, TData, TUid, TUidType, TDisplayHeader>
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected TDisplayList lstFull;
        protected TDisplayList lstXfer;

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
            this.SuspendLayout();


            this.lstFull = new TDisplayList();
            this.lstXfer = new TDisplayList();
            this.SuspendLayout();
            // 
            // lstFull
            // 
            this.lstFull.AutoSize = true;
            this.lstFull.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lstFull.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lstFull.Location = new System.Drawing.Point(285, 78);
            this.lstFull.Margin = new System.Windows.Forms.Padding(0);
            this.lstFull.Name = "lstFull";
            this.lstFull.Size = new System.Drawing.Size(234, 363);
            this.lstFull.TabIndex = 0;
            this.lstFull.AllowDrop = true;
            // 
            // lstXfer
            // 
            this.lstXfer.AutoSize = true;
            this.lstXfer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lstXfer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lstXfer.Location = new System.Drawing.Point(13, 78);
            this.lstXfer.Margin = new System.Windows.Forms.Padding(0);
            this.lstXfer.Name = "lstXfer";
            this.lstXfer.Size = new System.Drawing.Size(234, 363);
            this.lstXfer.TabIndex = 1;
            this.lstXfer.IgnoreFullData = true;
            this.lstXfer.AllowDrop = true;
            // 
            // MissionViewSwapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.lstXfer);
            this.Controls.Add(this.lstFull);
            this.Name = "MissionViewSwapper";
            this.Size = new System.Drawing.Size(597, 454);
            this.ResumeLayout(false);
            this.PerformLayout();
            // 
            // ViewSwapperInternal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ViewSwapper";
            this.Size = new System.Drawing.Size(534, 454);
            this.ResumeLayout(false);

        }

        #endregion
        
    }
}
