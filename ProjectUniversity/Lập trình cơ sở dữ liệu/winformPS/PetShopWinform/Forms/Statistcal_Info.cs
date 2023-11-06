using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShopWinform.Model;
using PetShopWinform.BUS;

namespace PetShopWinform.Forms
{
    public partial class Statistcal_Info : Form
    {
        #region Khai báo biến
        private PetshopWinformEntities DBPetShop;
        private Statistical_BUS busThongKe;
        private int maHoaDon;
        private DateTime ngayTao;
        private int maKhachHang = 0;
        #endregion

        #region Các hàm tạo
        public Statistcal_Info()
        {
            InitializeComponent();
            DBPetShop = new PetshopWinformEntities();
            busThongKe = new Statistical_BUS();
        }

        public Statistcal_Info(int maHoaDon, DateTime ngayTao)
        {
            InitializeComponent();
            DBPetShop = new PetshopWinformEntities();
            busThongKe = new Statistical_BUS();
            this.maHoaDon = maHoaDon;
            this.ngayTao = ngayTao;
        }

        public Statistcal_Info(int maKhachHang, int maHoaDon, DateTime ngayTao)
        {
            InitializeComponent();
            DBPetShop = new PetshopWinformEntities();
            busThongKe = new Statistical_BUS();
            this.maHoaDon = maHoaDon;
            this.maKhachHang = maKhachHang;
            this.ngayTao = ngayTao;
        }
        #endregion

        #region Các xử lý
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Statistcal_Info_Load(object sender, EventArgs e)
        {
            load_data();
            dinhDangBang();
        }

        private void dataGridViewDanhMucSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex.Equals(3))
            {
                e.Value = String.Format(CultureInfo.CreateSpecificCulture("vi-vn"), "{0:c}", dataGridViewDanhMucSanPham.Rows[e.RowIndex].Cells[3].Value);
            }
        }
        #endregion

        #region Các phương thức
        private void load_data()
        {
            busThongKe.truyenThongTinKhachHangTheoMaKhachHang(textBoxMaKhachHang, textBoxTenKhachHang, textBoxDiaChi, textBoxDienThoai, checkBoxGiamGia, maKhachHang);
            busThongKe.truyenThongTinSanPhamTheoMaHoaDon(dataGridViewDanhMucSanPham, maHoaDon);
            textBoxMaHoaDon.Text = maHoaDon.ToString();
            dateTimePickerNgayTao.Value = ngayTao;
            tongTienHoaDon();
        }

        private void tongTienHoaDon()
        {
            double tongCong = 0;
            for (int i = 0; i < dataGridViewDanhMucSanPham.RowCount; i++)
            {
                tongCong += Convert.ToDouble(dataGridViewDanhMucSanPham.Rows[i].Cells[3].Value);
            }
            textBoxTongTien.Text = String.Format(CultureInfo.CreateSpecificCulture("vi-vn"), "{0:c}", tongCong);
        }

        private void dinhDanhHeaderText()
        {
            dataGridViewDanhMucSanPham.Columns[0].HeaderText = "Mã";
            dataGridViewDanhMucSanPham.Columns[1].HeaderText = "Tên";
            dataGridViewDanhMucSanPham.Columns[2].HeaderText = "Số lượng";
            dataGridViewDanhMucSanPham.Columns[3].HeaderText = "Thanh toán";
        }

        private void dinhDangDoRongCot()
        {
            dataGridViewDanhMucSanPham.Columns[0].Width = (int)(dataGridViewDanhMucSanPham.Width * 0.21);
            dataGridViewDanhMucSanPham.Columns[1].Width = (int)(dataGridViewDanhMucSanPham.Width * 0.25);
            dataGridViewDanhMucSanPham.Columns[2].Width = (int)(dataGridViewDanhMucSanPham.Width * 0.21);
            dataGridViewDanhMucSanPham.Columns[3].Width = (int)(dataGridViewDanhMucSanPham.Width * 0.24);
        }

        private void dinhDangBang()
        {
            dinhDangDoRongCot();
            dinhDanhHeaderText();
        }
        #endregion

    }
}
