using Microsoft.AspNetCore.Mvc;

namespace HiringManager.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
