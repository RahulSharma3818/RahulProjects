using Microsoft.AspNetCore.Mvc;

namespace OganiMaster.Controllers
{
    public class Blog : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
