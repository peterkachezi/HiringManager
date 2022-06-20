using Microsoft.AspNetCore.Mvc;

namespace HiringManager.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
