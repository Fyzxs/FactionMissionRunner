using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControls.actual
{
    public abstract class DisplayController<TDisplayView, TData, TDisplayModel, TUid, TUidType> 
        where TDisplayView : DisplayView<TData, TUid, TUidType>
        where TData : Data<TUid, TUidType>
        where TDisplayModel : IDisplayModel
        where TUid : Uid<TUidType>
        where TUidType : IComparable
    {

        public event EventHandler DataChanged;

        protected virtual void OnDataChanged(TUid uid)
        {
            DataChanged?.Invoke(this, new DataChangedEventArgs<TUid, TUidType>(uid));
        }

        public TUid Uid { get; set; }
        protected TDisplayView ItemView;

        internal DisplayController(TDisplayView itemView)
        {
            ItemView = itemView;
        }
        internal abstract TDisplayModel GetModel();
        
    }
}
