using Microsoft.AspNetCore.Identity;

namespace EstateApp.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}