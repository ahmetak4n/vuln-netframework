using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;

namespace DI.Services
{
    public class InsecureDeserialization : IInsecureDeserialization
    {
        public void NewtonsoftDeserialization(string json)
        {
            try
            {
                JsonConvert.DeserializeObject<object>(json, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All
                });
            } catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void BinaryDeserialization (string json)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            try
            {
                MemoryStream memoryStream = new MemoryStream(Encoding.ASCII.GetBytes(json));
                binaryFormatter.Deserialize(memoryStream);
            } catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
