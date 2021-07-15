using DI.Services;
using System.Web.Mvc;
using vuln_netframework.Models.ServerSideRequestForgery;

namespace vuln_netframework.Controllers
{
    public class ServerSideRequestForgeryController : Controller
    {
        private readonly IServerSideRequestForgeryService _serverSideRequestForgeryService;

        public ServerSideRequestForgeryController(IServerSideRequestForgeryService serverSideRequestForgery)
        {
            _serverSideRequestForgeryService = serverSideRequestForgery;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        #region Classic

        [HttpGet]
        public ActionResult Classic()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ClassicWithHttpClient()
        {
            return View("Classic");
        }

        [HttpGet]
        public ActionResult ClassicWithWebClient()
        {
            return View("Classic");
        }

        [HttpGet]
        public ActionResult ClassicWithRestClient()
        {
            return View("Classic");
        }

        [HttpPost]
        public ActionResult ClassicWithHttpClient(Request request)
        {
            ViewBag.Message = _serverSideRequestForgeryService.ClassicWithHttpClient(request.Path);
            return View("Classic");
        }

        [HttpPost]
        public ActionResult ClassicWithWebClient(Request request)
        {
            ViewBag.Message = _serverSideRequestForgeryService.ClassicWithWebClient(request.Path);
            return View("Classic");
        }

        [HttpPost]
        public ActionResult ClassicWithRestClient(Request request)
        {
            ViewBag.Message = _serverSideRequestForgeryService.ClassicWithRestClient(request.Path);
            return View("Classic");
        }

        #endregion

        #region Blind

        [HttpGet]
        public ActionResult Blind()
        {
            return View();
        }

        [HttpGet]
        public ActionResult BlindWithHttpClient()
        {
            return View("Blind");
        }

        [HttpGet]
        public ActionResult BlindWithWebClient()
        {
            return View("Blind");
        }

        [HttpGet]
        public ActionResult BlindWithRestClient()
        {
            return View("Blind");
        }

        [HttpPost]
        public ActionResult BlindWithHttpClient(Request request)
        {
            ViewBag.Message = _serverSideRequestForgeryService.BlindWithHttpClient(request.Path);
            return View("Blind");
        }

        [HttpPost]
        public ActionResult BlindWithWebClient(Request request)
        {
            ViewBag.Message = _serverSideRequestForgeryService.BlindWithWebClient(request.Path);
            return View("Blind");
        }

        [HttpPost]
        public ActionResult BlindWithRestClient(Request request)
        {
            ViewBag.Message = _serverSideRequestForgeryService.BlindWithRestClient(request.Path);
            return View("Blind");
        }

        #endregion
    }
}