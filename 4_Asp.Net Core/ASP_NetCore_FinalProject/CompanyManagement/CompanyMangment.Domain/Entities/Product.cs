using System.ComponentModel.DataAnnotations;

namespace CompanyMangment.Domain.Entities
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

        public string? ImageUrl { get; set; }

        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

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
