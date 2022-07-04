using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CandyBug.Models;
using PagedList;
namespace CandyBug.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        CandybugOnlineEntities db = new CandybugOnlineEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ShopePage(int? page)
        {
            ViewBag.ActivePro = "active";
            var list = db.Products.Select(c => c);

            //Tạo biến số trang
            int pageSize = 12;
            int pageNumber = (page ?? 1);
            return View(list.OrderBy(u => u.Id).ToPagedList(pageNumber, pageSize));
        }
        [HttpGet]
        public ActionResult SingleProduct(int Id=0)
        {
            Product product;
            ViewBag.ActiveSingle = "active";
            if (Id != 0)
            {
                product = db.Products.SingleOrDefault(c => c.Id == Id);
                product.Views++;
                db.SaveChanges();
                ViewBag.ListRelated = db.Products.Where(c => c.Category.Name == product.Category.Name).ToList();
                return View(product);
            }
            else
            {
                product = db.Products.Select(c => c).First();
                ViewBag.ListRelated = db.Products.Where(c => c.Category.Name == product.Category.Name).ToList();
                return View(product);
            }
        }
        [ChildActionOnly]
        public ActionResult _ProductPartial()
        {

            return PartialView();
        }
        [ChildActionOnly]
        public ActionResult _TopProductPartial()
        {

            return PartialView();
        }
        [ChildActionOnly]
        [HttpGet]
        public ActionResult _SearchProductPartial()
        {
            var list = db.Products.Select(c => c).Take(4);
            return PartialView(list);
        }
        public ActionResult _SearchPartial(FormCollection f)
        {
            string key = f["KeySearch"];
            var list = db.Products.Where(c => c.Name.Contains(key)).Take(4);
            return PartialView(list);
        }

        public ActionResult _RecentPostPartial()
        {
            var list = db.Products.OrderByDescending(c => c.DateCreate).Take(5);
            return PartialView(list);
        }
    }
}