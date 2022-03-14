using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectController.Controllers
{
    public class LinkController : Controller
    {
        // GET: Link
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Hello(String hoTen)
        {
            ViewBag.hoTen = hoTen;
            return View();
        }
    }
}