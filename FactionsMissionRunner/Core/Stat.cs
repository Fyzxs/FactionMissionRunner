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
        public int Known { get; set; }
        public int Intel { get; set; }
        public int Actual { get; set; }
        public int Party { get; set; }
        
        public string DisplayText => $"{StatName} - K=[ {Known} ] I=[ {Intel} ] A=[ {Actual} ] P=[ {Party} ]";
    }
}
