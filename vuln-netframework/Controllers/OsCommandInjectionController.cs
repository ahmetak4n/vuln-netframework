using DI.Services;
using System.Web.Mvc;
using vuln_netframework.Models.OsCommandInjection;

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
        public ActionResult Classic(Ping ping)
        {
            ViewBag.Message = _osCommandInjection.Classic(ping.Ip);
            return View();
        }

        #endregion

        #region Blind

        [HttpGet]
        public ActionResult Blind()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Blind(Ping ping)
        {
            ViewBag.Message = _osCommandInjection.Blind(ping.Ip);
            return View();
        }

        #endregion
    }
}