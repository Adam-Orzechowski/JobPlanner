using System.ComponentModel.DataAnnotations;

namespace JobPlanner.Models
{
    public class Location
    {
        [Key]
        public  Guid Id { get; set; }

        [Required]
        [Display(Name = "Location Name")]
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Location Address")]
        [MinLength(10)]
        [MaxLength(100)]
        public string Address { get; set; } = string.Empty;

        [Display(Name = "Location Description")]
        [MinLength(10)]
        [MaxLength(500)]
        public string? Description { get; set; } = string.Empty;

        [Display(Name = "Location Image")]
        public byte[]? Image { get; set; }

        public ICollection<UserLocation> UserLocations { get; set; } = new List<UserLocation>();
    }
}
