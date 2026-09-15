using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FourthGroup_1.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [MaxLength(100), Required]
        public string Name { get; set; } = "";
         
        [Required(ErrorMessage = "Pls Enter The Age") ]
        public int Age { get; set; }
    }
}
