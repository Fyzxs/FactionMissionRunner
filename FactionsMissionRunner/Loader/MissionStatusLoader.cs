using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactionsMissionRunner.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace FactionsMissionRunner.Loader
{
    internal class MissionStatusLoader
    {
        private const string FileName = "Files/MissionStatus.json";
        private static readonly List<MissionStatus> Items = new List<MissionStatus>();

        internal static void Add(MissionStatus missionStatus)
        {
            Items.Add(missionStatus);
        }
        internal static void Remove(MissionStatus missionStatus)
        {
            Items.Remove(missionStatus);
        }

        internal static void Refresh()
        {
            Items.Clear();
            Load();
        }

        internal static List<MissionStatus> Get()
        {
            if (Items.Count == 0)
            {
                Load();
            }
            return Items;
        }

        internal static void SaveToFile()
        {
            var result = JsonConvert.SerializeObject(Items);

            File.WriteAllText(FileName, result);
            Refresh();
        }


        internal static void Load()
        {
            Items.AddRange(JsonConvert.DeserializeObject<List<MissionStatus>>(File.ReadAllText(FileName)));
        }
    }
}
