using DI.Services;
using vuln_netframework.Models;
using System.Web.Mvc;

namespace vuln_netframework.Controllers
{
    public class InsecureDeserializationController : Controller
    {
        private readonly IInsecureDeserializationService _insecureDeserialization;

        public InsecureDeserializationController(IInsecureDeserializationService insecureDeserialization)
        {
            _insecureDeserialization = insecureDeserialization;
        }

        public ActionResult Index()
        {
            return View();
        }

        /*
         * Request method can defined via multiple way:
         *  1) Metadata like [HttpPost], etc.
         *  2) Prefix of method name like PostNewtonsoftID
         *  3) in WebApiConfig.cs
         */

        /*
        [Route("newtonsoft")]
        public void PostNewtonsoftDeserialization([FromBody] string json)
        {
            _insecureDeserialization.NewtonsoftDeserialization(json);
        }

        [Route("newtonsoft/objectbinding")]
        public string PostObjectBinding([FromBody] NewtonsoftInsecureDeserializationModel model)
        {
            return "Object Binded";
        }

        [Route("fastjson")]
        public void PostFastJSONDeserialization([FromBody] string json)
        {
            _insecureDeserialization.FastJSONDeserialization(json);
        }

        [Route("datacontractjsondeserialization")]
        public void PostDataContractJsonDeserialization([FromBody] DataContractInsecureDeserializationModel obj)
        {
            _insecureDeserialization.DataContractJsonDeserialization(obj.T, obj.Model);
        }

        [Route("javascriptserializer")]
        public void PostJavascriptSerializerDeserialization([FromBody] string json)
        {
            _insecureDeserialization.JavascriptSerializerDeserialization(json);
        }

        [Route("binaryformatter")]
        public void PostBinaryDeserialization([FromBody] string json)
        {
            _insecureDeserialization.BinaryFormatterDeserialization(json);
        }

        [Route("losformatterdeserialization")]
        public void PostLosFormatterDeserialization([FromBody] string json)
        {
            _insecureDeserialization.LosFormatterDeserialization(json);
        }

        [Route("soapformatterdeserialization")]
        public void PostSoapFormatterDeserialization([FromBody] string json)
        {
            _insecureDeserialization.SoapFormatterDeserialization(json);
        }

        [Route("netdatacontractdeserialization")]
        public void PostNetDataContractDeserialization([FromBody] string json)
        {
            _insecureDeserialization.NetDataContractDeserialization(json);
        }

        [Route("fspickler")]
        public void PostFsPicklerDeserialization([FromBody] string json)
        {
            _insecureDeserialization.FsPicklerDeserialization(json);
        }

        */
    }
}
