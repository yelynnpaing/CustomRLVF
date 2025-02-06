using Microsoft.AspNetCore.Identity;

namespace AspDotNetCoreWebAppMVCCustomRLVF.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }    
    }
}
