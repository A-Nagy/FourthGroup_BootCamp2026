using System.ComponentModel.DataAnnotations;

namespace FourthGroup_1.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }=string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }
    }
}
