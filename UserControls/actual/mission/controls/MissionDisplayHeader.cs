using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls.actual.DisplayControls;
using UserControls.actual.mission.forms;

namespace UserControls.actual.mission
{
    public class MissionDisplayHeader : DisplayHeader
    {
        private System.Windows.Forms.Label lblSample;

        public MissionDisplayHeader()
        {
            InitializeComponent();
        }

        public void Hack(string s)
        {
            lblSample.Text = s;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newForm = new NewMissionFormInternal();
            newForm.ShowDialog(this);
            if (newForm.IsSaved)
            {
                MissionDataLoader.Instance.Save(newForm.EnteredView.DataItem);
            }
        }
        
        private void InitializeComponent()
        {
            this.lblSample = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(195, 2);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSample
            // 
            this.lblSample.AutoSize = true;
            this.lblSample.Location = new System.Drawing.Point(0, 4);
            this.lblSample.Name = "lblSample";
            this.lblSample.Size = new System.Drawing.Size(102, 13);
            this.lblSample.TabIndex = 0;
            this.lblSample.Text = "{{ Sample Header }}";
            // 
            // MissionDisplayHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.lblSample);
            this.Name = "MissionDisplayHeader";
            this.Size = new System.Drawing.Size(217, 27);
            this.Controls.SetChildIndex(this.lblSample, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
