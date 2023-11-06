 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrganizationWeb.Models;

namespace OrganizationWeb.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            List<Products> products = new List<Products>()
            {
                new Products{ productID = 1, name = "Products 1", category = "Category 1", decription = "Dễ vỡ", price = 10000},
                new Products{ productID = 1, name = "Products 2", category = "Category 1", decription = "Nhựa tổng hợp", price = 13000},
                new Products{ productID = 1, name = "Products 3", category = "Category 3", decription = "Dễ vỡ", price = 10000},
                new Products{ productID = 1, name = "Products 4", category = "Category 2", decription = "Cần chuyển", price = 50000},
                new Products{ productID = 1, name = "Products 5", category = "Category 1", decription = "Điện tử", price = 100000},
                new Products{ productID = 1, name = "Products 6", category = "Category 2", decription = "Dễ vỡ", price = 10000}
            };
            return View(products);
        }
    }
}