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
    public partial class PartyHijinksEdit : Form
    {
        public PartyHijinksEdit()
        {
            InitializeComponent();
        }

        private void lstHijinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHijinks.SelectedItem == null) return;
            txtString.Text = ((PartyHijink) lstHijinks.SelectedItem).HijinkString;
        }

        private void PartyHijinksEdit_Load(object sender, EventArgs e)
        {
            RefreshList();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            PartyHijinkLoader.Add(new PartyHijink() { HijinkString= "NEW ITEM" });
            RefreshList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PartyHijinkLoader.SaveToFile();
            Close();
        }

        private void RefreshList()
        {
            lstHijinks.DataSource = null;
            lstHijinks.DataSource = PartyHijinkLoader.Get();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PartyHijinkLoader.Remove((PartyHijink) lstHijinks.SelectedItem);
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {
            if (lstHijinks.SelectedItem == null) return;
            ((PartyHijink)lstHijinks.SelectedItem).HijinkString = txtString.Text;
            RefreshList();
        }

    }
}
