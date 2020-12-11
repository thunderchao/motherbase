using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace db_version
{
    public class Squad
    {
        public DateTime DateSaved { get; set; }
        public List<Troop> troops = new List<Troop>();

        public Squad()
        {
            this.DateSaved = DateTime.Now;
            this.troops = new List<Troop>();
        }

        public static Squad LoadSquad()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Squad));
            TextReader reader = new StreamReader(@".\savefile.xml");
            object obj = deserializer.Deserialize(reader);
            Squad XmlData = (Squad)obj;
            reader.Close();
            return XmlData;
        }
        public static void SaveSquad(Squad squad)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Squad));
            using (TextWriter writer = new StreamWriter(@".\savefile.xml"))
            {
                serializer.Serialize(writer, squad);
            }
        }
    }
    
}
