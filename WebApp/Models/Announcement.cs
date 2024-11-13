using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Announcement
    {
        [Required]
        public int Id { get; set; } // Id özelliği doğru tanımlanmış olmalı

        [Required (ErrorMessage = "Duyur başlığını giriniz.")]
        [StringLength(100)]
        public string? Title { get; set; }

        [Required (ErrorMessage = "Duyuru içeriğini giriniz.")]
        public string? Content { get; set; }
        public DateTime Date { get; set; }
    }
}