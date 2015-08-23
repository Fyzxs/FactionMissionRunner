using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactionsMissionRunner.Core;
using Newtonsoft.Json;

namespace FactionsMissionRunner.Files
{
    class MissionResultLoader
    {

        private const string FileName = "Files/MissionResult.json";
        private static readonly List<MissionResult> Items = new List<MissionResult>();

        internal static void Add(MissionResult item)
        {
            Items.Add(item);
        }
        internal static void Remove(MissionResult item)
        {
            Items.Remove(item);
        }

        internal static void Refresh()
        {
            Items.Clear();
            Load();
        }

        internal static List<MissionResult> Get()
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
            Items.AddRange(JsonConvert.DeserializeObject<List<MissionResult>>(File.ReadAllText(FileName)));
        }
    }
}
