using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LojicFloorboard_FormsApp
{
    class XMLWriter
    {
        public void SavePoints(Points pts)
        {
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(Points));
            string path = @"Data\Points.xml";
            if (!System.IO.File.Exists(path))
            {
                System.IO.FileStream fs = System.IO.File.Create(path);
                fs.Close();
            }
            using (System.IO.FileStream fs = System.IO.File.Create(path)) {
                writer.Serialize(fs, pts);
                fs.Close();
            }
        }
        public Points LoadPoints(string path)
        {
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(Points));
            if (!System.IO.File.Exists(path)) {
                return null;
            }
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(path);
                Points pts = (Points)reader.Deserialize(file);
                file.Close();
                return pts;
            }
            catch (Exception e) {
                return null;
            }
        }
    }

}
