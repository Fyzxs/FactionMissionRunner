using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactionMissionRunnerDataBound.controls.editors
{
    public partial class LabelIntegerEditor : Form
    {
        public LabelIntegerEditor()
        {
            InitializeComponent();
        }
        
        private void LabelEditor_TextChanged(object sender, EventArgs e)
        {
            mxtLabelEdit.Text = Text;
            var size = TextRenderer.MeasureText(mxtLabelEdit.Text, mxtLabelEdit.Font);
            Width = size.Width <= 50 ? 50 : size.Width;
            mxtLabelEdit.Width = Width;
            Height = mxtLabelEdit.Height;
            mxtLabelEdit.Location = new System.Drawing.Point(3, 0);

            mxtLabelEdit.SelectAll();
            mxtLabelEdit.Focus();
        }

        private void LabelEdit_MouseLeave(object sender, EventArgs e)
        {
            Close();
        }

        private void LabelEdit_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    {
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                        Close();
                        break;
                    }
                case Keys.Return:
                    {
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                        Text = mxtLabelEdit.Text;
                        Close();
                        break;
                    }
            }
        }
    }
}
