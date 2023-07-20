using System.ComponentModel.DataAnnotations;

namespace LabWebApp.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(255)] // Adjust the length as needed
        public string Description { get; set; }


     // Add a default constructor to initialize the non-nullable properties
        public Product()
        {
            Name = string.Empty;
            Description = string.Empty;
        }
    }
}
