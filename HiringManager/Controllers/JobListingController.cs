using Microsoft.AspNetCore.Mvc;

namespace HiringManager.Controllers
{

    public class JobListingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
