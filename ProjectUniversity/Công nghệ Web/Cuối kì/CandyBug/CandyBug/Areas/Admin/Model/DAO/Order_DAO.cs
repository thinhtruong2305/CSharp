using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CandyBug.Areas.Admin.Model.EF;
using CandyBug.Models;

namespace CandyBug.Areas.Admin.Model.DAO
{
    public class Order_DAO
    {
        private CandybugOnlineEntities DBCandyBug = new CandybugOnlineEntities();

        /// <summary>
        /// Lấy danh sách đơn hàng từ database
        /// </summary>
        /// <returns>danh sách đơn hàng kiểu List<DonHang></returns>
        public List<DonHang> getDanhSachDonHang()
        {
            var danhSach = (from u in DBCandyBug.Oders
                            select new DonHang
                            {
                                maHoaDon = u.Id,
                                ngayTao = u.DateCreate.Value,
                                diaChi = u.Address,
                                ngayGiao = u.DeliveryDate,
                                trangThai = u.Status,
                                soDienThoai = u.SDT,
                                tenNhanVien = u.Account.DisplayName
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

        /// <summary>
        /// Tìm đơn hàng theo mã và xóa đơn hàng đó nhưng trước khi xóa thì cần tìm hóa đơn theo mã đơn hàng xóa trước để tránh lỗi
        /// </summary>
        /// <param name="maDonHang">Dùng để đối chiếu với các khóa trong table Oder và OrderInfo</param>
        public void xoaDonHang(int maDonHang)
        {
            var order = DBCandyBug.Oders.Where(h => h.Id == maDonHang);
            var orderInfo = DBCandyBug.OrderInfoes.Where(h => h.IdOrder == maDonHang);
            DBCandyBug.OrderInfoes.RemoveRange(orderInfo);
            DBCandyBug.Oders.RemoveRange(order);
            DBCandyBug.SaveChanges();
        }

        /// <summary>
        /// Để gán các giá trị đã thay đổi vào database
        /// </summary>
        /// <param name="donHang">Đơn hàng đã chỉnh sửa</param>
        public void suaThongTinDonHang(DonHang donHang)
        {
            if (!donHang.ngayGiao.Equals(null))
            {
                var orderFind = DBCandyBug.Oders.Find(donHang.maHoaDon);
                orderFind.DeliveryDate = donHang.ngayGiao.Value;
                orderFind.Status = donHang.trangThai;
                DBCandyBug.SaveChanges();
            }
        }

        /// <summary>
        /// Phục vụ cho việc tìm một đơn hàng riêng cho việc hiển thị đơn lẻ
        /// </summary>
        /// <param name="ID">mã đơn hàng</param>
        /// <returns>một đơn hàng</returns>
        public DonHang timDonHang(int ID)
        {
            var donHang = (from u in DBCandyBug.Oders
                            where u.Id == ID
                            select new DonHang
                            {
                                maHoaDon = u.Id,
                                ngayTao = u.DateCreate.Value,
                                trangThai = u.Status,
                                ngayGiao = u.DeliveryDate,
                                diaChi = u.Address,
                                soDienThoai = u.SDT,
                                tenNhanVien = u.Account.DisplayName,
                            }).First();
            return donHang;
        }
    }
}