using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls.controls.headers;

namespace UserControls
{
    public class DisplayPanel : Panel
    {
        private UserControl header = null;
        private readonly Panel panel = new Panel();
       

        public DisplayPanel()
        {
            header = new SampleHeader();
            Controls.Add(header);
            Controls.SetChildIndex(header, 0);
            Width = header.Width + System.Windows.Forms.SystemInformation.VerticalScrollBarWidth + 1;

            panel.AutoScroll = true;
            panel.Height = Height - header.Height;
            panel.Width = Width;
            Controls.Add(panel);
        }
        public void Add(UserControl userControl)
        {
            panel.Controls.Add(userControl);
            panel.Height = panel.Controls.Count*userControl.Height;
            if (panel.Height > Height - header.Height)
            {
                panel.Height = Height - header.Height - 1;
            }
            
            userControl.Top = panel.Controls.Count * userControl.Height;
            userControl.Left = 0;
            userControl.Parent = panel;
        }
    }
}
