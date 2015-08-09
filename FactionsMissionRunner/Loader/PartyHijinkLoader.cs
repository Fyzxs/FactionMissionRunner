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
    class PartyHijinkLoader
    {
        const string FileName = "Files/PartyHijinks.json";
        readonly static List<Stat> Stats = new List<Stat>();

        static List<Stat> Get()
        {
            if (Stats.Count == 0)
            {
                LoadStats();
            }
            return Stats;
        }

        internal static void LoadStats()
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
                        Stats.Add(new Stat { StatName = line });
                    }
                }
            }
        }
    }
}
