using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CandyBug.Models;
using CandyBug.Areas.Admin.Model.DAO;
using CandyBug.Areas.Admin.Model.EF;
using System.Net;

namespace CandyBug.Areas.Admin.Controllers
{
    public class OrderManageController : Controller
    {
        private Order_DAO order = new Order_DAO();
        private CandybugOnlineEntities DBCandyBug = new CandybugOnlineEntities();

        // GET: Admin/OrderManage
        //Hiển thị danh sách đơn hàng
        public ActionResult Index()
        {
            return View(order.getDanhSachDonHang());
        }

        //Lấy thông tin chi tiết đơn hàng hoặc hóa đơn vì Order có nhiều nghĩa, thông qua ViewBag
        //Dùng model để hiển thị danh sách sản phẩm của đơn hàng hoặc hóa đơn
        [HttpGet]
        public ActionResult Detail(int? id)
        {
            if(id != null)
            {
                var hoaDon = DBCandyBug.Oders.Find(id);
                ViewBag.HoaDon = new DonHang
                {
                    maHoaDon = hoaDon.Id,
                    ngayTao = hoaDon.DateCreate.Value,
                    trangThai = hoaDon.Status,
                    diaChi = hoaDon.Address,
                    ngayGiao = hoaDon.DeliveryDate,
                    soDienThoai = hoaDon.SDT,
                    tenNhanVien = hoaDon.Account.DisplayName
                };
                return View(order.getThongTinHoaDon(id.Value));
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        //Tìm đơn hàng và hiển thị lên View để chỉnh sửa
        //List trạng thái này phục vụ trong dropdownlist
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id.Equals(null))
            {
                return RedirectToAction("Index");
            }
            else
            {
                List<String> trangThai = new List<string>() {"DUYỆT", "CHƯA DUYỆT", "GIAO HÀNG THÀNH CÔNG" };
                ViewBag.DanhSachTrangThai = trangThai;
                return View(order.timDonHang(id.Value));
            }
        }

        //Sau khi chỉnh sửa thành công thì sẽ gửi thông tin đã chỉnh sửa về đây và lưu lại
        //Các thông tin cần chỉnh sửa: Ngày giao và Trạng thái
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DonHang donHang)
        {
            if (ModelState.IsValid && donHang.ngayGiao.Equals(null))
            {
                ViewBag.ThongBaoNgay = "Vui lòng chọn ngày";
                return View("Edit");
            }
            else
            {
                order.suaThongTinDonHang(donHang);
                return RedirectToAction("Index");
            }
        }

        // GET: Admin/Oders/Delete/5
        //Lấy thông tin chi tiết đơn hàng hoặc hóa đơn vì Order có nhiều nghĩa, thông qua ViewBag
        //Dùng model để hiển thị danh sách sản phẩm của đơn hàng hoặc hóa đơn
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var hoaDon = DBCandyBug.Oders.Find(id.Value);
            ViewBag.HoaDon = new DonHang
            {
                maHoaDon = hoaDon.Id,
                ngayTao = hoaDon.DateCreate.Value,
                trangThai = hoaDon.Status,
                diaChi = hoaDon.Address,
                ngayGiao = hoaDon.DeliveryDate,
                soDienThoai = hoaDon.SDT,
                tenNhanVien = hoaDon.Account.DisplayName
            };
            if (hoaDon == null)
            {
                return HttpNotFound();
            }
            return View(order.getThongTinHoaDon(id.Value));
        }

        //Dùng để xác nhận là bạn chắc chắn muốn xóa đơn hàng hoặc hóa đơn này
        // POST: Admin/Oders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            order.xoaDonHang(id);
            return RedirectToAction("Index");
        }
    }
}