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
    public partial class StatsEdit : Form
    {
        public StatsEdit()
        {
            InitializeComponent();
        }

        private void lstHijinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstItems.SelectedItem == null) return;
            txtString.Text = ((Stat) lstItems.SelectedItem).StatName;
            txtFailureFlavor.Text = string.Join(Environment.NewLine, ((Stat)lstItems.SelectedItem).FailureFlavors.Select(x => x.ToString()).ToArray());
        }
        
        private void StatsEdit_Load(object sender, EventArgs e)
        {
            RefreshList();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            StatLoader.Add(new Stat() { StatName= "NEW ITEM" });
            RefreshList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StatLoader.SaveToFile();
            Close();
        }

        private void RefreshList()
        {
            lstItems.DataSource = null;
            lstItems.DataSource = StatLoader.Get();
            lstItems.DisplayMember = "StatName";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            StatLoader.Remove((Stat) lstItems.SelectedItem);
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {
            if (lstItems.SelectedItem == null) return;
            ((Stat)lstItems.SelectedItem).StatName = txtString.Text;
            RefreshList();
        }

        private void txtFailureFlavor_TextChanged(object sender, EventArgs e)
        {
            if (lstItems.SelectedItem == null) return;
            ((Stat)lstItems.SelectedItem).FailureFlavors = txtFailureFlavor.Text.Split(new [] { Environment.NewLine }, StringSplitOptions.None).ToList();
        }
    }
}
