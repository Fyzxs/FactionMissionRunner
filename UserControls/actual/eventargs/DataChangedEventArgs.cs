using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControls.actual
{
    public class DataChangedEventArgs<TUid, TUidType> : EventArgs 
        where TUid : Uid<TUidType>
        where TUidType : IComparable

    {
        public TUid Id { get; private set; }

        public DataChangedEventArgs(TUid uid)
        {
            Id = uid;
        }
    }
}
