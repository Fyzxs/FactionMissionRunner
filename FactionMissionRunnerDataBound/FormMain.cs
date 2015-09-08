using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FactionMissionRunnerDataBound.controls.editors;
using UserControls.controls;
using UserControls.controls.headers;

namespace FactionMissionRunnerDataBound
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void pnl_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        void panel_DragDrop(object sender, DragEventArgs e)
        {
            var lbl = e.Data.GetData(typeof (Label)) as Label;
            if (lbl != null && ((sender == pnlDragTo && lbl.Parent == pnlDragFrom) || (sender == pnlDragFrom && lbl.Parent == pnlDragTo)))
            {
                lbl.Parent = (Panel)sender;
            }
        }
        void ctrl_MouseDown(object sender, MouseEventArgs e)
        {
            var ctrl = sender as Control;
            ctrl?.DoDragDrop(ctrl, DragDropEffects.Move);
        }
    }
}
