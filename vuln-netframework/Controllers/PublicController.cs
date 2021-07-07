using System.Web.Mvc;
using vuln_netframework.Models.Login;

namespace vuln_netframework.Controllers
{
    [AllowAnonymous]
    public class PublicController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel loginModel)
        {
            return View();
        }
    }
}