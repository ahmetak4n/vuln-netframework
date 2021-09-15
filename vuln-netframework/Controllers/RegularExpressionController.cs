using DI.Services;
using System.Web.Mvc;
using vuln_netframework.Models.RegularExpression;

namespace vuln_netframework.Controllers
{
    public class RegularExpressionController : Controller
    {
        private readonly IRegularExpressionService _regularExpressionService;

        public RegularExpressionController(IRegularExpressionService regularExpressionService)
        {
            _regularExpressionService = regularExpressionService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CheckPattern()
        {
            return View("Index");
        }

        [HttpGet]
        public ActionResult CheckPattern2()
        {
            return View("Index");
        }

        [HttpPost]
        public ActionResult CheckPattern(Pattern pattern)
        {
            ViewBag.Message = _regularExpressionService.CheckPattern(pattern.Query);
            return View("Index");
        }

        [HttpPost]
        public ActionResult CheckPattern2(Pattern pattern)
        {
            ViewBag.Message = _regularExpressionService.CheckPattern2(pattern.Query);
            return View("Index");
        }
    }
}