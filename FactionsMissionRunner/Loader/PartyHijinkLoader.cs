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
            Hijinks.AddRange(JsonConvert.DeserializeObject<List<PartyHijink>>(File.ReadAllText(FileName)));
        }

        public static void Add(PartyHijink partyHijink)
        {
            Hijinks.Add(partyHijink);
        }
        internal static void Remove(PartyHijink partyHijink)
        {
            Hijinks.Remove(partyHijink);
        }

        internal static void Refresh()
        {
            Hijinks.Clear();
            Load();
        }
        internal static void SaveToFile()
        {
            var result = JsonConvert.SerializeObject(Hijinks);

            File.WriteAllText(FileName, result);
            Refresh();
        }
    }
}
