using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CandyBug.Models;
using CaptchaMvc;
using CaptchaMvc.HtmlHelpers;

namespace CandyBug.Controllers
{
    public class HomeController : Controller
    {
        CandybugOnlineEntities db = new CandybugOnlineEntities();
        public ActionResult Index()
        {
            ViewBag.Active = "active";
            //Danh sách các sản phẩm sell
            ViewBag.Listlast = db.Products.Where(c => c.Discount != 0);
            //Danh sách các Nhà sản xuất
            ViewBag.Listbrand = db.Producers.Select(c=>c);
            //Danh sách các sản phẩm mới nhất
            ViewBag.Listnew = (from c in db.Products orderby c.DateCreate descending select c);
            //Danh sách các sản phẩm xem nhiều nhất
            ViewBag.Listview = (from c in db.Products orderby c.Views descending select c);
            //Danh sách các sản phẩm bán chạy nhất
            ViewBag.Listtopsell = (from c in db.Products 
                                   orderby c.OrderInfoes.Sum(u=>u.Quantity) descending
                                   select c );
            //Set Route đến vùng Admin
            /*return View("~/Areas/Admin/Views/Home/Index.cshtml");*/
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            if (Request.Cookies["Username"] != null && Request.Cookies["Password"] != null)
            {
                ViewBag.Username = Request.Cookies["Username"].Value;
                ViewBag.Password = Request.Cookies["Password"].Value;
                ViewBag.Check = "checked";
            }
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection f)
        {
            string userName = Convert.ToString(f["Username"]);
            string password = Convert.ToString(f["Password"]);

            Account account = db.Accounts.SingleOrDefault(c => c.UserName == userName && c.PassWord == password);
            if (account != null)
            { 
                bool checkBox = Convert.ToBoolean(Request.Form["CheckRemember"]);
                if (checkBox == true)
                {
                    Response.Cookies["Username"].Value = account.UserName;
                    Response.Cookies["Password"].Value = account.PassWord;
                    Response.Cookies["Username"].Expires = DateTime.Now.AddDays(1);
                    Response.Cookies["Password"].Expires = DateTime.Now.AddDays(1);
                }
                else
                {
                    Response.Cookies["Username"].Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies["Password"].Expires = DateTime.Now.AddDays(-1);
                }
               
                if (account.Role == 1)
                {
                    Session["Account"] = account;
                    return RedirectToAction("Index", "Home", new { Area = "Admin"});
                }

                Session["Account"] = account;
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Message = "Sai tên đăng nhập hoặc mật khẩu !!";
            return View();

        }

        public ActionResult Logout()
        {
            Session["Account"] = null;
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public ActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Register(Account account, FormCollection f)
        {
            if (this.IsCaptchaValid("Captcha is not valid"))
            {
                if (ModelState.IsValid)
                {
                    if (db.Accounts.SingleOrDefault(c => c.UserName == account.UserName) == null)
                    {
                        if (Convert.ToString(f["PassWordAgain"]) == account.PassWord)
                        {
                            ViewBag.Success = "Đăng kí tài khoản thành công";
                            db.Accounts.Add(account);
                            db.SaveChanges();
                        }
                        else
                        {
                            ViewBag.PassWordAgain = "Mật khẩu không khớp";
                        }
                    }
                    else
                    {
                        ViewBag.TaiKhoanExits = "Tên tài khoản đã được sử dụng !";
                    }
                }
                return View();
            }
            ViewBag.Message = "Sai mã captcha !!";
            return View();
        }
    }
}