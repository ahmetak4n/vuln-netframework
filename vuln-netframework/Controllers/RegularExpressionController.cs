using DI.Services;
using System.Web.Http;

namespace vuln_netframework.Controllers
{
    [RoutePrefix("api/regularexpression")]
    public class RegularExpressionController : ApiController
    {
        private readonly IRegularExpressionService _regularExpressionService;

        public RegularExpressionController(IRegularExpressionService regularExpressionService)
        {
            _regularExpressionService = regularExpressionService;
        }

        [Route("index")]
        public string GetIndex()
        {
            return "Welcome Regular Expression Page";
        }

        [Route("validate")]
        public string PostValidate([FromBody] string search)
        {
            return _regularExpressionService.Validate(search);
        }

    }
}