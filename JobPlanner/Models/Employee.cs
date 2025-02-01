using System.ComponentModel.DataAnnotations;

namespace JobPlanner.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        [Required]
        [Display(Name = "Employee First Name")]
        [MinLength(1)]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Employee LAst Name")]
        [MinLength(3)]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Phone number")]
        [RegularExpression(@"(?:\+48\s?)?(?:[5-9]\d{2}\s?\d{3}\s?\d{3}|\d{2}\s?\d{3}\s?\d{2}\s?\d{2})",
            ErrorMessage = "Phone number must be in the format +48 501 234 567 or 501 234 567 or 22 345 12 12 or +48 22 345 12 12")]
        public string PhoneNumber { get; set; }
        
        public Guid LocationId { get; set; }
    }
}
