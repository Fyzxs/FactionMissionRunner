using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FactionsMissionRunner.Core
{
    internal class Stat
    {
        public string StatName { get; set; }
        [JsonIgnore]
        public int Known { get; set; }
        [JsonIgnore]
        public int Actual { get; set; }
        [JsonIgnore]
        public int Party { get; set; }
        
        [JsonIgnore]
        public string DisplayText => $"{StatName} - K=[ {Known} ] A=[ {Actual} ] P=[ {Party} ]";
    }
}
