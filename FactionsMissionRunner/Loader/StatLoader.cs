using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactionsMissionRunner.Core;
using Newtonsoft.Json;

namespace FactionsMissionRunner.Loader
{
    class StatLoader
    {
        const string FileName = "Files/Stats.json";
        readonly static List<Stat> Items = new List<Stat>();

        internal static void Add(Stat item)
        {
            Items.Add(item);
        }
        internal static void Remove(Stat item)
        {
            Items.Remove(item);
        }

        internal static void Refresh()
        {
            Items.Clear();
            Load();
        }

        internal static List<Stat> Get()
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
            Items.AddRange(JsonConvert.DeserializeObject<List<Stat>>(File.ReadAllText(FileName)));
        }
    }
}
