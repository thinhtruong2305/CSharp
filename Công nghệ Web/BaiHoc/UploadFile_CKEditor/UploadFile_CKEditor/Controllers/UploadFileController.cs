using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace UploadFile_CKEditor.Controllers
{
    public class UploadFileController : Controller
    {
        // GET: UploadFile
        [HttpGet]
        public ActionResult UploadFile()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase file)
        {
            try
            {
                if(file.ContentLength > 0)
                {
                    String fileName = Path.GetFileName(file.FileName.Trim());
                    String path = Path.Combine(Server.MapPath("~/UploadFiles"), fileName);
                    file.SaveAs(path);
                }
                ViewBag.Message = "File Upload Success";
                return View();
            }
            catch
            {
                ViewBag.Message = "File Upload Failed";
                return View();
            }
        }
    }
}