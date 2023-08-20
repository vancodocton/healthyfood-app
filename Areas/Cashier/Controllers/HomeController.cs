using Microsoft.AspNetCore.Mvc;

namespace asp_dotnet_core_healthyfood_app.Areas.Cashier.Controllers
{
    [Area("Cashier")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
