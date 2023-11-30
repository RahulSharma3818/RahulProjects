using Microsoft.AspNetCore.Mvc;

namespace OganiMaster.Controllers
{
    public class PagesController : Controller
    {
        public async Task<IActionResult> ShopDetails()
        {
           return View();
        }
        public async Task<IActionResult> ShopCart()
        {
            return View();
        }
        public async Task<IActionResult> Checkout()
        {
            return View();
        }
        public async Task<IActionResult> BlogDetails()
        {
            return View();
        }
    }
}
