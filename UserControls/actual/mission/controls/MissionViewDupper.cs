using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControls.actual.mission.internals;

namespace UserControls.actual.mission.controls
{
    public class MissionViewDupper : MissionViewDupperInternal
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // lstFull
            // 
            this.lstFull.Size = new System.Drawing.Size(218, 363);
            // 
            // lstXfer
            // 
            this.lstXfer.Size = new System.Drawing.Size(218, 363);
            // 
            // MissionViewDupper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "MissionViewDupper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
