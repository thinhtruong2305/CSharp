using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ShopThoiTrang.Models;

namespace ShopThoiTrang.Areas.Admin.Controllers
{
    public class CategoriesController : Controller
    {
        private ShopThoiTrangDBContext db = new ShopThoiTrangDBContext();

        // GET: Admin/Categories
        public ActionResult Index()
        {
            var list = db.Categories.Where(m => m.Status != 0)
                .OrderByDescending(m => m.CreateAt)
                .ToList();
            return View("Index", list);
        }

        public ActionResult Trash()
        {
            var list = db.Categories.Where(m => m.Status == 0)
                .OrderByDescending(m => m.CreateAt)
                .ToList();
            return View("Trash", list);
        }

        //Hiển thị status = 1, Không hiển thị status = 0
        public ActionResult Status(int id)
        {
            Category category = db.Categories.Find(id);
            int status = (category.Status == 1) ? 2 : 1;
            category.Status = status;
            category.UpdateBy = 1;
            category.UpdateAt = DateTime.Now;
            db.Entry(category).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Admin/Categories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // GET: Admin/Categories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Slug,ParentId,Orders,Metakey,Metades,Status")] Category category)
        {
            if (ModelState.IsValid)
            {
                category.CreateBy = 1;
                category.CreateAt = DateTime.Now;
                db.Categories.Add(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(category);
        }

        // GET: Admin/Categories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // POST: Admin/Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Slug,ParentId,Orders,Metakey,Metades,CreateBy,CreateAt,UpdateBy,UpdateAt,Status")] Category category)
        {
            if (ModelState.IsValid)
            {
                db.Entry(category).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        //Xóa vào thùng rác status = 0
        public ActionResult DelTrash(int id)
        {
            Category category = db.Categories.Find(id);
            int status = 0;
            category.Status = status;
            category.UpdateBy = 1;
            category.UpdateAt = DateTime.Now;
            db.Entry(category).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index", "Categories");
        }

        //Retrash status = 2
        public ActionResult ReTrash(int id)
        {
            Category category = db.Categories.Find(id);
            int status = 2;
            category.Status = status;
            category.UpdateBy = 1;
            category.UpdateAt = DateTime.Now;
            db.Entry(category).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Trash", "Categories");
        }

        // GET: Admin/Categories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // POST: Admin/Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Category category = db.Categories.Find(id);
            db.Categories.Remove(category);
            db.SaveChanges();
            return RedirectToAction("Trash", "Categories");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
