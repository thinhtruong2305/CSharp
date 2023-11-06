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
using System.Data.SqlClient;

namespace QuanLiGiuXe
{
    public partial class FormTaiKhoan : Form
    {
        private SqlConnection connection;
        private String connectionString = "Data Source=DESKTOP-J98APIA;Initial Catalog=DBCuoiKy;Integrated Security=True";
        private SqlCommand command;
        private SqlDataAdapter adapter = new SqlDataAdapter();

        BindingSource list = new BindingSource();
        public FormTaiKhoan()
        {
            InitializeComponent();
            dgvTaiKhoan.DataSource = list;
            LoadTaiKhoan();
        }

        void LoadTaiKhoan()
        {
            list.DataSource = TaiKhoanDAO.Instance.GetListAccount();
        }

        private void load_data_comboBoxNhanVien(String query)
        {
            DataTable table = new DataTable();
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            cbbMaNV.DataSource = table;
            cbbMaNV.DisplayMember = "HoTen";
            cbbMaNV.ValueMember = "IdNhanVien";
            connection.Close();
        }

        private void dinhDangHeaderText()
        {
            dgvTaiKhoan.Columns[0].HeaderText = "Mã tài khoản";
            dgvTaiKhoan.Columns[1].HeaderText = "Mã nhân viên";
            dgvTaiKhoan.Columns[2].HeaderText = "Tài khoản";
            dgvTaiKhoan.Columns[3].HeaderText = "Mật khẩu";
        }

        void Add(string tentk, string matkhau, int idnhanvien)
        {
            if (TaiKhoanDAO.Instance.Insert(tentk, matkhau, idnhanvien))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }

            LoadTaiKhoan();
        }

        void update(int idtk, string tentk, string matkhau, int idnhanvien)
        {
            if (TaiKhoanDAO.Instance.Update(idtk, tentk, matkhau, idnhanvien))
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }

            LoadTaiKhoan();
        }

        void delete(string tentk)
        {
            if (TaiKhoanDAO.Instance.Delete(tentk))
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }

            LoadTaiKhoan();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tentk = txtTenTK.Text;
            string matkhau = txtMatKhau.Text;
            int idnhanvien = Convert.ToInt32(cbbMaNV.SelectedValue.ToString());
            Add(tentk, matkhau, idnhanvien);
            LoadTaiKhoan();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int idtk = Convert.ToInt32(txtMaTK.Text);
            int idnv = Convert.ToInt32(cbbMaNV.SelectedValue.ToString());
            string tentk = txtTenTK.Text;
            string matkhau = txtMatKhau.Text;
            update(idtk, tentk, matkhau, idnv);
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvTaiKhoan.CurrentCell.Selected = true;
                txtMaTK.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["IdTaiKhoan"].Value.ToString();
                cbbMaNV.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["IdNhanVien"].Value.ToString();
                txtTenTK.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["TaiKhoan"].Value.ToString();
                txtMatKhau.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["MatKhau"].Value.ToString();

            }
            catch (Exception)
            {

            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tentk = txtTenTK.Text;
            delete(tentk);

        }

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            load_data_comboBoxNhanVien("SELECT * FROM NhanVien");
            dinhDangHeaderText();
        }
    }
}
