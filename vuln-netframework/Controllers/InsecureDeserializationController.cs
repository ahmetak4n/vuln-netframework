using DI.Services;

using System.Web.Http;

namespace vuln_netframework.Controllers
{
    [RoutePrefix("api/insecuredeserialization")]
    public class InsecureDeserializationController : ApiController
    {
        private IInsecureDeserialization _insecureDeserialization;

        public InsecureDeserializationController(IInsecureDeserialization insecureDeserialization)
        {
            _insecureDeserialization = insecureDeserialization;
        }

        [Route("index")]
        public string GetIndex()
        {
            return "value";
        }

        /*
         * Request method can defined via multiple way:
         *  1) [HttpPost], etc. metadata
         *  2) Prefix of method name like PostNewtonsoftID
         *  3) in WebApiConfig.cs
         */
        [Route("newtonsoft")]
        public void PostNewtonsoftID([FromBody] string json)
        {
            _insecureDeserialization.NewtonsoftDeserialization(json);
        }
    }
}
