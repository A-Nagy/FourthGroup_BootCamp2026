using System.ComponentModel.DataAnnotations;

namespace FourthGroup_1.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string Name { get; set; }=string.Empty;
      
        public string? Description { get; set; }
        [Required]
        [Range(10,5000)]
        public decimal Price { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}
