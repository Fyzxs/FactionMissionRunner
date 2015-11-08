using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls.actual.DisplayControls;
using UserControls.actual.mission;

namespace UserControls.actual
{
    public abstract partial class TypeDisplayList<TDisplayView, TData, TUid, TUidType, TDisplayHeader> : UserControl
        where TDisplayView : DisplayView<TData, TUid, TUidType>, new()
        where TData : Data<TUid, TUidType>
        where TUid : Uid<TUidType>
        where TDisplayHeader : DisplayHeader
        where TUidType : IComparable
    {

        public override bool AllowDrop
        {
            get { return base.AllowDrop; }
            set
            {
                Debug.WriteLine("Setting [flpItems.AllowDrop={0}]", value);
                flpItems.AllowDrop = value;
            }
        }

        private bool isDropCopy;

        public bool IsDropCopy
        {
            get { return isDropCopy; }
            set
            {
                isDropCopy = value;
                //Might need to set something on pnlItems
            }
        }

        public bool Contains(TData data)
        {
            return flpItems.Controls.Cast<TDisplayView>().Any(view => view.DataItem.CompareTo(data) == 0);
        }

        public bool IgnoreFullData { get; set; }


        public void ShowAddButton(bool show)
        {
            var pnlHeader = flpContainer.Controls.Find("pnlHeader", false)[0];
            ((TDisplayHeader) pnlHeader.Controls[0]).ShowAddButton(show);
        }

        protected TDisplayHeader ListDisplayHeader
        {
            set
            {
                var pnlHeader = flpContainer.Controls.Find("pnlHeader", false)[0];
                pnlHeader.Controls.Clear();
                pnlHeader.Controls.Add(value);
                pnlHeader.Width = value.Width + 1;
                pnlHeader.Height = value.Height;

                flpItems.Height = flpContainer.Height - pnlHeader.Height - 3;
                flpItems.Width = pnlHeader.Width;

                flpContainer.Width = pnlHeader.Width;
            }
        }

        protected TDisplayView[] AllDisplayViews
        {
            set
            {
                foreach (TDisplayView control in flpItems.Controls)
                {
                    control.InvalidModel -= OnInvalidModel;
                    control.MouseDown -= view_MouseDown;
                }
                flpItems.Controls.Clear();
                foreach (var displayView in value)
                {
                    Add(displayView);
                }
            }
        }

        protected void Remove(TData data)
        {
            // ReSharper disable once LoopCanBePartlyConvertedToQuery
            foreach (TDisplayView view in flpItems.Controls)
            {
                if (view.DataItem.Id.Value.CompareTo(data.Id.Value) != 0) continue;

                flpItems.Controls.Remove(view);
                view.MouseDown -= view_MouseDown;
                view.InvalidModel -= OnInvalidModel;

            }
        }

        protected void Add(TDisplayView view)
        {
            if (Contains(view.DataItem)) return;

            view.InvalidModel += OnInvalidModel;
            view.MouseDown += view_MouseDown;
            flpItems.Controls.Add(view);
        }

        internal void DroppedView(TDisplayView view)
        {
            if (IsDropCopy)
            {
                return;
            }
            view.Parent = flpItems;
            view.MouseDown += view_MouseDown;
            view.InvalidModel += OnInvalidModel;

            ClearDragEffects();
        }

        internal void DraggedView(TDisplayView view)
        {
            if (IsDropCopy) return;

            view.MouseDown -= view_MouseDown;
            view.InvalidModel -= OnInvalidModel;
            ClearDragEffects();
        }

        internal bool IsPanelItemsParent(TDisplayView view)
        {
            return view.Parent == flpItems || view == draggingView;
        }

        internal bool IsPanelItems(FlowLayoutPanel ctrl)
        {
            return ctrl == flpItems;
        }

        private TDisplayView draggingView = null;

        protected internal virtual void view_MouseDown(object sender, MouseEventArgs e)
        {
            if (!flpItems.AllowDrop)
            {
                return;
            }
            var view = sender as TDisplayView;
            Debug.WriteLine("Inside view_MouseDown [ctrl={0}] [AllowDrop={1}]", view, flpItems.AllowDrop);
            if (view == null)
            {
                return;
            }
            if (!IsDropCopy)
            {
                var emptyView = new EmptyView<TDisplayView, TData, TUid, TUidType>(view) {Visible = false};
                draggingView = view;
                flpItems.Controls.Add(emptyView);
                flpItems.Controls.SetChildIndex(emptyView, flpItems.Controls.GetChildIndex(view));
                flpItems.Controls.Remove(view);
                flpItems.DoDragDrop(view, IsDropCopy ? DragDropEffects.Copy : DragDropEffects.Move);
            }
            else
            {
                if (view.Tag == null || !view.Tag.Equals("CLONE"))
                {
                    Debug.WriteLine("CLONING");
                    var clone = new TDisplayView
                    {
                        DataItem = view.DataItem,
                        Parent = null,
                        BorderStyle = BorderStyle.Fixed3D
                    };
                    clone.MouseDown += view_MouseDown;
                    flpItems.DoDragDrop(clone, DragDropEffects.Copy);
                }
                else
                {
                    Debug.WriteLine("SETTING DraggingView");
                    flpItems.DoDragDrop(view, DragDropEffects.Copy);
                    draggingView = view;
                }
            }

            view.BorderStyle = BorderStyle.Fixed3D;
        }


        public void ClearDragEffects(bool abandon = false)
        {
            for (var i = flpItems.Controls.Count - 1; i >= 0; i--)
            {
                if (!IsDropCopy)
                {
                    var view = flpItems.Controls[i] as EmptyView<TDisplayView, TData, TUid, TUidType>;
                    if (view == null)
                    {
                        continue;
                    }
                    flpItems.Controls.RemoveAt(i);
                    if (abandon)
                    {
                        flpItems.Controls.Add(draggingView);
                        flpItems.Controls.SetChildIndex(draggingView, i);
                    }
                    if (draggingView != null)
                    {
                        draggingView.BorderStyle = BorderStyle.FixedSingle;
                        draggingView = null;
                    }
                    break;
                }
                else
                {
                    if (draggingView != null && abandon)
                    {
                        flpItems.Controls.Remove(draggingView);
                        draggingView.Parent = null;
                        draggingView = null;
                        continue;
                    }
                    //var displayView = flpItems.Controls[i] as TDisplayView;
                    //if (displayView != null)
                    //{
                    //    if (abandon && displayView.Tag != null && displayView.Tag.Equals("CLONE"))
                    //    {
                    //        flpItems.Controls.RemoveAt(i);
                    //    }
                    //    else
                    //    {
                    //        displayView.BorderStyle = BorderStyle.FixedSingle;
                    //    }
                    //}
                }
                draggingView = null;

                var cleanView = flpItems.Controls[i] as TDisplayView;
                if (cleanView != null)
                {
                    cleanView.BorderStyle = BorderStyle.FixedSingle;
                }
            }
        }

        internal virtual void ToggleEmptyView(bool show)
        {
            if (IsDropCopy)
            {
                return;
            }
            for (var i = flpItems.Controls.Count - 1; i >= 0; i--)
            {
                var view = flpItems.Controls[i] as EmptyView<TDisplayView, TData, TUid, TUidType>;
                if (view == null)
                {
                    continue;
                }
                view.Visible = show;
            }

            if (draggingView != null && show)
            {
                flpItems.Controls.Remove(draggingView);
            }
        }

        protected internal abstract void OnInvalidModel(object sender, EventArgs eventArgs);

        protected abstract void DisplayList_Load(object sender, EventArgs e);

        internal void AddItemsDragDrop(DragEventHandler dragDrop)
        {
            flpItems.DragDrop += dragDrop;
        }

        internal void AddItemsDragEnter(DragEventHandler dragEnter)
        {
            flpItems.DragEnter += dragEnter;
        }

        internal void AddItemsDragOver(DragEventHandler dragOver)
        {
            flpItems.DragOver += dragOver;
        }

        internal void AddItemsDragLeave(EventHandler dragLeave)
        {
            flpItems.DragLeave += dragLeave;
        }

        internal void AddItemsQueryContinueDrag(QueryContinueDragEventHandler queryContinueDrag)
        {
            flpItems.QueryContinueDrag += queryContinueDrag;
        }

    }
}