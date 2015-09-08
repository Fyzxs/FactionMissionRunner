using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControls.actual.eventargs
{
    public class InvalidModelEventArgs<TData, TUid, TUidType> : EventArgs where TData : Data<TUid, TUidType>
                                                                          where TUid : Uid<TUidType>
                                                                          where TUidType : IComparable

    {
        public TData Data { get; private set; }
        public InvalidModelEventArgs(TData data)
        {
            Data = data;
        }
    }
}
