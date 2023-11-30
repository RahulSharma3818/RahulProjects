using Microsoft.EntityFrameworkCore;
using OganiMaster.Models;

namespace OganiMaster.Data
{
    public class Dbcontext : DbContext
    {
        public Dbcontext(DbContextOptions<Dbcontext> Options) : base(Options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Customer> Customers{ get; set; }
       
    }
}
