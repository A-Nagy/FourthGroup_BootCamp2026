using System.ComponentModel.DataAnnotations;

namespace FourthGroup_1.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Name { get; set; }= string.Empty;
        public string ? Description { get; set; }
    }
}
