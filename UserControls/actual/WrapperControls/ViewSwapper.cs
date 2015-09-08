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

namespace UserControls.actual.WrapperControls
{
    public partial class ViewSwapper<TDisplayList, TDisplayView, TData, TUid, TUidType, TDisplayHeader> : UserControl
        where TDisplayList : TypeDisplayList<TDisplayView, TData, TUid, TUidType, TDisplayHeader>, new()
        where TDisplayView : DisplayView<TData, TUid, TUidType>, new()
        where TData : Data<TUid, TUidType>
        where TUid : Uid<TUidType>
        where TUidType : IComparable
        where TDisplayHeader : DisplayHeader
    {
        
        private bool isDropCopy;
        public bool IsDropCopy
        {
            get
            {
                return isDropCopy;
            }
            set
            {
                isDropCopy = value;
                lstFull.IsDropCopy = value;
                lstXfer.IsDropCopy = value;
            }
        }

        public ViewSwapper()
        {
            InitializeComponent();
            lstXfer.ShowAddButton(false);
            lstXfer.AddItemsDragDrop(pnl_DragDrop);
            lstXfer.AddItemsDragEnter(pnl_DragEnter);
            lstXfer.AddItemsDragOver(pnl_DragOver);
            lstXfer.AddItemsDragLeave(pnl_DragLeave);
            lstXfer.AddItemsQueryContinueDrag(pnl_QueryContinueDrag);
            lstFull.AddItemsDragDrop(pnl_DragDrop);
            lstFull.AddItemsDragEnter(pnl_DragEnter);
            lstFull.AddItemsDragOver(pnl_DragOver);
            lstFull.AddItemsDragLeave(pnl_DragLeave);
            lstFull.AddItemsQueryContinueDrag(pnl_QueryContinueDrag);
        }

        private void pnl_DragOver(object sender, DragEventArgs e)
        {
            var flp = sender as FlowLayoutPanel;
            var view = e.Data.GetData(typeof(TDisplayView)) as TDisplayView;
            Debug.WriteLine("Inside pnl_DragOver [sender={0}] [IsDropCopy={1}] [e.Data={2}] [view={3}] [flp={4}]", sender, IsDropCopy, e.Data, view, flp);
            if (flp == null || view == null)
            {
                return;
            }

            Debug.WriteLine("Changing Order");
            var p = flp.PointToClient(new Point(e.X, e.Y));
            var item = flp.GetChildAtPoint(p);
            if (item == view)
            {
                return;
            }
            var index = item == null ? flp.Controls.Count - 1 : flp.Controls.GetChildIndex(item, false);
            var viewIndex = flp.Controls.GetChildIndex(view, false);
            Debug.WriteLine("[index={0}] [item={1}] [viewIndex={2}]", index, item,viewIndex);
            if (index < 0 || item == null || viewIndex < 0)
            {
                flp.Controls.Add(view);
                if (viewIndex < 0)
                {
                    return;
                }
            }
            flp.Controls.SetChildIndex(view, index);
        }


        protected virtual void pnl_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            Debug.WriteLine("Inside pnl_QueryContinueDrag [sender={0}] [e={1}]", sender, e);
            var xferRect = new Rectangle(lstXfer.Location, lstXfer.Size);
            var fullRect = new Rectangle(lstFull.Location, lstFull.Size);

            //If the left mouse button is up and the mouse is currently over a list
            if (Control.MouseButtons != MouseButtons.Left)
            {
                if (
                    (!xferRect.Contains(PointToClient(Control.MousePosition)) &&
                     !fullRect.Contains(PointToClient(Control.MousePosition))))
                {
                    //Cancel the DragDrop Action
                    e.Action = DragAction.Cancel;
                    //Manually fire the MouseUp event
                    lstFull.ClearDragEffects(true);
                    lstXfer.ClearDragEffects(true);
                }
                else
                {
                    //it is inside one of them AND the mouse is up
                    e.Action = DragAction.Drop;
                }
        }
    }

        private void pnl_DragEnter(object sender, DragEventArgs e)
        {
            var flp = sender as FlowLayoutPanel;
            e.Effect = DragDropEffects.Move;

            if (lstXfer.IsPanelItems(flp))//Dragging From
            {
                lstXfer.ToggleEmptyView(false);
            }
            if (lstFull.IsPanelItems(flp))//Dragging From
            {
                lstFull.ToggleEmptyView(false);
            }
        }
        private void pnl_DragLeave(object sender, EventArgs e)
        {
            var flp = sender as FlowLayoutPanel;
            if (lstXfer.IsPanelItems(flp))//Dragging From
            {
                lstXfer.ToggleEmptyView(true);
            }
            else if (lstFull.IsPanelItems(flp)) //Dragging From
            {
                lstFull.ToggleEmptyView(true);
            }
        }

        private void pnl_DragDrop(object sender, DragEventArgs e)
        {
            var flp = sender as FlowLayoutPanel;
            var view = e.Data.GetData(typeof(TDisplayView)) as TDisplayView;
            Debug.WriteLine("Inside pnl_DragDrop [sender={0}] [IsDropCopy={1}] [e.Data={2}] [view={3}]", sender, IsDropCopy, e.Data, view);
            if (flp == null || view == null)
            {
                return;
            }
            Debug.WriteLine("[lstFull.IsPanelItems(flp)={0}] [lstXfer.IsPanelItemsParent(view)={1}]", lstFull.IsPanelItems(flp), lstXfer.IsPanelItemsParent(view));
            Debug.WriteLine("[lstXfer.IsPanelItems(flp)={0}] [lstFull.IsPanelItemsParent(view)={1}]", lstXfer.IsPanelItems(flp), lstFull.IsPanelItemsParent(view));
            if (lstFull.IsPanelItems(flp) && lstXfer.IsPanelItemsParent(view))
            {
                Debug.WriteLine("Dropping into lstFull");
                //Dropping into lstFull
                lstFull.DroppedView(view);
                lstXfer.DraggedView(view);

            }
            else if (lstXfer.IsPanelItems(flp) && lstFull.IsPanelItemsParent(view))
            {
                Debug.WriteLine("Dropping into lstXfer");
                //Dropping into lstXfer
                lstXfer.DroppedView(view);
                lstFull.DraggedView(view);
            }
            else
            {
                Debug.WriteLine("Dropping into self");

                flp.Controls.Add(view);

                lstFull.ClearDragEffects();
                lstXfer.ClearDragEffects();
            }

            AdjustViewOrder(new Point(e.X, e.Y), flp, view);
        }

        private static void AdjustViewOrder(Point point, Control flp, TDisplayView view)
        {
            Debug.WriteLine("Changing Order");
            var p = flp.PointToClient(point);
            var item = flp.GetChildAtPoint(p);

            var index = item == null ? flp.Controls.Count - 1 : flp.Controls.GetChildIndex(item, false);
            flp.Controls.SetChildIndex(view, index);
        }
    }
}
