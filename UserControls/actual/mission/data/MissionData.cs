﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControls.actual.mission
{
    public class MissionData : Data<MissionUid, int>
    {
        public string Name { get; set; }
    }
}
