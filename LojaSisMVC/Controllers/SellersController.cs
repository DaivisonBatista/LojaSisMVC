using Microsoft.AspNetCore.Mvc;

namespace LojaSisMVC.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
