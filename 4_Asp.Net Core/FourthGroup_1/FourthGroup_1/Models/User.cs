using System.ComponentModel.DataAnnotations;

namespace FourthGroup_1.Models
{
    public class User
    {

      
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        public string? Email { get; set; }
        [Required]
        public string UserName { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;

        public ICollection<Role>? Roles { get; set; }
    }
}
