using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CandyBug.Models;
using CandyBug.Areas.Admin.Model.DAO;

namespace CandyBug.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        DoanhThu_DAO doanhThu = new DoanhThu_DAO();

        // GET: Admin/Home
        public ActionResult Index()
        {
            ViewBag.Nam = doanhThu.getYear();
            return View();
        }

        [HttpGet]
        public ActionResult GetReportByYear(int year)
        {
            var lsData = doanhThu.getDoanhThuByYear(year);
            return Json(lsData, JsonRequestBehavior.AllowGet);
        }
    }
}