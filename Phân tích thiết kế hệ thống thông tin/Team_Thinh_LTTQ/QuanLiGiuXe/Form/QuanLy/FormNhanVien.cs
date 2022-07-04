using QuanLiGiuXe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiGiuXe
{
    public partial class FormNhanVien : Form
    {
        BindingSource list = new BindingSource();
        public FormNhanVien()
        {
            InitializeComponent();
            dgvNhanVien.DataSource = list;
            LoadNhanVien();
        }

        private void dinhDangHeaderText()
        {
            dgvNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns[1].HeaderText = "Họ và tên";
            dgvNhanVien.Columns[2].HeaderText = "Chức vụ";
            dgvNhanVien.Columns[3].HeaderText = "Ngày sinh";
        }

        void LoadNhanVien()
        {
            list.DataSource = NhanVienDAO.Instance.GetListNhanVien();
        }

        void AddNhanVien(string hoten, string chucvu, DateTime ngaysinh)
        {
            if (NhanVienDAO.Instance.AddNhanVien(hoten, chucvu, ngaysinh))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }

            LoadNhanVien();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoten = txtHoTen.Text;
            string chucvu = txtChucVu.Text;
            DateTime ngaysinh = dateTimePicker1.Value;
            AddNhanVien(hoten, chucvu, ngaysinh);

        }


        void UpdateNhanVien(int manv,string hoten, string chucvu, DateTime ngaysinh)
        {
            if (NhanVienDAO.Instance.UpdateNhanVien(manv, hoten, chucvu, ngaysinh))
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }

            LoadNhanVien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int manv = Convert.ToInt32(txtMaNhanVien.Text);
            string hoten = txtHoTen.Text;
            string chucvu = txtChucVu.Text;
            DateTime ngaysinh = dateTimePicker1.Value;
            UpdateNhanVien(manv,hoten, chucvu, ngaysinh);
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvNhanVien.CurrentCell.Selected = true;
                txtMaNhanVien.Text = dgvNhanVien.Rows[e.RowIndex].Cells["IdNhanVien"].Value.ToString();
                txtHoTen.Text = dgvNhanVien.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
                txtChucVu.Text = dgvNhanVien.Rows[e.RowIndex].Cells["ChucVu"].Value.ToString();
                dateTimePicker1.Text = dgvNhanVien.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString();
                
            }
            catch (Exception)
            {

            }
        }

        void DeleteNhanVien(string tennv)
        {

            if (NhanVienDAO.Instance.DeleteNhanVien(tennv))
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }

            LoadNhanVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tennv = txtHoTen.Text;
            DeleteNhanVien(tennv);
            LoadNhanVien();
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtChucVu.Clear();
            txtHoTen.Clear();
            txtMaNhanVien.Clear();
            dateTimePicker1.Value = DateTime.Now;
            LoadNhanVien();

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            dinhDangHeaderText();
        }
    }
}
