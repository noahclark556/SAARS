using SAARS.models;
using SAARS.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SAARS.components
{
    public static class DataSerializer
    {
        public static byte[] Serialize(SettingsModel settings)
        {
            IFormatter formatter = new BinaryFormatter();
            using (MemoryStream memoryStream = new MemoryStream())
            {
                formatter.Serialize(memoryStream, settings);
                byte[] serialized = memoryStream.ToArray();
                return serialized;
            }
        }

        public static SettingsModel Deserialize(byte[] data)
        {
            IFormatter formatter = new BinaryFormatter();
            using(MemoryStream memoryStream = new MemoryStream(data))
            {
                SettingsModel settings = (SettingsModel)formatter.Deserialize(memoryStream);
                return settings;
            }
        }
    }
}
