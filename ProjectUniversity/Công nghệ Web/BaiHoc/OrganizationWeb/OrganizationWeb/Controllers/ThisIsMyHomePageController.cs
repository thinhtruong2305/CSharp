using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrganizationWeb.Controllers
{
    public class ThisIsMyHomePageController : Controller
    {
        // GET: ThisIsMyHomePage
        public ActionResult Index()
        {
            return View();
        }
    }
}