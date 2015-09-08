using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls.controls
{
    public partial class DisplayList : UserControl
    {
        private readonly List<UserControl> userControls = new List<UserControl>();
        public DisplayList()
        {
            InitializeComponent();
        }

        public void add(UserControl userControl)
        {
            userControl.Top = userControls.Count*(userControl.Height + 1);
            userControls.Add(userControl);
            userControl.Left = 0;
            userControl.Parent = this;
        }


    }
}
