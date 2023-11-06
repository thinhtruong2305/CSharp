using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UploadFile_CKEditor.Controllers
{
    public class CkEditorController : Controller
    {
        // GET: CkEditor
        public ActionResult Index()
        {
            Models.CkEditor ckEditor = new Models.CkEditor();
            return View(ckEditor);
        }
    }
}