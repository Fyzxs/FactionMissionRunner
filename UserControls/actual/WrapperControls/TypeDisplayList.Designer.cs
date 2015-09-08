using System;
using System.Windows.Forms;

namespace UserControls.actual
{
    partial class TypeDisplayList<TDisplayView, TData, TUid, TUidType, TDisplayHeader>
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
        protected virtual void InitializeComponent()
        {
            System.Windows.Forms.Panel pnlHeader;
            this.flpContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.flpItems = new System.Windows.Forms.FlowLayoutPanel();
            pnlHeader = new System.Windows.Forms.Panel();
            this.flpContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = System.Drawing.SystemColors.Control;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(198, 31);
            pnlHeader.TabIndex = 0;
            // 
            // flpContainer
            // 
            this.flpContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpContainer.Controls.Add(pnlHeader);
            this.flpContainer.Controls.Add(this.flpItems);
            this.flpContainer.Location = new System.Drawing.Point(0, 0);
            this.flpContainer.Margin = new System.Windows.Forms.Padding(0);
            this.flpContainer.Name = "flpContainer";
            this.flpContainer.Size = new System.Drawing.Size(200, 363);
            this.flpContainer.TabIndex = 0;
            // 
            // flpItems
            // 
            this.flpItems.AutoScroll = true;
            this.flpItems.BackColor = System.Drawing.SystemColors.Control;
            this.flpItems.Location = new System.Drawing.Point(0, 34);
            this.flpItems.Margin = new System.Windows.Forms.Padding(0);
            this.flpItems.Name = "flpItems";
            this.flpItems.Size = new System.Drawing.Size(198, 326);
            this.flpItems.TabIndex = 1;
            // 
            // TypeDisplayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.flpContainer);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TypeDisplayList";
            this.Size = new System.Drawing.Size(200, 363);
            this.Load += new System.EventHandler(this.DisplayList_Load);
            this.flpContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpContainer;
        private System.Windows.Forms.FlowLayoutPanel flpItems;
    }
}
