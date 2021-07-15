using DI.Services;
using System.Web.Mvc;
using vuln_netframework.Models.SqlInjection;

namespace vuln_netframework.Controllers
{
    public class SqlInjectionController : Controller
    {
        private readonly ISqlInjectionService _sqlInjectionService;

        public SqlInjectionController(ISqlInjectionService sqlInjectionService)
        {
            _sqlInjectionService = sqlInjectionService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        #region Union Based

        [HttpGet]
        public ActionResult UnionBased()
        {
            return View();
        }

        [HttpGet]
        public ActionResult UnionBasedWithFormatString()
        {
            return View("UnionBased");
        }

        [HttpGet]
        public ActionResult UnionBasedWithSqlDataAdapter()
        {
            return View("UnionBased");
        }

        [HttpPost]
        public ActionResult UnionBased(Search search)
        {
            ViewBag.Message = _sqlInjectionService.UnionBased(search.Username);
            return View();
        }

        [HttpPost]
        public ActionResult UnionBasedWithFormatString(Search search)
        {
            ViewBag.Message = _sqlInjectionService.UnionBasedWithFormatString(search.Username);
            return View("UnionBased");
        }

        [HttpPost]
        public ActionResult UnionBasedWithSqlDataAdapter(Search search)
        {
            ViewBag.Message = _sqlInjectionService.UnionBasedWithSqlDataAdapter(search.Username);
            return View("UnionBased");
        }

        #endregion

        #region Error Based

        [HttpGet]
        public ActionResult ErrorBased()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ErrorBasedWithFormatString()
        {
            return View("ErrorBased");
        }

        [HttpGet]
        public ActionResult ErrorBasedWithSqlDataAdapter()
        {
            return View("ErrorBased");
        }

        [HttpPost]
        public ActionResult ErrorBased(Insert insert)
        {
            ViewBag.Message = _sqlInjectionService.ErrorBased(insert.ProductName);
            return View();
        }

        [HttpPost]
        public ActionResult ErrorBasedWithFormatString(Insert insert)
        {
            ViewBag.Message = _sqlInjectionService.ErrorBasedWithFormatString(insert.ProductName);
            return View("ErrorBased");
        }

        [HttpPost]
        public ActionResult ErrorBasedWithSqlDataAdapter(Insert insert)
        {
            ViewBag.Message = _sqlInjectionService.ErrorBasedWithSqlDataAdapter(insert.ProductName);
            return View("ErrorBased");
        }

        #endregion

        #region Boolean Based

        [HttpGet]
        public ActionResult BooleanBased()
        {
            return View();
        }

        [HttpGet]
        public ActionResult BooleanBasedWithFormatString()
        {
            return View("BooleanBased");
        }

        [HttpGet]
        public ActionResult BooleanBasedWithSqlDataAdapter()
        {
            return View("BooleanBased");
        }

        [HttpPost]
        public ActionResult BooleanBased(Search search)
        {
            ViewBag.Message = _sqlInjectionService.BooleanBased(search.Username);
            return View();
        }

        [HttpPost]
        public ActionResult BooleanBasedWithFormatString(Search search)
        {
            ViewBag.Message = _sqlInjectionService.BooleanBasedWithFormatString(search.Username);
            return View("BooleanBased");
        }

        [HttpPost]
        public ActionResult BooleanBasedWithSqlDataAdapter(Search search)
        {
            ViewBag.Message = _sqlInjectionService.BooleanBasedWithSqlDataAdapter(search.Username);
            return View("BooleanBased");
        }

        #endregion

        #region Time Based

        [HttpGet]
        public ActionResult TimeBased()
        {
            return View();
        }

        [HttpGet]
        public ActionResult TimeBasedWithFormatString()
        {
            return View("TimeBased");
        }

        [HttpGet]
        public ActionResult TimeBasedWithSqlDataAdapter()
        {
            return View("TimeBased");
        }

        [HttpPost]
        public ActionResult TimeBased(Insert insert)
        {
            ViewBag.Message = _sqlInjectionService.TimeBased(insert.ProductName);
            return View();
        }

        [HttpPost]
        public ActionResult TimeBasedWithFormatString(Insert insert)
        {
            ViewBag.Message = _sqlInjectionService.TimeBasedWithFormatString(insert.ProductName);
            return View("TimeBased");
        }

        [HttpPost]
        public ActionResult TimeBasedWithSqlDataAdapter(Insert insert)
        {
            ViewBag.Message = _sqlInjectionService.TimeBasedWithSqlDataAdapter(insert.ProductName);
            return View("TimeBased");
        }

        #endregion

        #region Ouf-Of-Band

        [HttpGet]
        public ActionResult OutOfBand()
        {
            return View();
        }

        #endregion
    }
}