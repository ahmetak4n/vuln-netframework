using Newtonsoft.Json;

namespace vuln_netframework.Models
{
    public class NewtonsoftInsecureDeserializationModel
    {
        [JsonProperty(PropertyName = "model")]
        public dynamic Model { get; set; }
    }
}