using System.ComponentModel.DataAnnotations;

namespace CompanyMangment.Domain.Entities
{
    public class Permission
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }=string.Empty;

        public ICollection<Role>? Roles { get; set; } = new List<Role>();

    }
}
