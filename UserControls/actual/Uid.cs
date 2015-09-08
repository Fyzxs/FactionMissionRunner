using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControls.actual
{
    public abstract class Uid<T> : IComparable<Uid<T>> where T : IComparable
    {
        public T Value { get;}

        protected Uid(T uid)
        {
            Value = uid;
        }

        public int CompareTo(Uid<T> other)
        {
            return Value.CompareTo(other.Value);
        }
    }
}
