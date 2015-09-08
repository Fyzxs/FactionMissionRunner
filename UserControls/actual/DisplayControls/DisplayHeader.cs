using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls.actual.DisplayControls
{
    [ToolboxItem(false)]
    public class DisplayHeader : UserControl
    {
        protected DisplayHeader()
        {
            components = new Container();
            AutoScaleMode = AutoScaleMode.Font;
            InitializeComponent();
        }

        public void ShowAddButton(bool show)
        {
            btnAdd.Visible = show;
        }

        private void InitializeComponent() {
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(195, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(19, 22);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // DisplayHeader
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.btnAdd);
            this.Name = "DisplayHeader";
            this.Size = new System.Drawing.Size(217, 28);
            this.ResumeLayout(false);

}
        protected Button btnAdd;

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private readonly IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
