using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls.actual.eventargs;

namespace UserControls.actual.mission
{
    public class MissionDisplayListInternal : TypeDisplayList<MissionDisplayView, MissionData, MissionUid, int, MissionDisplayHeader>
    {
        public MissionDisplayListInternal()
        {
            InitializeComponent();
            var header = new MissionDisplayHeader();
            header.Hack("Hack Test");
            ListDisplayHeader = header;


            MissionDataLoader.Instance.ItemAdded += AddItem;
            MissionDataLoader.Instance.ItemRemoved += RemoveItem;
        }
        

        private void LoadData()
        {
            if (IgnoreFullData) return;
            AllDisplayViews = MissionDataLoader.Instance.GetAll()
                .Select(missionData => new MissionDisplayView() {DataItem = missionData})
                .ToArray();
        }

        private void AddItem(object sender, EventArgs args)
        {
            var e = args as DataChangedEventArgs<MissionUid, int>;
            if (IgnoreFullData || e == null) return;
            
            var data = MissionDataLoader.Instance.GetData(e.Id);
            if (data == null) return;

            Add(new MissionDisplayView() {DataItem = data});

        }

        private void RemoveItem(object sender, EventArgs eventArgs)
        {
            
        }

        protected internal override void OnInvalidModel(object sender, EventArgs eventArgs)
        {
            var args = eventArgs as InvalidModelEventArgs<MissionData, MissionUid, int>;
            if (args == null)
            {
                return;
            }

            Remove(args.Data);
        }

        protected override void DisplayList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        protected override sealed void InitializeComponent()
        {
            base.InitializeComponent();
        }
    }
}
