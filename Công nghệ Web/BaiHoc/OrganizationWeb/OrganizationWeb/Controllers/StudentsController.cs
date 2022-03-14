using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrganizationWeb.Models;

namespace OrganizationWeb.Controllers
{
    public class StudentsController : Controller
    {
        List<Student> students = new List<Student>
        {
            new Student{ studentID = 1, studentName = "Thịnh", age = 20},
            new Student{ studentID = 2, studentName = "Thư", age = 20},
            new Student{ studentID = 3, studentName = "Trường", age = 20},
            new Student{ studentID = 4, studentName = "Giang", age = 20},
            new Student{ studentID = 5, studentName = "Việt", age = 20}
        };
        // GET: Students
        public ActionResult Index()
        {
            //ViewBag.TotalStudents = students.Count();
            ViewData["students"] = students;
            return View();
        }
    }
}