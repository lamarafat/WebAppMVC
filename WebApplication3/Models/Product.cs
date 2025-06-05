using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Product
    {

        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(250)]
        public string Description { get; set; }

    }
}
