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

        internal static List<Npc> Get()
        {
            if (Items.Count == 0)
            {
                Load();
            }
            return Items;
        }
/*[
    {
        "Name": "Blort",
        "Class": "OtherBlort",
        "Level": 1,
        "Stats": [
            { "Diplomacy": 1 },
            { "Stealth": 1 }
        ]
    },
    {
        "Name": "NewBlort",
        "Class": "Fighter",
        "Level": 1,
        "Stats": [
            { "Diplomacy": 1 },
            { "Stealth": 1 }
        ]
    }
]*/
        internal static void Load()
        {
            var jArray = JArray.Parse(File.ReadAllText(FileName));
            foreach (var item in jArray)
            {
                var name = item["Name"].Value<string>();
                var clazz = item["Class"].Value<string>();
                var stats = item["Stats"];
                var level = item["Level"].Value<int>();
                var npcStats = new List<NpcStat>();
                // ReSharper disable once LoopCanBeConvertedToQuery
                foreach (var stat in stats.Children())
                {
                    var statName = ((JProperty) stat.First).Name;
                    var statValue = ((JProperty) stat.First).Value.Value<int>();

                    npcStats.Add(new NpcStat() {StatName = statName, StatValue = statValue});
                }

                Items.Add(new Npc() {Class = clazz, Name = name, Level = level, Stats = npcStats});
            }
        }
    }
}
