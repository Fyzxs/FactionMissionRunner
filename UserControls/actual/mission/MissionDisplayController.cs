using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControls.actual.mission
{
    public class MissionDisplayController : DisplayController<MissionDisplayViewInternal, MissionData, MissionDisplayModel, MissionUid, int>
    {


        public MissionDisplayController(MissionDisplayViewInternal itemView) : base(itemView)
        {
            MissionDataLoader.Instance.ItemUpdated += OnItemUpdated;
        }
        ~MissionDisplayController()
        {
            MissionDataLoader.Instance.ItemUpdated -= OnItemUpdated;
        }

        private void OnItemUpdated(object sender, EventArgs eventArgs)
        {
            var args = eventArgs as DataChangedEventArgs<MissionUid, int>;
            if (args == null || args.Id != ItemView.DataItem.Id)
            {
                return;
            }
            OnDataChanged(args.Id);
        }


        internal override MissionDisplayModel GetModel()
        {
            return new MissionDisplayModel() {Name = ItemView.DataItem.Name};
        }
    }
}
