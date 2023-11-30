using Microsoft.AspNetCore.Mvc;

namespace OganiMaster.Controllers
{
    public class ShopController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
