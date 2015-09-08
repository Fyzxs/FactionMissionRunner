using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls.actual.empty;

namespace UserControls.actual.DisplayControls
{
    public class EmptyView<TDisplayView, TData, TUid, TUidType> : DisplayView<EmptyData, EmptyUid, int>
        where TDisplayView : DisplayView<TData,TUid,TUidType>
        where TData : Data<TUid, TUidType>
        where TUid : Uid<TUidType>
        where TUidType : IComparable
    {
        public EmptyView(TDisplayView view)
        {
            Width = view.Width;
            Height = view.Height;
            BorderStyle = BorderStyle.Fixed3D;
            Margin = new Padding(0);
        }
        protected override void UpdateUi()
        {
            throw new NotImplementedException();
        }

        public override void ExtractData()
        {
            throw new NotImplementedException();
        }

        protected override void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
