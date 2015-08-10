using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactionsMissionRunner.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FactionsMissionRunner.Loader
{
    class NpcLoader
    {
        const string FileName = "Files/NPCs.json";
        readonly static List<Npc> Items = new List<Npc>();

        internal static void Add(Npc item)
        {
            Items.Add(item);
        }
        internal static void Remove(Npc item)
        {
            Items.Remove(item);
        }

        internal static void Refresh()
        {
            Items.Clear();
            Load();
        }

        internal static List<Npc> Get()
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
            Items.AddRange(JsonConvert.DeserializeObject<List<Npc>>(File.ReadAllText(FileName)));
        }
    }
}
