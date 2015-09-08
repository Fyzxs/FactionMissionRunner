using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControls.actual
{
    public abstract class Data<TUid, TUidType> : IComparable<Data<TUid, TUidType>> where TUid : Uid<TUidType>
        where TUidType : IComparable
    {
        public TUid Id { get; set; }

        public int CompareTo(Data<TUid, TUidType> other)
        {
            return Id.CompareTo(other.Id);
        }
    }
}
