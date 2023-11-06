using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinQToSQL.Controllers
{
    public class ProductController : Controller
    {
        ProductClassDataContext dataContext = new ProductClassDataContext();
        // GET: Product
        public ActionResult Index()
        {
            var ProductList = from x in dataContext.Products select x;
            return View(ProductList);
        }

        public ActionResult OrderByName()
        {
            var Products = from p in dataContext.Products
                           orderby p.ProductName ascending
                           select p;
            return View(Products);
        }
    }
}