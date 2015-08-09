using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactionsMissionRunner.Core
{
    class Npc
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public int Level { get; set; }
        public List<NpcStat> Stats { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Class}:{Level}";
        }
    }
}
