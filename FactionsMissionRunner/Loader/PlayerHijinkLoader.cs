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
    class PlayerHijinkLoader
    {
        const string FileName = "Files/PlayerHijinks.json";
        readonly static List<PlayerHijink> Hijinks = new List<PlayerHijink>();

        internal static List<PlayerHijink> Get()
        {
            if (Hijinks.Count == 0)
            {
                Load();
            }
            return Hijinks;
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
                        Hijinks.Add(new PlayerHijink(){ HijinkString = line });
                    }
                }
            }
        }
    }
}
