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
    public partial class MissionResultsEdit : Form
    {
        public MissionResultsEdit()
        {
            InitializeComponent();
        }

        private void lstHijinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstItems.SelectedItem == null) return;
            txtString.Text = ((MissionResult) lstItems.SelectedItem).Name;
            txtFailureFlavor.Text = string.Join(Environment.NewLine, ((MissionResult)lstItems.SelectedItem).Values.Select(x => x.ToString()).ToArray());
        }
        
        private void StatsEdit_Load(object sender, EventArgs e)
        {
            RefreshList();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            MissionResultLoader.Add(new MissionResult() { Name = "NEW ITEM", Values = new List<string>() {"EXAMPLE"} });
            RefreshList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MissionResultLoader.SaveToFile();
            Close();
        }

        private void RefreshList()
        {
            lstItems.DataSource = null;
            lstItems.DataSource = MissionResultLoader.Get();
            lstItems.DisplayMember = "Name";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MissionResultLoader.Remove((MissionResult) lstItems.SelectedItem);
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {
            if (lstItems.SelectedItem == null) return;
            ((MissionResult)lstItems.SelectedItem).Name = txtString.Text;
            RefreshList();
            txtString.SelectionStart = txtString.Text.Length == 0 ? 0 : txtString.Text.Length; // add some logic if length is 0
            txtString.SelectionLength = 0;
        }

        private void txtFailureFlavor_TextChanged(object sender, EventArgs e)
        {
            if (lstItems.SelectedItem == null) return;
            ((MissionResult)lstItems.SelectedItem).Values = txtFailureFlavor.Text.Split(new [] { Environment.NewLine }, StringSplitOptions.None).ToList();
        }
    }
}
