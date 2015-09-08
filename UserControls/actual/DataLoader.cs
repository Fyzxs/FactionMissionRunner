using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls.actual.mission;

namespace UserControls.actual
{
    public abstract class DataLoader<TData, TUid, TUidType> where TData : Data<TUid, TUidType>, new()
                                                            where TUid : Uid<TUidType>
                                                            where TUidType : IComparable


    {
        protected List<TData> Datum = new List<TData>();

        public event EventHandler ItemAdded;
        public event EventHandler ItemRemoved;
        public event EventHandler ItemUpdated;
        

        protected virtual void OnItemAdded(TUid uid)
        {
            ItemAdded?.Invoke(this, new DataChangedEventArgs<TUid, TUidType>(uid));
        }
        protected virtual void OnItemRemoved(TUid uid)
        {
            ItemRemoved?.Invoke(this, new DataChangedEventArgs<TUid, TUidType>(uid));
        }
        protected virtual void OnItemUpdated(TUid uid)
        {
            ItemUpdated?.Invoke(this, new DataChangedEventArgs<TUid, TUidType>(uid));
        }

        protected abstract void Read();

        protected abstract void Write();

        public virtual bool Exists(TData data)
        {
            return GetData(data.Id) != null;
        }
        public virtual TData GetData(TUid uid)
        {
            return Datum.FirstOrDefault(data => data.Id.CompareTo(uid) == 0);
        }

        public virtual ICollection<TData> GetAll()
        {
            return Datum;
        }

        public virtual void Save(TData data)
        {
            if (!Exists(data))
            {
                throw new InvalidOperationException("Call 'Add' for new items");
            }
            
            Write();
            OnItemUpdated(data.Id);
        }

        public abstract void Export(TData data);

        public virtual void Remove(TData data)
        {
            
        }

        public virtual void Add(TData data)
        {
            if (Exists(data))
            {
                throw new InvalidOperationException("Call 'Save' for existing items");
            }

            Write();
            OnItemAdded(data.Id);
        }
    }
}
