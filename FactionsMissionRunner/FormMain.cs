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

namespace FactionsMissionRunner
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lstDefaultStats.DataSource = StatLoader.Get();
        }
        

        private void lstDefaultStats_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var activeStat = lstDefaultStats.SelectedItem as Stat;
            if (activeStat == null)
            {
                return;
            }
            var addStat = new FormAddStat { Owner = this, ActiveStat = activeStat };
            Enabled = false;
            addStat.ShowDialog();
            Enabled = true;
            lstDefaultStats.DisplayMember = "";
            lstDefaultStats.DisplayMember = "DisplayText";
            UpdateForumCode();
        }

        private void txtMissionName_TextChanged(object sender, EventArgs e)
        {
            UpdateForumCode();
        }
        private void UpdateForumCode()
        {
            var forumPost = string.Format("[quote=\"Mission - " + txtMissionName.Text + "\"]\r\n[list]");
            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (Stat item in lstDefaultStats.Items)
            {
                forumPost += "\r\n[*]" + item.StatName + ":" + (item.Known < 0 
                                    ? "?" 
                                    : item.Known + "/" + item.Intel);
            }
            forumPost += "\r\n[/list]\r\n[/quote]";

            txtForumCode.Text = forumPost;
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtForumCode.Text);
        }
    }
}
