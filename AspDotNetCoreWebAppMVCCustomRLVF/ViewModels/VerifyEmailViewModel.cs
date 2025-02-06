using System.ComponentModel.DataAnnotations;

namespace AspDotNetCoreWebAppMVCCustomRLVF.ViewModels
{
    public class VerifyEmailViewModel
    {
        [Required(ErrorMessage = "Email is rquire!")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
