using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CandyBug.Models;
namespace CandyBug.Controllers
{
    public class CartController : Controller
    {
        CandybugOnlineEntities db = new CandybugOnlineEntities();
        public List<ItemCart> getCart()
        {
            List<ItemCart> listItem = Session["ItemCart"] as List<ItemCart>;
            if (listItem == null)
            {
                listItem = new List<ItemCart>();
                Session["ItemCart"] = listItem;
            }
            return listItem;
        }

        public ActionResult AddItem(int Id, string strURL)
        {
            if (Session["Account"] == null)
            {
                return Content("<script>alert('Vui lòng đăng nhập để tiếp tục')</script>");
            }
            Product product = db.Products.SingleOrDefault(c => c.Id == Id);
            if (product == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            List<ItemCart> list = getCart();
            ItemCart productCheck = list.SingleOrDefault(c => c.Id == Id);
            if (productCheck != null)
            {
                if (product.Quantity < productCheck.Quantity)
                {
                    return Redirect(strURL);
                }
                productCheck.Quantity++;
                productCheck.Total = productCheck.Quantity * productCheck.Price;

                return Redirect(strURL);
            }
            ItemCart newItem = new ItemCart(Id);
            if (product.Quantity < newItem.Quantity)
            {
                return Redirect(strURL);
            }

            list.Add(newItem);
            return Redirect(strURL);
        }

        public int CountQuantity()
        {
            List<ItemCart> listCarts = Session["ItemCart"] as List<ItemCart>;
            if (listCarts == null)
            {
                return 0;
            }
            return listCarts.Sum(c => c.Quantity);
        }

        public decimal TotalPrice()
        {
            List<ItemCart> listCarts = Session["ItemCart"] as List<ItemCart>;
            if (listCarts == null)
            {
                return 0;
            }
            return listCarts.Sum(c => c.Total);
        }

        public ActionResult _CartPartial()
        {
            if (CountQuantity() == 0)
            {
                ViewBag.TongSL = 0;
                ViewBag.TongTien = 0;
                return PartialView();
            }
            ViewBag.TongSL = CountQuantity();
            ViewBag.TongTien = TotalPrice();
            return PartialView();
        }
        // GET: Cart
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.ActiveCart = "active";
            List<ItemCart> list = getCart();
            return View(list);
        }
        [HttpPost]
        public ActionResult Index(int[] quantity, int[] Id)
        {

            List<ItemCart> list = getCart();
            int i = 0;
            foreach (var intem in list)
            {
                if (quantity[i] > 0)
                {
                    Product productCheck = db.Products.SingleOrDefault(c => c.Id == intem.Id);
                    if (productCheck.Quantity < quantity[i])
                    {
                        return Content("<script>alert('Sản phẩm hết hàng')</script>");
                    }
                    intem.Quantity = quantity[i];
                    intem.Total = intem.Price * intem.Quantity;
                }
                i++;
            }
            return View(list);
        }

        public ActionResult DeleteItemCart(int Id)
        {
            if (Session["Account"] == null)
            {
                return Content("<script>alert('Vui lòng đăng nhập để tiếp tục')</script>");
            }
            Product product = db.Products.SingleOrDefault(c => c.Id == Id);
            if (product == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            List<ItemCart> list = getCart();
            ItemCart productCheck = list.SingleOrDefault(c => c.Id == Id);
            if (productCheck == null)
            {
                return RedirectToAction("Index", "Home");
            }
            list.Remove(productCheck);
            return RedirectToAction("Index", "Cart");
        }
        [HttpGet]
        public ActionResult Checkout()
        {
            ViewBag.ActiveCheckout = "active";
            List<ItemCart> list = getCart();
            return View(list);
        }
        [HttpPost]
        public ActionResult Checkout(ItemCart item)
        {
            ViewBag.ActiveCheckout = "active";

            return View();
        }

        public ActionResult PlaceOrder(Oder oder, FormCollection f)
        {
            if (Session["Account"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            try
            {
                Account acc = (Account)Session["Account"];
                oder.IdAcc = acc.Id;
                oder.DateCreate = DateTime.Now;
                oder.Status = "CHƯA DUYỆT";
                oder.Address = oder.Address + " " + Convert.ToString(f["City"]);
                db.Oders.Add(oder);
                db.SaveChanges();
                List<ItemCart> list = getCart();
                foreach (var item in list)
                {
                    OrderInfo orderInfo = new OrderInfo();
                    orderInfo.IdOrder = oder.Id;
                    orderInfo.IdProduct = item.Id;
                    orderInfo.Total = item.Total;
                    orderInfo.Quantity = item.Quantity;
                    db.OrderInfoes.Add(orderInfo);
                }
                db.SaveChanges();
                Session["ItemCart"] = null;
            }
            catch (DbEntityValidationException e)
            {
                Console.WriteLine(e);
            }
            return RedirectToAction("MyCart");
        }

        public ActionResult MyCart()
        {
            if (Session["Account"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            Account account = (Account)Session["Account"];
            Session["Account"] = db.Accounts.SingleOrDefault(c=>c.Id==account.Id);
            account = (Account)Session["Account"];
            var list = account.Oders.Select(c=>c);
            return View(list);
        }
    }
}