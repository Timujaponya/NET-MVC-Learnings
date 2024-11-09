using System.ComponentModel.DataAnnotations;

namespace AnnouncementApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen isim giriniz")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Lütfen telefon numarası giriniz")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Lütfen email adresi giriniz")]
        [EmailAddress(ErrorMessage = "Lütfen geçerli bir email adresi giriniz")]
        public string? Email { get; set; }
    }
}