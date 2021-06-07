using DI.Services;
using System.Web.Http;

namespace vuln_netframework.Controllers
{
    [RoutePrefix("api/oscommandinjection")]
    public class OsCommandInjectionController : ApiController
    {
        private readonly IOsCommandInjectionService _osCommandInjection;

        public OsCommandInjectionController(IOsCommandInjectionService osCommandInjection)
        {
            _osCommandInjection = osCommandInjection;
        }

        [Route("index")]
        public string GetIndex()
        {
            return "Welcome Injection Page";
        }

        [Route("runoscommand")]
        public void PostRunOsCommand([FromBody] string json)
        {
            _osCommandInjection.RunOsCommand(json);
        }

        [Route("runoscommandwithstartinfo")]
        public void PostRunOsCommandWithStartInfo([FromBody] string json)
        {
            _osCommandInjection.RunOsCommandWithStartInfo(json);
        }

        [Route("runpythonwithargs")]
        public void PostRunPythonWithArgs([FromBody] string args)
        {
            _osCommandInjection.RunPythonWithArgs(args);
        }
    }
}