using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OganiMaster.Data;
using OganiMaster.Models;

namespace OganiMaster.Controllers
{
    public class ContactController : Controller
    {
        private readonly Dbcontext _context;

        public ContactController(Dbcontext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Send(Contact contact)
        {
            if (contact!=null)
            {
                // Ensure Email is set to a non-null value
               

                await _context.Contacts.AddAsync(contact);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View("Index");
        }

    }
}
