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
    class NpcLoader
    {
        const string FileName = "Files/Stats.json";
        readonly static List<Npc> Items = new List<Npc>();

        internal static List<Npc> Get()
        {
            if (Items.Count == 0)
            {
                Load();
            }
            return Items;
        }

        internal static void Load()
        {
            using (var sw = new StreamReader(FileName))
            {
                using (JsonReader reader = new JsonTextReader(sw))
                {
                    if (!reader.Read())
                    {
                        return;
                    }
                    string line;
                    while ((line = reader.ReadAsString()) != null)
                    {
                        Items.Add(new Npc { StatName = line });
                    }
                }
            }
        }
    }
}
