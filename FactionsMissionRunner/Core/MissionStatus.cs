using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FactionsMissionRunner.Core
{
    class MissionStatus
    {
        [JsonProperty]
        internal int MinValue { get; set; }
        [JsonProperty(PropertyName = "Text")]
        internal string MissionStatusString { get; set; }
        public string Color { get; set; } = "#000000";

        public override string ToString()
        {
            return MissionStatusString + " [" + MinValue + "]";
        }
    }
}
