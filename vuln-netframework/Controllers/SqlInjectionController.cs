using DI.Services;
using System.Web.Http;

namespace vuln_netframework.Controllers
{
    [RoutePrefix("api/sqlinjection")]
    public class SqlInjectionController : ApiController
    {
        private readonly ISqlInjectionService _sqlInjectionService;

        public SqlInjectionController(ISqlInjectionService sqlInjectionService)
        {
            _sqlInjectionService = sqlInjectionService;
        }

        [Route("index")]
        public string GetIndex()
        {
            return "Welcome SQL Injection Page";
        }

        [Route("classic")]
        public string PostClassic([FromBody] string param)
        {
            return _sqlInjectionService.Classic(param);
        }

        [Route("classicwithformatstring")]
        public string PostClassicWithFormatString([FromBody] string param)
        {
            return _sqlInjectionService.ClassicWithFormatString(param);
        }

        [Route("blind")]
        public string PostBlind([FromBody] string param)
        {
            return _sqlInjectionService.Blind(param);
        }

        [Route("blindsecond")]
        public void PostBlindSecond([FromBody] string param)
        {
            _sqlInjectionService.BlindSecond(param);
        }

    }
}