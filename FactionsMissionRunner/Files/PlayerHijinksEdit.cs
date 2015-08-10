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
    public partial class PlayerHijinksEdit : Form
    {
        public PlayerHijinksEdit()
        {
            InitializeComponent();
        }

        private void lstHijinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHijinks.SelectedItem == null) return;
            txtString.Text = ((PlayerHijink) lstHijinks.SelectedItem).HijinkString;
        }
        
        private void PlayerHijinksEdit_Load(object sender, EventArgs e)
        {
            RefreshList();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            PlayerHijinkLoader.Add(new PlayerHijink() { HijinkString= "NEW ITEM" });
            RefreshList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PlayerHijinkLoader.SaveToFile();
            Close();
        }

        private void RefreshList()
        {
            lstHijinks.DataSource = null;
            lstHijinks.DataSource = PlayerHijinkLoader.Get();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PlayerHijinkLoader.Remove((PlayerHijink) lstHijinks.SelectedItem);
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {
            if (lstHijinks.SelectedItem == null) return;
            ((PlayerHijink)lstHijinks.SelectedItem).HijinkString = txtString.Text;
            RefreshList();
        }

    }
}
