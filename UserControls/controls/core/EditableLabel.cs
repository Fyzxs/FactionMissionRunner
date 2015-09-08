using System;
using System.Drawing;
using System.Windows.Forms;

namespace FactionMissionRunnerDataBound.controls.core
{
    public class EditableLabel<T> : Label where T:Form, new()
    {
        private T edit;

        public EditableLabel() : base()
        {
            FlatStyle = FlatStyle.Standard;
        } 

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            var locationOnScreen = Parent.PointToScreen(Location);
            if (edit == null || edit.IsDisposed)
            {
                edit = new T();
            }

            edit.Text = Text;
            edit.Location = new Point(locationOnScreen.X, locationOnScreen.Y);
            edit.Show(this);
            edit.Closed += Edit_Closed;
        }

        protected void Edit_Closed(object sender, EventArgs e)
        {
            Text = edit.Text;
        }
    }
}
