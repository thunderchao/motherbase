using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace db_version
{
    public partial class Form1 : Form
    {
        static Squad loadedSquad = new Squad();
        static Squad activeSquad = new Squad();
        static Missions missionList = LoadMissionList();
        static string mainStat;
        static int missionTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(@".\missions.xml"))
            {
                UpdateMissionList();
            }

            if (File.Exists(@".\savefile.xml")) 
            { 
                loadedSquad = Squad.LoadSquad();
                UpdateListBox(lboTroops, loadedSquad);
            }
            // else should display a message or make a new dude automatically
            // or start the tutorial
        }

        private void UpdateListBox(ListBox lbo, Squad squad)
        {
            lbo.BeginUpdate();
            lbo.Items.Clear();
            for (int x = 0; x < squad.troops.Count; x++)
            {
                lbo.Items.Add(squad.troops.ElementAt(x).Name);
            }
            lbo.EndUpdate();
        }

        private void UpdateMissionList()
        {
            lboAvailableMissions.BeginUpdate();
            lboAvailableMissions.Items.Clear();
            for (int x = 0; x < missionList.MissionList.Length; x++)
            {
                lboAvailableMissions.Items.Add(missionList.MissionList.ElementAt(x).Name);
            }
            lboAvailableMissions.EndUpdate();
        }

        private void btnNewTroop_Click(object sender, EventArgs e)
        {
            Troop newb = new Troop();
            loadedSquad.troops.Add(newb);
            UpdateListBox(lboTroops, loadedSquad);
        }


        private void btnDeleteTroop_Click(object sender, EventArgs e)
        {
            string tname = lboTroops.Items[lboTroops.SelectedIndex].ToString();
            Troop tSelected = loadedSquad.troops.FirstOrDefault(t => tname == t.Name);
            DialogResult result = MessageBox.Show("Confirm deletion of " + tname + ".", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //string deleteStatement = @"delete from troops where ID = '" + value + "'";

            if (result == DialogResult.Yes)
            {
                loadedSquad.troops.Remove(tSelected);
                UpdateListBox(lboTroops, loadedSquad);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Squad dump = new Squad();
            
            for(int i = 0; i <5; i++)
            {
                dump.troops.Add(new Troop());
            }
            
            dump.DateSaved = DateTime.Now;
            Squad.SaveSquad(dump);
            MessageBox.Show("Squad saved.");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tname = lboTroops.Items[lboTroops.SelectedIndex].ToString();
            Troop tSelected = loadedSquad.troops.FirstOrDefault(t => tname == t.Name);
            lblXPresult.Text = tSelected.XP.ToString();
            lblLevelresult.Text = tSelected.Level.ToString();
            lblSAresult.Text = Troop.getRank(tSelected.SmallArms) + " " + tSelected.SmallArms.ToString();
            lblLAresult.Text = Troop.getRank(tSelected.LargeArms) + " " + tSelected.LargeArms.ToString();
            lblVEresult.Text = Troop.getRank(tSelected.Vehicles) + " " + tSelected.Vehicles.ToString();
            lblSNresult.Text = Troop.getRank(tSelected.Sneak) + " " + tSelected.Sneak.ToString();
            lblCQresult.Text = Troop.getRank(tSelected.CQC) + " " + tSelected.CQC.ToString();
            SetButtonsEditable();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            AbortMission();
            loadedSquad.troops.AddRange(activeSquad.troops);
            loadedSquad.DateSaved = DateTime.Now;
            Squad.SaveSquad(loadedSquad);
        }

        static Missions LoadMissionList()
        {
            using (TextReader reader = new StreamReader(@".\missions.xml"))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(Missions));
                return (Missions)deserializer.Deserialize(reader);
            }/*
            XmlSerializer deserializer = new XmlSerializer(typeof(Missions));
            TextReader reader = new StreamReader(@".\missions.xml");
            object obj = deserializer.Deserialize(reader);
            Missions XmlData = (Missions)obj;
            reader.Close();
            return XmlData;*/
        }

        private void lboAvailableMissions_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mname = lboAvailableMissions.Items[lboAvailableMissions.SelectedIndex].ToString();
            Mission mSelected = missionList.MissionList.FirstOrDefault(m => mname == m.Name);
            lblMainStatR.Text = mSelected.MainStat.ToString();

            if (mSelected.Danger == "Green") { lblDanger.ForeColor = System.Drawing.Color.Green; }
            else if (mSelected.Danger == "Yellow") { lblDanger.ForeColor = System.Drawing.Color.Yellow; }
            else if (mSelected.Danger == "Red") { lblDanger.ForeColor = System.Drawing.Color.Red; }
            else { lblDanger.ForeColor = System.Drawing.Color.Black; }

            lblTimeR.Text = mSelected.TotalTime.ToString();
            lblMissionXPR.Text = mSelected.Xp.ToString();
            lblRewardsR.Text = mSelected.Rewards.ToString();

            mainStat = mSelected.MainStat.ToString();
            missionTime = mSelected.TotalTime * 1000;
        }

        static public decimal Calculate(decimal a, decimal b, decimal c, decimal d)
        {
            decimal result = a + b + c + d;
            result = 1000 / result;
            return result;
        }

        private void btnMissionStart_Click(object sender, EventArgs e)
        {
            //start progress bar
            pbActiveMission.Value = 0;
            pbActiveMission.Maximum = missionTime;
            decimal numA=1, numB=1, numC=1, numD=1;
            if (mainStat == "SmallArms")
            {
                numA = activeSquad.troops[0].SmallArms;
                numB = activeSquad.troops[1].SmallArms;
                numC = activeSquad.troops[2].SmallArms;
                numD = activeSquad.troops[3].SmallArms;
            }
            else if (mainStat == "LargeArms")
            {
                numA = activeSquad.troops[0].LargeArms;
                numB = activeSquad.troops[1].LargeArms;
                numC = activeSquad.troops[2].LargeArms;
                numD = activeSquad.troops[3].LargeArms;
            }
            else if (mainStat == "Vehicles")
            {
                numA = activeSquad.troops[0].Vehicles;
                numB = activeSquad.troops[1].Vehicles;
                numC = activeSquad.troops[2].Vehicles;
                numD = activeSquad.troops[3].Vehicles;
            }
            else if (mainStat == "Sneak")
            {
                numA = activeSquad.troops[0].Sneak;
                numB = activeSquad.troops[1].Sneak;
                numC = activeSquad.troops[2].Sneak;
                numD = activeSquad.troops[3].Sneak;
            }
            else if (mainStat == "CQC")
            {
                numA = activeSquad.troops[0].CQC;
                numB = activeSquad.troops[1].CQC;
                numC = activeSquad.troops[2].CQC;
                numD = activeSquad.troops[3].CQC;
            }
            decimal increase = Calculate(numA, numB, numC, numD);
            btnMissionStart.Enabled = false;
            tmrMission.Enabled = true;
            tmrMission.Start();
            tmrMission.Interval = (int)increase;
            lblSpeed.Text = $"Speed: {increase}ms per step";
            int remaining = (int)increase * pbActiveMission.Maximum;
            DateTime startTime = DateTime.Now;
            TimeSpan totalTime = new TimeSpan(0, 0, 0, 0, remaining);
            TimeSpan timeRem = startTime.Add(totalTime) - DateTime.Now;
            lblTimeRem.Text = $"Total time: {timeRem}";
            lboAvailableMissions.Enabled = false;
        }

        private void tmrMission_Tick(object sender, EventArgs e)
        {
            if (pbActiveMission.Value < pbActiveMission.Maximum)
            {
                pbActiveMission.Value++;
                lblProg.Text = $"Current progress: {pbActiveMission.Value} steps of {pbActiveMission.Maximum}";
            }
            else
            {
                tmrMission.Stop();
                btnMissionStart.Enabled = true;
                lboAvailableMissions.Enabled = true;
                lblTimeRem.Text = "Total time:";
                lblSpeed.Text = "Speed: 0ms";
                lblProg.Text = $"Current progress: {pbActiveMission.Value}";
            }
        }

        private void AbortMission()
        {
            tmrMission.Stop();
            btnMissionStart.Enabled = true;
            lboAvailableMissions.Enabled = true;
            pbActiveMission.Value = 0;
            lblTimeRem.Text = "Total time:";
            lblSpeed.Text = "Speed: 0ms";
            lblProg.Text = $"Current progress: {pbActiveMission.Value}";
        }

        private void btnAbortMission_Click(object sender, EventArgs e)
        {
            AbortMission();
        }
        
        private void MoveTroop(Squad fromSquad, Squad toSquad, ListBox fromBox)
        {
            string tname = fromBox.Items[fromBox.SelectedIndex].ToString();
            Troop tSelected = fromSquad.troops.FirstOrDefault(t => tname == t.Name);

            toSquad.troops.Add(tSelected);
            fromSquad.troops.Remove(tSelected);
            
        }
        private void SetButtonsEditable()
        {
            btnAddToSquad.Enabled = (lboTroops.SelectedItems.Count > 0);
            btnRemoveFromSquad.Enabled = (lboActiveSquad.SelectedItems.Count > 0);
        }

        private void btnAddToSquad_Click(object sender, EventArgs e)
        {
            MoveTroop(loadedSquad, activeSquad, lboTroops);
            UpdateListBox(lboTroops, loadedSquad);
            UpdateListBox(lboActiveSquad, activeSquad);

            // average out scores for those in the box
            decimal acq = 0, ala = 0, asa = 0, asn = 0, ave = 0, alv = 0;
            decimal count = 0;
            foreach (Troop t in activeSquad.troops)
            {
                acq += t.CQC;
                ala += t.LargeArms;
                asa += t.SmallArms;
                asn += t.Sneak;
                ave += t.Vehicles;
                alv += t.Level;
                count++;
            }
            lblAvgCQC.Text = Troop.getRank(acq / count);
            lblAvgLarge.Text = Troop.getRank(ala / count);
            lblAvgLevel.Text = (alv / count).ToString();
            lblAvgSmall.Text = Troop.getRank(asa / count);
            lblAvgSneak.Text = Troop.getRank(asn / count);
            lblAvgVehicles.Text = Troop.getRank(ave / count);
        }

        private void btnRemoveFromSquad_Click(object sender, EventArgs e)
        {
            MoveTroop(activeSquad, loadedSquad, lboActiveSquad);
            UpdateListBox(lboTroops, loadedSquad);
            UpdateListBox(lboActiveSquad, activeSquad);
        }

        private void lboActiveSquad_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetButtonsEditable();
        }
    }
}
