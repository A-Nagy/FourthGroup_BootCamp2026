 
using System.ComponentModel.DataAnnotations;

namespace CompanyMangment.Domain.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string UID { get; set; }=Guid.NewGuid().ToString();
        [Required]
        [StringLength(200)]
        public string Name { get; set; }= string.Empty;
        public string ? Description { get; set; }
        
        public ICollection<Category>? Categories { get; set; }

        public ICollection<Product>? products { get; set; }

        public int? IsActivate { get; set; } = 1; // Activate = 1  and this Shown in Select , Deactivate = 0 Dont Active on System  
        public int? DeActivateby { get; set; }
        public DateTime? DeActivateOn { get; set; }
        public int IsDeleted { get; set; } = 0;
        public int IsDeletedBy { get; set; }
        public DateTime IsDeletedOn { get; set; }
        public int IsUpdated { get; set; } = 0;
        public int IsUpdatedBy { get; set; }
        public DateTime IsUpdatedOn { get; set; }
    }
}