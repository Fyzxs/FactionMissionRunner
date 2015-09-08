using System;
using System.Windows.Forms;

namespace FactionMissionRunnerDataBound.controls.editors
{
    public partial class LabelTextEditor : Form
    {
        public LabelTextEditor()
        {
            InitializeComponent();
        }
        
        private void LabelEdit_TextChanged(object sender, EventArgs e)
        {
            txtLabelEdit.Text = Text;
            var size = TextRenderer.MeasureText(txtLabelEdit.Text, txtLabelEdit.Font);
            Width = size.Width <= 100 ? 100 : size.Width;
            txtLabelEdit.Width = Width;
            Height = txtLabelEdit.Height;
            txtLabelEdit.Location = new System.Drawing.Point(3, 0);

            txtLabelEdit.SelectAll();
            txtLabelEdit.Focus();
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
                    Text = txtLabelEdit.Text;
                    Close();
                    break;
                }
            }
        }
    }
}
