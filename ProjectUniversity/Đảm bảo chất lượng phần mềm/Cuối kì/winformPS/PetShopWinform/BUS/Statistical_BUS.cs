using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShopWinform.DAO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PetShopWinform.BUS
{
    class Statistical_BUS
    {
        private Statistical_DAO statistical_DAO;

        public Statistical_BUS() { statistical_DAO = new Statistical_DAO(); }

        #region Sử dụng trên Form Statistical
        /// <summary>
        /// Lấy và truyền danh sách vào DataGridView
        /// </summary>
        /// <param name="bangHienThi">bảng hiển thị thông tin hóa đơn</param>
        public void truyenThongTinHoaDon(DataGridView bangHienThi)
        {
            bangHienThi.DataSource = null;
            bangHienThi.DataSource = statistical_DAO.layDanhSachHoaDon();
        }

        /// <summary>
        /// Lấy và truyền danh sách đã lọc theo ngày vào DataGridView
        /// </summary>
        /// <param name="bangHienThi">bảng hiển thị danh sách hóa đơn</param>
        /// <param name="ngayBatDau">Mốc bắt đầu để lọc</param>
        /// <param name="ngayKetThuc">Mốc kết thúc để lọc</param>
        public void truyenThongTinHoaDonTheoNgay(DataGridView bangHienThi, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            bangHienThi.DataSource = statistical_DAO.locDanhSachHoaDonTheoNgay(ngayBatDau, ngayKetThuc);
        }

        /// <summary>
        /// Lấy và truyền danh sách đã tìm vào DataGridView
        /// </summary>
        /// <param name="bangHienThi">Bảng hiển thị thông tin hóa đơn</param>
        /// <param name="tuKhoa">Dùng để tìm kiếm theo kiểu String đối chiếu với tên khách hàng</param>
        /// <returns>boolean để xác nhận tìm thấy hoặc không tìm thấy</returns>
        public bool truyenThongTinHoaDonTheoTen(DataGridView bangHienThi, String tuKhoa)
        {
            var danhSach = statistical_DAO.timKiemDanhSachHoaDonTheoTenKhachHang(tuKhoa);
            if(danhSach != null)
            {
                bangHienThi.DataSource = statistical_DAO.timKiemDanhSachHoaDonTheoTenKhachHang(tuKhoa);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Lấy và truyền danh sách đã tìm vào DataGridView
        /// </summary>
        /// <param name="bangHienThi">Bảng hiển thị thông tin hóa đơn</param>
        /// <param name="tuKhoa">Dùng để tìm kiếm theo kiểu int đối chiếu với mã hóa đơn</param>
        /// <returns>boolean để xác nhận tìm thấy hoặc không tìm thấy</returns>
        public bool truyenThongTinHoaDonTheoMaHoaDon(DataGridView bangHienThi, int tuKhoa)
        {
            var danhSach = statistical_DAO.timKiemDanhSachHoaDonTheoMaHoaDon(tuKhoa);
            if (danhSach != null)
            {
                bangHienThi.DataSource = statistical_DAO.timKiemDanhSachHoaDonTheoMaHoaDon(tuKhoa);
                return true;
            }
            return false;
        }
        #endregion

        #region Sử dụng trên Form Statistical_Info
        /// <summary>
        /// Lấy và truyền các thông tin khách hàng vào các TextBox
        /// </summary>
        /// <param name="txtMaKhachHang">Truyền thông tin và TextBox phụ trách hiển thị mã khách hàng</param>
        /// <param name="txtName">Truyền thông tin và TextBox phụ trách hiển thị tên khách hàng</param>
        /// <param name="txtAddress">Truyền thông tin và TextBox phụ trách hiển thị địa chỉ khách hàng</param>
        /// <param name="txtPhone">Truyền thông tin và TextBox phụ trách hiển thị số điện thoại khách hàng</param>
        /// <param name="ckbVIP">Truyền thông tin và CheckBox phụ trách hiển thị VIP (có thể được giảm giá)</param>
        /// <param name="maKhachHang">Dùng để tìm kiếm theo kiểu int đối chiếu với mã khách hàng</param>
        public void truyenThongTinKhachHangTheoMaKhachHang(TextBox txtMaKhachHang, TextBox txtName, TextBox txtAddress, TextBox txtPhone, CheckBox ckbVIP,int maKhachHang)
        {
            if (!maKhachHang.Equals(0))
            {
                var khachHang = statistical_DAO.timKiemThongTinKhachHangTheoMa(maKhachHang);
                txtMaKhachHang.Text = khachHang.Id.ToString();
                txtName.Text = khachHang.Name;
                txtAddress.Text = khachHang.Address;
                txtPhone.Text = khachHang.Phone;
                ckbVIP.Checked = khachHang.Vip.Value;
            }
        }

        /// <summary>
        /// Lấy và truyền các thông tin một hoặc nhiều sản phẩm của một hóa đơn
        /// </summary>
        /// <param name="bangHienThi">Bảng hiển thị thông sản phẩm</param>
        /// <param name="maHoaDon">Dùng để tìm kiếm theo kiểu int đối chiếu với mã hóa đơn</param>
        public void truyenThongTinSanPhamTheoMaHoaDon(DataGridView bangHienThi, int maHoaDon)
        {
            bangHienThi.DataSource = statistical_DAO.timDanhSachSanPhamThemMaHoaDon(maHoaDon);
        }
        #endregion

        #region Sử dụng trên Form ChartDoanhThu
        /// <summary>
        /// Truyền thông tin và0 biểu đồ dựa trên ngày bắt đầu và ngày kết thúc
        /// </summary>
        /// <param name="chartDoanhThu">Biểu đồ thể hiện doanh thu</param>
        /// <param name="ngayBatDau">Mốc bắt đầu lọc</param>
        /// <param name="ngayKetThuc">Mốc kết thúc lọc</param>
        public void truyenThongTinDoanhThuTheoNgay(Chart chartDoanhThu, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            chartDoanhThu.DataSource = statistical_DAO.layDanhSachDoanhThuTheoNgay(ngayBatDau, ngayKetThuc);
            chartDoanhThu.Series["DoanhThu"].XValueMember = "Date";
            chartDoanhThu.Series["DoanhThu"].XValueType = ChartValueType.Int32;
            chartDoanhThu.Series["DoanhThu"].YValueMembers = "DoanhThu";
            chartDoanhThu.Series["DoanhThu"].YValueType = ChartValueType.Int32;
        }

        /// <summary>
        /// Truyền thông tin vào biểu đồ dựa trên ngày bắt đầu và ngày kết thúc
        /// </summary>
        /// <param name="chartDoanhThu">Biểu đồ hiển thị doanh thu</param>
        /// <param name="ngayBatDau">Mốc bắt đầu để lọc</param>
        /// <param name="ngayKetThuc">Mốc kết thúc để lọc</param>
        public void truyenThongtinDoanhThuTheoThang(Chart chartDoanhThu, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            chartDoanhThu.DataSource = statistical_DAO.layDanhSachDoanhThuTheoThang(ngayBatDau, ngayKetThuc);
            chartDoanhThu.Series["DoanhThu"].XValueMember = "Month";
            chartDoanhThu.Series["DoanhThu"].XValueType = ChartValueType.Int32;
            chartDoanhThu.Series["DoanhThu"].YValueMembers = "DoanhThu";
            chartDoanhThu.Series["DoanhThu"].YValueType = ChartValueType.Int32;
        }

        /// <summary>
        /// Truyền thông tin vào biểu đồ dựa trên ngày bắt đầu và ngày kết thúc
        /// </summary>
        /// <param name="chartDoanhThu">Biểu đô hiển thị doanh thu</param>
        /// <param name="ngayBatDau">Mốc bắt đầu để lọc</param>
        /// <param name="ngayKetThuc">Mốc kết thúc để lọc</param>
        public void truyenThongTinDoanhThuTheoNam(Chart chartDoanhThu, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            chartDoanhThu.DataSource = statistical_DAO.layDanhSachDoanhThuTheoNam(ngayBatDau, ngayKetThuc);
            chartDoanhThu.Series["DoanhThu"].XValueMember = "Year";
            chartDoanhThu.Series["DoanhThu"].XValueType = ChartValueType.Int32;
            chartDoanhThu.Series["DoanhThu"].YValueMembers = "DoanhThu";
            chartDoanhThu.Series["DoanhThu"].YValueType = ChartValueType.Int32;
        }
        #endregion
    }
}
