using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


namespace ADGP125
{
   
    class Serial
    {
        public static void GoToBinary<T>(string a, T t, string path)
        {
            using (FileStream fs = File.Create(path + a + ".xml"))
            {
                XmlSerializer Serial = new XmlSerializer(typeof(T));
                Serial.Serialize(fs, t);

                fs.Close();
            }
        }
        
        public static T ComeBack<T>(string a)
        {
            XmlSerializer Deserial = new XmlSerializer(typeof(T));

            T t;

            using (FileStream fs = File.OpenRead(a + ".xml"))
            {

                t = (T)Deserial.Deserialize(fs);
                fs.Close();
            }

            return t;
        }
    }




}