using DI.Services;
using System.Web.Mvc;

namespace vuln_netframework.Controllers
{
    public class SqlInjectionController : Controller
    {
        private readonly ISqlInjectionService _sqlInjectionService;

        public SqlInjectionController()
        {
            
        }

        public SqlInjectionController(ISqlInjectionService sqlInjectionService)
        {
            _sqlInjectionService = sqlInjectionService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult UnionBased()
        {
            return View();
        }

        /*
        [Route("classic/unionbased")]
        public string PostUnionBased([FromBody] string param)
        {
            return _sqlInjectionService.UnionBased(param);
        }

        [Route("classic/unionbasedwithformatstring")]
        public string PostUnionBasedWithFormatString([FromBody] string param)
        {
            return _sqlInjectionService.UnionBasedWithFormatString(param);
        }

        [Route("classic/unionbasedsqldataadapter")]
        public string PostUnionBasedSqlDataAdapter([FromBody] string param)
        {
            return _sqlInjectionService.UnionBasedSqlDataAdapter(param);
        }

        [Route("classic/errorbased")]
        public void PostErrorBased([FromBody] string param)
        {
            _sqlInjectionService.ErrorBased(param);
        }

        [Route("classic/errorbasedwithformatstring")]
        public void PostErrorBasedWithFormatString([FromBody] string param)
        {
            _sqlInjectionService.ErrorBasedWithFormatString(param);
        }

        [Route("classic/errorbasedsqldataadapter")]
        public void PostErrorBasedSqlDataAdapter([FromBody] string param)
        {
            _sqlInjectionService.ErrorBasedSqlDataAdapter(param);
        }

        [Route("blind/booleanbased")]
        public string PostBooleanBased([FromBody] string param)
        {
            return _sqlInjectionService.BooleanBased(param);
        }

        [Route("blind/booleanbasedwithformatstring")]
        public string PostBooleanBasedWithFormatString([FromBody] string param)
        {
            return _sqlInjectionService.BooleanBasedWithFormatString(param);
        }

        [Route("blind/booleanbasedsqldataadapter")]
        public string PostBooleanBasedSqlDataAdapter([FromBody] string param)
        {
            return _sqlInjectionService.BooleanBasedSqlDataAdapter(param);
        }

        [Route("blind/timebased")]
        public void PostTimeBased([FromBody] string param)
        {
            _sqlInjectionService.TimeBased(param);
        }

        [Route("blind/timebasedwithformatstring")]
        public void PostTimeBasedWithFormatString([FromBody] string param)
        {
            _sqlInjectionService.TimeBasedWithFormatString(param);
        }

        [Route("blind/timebasedsqldataadapter")]
        public void PostTimeBasedSqlDataAdapter([FromBody] string param)
        {
            _sqlInjectionService.TimeBasedSqlDataAdapter(param);
        }

        */
    }
}