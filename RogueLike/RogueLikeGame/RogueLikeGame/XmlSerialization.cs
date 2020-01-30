using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace RogueLikeGame
{
    public static class XmlSerialization
    {
        public static void Serialize(Dictionary<string, int> dictionary)    //Dictionary
        {
            FileStream fs = new FileStream("Data.xml", FileMode.OpenOrCreate);

            List<DictionaryEntries> entries = new List<DictionaryEntries>(dictionary.Count);
            foreach (string key in dictionary.Keys)
            {
                entries.Add(new DictionaryEntries(key, dictionary[key]));
            }
            XmlSerializer serializer = new XmlSerializer(typeof(List<DictionaryEntries>));
            serializer.Serialize(fs, entries);
        }

        public static void Deserialize(Dictionary<string, int> dictionary)  //Dictionary
        {
            FileStream fs = new FileStream("Data.xml", FileMode.Open);

            dictionary.Clear();
            XmlSerializer serializer = new XmlSerializer(typeof(List<DictionaryEntries>));
            List<DictionaryEntries> list = (List<DictionaryEntries>)serializer.Deserialize(fs);
            foreach (DictionaryEntries entry in list)
            {
                dictionary[entry.Key] = entry.Value;
            }
        }

        public static void SerializeObject(UserSettings user)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(UserSettings));
            using (FileStream fs = new FileStream("CurrentUserSettings.xml", FileMode.Create))
            {
                serializer.Serialize(fs, user);
            }
        }

        public static UserSettings DeserializeObject()
        {
            XmlSerializer serialize = new XmlSerializer(typeof(UserSettings));
            using (FileStream fs = new FileStream("CurrentUserSettings.xml", FileMode.Open))
            {
                return serialize.Deserialize(fs) as UserSettings;
            }
        }
    }
}
