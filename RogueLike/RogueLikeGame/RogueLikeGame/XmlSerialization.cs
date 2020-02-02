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

        public static void SerializeObject(object user)
        {
            if (user.GetType() == typeof(UserSettings))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(UserSettings));
                using (FileStream fs = new FileStream("CurrentUserSettings.xml", FileMode.Create))
                {
                    serializer.Serialize(fs, user);
                }
            }
            else if(user.GetType() == typeof(GlobalSettings))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(GlobalSettings));
                using (FileStream fs = new FileStream("CurrentGlobalSettings.xml", FileMode.Create))
                {
                    serializer.Serialize(fs, user);
                }
            }
            else if (user.GetType() == typeof(Items))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Items));
                using (FileStream fs = new FileStream("CurrentItems.xml", FileMode.Create))
                {
                    serializer.Serialize(fs, user);
                }
            }
            else if(user.GetType() == typeof(DictionaryEntries))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(DictionaryEntries));
                using (FileStream fs = new FileStream("UserScores.xml", FileMode.Create))
                {
                    serializer.Serialize(fs, user);
                }
            }
        }

        public static object DeserializeObject(int i)
        {
            XmlSerializer serialize;
            switch (i)
            {
                case 0:
                    serialize = new XmlSerializer(typeof(UserSettings));
                    using (FileStream fs = new FileStream("CurrentUserSettings.xml", FileMode.Open))
                    {
                        return serialize.Deserialize(fs) as UserSettings;
                    }
                case 1:
                    serialize = new XmlSerializer(typeof(GlobalSettings));
                    using (FileStream fs = new FileStream("CurrentGlobalSettings.xml", FileMode.Open))
                    {
                        return serialize.Deserialize(fs) as GlobalSettings;
                    }
                case 2:
                    serialize = new XmlSerializer(typeof(Items));
                    using (FileStream fs = new FileStream("CurrentItems.xml", FileMode.Open))
                    {
                        return serialize.Deserialize(fs) as Items;
                    }
                case 3:
                    serialize = new XmlSerializer(typeof(DictionaryEntries));
                    using(FileStream fs = new FileStream("UserScores.xml", FileMode.Open))
                    {
                        return serialize.Deserialize(fs) as DictionaryEntries;
                    }
            }
            return null;
        }
    }
}
