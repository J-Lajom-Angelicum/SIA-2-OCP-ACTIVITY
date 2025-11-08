using Microsoft.AspNetCore.Mvc;

namespace SIA_2_OCP_ACTIVITY.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
