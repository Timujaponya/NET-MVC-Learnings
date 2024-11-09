using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class CourseController : Controller
{
    public IActionResult Index()
    {
        var course = new Course{ Id = 1, Title = "C#", Description = "C# Kursu", Duration = 30, Image = "1.jpg" }; // Course modelini burada oluşturun veya veritabanından alın
        return View(course);
    }

    public IActionResult Details(int? id)
    {
        if (id == null)
        {
            return RedirectToAction("List","Course");
        }
        var course = Repository.GetById(id);

        return View(course);
    }
    public IActionResult List()
    {
        return View("CourseList", Repository.Courses);
    }
}