using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FactionsMissionRunner.Core;
using FactionsMissionRunner.Files;
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
            lstNpcs.DataSource = NpcLoader.Get();
        }


        private void lstDefaultStats_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var activeStat = lstDefaultStats.SelectedItem as Stat;
            if (activeStat == null)
            {
                return;
            }
            var addStat = new FormAddStat {Owner = this, ActiveStat = activeStat};
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
            forumPost += "\r\nMission Level: " + nudMedianPartyLevel.Value;
            forumPost += "\r\nStats";
            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (Stat item in lstDefaultStats.Items)
            {
                if (item.Known <= 0)
                {
                    continue;
                }
                forumPost += "\r\n[*]" + item.StatName + ":" + (item.Known < 0
                    ? "?"
                    : item.Known.ToString());
            }
            forumPost += "\r\n[/list]";
            if (txtMissionNotes.Text.Length > 0)
            {
                forumPost += "\r\n[quote=\"Notes\"]" + txtMissionNotes.Text + "[/quote]";
            }
            forumPost += "\r\n[/quote]";

            txtForumCode.Text = forumPost;
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            UpdateForumCode();
            Clipboard.SetText(txtForumCode.Text);
        }

        private void btnResolveMission_Click(object sender, EventArgs e)
        {
            var forumPost = string.Format("[quote=\"Mission Results- " + txtMissionName.Text + "\"]\r\n[list]");
            forumPost += "\r\nParty:";
            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (Npc npc in lstNpcs.CheckedItems)
            {
                forumPost += "\r\n[*]" + npc.Name;
            }
            forumPost += "\r\n[/list]";

            forumPost += "\r\nMission Status: " + CalculateMissionStatus();
            
            forumPost += GetPartyHijinks();

            forumPost += GetPlayerHijinks();

            forumPost += "\r\n[/quote]";

            txtMissionResolved.Text = forumPost;
        }

        private string GetPlayerHijinks()
        {
            var forumPost = "\r\nPlayer Happening[list]";
            foreach (Npc npc in lstNpcs.CheckedItems)
            {
                forumPost += "\r\n[*]" + npc.Name + "\r\n[list]";
                var playerHijinks = Rand.Next(0, 2);
                var selected = new List<int>();
                for (var i = 0; i < playerHijinks; i++)
                {
                    var x = Rand.Next(0, PlayerHijinkLoader.Get().Count);
                    if (selected.Contains(x))
                    {
                        continue;
                    }
                    selected.Add(x);
                    forumPost += "\r\n[*]" + PlayerHijinkLoader.Get()[x];
                }
                forumPost += "\r\n[/list]";
            }
            forumPost += "\r\n[/list]";

            return forumPost;
        }

        private static string GetPartyHijinks()
        {
            var forumPost = "\r\nParty Happening[list]";
            var partyHijinks = Rand.Next(0, 5);
            var selected = new List<int>();
            for (var i = 0; i < partyHijinks; i++)
            {
                var x = Rand.Next(0, PartyHijinkLoader.Get().Count);
                if (selected.Contains(x))
                {
                    continue;
                }
                selected.Add(x);
                forumPost += "\r\n[*]" + PartyHijinkLoader.Get()[x];
            }
            forumPost += "\r\n[/list]";

            return forumPost;
        }

        private string CalculateMissionStatus()
        {
            var partyLevels = new List<double>();
            var statSuccesses = 0;
            foreach (Npc npc in lstNpcs.CheckedItems)
            {
                partyLevels.Add(npc.Level);
            }
            var levelMedian = GetMedian(partyLevels.ToArray());
            lstStatResults.Items.Clear();
            foreach (Stat stat in lstDefaultStats.Items)
            {
                if (stat.Actual <= 0)
                {
                    continue;
                }
                var statCalc = stat.Party;
                foreach (Npc npc in lstNpcs.CheckedItems)
                {
                    foreach (var npcStat in npc.Stats)
                    {
                        if (npcStat.StatName != stat.StatName)
                        {
                            continue;
                        }
                        statCalc += npcStat.StatValue;
                    }
                }

                var successValue = (statCalc - stat.Actual) + levelMedian;
                var successRoll = Rand.Next(1, 21) + successValue;
                var isSuccess = successRoll >= 10;
                statSuccesses += isSuccess ? 1 : 0;
                lstStatResults.Items.Add(stat.StatName + " [" + stat.Actual + "] " +  "Value=[" + successValue + "] Result=[" + successRoll + "]", isSuccess);
            }

            var successCountEach = lstStatResults.Items.Count/lstDefaultStats.Items.Count;

            var success = Rand.Next(1, 101) + (statSuccesses*successCountEach) + nudAdditionalSuccessMod.Value;
            MissionStatus missionStatus = null;
            foreach (var status in MissionStatusLoader.Get())
            {
                //null
                // If the NEW.val >
                if ((success > status.MinValue && (missionStatus == null || status.MinValue > missionStatus.MinValue )))
                {
                    missionStatus = status;
                }
            }

            return missionStatus == null ? "Uh - Oh" : missionStatus.MissionStatusString;
        }

        protected static readonly Random Rand = ThreadSafeRandom.ThisThreadsRandom;
        private static double GetMedian(double[] sourceNumbers)
        {
            //Framework 2.0 version of this method. there is an easier way in F4        
            if (sourceNumbers == null || sourceNumbers.Length == 0)
                return -100;

            //make sure the list is sorted, but use a new array
            var sortedPNumbers = (double[])sourceNumbers.Clone();
            Array.Sort(sortedPNumbers);

            //get the median
            var size = sortedPNumbers.Length;
            var mid = size / 2;
            var median = (size % 2 != 0) ? (double)sortedPNumbers[mid] : ((double)sortedPNumbers[mid] + (double)sortedPNumbers[mid - 1]) / 2;
            return median;
        }

        private void btnCopyResult_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtMissionResolved.Text);
        }

        private void missionStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StatsEdit().ShowDialog(this);
            lstDefaultStats.DataSource = null;
            lstDefaultStats.DataSource = StatLoader.Get();
        }

        private void partyHijinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PartyHijinksEdit().ShowDialog(this);
        }

        private void playerHijinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PlayerHijinksEdit().ShowDialog(this);
        }

        private void missionStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MissionStatusEdit().ShowDialog(this);
        }

        private void nPCsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NpcEdit().ShowDialog(this);
            lstNpcs.DataSource = null;
            lstNpcs.DataSource = NpcLoader.Get();
        }

        private void txtMissionNotes_TextChanged(object sender, EventArgs e)
        {
            UpdateForumCode();
        }
    }
}

