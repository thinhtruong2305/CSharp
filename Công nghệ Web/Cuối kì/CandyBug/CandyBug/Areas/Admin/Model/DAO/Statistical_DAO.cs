using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CandyBug.Models;
using CandyBug.Areas.Admin.Model.EF;

namespace CandyBug.Areas.Admin.Model.DAO
{
    public class Statistical_DAO
    {
        CandybugOnlineEntities DBCandyBug = new CandybugOnlineEntities();

        /// <summary>
        /// Lấy danh sách thống kê theo trạng thái Giao hàng thành công
        /// </summary>
        /// <returns>Danh sách dùng để thống kê kiểu List<Statistical></returns>
        public List<Statistical> getDanhSachThongKe()
        {
            var danhSach = (from u in DBCandyBug.Oders
                            where u.Status.Equals("GIAO HÀNG THÀNH CÔNG")
                            select new Statistical
                            {
                                maHoaDon = u.Id,
                                ngayTao = u.DateCreate,
                                tongTien = u.OrderInfoes.Select(c => c.Total).Sum(),
                                trangThai = u.Status,
                            }).ToList();
            return danhSach;
        }

        /// <summary>
        /// Lấy danh sách thống kê theo trạng thái Giao hàng thành công và được lọc theo ngày
        /// </summary>
        /// <param name="fromDate">Mốc bắt đầu lọc</param>
        /// <param name="toDate">Mốc kết thúc lọc</param>
        /// <returns>Danh sách thống kê List<Statistical></returns>
        public List<Statistical> getDanhSachThongKeByDate(DateTime fromDate, DateTime toDate)
        {
            var danhSach = (from u in DBCandyBug.Oders
                            where u.DateCreate >= fromDate && u.DateCreate <= toDate
                            where u.Status.Equals("GIAO HÀNG THÀNH CÔNG")
                            select new Statistical
                            {
                                maHoaDon = u.Id,
                                ngayTao = u.DateCreate,
                                tongTien = u.OrderInfoes.Select(c => c.Total).Sum(),
                                trangThai = u.Status,
                            }).ToList();
            return danhSach;
        }

        /// <summary>
        /// lấy danh sách hóa đơn gồm mã hóa đơn, tên sản phẩm, giá, số lượng, tổng tiền
        /// </summary>
        /// <param name="idOrder">maHoaDon</param>
        /// <returns>danh sách hóa đơn gồm mã hóa đơn, tên sản phẩm, giá, số lượng, tổng tiền. Kiểu List<HoaDon></returns>
        public List<HoaDon> getThongTinHoaDon(int idOrder)
        {
            var danhSach = (from u in DBCandyBug.OrderInfoes
                            where u.IdOrder == idOrder
                            select new HoaDon
                            {
                                maHoaDon = u.IdOrder,
                                tenSanPham = u.Product.Name,
                                gia = u.Product.Price,
                                soLuong = u.Quantity,
                                tongTien = u.Total
                            }).ToList();
            return danhSach;
        }
    }
}