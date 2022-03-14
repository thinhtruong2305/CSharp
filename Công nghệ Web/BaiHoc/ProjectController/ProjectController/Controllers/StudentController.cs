using ProjectController.Models;
using System.Web.Mvc;

namespace ProjectController.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection f)
        {
            Student student = new Student();
            student.studentID = int.Parse(f["txtID"].ToString());
            student.firstName = f.Get("txtFName").ToString();
            student.lastName = f.Get("txtLName").ToString();
            return View(student);
        }
    }
}