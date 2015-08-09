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
            forumPost += "Party";
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
            foreach (Npc npc in lstNpcs.CheckedItems)
            {
                foreach (Stat stat in lstDefaultStats.Items)
                {
                    var statCalc = stat.Party;
                    foreach (var npcStat in npc.Stats)
                    {
                        if (npcStat.StatName != stat.StatName)
                        {
                            continue;
                        }
                        statCalc += npcStat.StatValue;
                    }
                    var successValue = statCalc - stat.Actual + levelMedian;
                    statSuccesses += Rand.Next(1, 21) + successValue >= 10 ? 1 : 0;
                }
            }

            var success = Rand.Next(1, 101) + statSuccesses + nudAdditionalSuccessMod.Value;
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
    }
}

