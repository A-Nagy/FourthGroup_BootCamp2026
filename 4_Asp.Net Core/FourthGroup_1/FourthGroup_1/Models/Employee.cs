using System.ComponentModel.DataAnnotations;

namespace FourthGroup_1.Models
{
    public class Employee
    {
        //Data Annotations are used to specify the validation rules for the properties of the model

        [Key]//key attribute is used to specify the primary key of the entity
        // this is the primary key for the employee table
        public int Id { get; set; }
        [Required] //required attribute is used to specify that the property is required
        [StringLength(100,ErrorMessage ="This Name is Too Long")]//stringlength attribute is used to specify the maximum length of the property
        public string Name { get; set; } = string.Empty;
        [EmailAddress] //emailaddress attribute is used to specify that the property is an email address
        public string Email { get; set; }  
        [Required]
        public string Phone { get; set; } = string.Empty;
             // ? means that the property is nullable
        public string? Address { get; set; }
        [Required]
        [Range(3000,10000, ErrorMessage = "Salary must be between 3000 and 10000 SR")] //range attribute is used to specify the range of the property
        public double Salary { get; set; }

        public int? DepartmentId { get; set; }
        //navigation Property
        public Department? Department { get; set; }

    }
}
