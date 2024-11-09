using System.ComponentModel.DataAnnotations;

namespace AnnouncementApp.Models
{
    public class Announcement
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen başlık giriniz.")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Lütfen içerik giriniz.")]
        public string? Content { get; set; }
        public DateTime Date { get; set; }
        public UserInfo? User { get; set; } = new UserInfo();
    }
}