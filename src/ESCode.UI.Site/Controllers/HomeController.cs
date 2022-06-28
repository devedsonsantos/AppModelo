using Microsoft.AspNetCore.Mvc;

namespace ESCode.UI.Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
