using System.ComponentModel.DataAnnotations;

namespace OganiMaster.Models
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }

      
        public string? Name { get; set; }

     
        public string? Email { get; set; }

        public string? Message { get; set; }
    }
}
