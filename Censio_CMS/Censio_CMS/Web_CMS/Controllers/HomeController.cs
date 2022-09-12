
using Censio_CMS.Web;
using Censio_CMS.Web.Filter;
using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Logging;


namespace Censio_CMS.Controllers
{
    [SessionTimeout]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public int SetOrg(int ID_ORGANIZATION)
        {
            CommonFunctions.ID_ORGANIZATION = ID_ORGANIZATION;
            return 1;

        }
    }
}
