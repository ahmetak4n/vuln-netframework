using DI.Services;
using System.Web.Mvc;

namespace vuln_netframework.Controllers
{
    public class OsCommandInjectionController : Controller
    {
        private readonly IOsCommandInjectionService _osCommandInjection;

        public OsCommandInjectionController(IOsCommandInjectionService osCommandInjection)
        {
            _osCommandInjection = osCommandInjection;
        }

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

        [HttpPost]
        public ActionResult Classic(string command, string arguments)
        {
            ViewBag.Message = _osCommandInjection.Classic(command, arguments);
            return View();
        }

        [HttpPost]
        public ActionResult ClassicWithProcessStartInfo(string command, string arguments)
        {
            ViewBag.Message = _osCommandInjection.ClassicWithProcessStartInfo(command, arguments);
            return View("Classic");
        }

        [HttpPost]
        public ActionResult Classic2(string ip)
        {
            ViewBag.Message = _osCommandInjection.Classic2(ip);
            return View("Classic");
        }

        
        [HttpPost]
        public ActionResult Classic2WithProcessStartInfo(string ip)
        {
            ViewBag.Message = _osCommandInjection.Classic2WithProcessStartInfo(ip);
            return View("Classic");
        }

        [HttpPost]
        public ActionResult ClassicWithPython(string arguments)
        {
            ViewBag.Message = _osCommandInjection.ClassicWithPython(arguments);
            return View("Classic");
        }

        #endregion
        
        #region Blind
        [HttpGet]
        public ActionResult Blind()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Blind(string command)
        {
            ViewBag.Message = _osCommandInjection.Blind(command);
            return View();
        }

        [HttpPost]
        public ActionResult BlindWithArguments(string command, string arguments)
        {
            ViewBag.Message = _osCommandInjection.BlindWithArguments(command, arguments);
            return View("Blind");
        }

        [HttpPost]
        public ActionResult Blind2(string command)
        {
            ViewBag.Message = _osCommandInjection.Blind2(command);
            return View("Blind");
        }

        [HttpPost]
        public ActionResult Blind2WithProcessStartInfo(string command)
        {
            ViewBag.Message = _osCommandInjection.Blind2WithProcessStartInfo(command);
            return View("Blind");
        }

        [HttpPost]
        public ActionResult Blind3(string command, string arguments)
        {
            ViewBag.Message = _osCommandInjection.Blind3(command, arguments);
            return View("Blind");
        }

        [HttpPost]
        public ActionResult Blind3WithProcessStartInfo(string command, string arguments)
        {
            ViewBag.Message = _osCommandInjection.Blind3WithProcessStartInfo(command, arguments);
            return View("Blind");
        }

        [HttpPost]
        public ActionResult Blind4(string host)
        {
            ViewBag.Message = _osCommandInjection.Blind4(host);
            return View("Blind");
        }

        [HttpPost]
        public ActionResult Blind4WithProcessStartInfo(string host)
        {
            ViewBag.Message = _osCommandInjection.Blind4WithProcessStartInfo(host);
            return View("Blind");
        }
        #endregion
    }
}