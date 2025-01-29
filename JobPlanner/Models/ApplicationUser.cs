using Microsoft.AspNetCore.Identity;

namespace JobPlanner.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public byte[]? Image { get; set; }
    }
}
