using AnnouncementApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnnouncementApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            ViewBag.Selamlama = saat > 12 ? "İyi Günler" : "Günaydın";
            ViewBag.TotalAnnouncements = Repository.Announcements.Count;
            ViewBag.CurrentDateTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            return View();
        }
    }
}