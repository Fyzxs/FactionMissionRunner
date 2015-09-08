using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls.actual.DisplayControls;
using UserControls.actual.eventargs;

namespace UserControls.actual
{
    public abstract class DisplayView<TData, TUid, TUidType> : UserControl 
        where TData : Data<TUid, TUidType>
        where TUid : Uid<TUidType>
        where TUidType : IComparable
    {
        public event EventHandler InvalidModel;

        protected virtual void OnInvalidModel()
        {
            //How to do this w/o using DisplayView (aka the actual View Type)
            InvalidModel?.Invoke(this, new InvalidModelEventArgs<TData, TUid, TUidType>(DataItem));
        }

        private TData dataItem;
        public TData DataItem
        {
            get { return dataItem; }
            set
            {
                if (dataItem != null)
                {
                    throw new InvalidOperationException("Don't set data twice");
                }
                dataItem = value;
                UpdateUi();
            }
        }

        protected abstract void UpdateUi();

        public abstract void ExtractData();

        protected DisplayView()
        {
            components = new Container();
            AutoScaleMode = AutoScaleMode.Font;
        }

        protected abstract void InitializeComponent();

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private readonly IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
