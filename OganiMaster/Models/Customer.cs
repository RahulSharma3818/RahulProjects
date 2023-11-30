using System.ComponentModel.DataAnnotations;

namespace OganiMaster.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string? Name { get; set; }
        public string? Country { get; set; }
        public string? Address { get; set; }
        public string? State { get; set; }
        public int? Phone { get; set; }

        
        public string? Email { get; set; }


        
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}

