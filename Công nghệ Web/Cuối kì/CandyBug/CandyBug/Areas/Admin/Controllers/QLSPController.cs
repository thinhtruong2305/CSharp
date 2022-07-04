using CandyBug.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;
using System.IO;

namespace CandyBug.Areas.Admin.Controllers
{
    public class QLSPController : Controller
    {
        // GET: Admin/QLSP
        CandybugOnlineEntities db = new CandybugOnlineEntities();
        public ActionResult Index(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 10;
            return View(db.Products.ToList().OrderBy(n => n.Id).ToPagedList(pageNumber, pageSize));

        }

        //thêm mới
        [HttpGet]
        public ActionResult ThemMoi()
        {
            //đưa dữ liệu vào dropdown list
            ViewBag.IdCategory = new SelectList(db.Categories.ToList().OrderBy(n => n.Name), "Id", "Name");
            ViewBag.IdProducer = new SelectList(db.Producers.ToList().OrderBy(n => n.Name), "Id", "Name");
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ThemMoi(Product product, HttpPostedFileBase fileUpload)
        {


            //đưa dữ liệu vào dropdown list
            ViewBag.IdCategory = new SelectList(db.Categories.ToList().OrderBy(n => n.Name), "Id", "Name");
            ViewBag.IdProducer = new SelectList(db.Producers.ToList().OrderBy(n => n.Name), "Id", "Name");
            //Kiểm tra đường dẫn ảnh 
            if (fileUpload == null)
            {
                ViewBag.ThongBao = "Chọn hình ảnh";
                return View();
            }
            //thêm vào csdl
            if (ModelState.IsValid)
            {
                //Lưu tên của file
                var fileName = Path.GetFileName(fileUpload.FileName);
                //lưu đường dẫn của file
                var path = Path.Combine(Server.MapPath("~/Content/Client/img"), fileName);
                //kiểm tra hình ảnh có tồn tại chưa
                if (System.IO.File.Exists(path))
                {
                    ViewBag.ThongBao = "Hình ảnh đã tồn tại";
                }
                else
                {
                    fileUpload.SaveAs(path);
                }
                product.Image = fileUpload.FileName;
                db.Products.Add(product);
                db.SaveChanges();
            }

            /* return View();*/
            return RedirectToAction("Index");
        }
        //Chỉnh sửa sp
        [HttpGet]
        public ActionResult ChinhSua(int Id)
        {
            //lấy ra đối tượng sách theo mã
            Product product = db.Products.SingleOrDefault(n => n.Id == Id);
            if (product == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            //đưa dữ liệu vào dropdown list
            ViewBag.IdCategory = new SelectList(db.Categories.ToList().OrderBy(n => n.Name), "Id", "Name");
            ViewBag.IdProducer = new SelectList(db.Producers.ToList().OrderBy(n => n.Name), "Id", "Name");
            return View(product);

        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ChinhSua(Product product, HttpPostedFileBase fileUpload)
        {
            /*if (fileUpload == null)
            {
                ViewBag.ThongBao = "Chọn hình ảnh";
                return View();
            }*/

            if (ModelState.IsValid)
            {
                //Lưu tên của file
                var fileName = Path.GetFileName(fileUpload.FileName);
                //lưu đường dẫn của file
                var path = Path.Combine(Server.MapPath("~/Content/Client/img"), fileName);
                //kiểm tra hình ảnh có tồn tại chưa
                if (System.IO.File.Exists(path))
                {
                    ViewBag.ThongBao = "Hình ảnh đã tồn tại";
                }
                else
                {
                    fileUpload.SaveAs(path);
                }
                product.Image = fileUpload.FileName;
                //thực hiện cập nhật trong model
                db.Entry(product).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            //đưa dữ liệu vào dropdown list
            ViewBag.IdCategory = new SelectList(db.Categories.ToList().OrderBy(n => n.Name), "Id", "Name");
            ViewBag.IdProducer = new SelectList(db.Producers.ToList().OrderBy(n => n.Name), "Id", "Name");
            return RedirectToAction("Index");
        }
        //hiển thị sp
        public ActionResult HienThi(int Id)
        {
            //lấy ra đối tượng sách theo mã
            Product product = db.Products.SingleOrDefault(n => n.Id == Id);
            if (product == null)
            {
                Response.StatusCode = 404;
                return null;
            }


            return View(product);
        }
        //xóa sp
        [HttpGet]
        public ActionResult Xoa(int Id)
        {
            //lấy ra đối tượng sách theo mã
            Product product = db.Products.SingleOrDefault(n => n.Id == Id);
            if (product == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(product);
        }
        [HttpPost, ActionName("Xoa")]
        public ActionResult XacNhanXoa(int Id)
        {
            Product product = db.Products.SingleOrDefault(n => n.Id == Id);


            if (product == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            IEnumerable<OrderInfo> orderInfos = db.OrderInfoes.Where(c => c.IdProduct == product.Id).ToList();
            List<Oder> oders = new List<Oder>();
            foreach (OrderInfo item in orderInfos)
            {
                Oder oder = db.Oders.SingleOrDefault(c => c.Id == item.IdOrder);
                if (oders.SingleOrDefault(c=>c.Id==oder.Id)==null)
                {
                    oders.Add(oder);
                }
                db.OrderInfoes.Remove(item);
                db.SaveChanges();
            }
            IEnumerable<Oder> oders1 = oders;
            foreach (Oder item in oders1)
            {
                db.Oders.Remove(item);
                db.SaveChanges();
            }
            db.Products.Remove(product);

            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
