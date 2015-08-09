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
        readonly static List<PartyHijink> Hijinks = new List<PartyHijink>();

        internal static List<PartyHijink> Get()
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
                        Hijinks.Add(new PartyHijink() { HijinkString = line });
                    }
                }
            }
        }
    }
}
