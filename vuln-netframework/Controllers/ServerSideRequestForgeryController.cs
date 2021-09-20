using DI.Services;
using System.Web.Mvc;

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
        public ActionResult ClassicWithHttpClient(string path)
        {
            ViewBag.Message = _serverSideRequestForgeryService.ClassicWithHttpClient(path);
            return View("Classic");
        }

        [HttpPost]
        public ActionResult ClassicWithWebClient(string path)
        {
            ViewBag.Message = _serverSideRequestForgeryService.ClassicWithWebClient(path);
            return View("Classic");
        }

        [HttpPost]
        public ActionResult ClassicWithRestClient(string path)
        {
            ViewBag.Message = _serverSideRequestForgeryService.ClassicWithRestClient(path);
            return View("Classic");
        }

        [HttpPost]
        public ActionResult ClassicWithWebRequest(string path)
        {
            ViewBag.Message = _serverSideRequestForgeryService.ClassicWithWebRequest(path);
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
        public ActionResult BlindWithHttpClient(string path)
        {
            ViewBag.Message = _serverSideRequestForgeryService.BlindWithHttpClient(path);
            return View("Blind");
        }

        [HttpPost]
        public ActionResult BlindWithWebClient(string path)
        {
            ViewBag.Message = _serverSideRequestForgeryService.BlindWithWebClient(path);
            return View("Blind");
        }

        [HttpPost]
        public ActionResult BlindWithRestClient(string path)
        {
            ViewBag.Message = _serverSideRequestForgeryService.BlindWithRestClient(path);
            return View("Blind");
        }

        [HttpPost]
        public ActionResult BlindWithWebRequest(string path)
        {
            ViewBag.Message = _serverSideRequestForgeryService.BlindWithWebRequest(path);
            return View("Blind");
        }

        #endregion
    }
}