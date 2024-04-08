using Microsoft.AspNetCore.Mvc;

namespace ChatApps.Controllers
{
    public class testController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
