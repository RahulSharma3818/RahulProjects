using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OganiMaster.Data;
using OganiMaster.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OganiMaster.Controllers
{
    public class CustomerController : Controller
    {
        private readonly Dbcontext _context;
     

        public CustomerController(Dbcontext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Customersignup()
        {
            return View();
        }

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Check(Customer customer)
        
        {
            if ( (customer.Email!=null)&& ( customer.Password!=null))
            {
                await _context.Customers.AddAsync(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction("SignIn");
            }

            // Authentication failed
            return View("SignIn");
        }
        [HttpPost]
        public async Task<IActionResult> Confirm(string Email,string Password)
        {
            var customer = await _context.Customers.SingleOrDefaultAsync(c => c.Email == Email && c.Password == Password);

            if (customer != null)
            {
                return RedirectToAction("Index", "Home");

            }

            // Authentication failed
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return View("Index");
        }
    }
}
