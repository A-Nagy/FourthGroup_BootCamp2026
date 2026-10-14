using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyMangment.Domain.Entities
{
    public class Employee
    {
       
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required] 
        public string Email { get; set; }  
        [Required]
        public string Phone { get; set; } = string.Empty;
        public string? Address { get; set; }
        [Required]
        [Range(3000,10000, ErrorMessage = "Salary must be between 3000 and 10000 SR")]
        public double Salary { get; set; }
        [ForeignKey("Department")]
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
        [ForeignKey("Role")]
        public int? RoleId { get; set; }
        public Role? Role { get; set; }
        public int? IsActivate { get; set; } = 1; // Activate = 1  and this Shown in Select , Deactivate = 0 Dont Active on System  
        public int? DeActivateby { get; set; }
        public DateTime? DeActivateOn { get; set; }
        public int IsDeleted { get; set; } = 0;//softdelete
        public int IsDeletedBy { get; set; }
        public DateTime IsDeletedOn { get; set;}
        public int IsUpdated { get; set; } = 0;
        public int IsUpdatedBy { get; set; }
        public DateTime IsUpdatedOn { get; set; }

    }
}
