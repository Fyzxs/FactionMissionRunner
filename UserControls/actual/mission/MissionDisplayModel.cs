using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControls.actual.mission
{
    public class MissionDisplayModel : IDisplayModel
    {
        public string Name { get; set; }

        public bool IsNull()
        {
            return false;
        }
    }
}
