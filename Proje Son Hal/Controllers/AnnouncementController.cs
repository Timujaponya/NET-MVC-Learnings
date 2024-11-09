using Microsoft.AspNetCore.Mvc;
using AnnouncementApp.Models;

namespace AnnouncementApp.Controllers
{
    public class AnnouncementController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.Announcements);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Announcement announcement)
        {
            if (ModelState.IsValid)
            {
                announcement.Date = DateTime.Now;
                // Sorumlu kişinin bilgilerini kaydet
                var user = Repository.GetUserByEmail(announcement.User.Email);
                if (user == null)
                {
                    user = new UserInfo
                    {
                        Name = announcement.User.Name,
                        Phone = announcement.User.Phone,
                        Email = announcement.User.Email
                    };
                    Repository.Users.Add(user);
                }
                announcement.User = user;
                Repository.AddAnnouncement(announcement);
                return RedirectToAction("Index");
            }
            return View(announcement);
        }

        public IActionResult Details(int id)
        {
            var announcement = Repository.GetAnnouncement(id);
            if (announcement == null)
            {
                return NotFound();
            }
            return View(announcement);
        }
    }
}