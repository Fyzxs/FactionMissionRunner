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
    internal class MissionStatusLoader
    {
        private const string FileName = "Files/MissionStatus.json";
        private static readonly List<MissionStatus> Hijinks = new List<MissionStatus>();

        internal static List<MissionStatus> Get()
        {
            if (Hijinks.Count == 0)
            {
                Load();
            }
            return Hijinks;
        }

        internal static void Load()
        {
            var jArray = JArray.Parse(File.ReadAllText(FileName));
            foreach(var item in jArray)
            {
                Hijinks.Add(new MissionStatus() {MinValue = item["MinValue"].Value<int>(), MissionStatusString = item["Text"].Value<string>()});
            }
        }
    }
}
