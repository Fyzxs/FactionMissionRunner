using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FactionsMissionRunner.Core;

namespace FactionsMissionRunner
{
    public partial class FormAddStat : Form
    {
        private Stat stat;
        internal Stat ActiveStat
        {
            get { return stat; }
            set
            {
                stat = value;
                lblStatLabel.Text = stat.StatName;
                nudActual.Value = stat.Actual;
                nudKnown.Value = stat.Known;
                nudPartyBonus.Value = stat.Party;
            }
        }

        public FormAddStat()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            stat.Known = (int)nudKnown.Value;
            stat.Actual = (int)nudActual.Value;
            stat.Party = (int)nudPartyBonus.Value;
            Close();
        }
    }
}
