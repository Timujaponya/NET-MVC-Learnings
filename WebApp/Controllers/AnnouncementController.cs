using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
namespace WebApp.Controllers
{
    public class AnnouncementController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Announcement> announcements = Repository.Announcements;
            return View(announcements);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Announcement announcement)
        {
            if (ModelState.IsValid)
            {
                Repository.AddAnnouncement(announcement);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model: announcement);
            }
        }
        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Announcement announcement)
        {
            Repository.UpdateAnnouncement(announcement);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            Repository.DeleteAnnouncement(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Search()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult List()
        {
            return View();
        }
    }
}