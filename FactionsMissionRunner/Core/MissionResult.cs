using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactionsMissionRunner.Core
{
    class MissionResult
    {
        public string Name { get; set; }
        public List<string> Values { get; set; } = new List<string>();
    }
}
