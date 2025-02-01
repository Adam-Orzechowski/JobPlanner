using System.ComponentModel.DataAnnotations;

namespace JobPlanner.Models
{
    public class UserLocation
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        [Required]
        public Guid LocationId { get; set; }

        public Location Location { get; set; }
    }
}
