using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace JobPlanner.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Display(Name = "User First name")]
        [MinLength(1)]
        [MaxLength(50)]
        public string? FirstName { get; set; }
        [Required]
        [Display(Name = "User Last name")]
        [MinLength(3)]
        [MaxLength(50)]
        public string? LastName { get; set; }

        [Display(Name = "User Image")]
        public byte[]? Image { get; set; }

        public ICollection<UserLocation> UserLocations { get; set; } = new List<UserLocation>();
    }
}
