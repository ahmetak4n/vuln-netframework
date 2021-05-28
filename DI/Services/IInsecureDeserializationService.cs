namespace DI.Services
{
    public interface IInsecureDeserializationService
    {
        void NewtonsoftDeserialization(string json);
        void FastJSONDeserialization(string json);
        void DataContractJsonDeserialization(string type, string json);
        void JavascriptSerializerDeserialization(string json);
        void BinaryFormatterDeserialization(string json);
        void LosFormatterDeserialization(string json);
        void SoapFormatterDeserialization(string json);
        void NetDataContractDeserialization(string json);
        void FsPicklerDeserialization(string json);
    }
}
