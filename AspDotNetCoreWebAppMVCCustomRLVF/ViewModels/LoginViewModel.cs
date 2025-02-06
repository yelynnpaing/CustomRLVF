using System.ComponentModel.DataAnnotations;

namespace AspDotNetCoreWebAppMVCCustomRLVF.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email is require!")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is require!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
