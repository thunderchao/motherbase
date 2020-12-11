using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_version
{
    public class Mission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Requirement { get; set; }
        public string MainStat { get; set; }
        public int TotalTime { get; set; }
        public string Danger { get; set; }
        public int Xp { get; set; }
        public List<InventoryItem> Rewards { get; set; } //trick to figure this one out
        public bool Completed { get; set; }
        public bool Repeatable { get; set; }

        public Mission(int Id, string Name, string Requirement, string MainStat, int TotalTime, string Danger, int Xp, bool Repeatable)
        {
            this.Id = Id;
            this.Name = Name;
            this.Requirement = Requirement;
            this.TotalTime = TotalTime;
            this.Danger = Danger;
            this.Xp = Xp;
            this.Repeatable = Repeatable;
        }

        public static List<Mission> fullList = new List<Mission>()
        {
            new Mission(001, "Obtain a helicopter", "none", "Vehicles", 1, "Green", 10, false),
            new Mission(002, "Recruit a new soldier", "none", "any", 1, "Green", 10, true),
            new Mission(003, "Heist: necessary materials", "helicopter", "Sneak", 5, "Yellow", 10, true)
        };

    }
}
