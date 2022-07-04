using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Mvc;
using CandyBug.Areas.Admin.Model.DAO;
using CandyBug.Areas.Admin.Model.EF;
using CandyBug.Models;
using System.Web.Routing;

namespace CandyBug.Areas.Admin.Controllers
{
    public class StatisticalController : Controller
    {
        private Statistical_DAO statistical = new Statistical_DAO();
        private CandybugOnlineEntities DBCandyBug = new CandybugOnlineEntities();

        // GET: Admin/Statistical
        public ActionResult Index()
        {
            return View(statistical.getDanhSachThongKe());
        }

        [HttpGet, ActionName("Detail")]
        //Hiển thị thông tin chi tiết về hóa đơn
        public ActionResult Detail(int? id)
        {
            if(id.Equals(null))
            {
                return View("Index", statistical.getDanhSachThongKe());
            }
            else
            {
                var hoaDon = DBCandyBug.Oders.Find(id);
                ViewBag.HoaDon = new Statistical
                {
                    maHoaDon = hoaDon.Id,
                    ngayTao = hoaDon.DateCreate,
                    trangThai = hoaDon.Status
                };
                return View(statistical.getThongTinHoaDon(id.Value));
            }
        }

        //Hiển thị View Lọc theo ngày
        public ActionResult LocTheoNgay()
        {
            return View();
        }

        //Nhận giá trị từ view và xử lí lọc
        [HttpPost]
        public ActionResult LocTheoNgay(DateTime? fromDate, DateTime? toDate)
        {
            List<Statistical> danhSach;
            if (fromDate == null || toDate.Equals(null))
            {
                ViewBag.ThongBaoLoiDuLieuDauVao = "Vui lòng chọn lại ngày!";
                return View();
            }
            if (fromDate > toDate)
            {
                ViewBag.ThongBaoLoiDuLieuDauVao = "Vui lòng chọn lại ngày!";
                return View();
            }
            if ((!fromDate.Equals(null) && !toDate.Equals(null)) && !(fromDate > toDate))
            {
                danhSach = statistical.getDanhSachThongKeByDate(fromDate.Value, toDate.Value);
                return View("ThongKeByDate", danhSach);
            }
            return View();
        }

        //Hiển thị danh sách đã được lọc theo ngày
        [ActionName("ThongKeByDate")]
        public ActionResult ThongKeByDate(List<Statistical> danhSach)
        {
            return View(danhSach);
        }
    }
}