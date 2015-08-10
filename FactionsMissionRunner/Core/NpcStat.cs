using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FactionsMissionRunner.Core
{
    class NpcStat
    {
        public string StatName { get; set; }
        public int StatValue { get; set; }


        [JsonIgnore]
        public string DisplayText => $"{StatName} - {StatValue}";
    }
}
