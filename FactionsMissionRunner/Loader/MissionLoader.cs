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
    internal class MissionLoader
    {
        private const string FileName = "Files/Mission.json";
        private static readonly List<Mission> Items = new List<Mission>();

        internal static void Add(Mission item)
        {
            Items.Add(item);
        }
        internal static void Remove(Mission item)
        {
            Items.Remove(item);
        }

        internal static void Refresh()
        {
            Items.Clear();
            Load();
        }

        internal static List<Mission> Get()
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
            Items.AddRange(JsonConvert.DeserializeObject<List<Mission>>(File.ReadAllText(FileName)));
        }
    }
}
