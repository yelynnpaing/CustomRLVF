using System.ComponentModel.DataAnnotations;

namespace AspDotNetCoreWebAppMVCCustomRLVF.ViewModels
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Email is require!")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is require!")]
        [DataType(DataType.Password)]
        [StringLength(40, MinimumLength = 8, ErrorMessage ="The {0} must be at {2} and {1} characters long. ")]
        [Compare("NewConfirmPassword", ErrorMessage ="Password does not match!..." )]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }
        [Required(ErrorMessage = "Confirm New Password is require!")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm New Password")]
        public string NewConfirmPassword { get; set; }
    }
}
