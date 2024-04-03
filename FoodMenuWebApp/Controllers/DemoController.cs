using Microsoft.AspNetCore.Mvc;

namespace FoodMenuWebApp.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
