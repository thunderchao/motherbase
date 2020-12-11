using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_version
{
    public class Troop
    {
        static Random rnd = new Random();

        public string Name { get; set; }
        public int Level { get { return ((XP / 100) + 1); } }
        public int XP { get; set; }
        public string Role { get; set; }
        public int CurrentMissionID { get; set; }
        public decimal SmallArms { get; set; }
        public decimal LargeArms { get; set; }
        public decimal Vehicles { get; set; }
        public decimal Sneak { get; set; }
        public decimal CQC { get; set; }
        public string Rank { get
            {
                decimal sum = this.SmallArms + this.LargeArms + this.Vehicles + this.Sneak + this.CQC;
                sum /= 5;
                if (sum >= 4) { return "S"; }
                else if (sum < 4 && sum >= 3) { return "A"; }
                else if (sum < 3 && sum >= 2) { return "B"; }
                else if (sum < 2 && sum >= 1) { return "C"; }
                else { return "D"; }
            } 
            set { }
        }

        static public string getRank(decimal d)
        {
            if (d >= 4) { return "S"; }
            else if (d < 4 && d >= 3) { return "A"; }
            else if (d < 3 && d >= 2) { return "B"; }
            else if (d < 2 && d >= 1) { return "C"; }
            else { return "D"; }
        }

        static public string assignName()
        {
            var adj = new List<string>
            {
                "Feisty","Toxic","Blue","Triangle","Simp","Jagex","Tight","Buttcheek","Yellow","Deleted","Crunchy",
                "Lumpen","Gravy","Hootin","Hazmat","Crumpled","Ochre","Defense","Dark","Unknowable","Explosive",
                "Cherry","Brave","Boastful","Passenger","Punch","Scared","Chonky","Beginner","Soulless","Mushroom"
            };
            var noun = new List<string>
            {
                "Raspberry","Eel","Brother","Apricot","Biologic","Dongle","Jackal","Viper","Tundra","Kazoo","Boundary",
                "Garfield","Foyer","Eraser","Ridgeline","Fissure","Panther","Zebra","Woodsman","Antelope","Saiyan",
                "Chungus","Tear","Rival","Blister","Accordion","Luigi","Helmet","Banana","Ziggurat","Trench"
            };
            int indexA = rnd.Next(adj.Count);
            int indexN = rnd.Next(noun.Count);
            string name = $"{adj[indexA]} {noun[indexN]}";
            return name;
        }

        public Troop(decimal small, decimal large, decimal vehicles, decimal sneak, decimal cqc)
        {
            this.Name = assignName();
            this.XP = 0;
            this.Role = "placeholder";
            this.SmallArms = small;
            this.LargeArms = large;
            this.Vehicles = vehicles;
            this.Sneak = sneak;
            this.CQC = cqc;
        }

        public Troop()
        {
            this.Name = assignName();
            this.XP = 0;
            this.Role = "placeholder";
            this.SmallArms = (decimal)Math.Round((rnd.NextDouble()) * 4, 2);
            this.LargeArms = (decimal)Math.Round((rnd.NextDouble()) * 4, 2);
            this.Vehicles = (decimal)Math.Round((rnd.NextDouble()) * 4, 2);
            this.Sneak = (decimal)Math.Round((rnd.NextDouble()) * 4, 2);
            this.CQC = (decimal)Math.Round((rnd.NextDouble()) * 4, 2);
        }
        
        static public void LevelUp(Troop troop)
        {
            // https://stackoverflow.com/questions/9569489/easiest-way-to-create-a-custom-dialog-box-which-returns-a-value

            Form form = new Form();
            Label label = new Label() { Left = 50, Top = 20, Width = 400 };
            Button btnSpec = new Button() { Left = 50, Top = 150, Width = 100 };
            Button btnDiv = new Button() { Left = 200, Top = 150, Width = 100 };

            form.Width = 500;
            form.Height = 200;

            form.Text = $"{troop.Name} has leveled up!";
            label.Text = "Do you want this troop to double down on its strengths (Specialize) or become more well-rounded (Diversify)?";

            btnSpec.Text = "Specialize";
            btnDiv.Text = "Diversify";
            btnSpec.Click += new EventHandler(btnSpec_Click);
            btnDiv.Click += new EventHandler(btnDiv_Click);

            form.Controls.Add(label);
            form.Controls.Add(btnDiv);
            form.Controls.Add(btnSpec);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.ShowDialog();

            void btnSpec_Click(object sender, EventArgs e)
            {
                decimal[] stats = { troop.SmallArms, troop.LargeArms, troop.Vehicles, troop.Sneak, troop.CQC };
                decimal first = stats.Max();
                decimal second = (from stat in stats
                                  orderby stat descending
                                  select stat).Skip(1).First();
                if (troop.SmallArms == first) { troop.SmallArms += first; }
                if (troop.SmallArms == second) { troop.SmallArms += second; }
                if (troop.LargeArms == first) { troop.LargeArms += first; }
                if (troop.LargeArms == second) { troop.LargeArms += second; }
                if (troop.Vehicles == first) { troop.Vehicles += first; }
                if (troop.Vehicles == second) { troop.Vehicles += second; }
                if (troop.Sneak == first) { troop.Sneak += first; }
                if (troop.Sneak == second) { troop.Sneak += second; }
                if (troop.CQC == first) { troop.CQC += first; }
                if (troop.CQC == second) { troop.CQC += second; }
                form.Close();
            }
            void btnDiv_Click(object sender, EventArgs e)
            {
                decimal[] stats = { troop.SmallArms, troop.LargeArms, troop.Vehicles, troop.Sneak, troop.CQC };
                decimal first = stats.Min();
                decimal second = (from stat in stats
                                  orderby stat ascending
                                  select stat).Skip(1).First();
                if (troop.SmallArms == first) { troop.SmallArms += first; }
                if (troop.SmallArms == second) { troop.SmallArms += second; }
                if (troop.LargeArms == first) { troop.LargeArms += first; }
                if (troop.LargeArms == second) { troop.LargeArms += second; }
                if (troop.Vehicles == first) { troop.Vehicles += first; }
                if (troop.Vehicles == second) { troop.Vehicles += second; }
                if (troop.Sneak == first) { troop.Sneak += first; }
                if (troop.Sneak == second) { troop.Sneak += second; }
                if (troop.CQC == first) { troop.CQC += first; }
                if (troop.CQC == second) { troop.CQC += second; }
                form.Close();
            }
        }
    }
}
