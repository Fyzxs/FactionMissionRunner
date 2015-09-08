using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControls.actual.mission.forms
{
    public class NewMissionFormInternal : NewForm<MissionDisplayView, MissionData, MissionUid, int>
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            if (!IsSaved) return;

            EnteredView.ExtractData();
            MissionDataLoader.Instance.Add(EnteredView.DataItem);
        }
    }
}
