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
using FactionsMissionRunner.Loader;

namespace FactionsMissionRunner.Files
{
    public partial class NpcEdit : Form
    {
        public NpcEdit()
        {
            InitializeComponent();
        }

        private void NpcEdit_Load(object sender, EventArgs e)
        {
            RefreshList();

        }

        private void RefreshList()
        {
            lstItems.DataSource = null;
            lstItems.DataSource = NpcLoader.Get();
        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {

            var item = lstItems.SelectedItem as Npc;
            if (item == null)
            {
                return;
            }

            txtClass.Text = item.Class;
            txtName.Text = item.Name;
            nudLevel.Value = item.Level;
            foreach (var stat in StatLoader.Get())
            {
                var found = false;
                foreach (var npcStat in item.Stats)
                {
                    if (npcStat.StatName != stat.StatName) continue;

                    found = true;
                    break;
                }
                if (found)
                {
                    continue;
                }
                item.Stats.Add(new NpcStat() {StatName = stat.StatName});
            }
            RefreshStatList();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (lstItems.SelectedItem == null) return;
            ((Npc)lstItems.SelectedItem).Name = txtName.Text;
            RefreshList();
        }
        private void txtClass_TextChanged(object sender, EventArgs e)
        {
            if (lstItems.SelectedItem == null) return;
            ((Npc)lstItems.SelectedItem).Class = txtClass.Text;
            RefreshList();
        }
        private void nudLevel_ValueChanged(object sender, EventArgs e)
        {
            if (lstItems.SelectedItem == null) return;
            ((Npc)lstItems.SelectedItem).Level = (int)nudLevel.Value;
            RefreshList();
        }

        private void lstNpcStats_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = lstNpcStats.SelectedItem as NpcStat;
            if (item == null)
            {
                return;
            }

            txtNpcStatName.Text = item.StatName;
            nudNpcStatValue.Value = item.StatValue;
        }

        private void nudNpcStatValue_ValueChanged(object sender, EventArgs e)
        {
            if (lstNpcStats.SelectedItem == null) return;
            ((NpcStat)lstNpcStats.SelectedItem).StatValue = (int)nudNpcStatValue.Value;
            RefreshStatList();
        }

        private void txtNpcStatName_TextChanged(object sender, EventArgs e)
        {
            if (lstNpcStats.SelectedItem == null) return;
            ((NpcStat)lstNpcStats.SelectedItem).StatName = txtNpcStatName.Text;
            RefreshStatList();
        }

        private void RefreshStatList()
        {
            lstNpcStats.DataSource = null;
            lstNpcStats.DataSource = ((Npc)lstItems.SelectedItem).Stats;
            lstNpcStats.DisplayMember = "DisplayText";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NpcLoader.SaveToFile();
            Close();
        }

        private void btnNpcStatNew_Click(object sender, EventArgs e)
        {
            ((Npc)lstItems.SelectedItem).Stats.Add(new NpcStat() { StatName = "NEW VALUE", StatValue = 0});
            RefreshList();
            RefreshStatList();
        }

        private void npcStatDelete_Click(object sender, EventArgs e)
        {
            ((Npc)lstItems.SelectedItem).Stats.Remove((NpcStat)lstNpcStats.SelectedItem);
            RefreshStatList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var npc = new Npc()
            {
                Name = "NEW NPC",
                Stats = new List<NpcStat>()
            };
            foreach (var stat in StatLoader.Get())
            {  
                npc.Stats.Add(new NpcStat() {StatName = stat.StatName});
            }
            NpcLoader.Add(npc);
            RefreshList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            NpcLoader.Remove((Npc)lstItems.SelectedItem);
            RefreshList();
        }

        private void nudExperience_ValueChanged(object sender, EventArgs e)
        {
            if (lstItems.SelectedItem == null) return;
            ((Npc)lstItems.SelectedItem).Experience = (int)nudExperience.Value;
            RefreshList();
        }
    }
}
