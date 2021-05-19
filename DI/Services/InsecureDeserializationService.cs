using System;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.UI;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization;

namespace DI.Services
{
    public class InsecureDeserializationService : IInsecureDeserializationService
    {
        /*
         * Insecure Netwonsoft.JSON Deserialize usage
         */
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

        /*
         * Insecure DataContractJsonSerializer Deserialize usage
         */
        public void DataContractJsonDeserialization(string type, string json)
        {
            DataContractJsonSerializerSettings dataContractJsonSerializerSettings = new DataContractJsonSerializerSettings()
            {
                KnownTypes = null
            };

            DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(Type.GetType(type), dataContractJsonSerializerSettings);

            try
            {
                MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(json));
                dataContractJsonSerializer.ReadObject(memoryStream);
                memoryStream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /*
         * Insecure BinaryFormatter usage
         * https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.formatters.binary.binaryformatter?view=net-5.0#remarks
         */
        public void BinaryFormatterDeserialization(string json)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            try
            {
                MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(json));
                binaryFormatter.Deserialize(memoryStream);
                memoryStream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /*
         * Insecure LosFormatter usage
         * https://docs.microsoft.com/en-us/dotnet/api/system.web.ui.losformatter.deserialize?view=netframework-4.8#remarks
         */
        public void LosFormatterDeserialization(string json)
        {
            try
            {
                LosFormatter losFormatter = new LosFormatter();
                object obj = losFormatter.Deserialize(json);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /*
         * Insecure SoapFormatter usage
         * https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.formatters.soap.soapformatter.deserialize?view=netframework-4.8#remarks
         */
        public void SoapFormatterDeserialization(string json)
        {
            try
            {
                MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json));

                SoapFormatter soapFormatter = new SoapFormatter();
                object obj = soapFormatter.Deserialize(ms);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /*
         * Insecure NetDataContractSerializer usage
         * https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.netdatacontractserializer.deserialize?view=netframework-4.8#remarks
         */
        public void NetDataContractDeserialization(string json)
        {
            try
            {
                MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json));

                NetDataContractSerializer netDataContractSerializer = new NetDataContractSerializer();
                object obj = netDataContractSerializer.Deserialize(ms);
                Console.WriteLine(obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
