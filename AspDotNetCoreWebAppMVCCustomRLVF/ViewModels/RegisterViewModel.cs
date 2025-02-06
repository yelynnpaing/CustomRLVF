using System.ComponentModel.DataAnnotations;

namespace AspDotNetCoreWebAppMVCCustomRLVF.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Name is require!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is require!")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is require!")]
        [DataType(DataType.Password)]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "The {0} must be at {2} and max {1} Characters long.")]
        [Compare("ConfirmPassword", ErrorMessage = "Password does not match")]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirm Password is require!")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

    }
}
