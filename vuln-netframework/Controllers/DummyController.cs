using DI.Services;
using System.Web.Mvc;

namespace vuln_netframework.Controllers
{
    public class DummyController : Controller
    {
        private readonly IDummyService _dummyService;
        public DummyController(IDummyService dummyService) 
        {
            _dummyService = dummyService;
        }
        
        [HttpGet]
        public string CityList()
        {
            return _dummyService.CityList();
        }
    }
}
