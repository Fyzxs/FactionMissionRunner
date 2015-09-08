using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls.actual.mission
{
    public class MissionDataLoader : DataLoader<MissionData, MissionUid, int>
    {
        public static readonly MissionDataLoader Instance = new MissionDataLoader();

        public MissionDataLoader()
        {
            Read();
        }

        public override void Export(MissionData data)
        {
            throw new NotImplementedException();
        }

        protected override sealed void Read()
        {

            Datum = new List<MissionData>()
            {
                new MissionData() { Name = "SAMPLE1 NAME:" + X++, Id = new MissionUid(X) },
                new MissionData() { Name = "SAMPLE2 NAME:" + X++ , Id = new MissionUid(X)},
                new MissionData() { Name = "SAMPLE3 NAME:" + X++ , Id = new MissionUid(X)},
                new MissionData() { Name = "SAMPLE4 NAME:" + X++ , Id = new MissionUid(X)},
                new MissionData() { Name = "SAMPLE5 NAME:" + X++ , Id = new MissionUid(X)},
                new MissionData() { Name = "SAMPLE6 NAME:" + X++, Id = new MissionUid(X) }
            };
        }

        protected override void Write()
        {
            throw new NotImplementedException();
        }

        private static int X = 0;
        public override ICollection<MissionData> GetAll()
        {
            return Datum;
        }

        public override MissionData GetData(MissionUid uid)
        {
            return Datum.FirstOrDefault(d => d.Id.CompareTo(uid) == 0);
        }

        public override void Remove(MissionData data)
        {
            throw new NotImplementedException();
        }

        public override void Save(MissionData data)
        {
            OnItemUpdated(data.Id);
        }

        public override void Add(MissionData data)
        {
            data.Id = new MissionUid(Datum.Count+1);
            Datum.Add(data);
            OnItemAdded(data.Id);
        }
    }
}
