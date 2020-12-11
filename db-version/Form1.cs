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

namespace db_version
{
    public partial class Form1 : Form
    {
        static Squad loadedSquad = new Squad();
        // initialize full list of missions - Mission.fullList
        // initialize list of available missions

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(@".\savefile.xml")) 
            { 
                loadedSquad = Squad.LoadSquad();
                UpdateListBox();
            }
            // else should display a message or make a new dude automatically
            // or start the tutorial
        }

        private void UpdateListBox()
        {
            lboTroops.BeginUpdate();
            lboTroops.Items.Clear();
            for (int x = 0; x < loadedSquad.troops.Count; x++)
            {
                lboTroops.Items.Add(loadedSquad.troops.ElementAt(x).Name);
            }
            lboTroops.EndUpdate();
        }

        private void btnNewTroop_Click(object sender, EventArgs e)
        {
            Troop newb = new Troop();
            loadedSquad.troops.Add(newb);
            UpdateListBox();
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
                UpdateListBox();
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
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            loadedSquad.DateSaved = DateTime.Now;
            Squad.SaveSquad(loadedSquad);
        }
    }
}
