using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls.actual.mission.forms
{
    public partial class NewForm<TDisplayView, TData, TUid, TUidType> : Form 
        where TDisplayView : DisplayView<TData, TUid, TUidType>, new()
        where TData : Data<TUid, TUidType>
        where TUid : Uid<TUidType>
        where TUidType : IComparable
    {
        public bool IsSaved { get; private set; }
        public TDisplayView EnteredView { get; private set; }
        protected NewForm()
        {
            InitializeComponent();
            EnteredView = new TDisplayView();
            flpSaving.Controls.Add(EnteredView);
            flpSaving.Controls.SetChildIndex(EnteredView, 0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IsSaved = true;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnteredView = null;
            Close();
        }
    }
}

