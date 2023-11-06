using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CandyBug.Models;
using PagedList;
namespace CandyBug.Controllers
{
    public class CategoryController : Controller
    {
        CandybugOnlineEntities db = new CandybugOnlineEntities();
        // GET: Category
        public ActionResult Index(string category,int? page)
        {
            ViewBag.ActiveCate = "active";
            int pageSize = 12;
            int pageNumber = (page ?? 1);
            if (category != null)
            {
                 var list = db.Products.Where(c => c.Category.Name == category);
                return View(list.OrderBy(u => u.Id).ToPagedList(pageNumber, pageSize));
            }
            else
            {
                var list = db.Products.Where(c => c.Category.Name == "Candy");
                return View(list.OrderBy(u=>u.Id).ToPagedList(pageNumber,pageSize));
            }
        }
    }
}