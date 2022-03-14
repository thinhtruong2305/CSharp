using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectController.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Account(FormCollection formCollection, String hoTen)
        {
            String account = formCollection.Get("txtAccount");
            String password = formCollection.Get("txtPassWord");
            if (!account.Equals("Trương Văn Tiến Thịnh") && !password.Equals("123"))
                return null;
            ViewBag.account = account;
            ViewBag.hoTen = hoTen;
            return View();
        }
    }
}