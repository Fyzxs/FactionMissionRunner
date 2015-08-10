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
using Newtonsoft.Json;

namespace FactionsMissionRunner.Files
{
    public partial class MissionStatusEdit : Form
    {
        public MissionStatusEdit()
        {
            InitializeComponent();
        }

        private void lstMissionStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            var missionStatus = lstMissionStatus.SelectedItem as MissionStatus;
            if (missionStatus == null)
            {
                return;
            }
            txtText.Text = missionStatus.MissionStatusString;
            nudValue.Value = missionStatus.MinValue;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            MissionStatusLoader.Add(new MissionStatus() {MinValue = 0, MissionStatusString = "NEW ITEM"});

            RefreshList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MissionStatusLoader.SaveToFile();
            Close();
        }

        private void MissionStatusEdit_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {
            if (lstMissionStatus.SelectedItem == null) return;
            ((MissionStatus) lstMissionStatus.SelectedItem).MissionStatusString = txtText.Text;
            RefreshList();
        }

        private void nudValue_ValueChanged(object sender, EventArgs e)
        {
            ((MissionStatus)lstMissionStatus.SelectedItem).MinValue = (int) nudValue.Value;
            RefreshList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MissionStatusLoader.Remove((MissionStatus) lstMissionStatus.SelectedItem);
            RefreshList();
        }

        private void RefreshList()
        {
            lstMissionStatus.DataSource = null;
            lstMissionStatus.DataSource = MissionStatusLoader.Get();
        }
    }
}
