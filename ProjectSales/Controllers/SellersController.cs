using Microsoft.AspNetCore.Mvc;

namespace ProjectSales.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
