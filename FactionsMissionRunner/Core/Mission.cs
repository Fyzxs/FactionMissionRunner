using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactionsMissionRunner.Core
{
    internal class Mission
    {
        public string Name { get; set; }
        public int PartyLevel { get; set; }

        public List<MissionStat> Stats { get; } = new List<MissionStat>();

        public List<Npc> SelectedNpcs { get; } = new List<Npc>();
        public string Notes { get; set; }
        public int AdditionalSuccessMod { get; set; }

        public override string ToString()
        {
            return $"{Name} - {PartyLevel}";
        }
    }
}
