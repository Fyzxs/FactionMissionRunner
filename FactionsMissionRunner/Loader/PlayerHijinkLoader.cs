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
            Hijinks.AddRange(JsonConvert.DeserializeObject<List<PlayerHijink>>(File.ReadAllText(FileName)));
        }

        public static void Add(PlayerHijink item)
        {
            Hijinks.Add(item);
        }
        internal static void Remove(PlayerHijink item)
        {
            Hijinks.Remove(item);
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
