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
        public ActionResult Classic(string ip)
        {
            ViewBag.Message = _osCommandInjection.Classic(ip);
            return View();
        }

        [HttpPost]
        public ActionResult Classic2(string command)
        {
            ViewBag.Message = _osCommandInjection.Classic2(command);
            return View("Classic");
        }

        [HttpPost]
        public ActionResult Classic3(string command)
        {
            ViewBag.Message = _osCommandInjection.Classic3(command);
            return View("Classic");
        }

        [HttpPost]
        public ActionResult ClassicWithPython(string command)
        {
            ViewBag.Message = _osCommandInjection.ClassicWithPython(command);
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
        public ActionResult Blind(string ip)
        {
            ViewBag.Message = _osCommandInjection.Blind(ip);
            return View();
        }

        #endregion
    }
}