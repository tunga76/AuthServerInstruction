using Microsoft.AspNetCore.Identity;

namespace AuthServerInstruction.Identity.API.Models
{
    public class AppUser : IdentityUser
    {
        public string? City { get; set; }
    }
}
