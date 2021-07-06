using DI.Services;
using System.Web.Http;

namespace vuln_netframework.Controllers
{
    [RoutePrefix("api/serversiderequestforgery")]
    public class ServerSideRequestForgeryController : ApiController
    {
        private readonly IServerSideRequestForgeryService _serverSideRequestForgeryService;

        public ServerSideRequestForgeryController(IServerSideRequestForgeryService serverSideRequestForgery)
        {
            _serverSideRequestForgeryService = serverSideRequestForgery;
        }

        [Route("index")]
        public string GetIndex()
        {
            return "Welcome Server Side Request Forgery Page";
        }

        [Route("synchttpclient")]
        public string PostSyncHttpClient([FromBody] string path)
        {
            return _serverSideRequestForgeryService.SyncHttpClient(path);
        }

        [Route("syncwebclient")]
        public string PostSyncWebClient([FromBody] string path)
        {
            return _serverSideRequestForgeryService.SyncWebClient(path);
        }

        [Route("syncrestclient")]
        public string PostSyncRestClient([FromBody] string path)
        {
            return _serverSideRequestForgeryService.SyncRestClient(path);
        }
    }
}