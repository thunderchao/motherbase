using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

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
        public InventoryItem Reward { get; set; }
        public bool Completed { get; set; }
        public bool Repeatable { get; set; }

        public Mission(int Id, string Name, string Requirement, string MainStat, int TotalTime, string Danger, int Xp, bool Repeatable)
        {
            this.Id = Id;
            this.Name = Name;
            this.Requirement = Requirement;
            this.MainStat = MainStat;
            this.TotalTime = TotalTime;
            this.Danger = Danger;
            this.Xp = Xp;
            this.Repeatable = Repeatable;
        }
    }

    [XmlRootAttribute("MissionList")]
    public class Missions
    {
        [XmlElement("Mission")]
        public Mission[] MissionList { get; set; }

        public Missions()
        {
            this.MissionList = MissionList;
        }
    }
}
