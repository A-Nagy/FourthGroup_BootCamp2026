using System.ComponentModel.DataAnnotations;

namespace CompanyMangment.Domain.Entities
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
        public string? PasswordHash { get; set; } = string.Empty;
        public string Password { get; set; }

        public int? IsActivate { get; set; } = 1; // Activate = 1  and this Shown in Select , Deactivate = 0 Dont Active on System  
        public int? DeActivateby { get; set; }
        public DateTime? DeActivateOn { get; set; }
        public int IsDeleted { get; set; } = 0;
        public int IsDeletedBy { get; set; }
        public DateTime IsDeletedOn { get; set; }
        public int IsUpdated { get; set; } = 0;
        public int IsUpdatedBy { get; set; }
        public DateTime IsUpdatedOn { get; set; }

        public ICollection<Role>? Roles { get; set; }
    }
}
