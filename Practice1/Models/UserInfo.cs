using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Name field is required")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Phone field is required")]
        public string? Phone { get; set; }

        [Required]
        [EmailAddress]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "The e-mail address is not valid")]
        public string? Email { get; set; }

        [Required]
        public bool? WillAttend { get; set; }
    }
}
