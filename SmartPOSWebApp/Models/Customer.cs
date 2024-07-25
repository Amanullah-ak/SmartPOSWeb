using System.ComponentModel.DataAnnotations;

namespace SmartPOSWebApp.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
