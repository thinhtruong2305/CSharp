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
    public partial class FormBaiDo : Form
    {
        BindingSource listViTri = new BindingSource();
        BindingSource listKhuVuc = new BindingSource();
        private SqlConnection connection;
        private String connectionString = "Data Source=DESKTOP-J98APIA;Initial Catalog=DBCuoiKy;Integrated Security=True";
        private SqlCommand command;
        private SqlDataAdapter adapter = new SqlDataAdapter();

        public FormBaiDo()
        {
            InitializeComponent();
        }

        private void dinhDangHeaderText()
        {
            dgvViTri.Columns[0].HeaderText = "Mã vị trí";
            dgvViTri.Columns[1].HeaderText = "Tên vị trí";
            dgvViTri.Columns[2].HeaderText = "Trạng thái";
            dgvViTri.Columns[3].HeaderText = "Mã khu vực";

            dataGridViewKhuVuc.Columns[0].HeaderText = "Mã khu vực";
            dataGridViewKhuVuc.Columns[1].HeaderText = "Tên khu vực";
            dataGridViewKhuVuc.Columns[2].HeaderText = "Loại xe";
        }

        #region Các DAO kết nối vị trí
        void LoadViTRi()
        {
            listViTri.DataSource = ViTriDAO.Instance.GetListViTri();
        }

        void AddViTri(string tenvitri, int makhuvuc, int trangthai)
        {
            if (ViTriDAO.Instance.AddViTri(tenvitri, makhuvuc, trangthai))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }

            LoadViTRi();
        }

        void DeleteVITri(string tenvitri)
        {

            if (ViTriDAO.Instance.DeleteViTri(tenvitri))
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }

            LoadViTRi();
        }

        void UpdateViTri(int mavt, string tenvitri, int makhuvuc, int trangthai)
        {
            if (ViTriDAO.Instance.UpdateViTri(mavt, tenvitri, makhuvuc, trangthai))
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }

            LoadViTRi();
        }
        #endregion

        #region Các DAO kết nối khu vực
        void LoadKhuVuc()
        {
            listKhuVuc.DataSource = KhuVucDAO.Instance.GetListKhuVuc();
        }

        void AddKhuVuc(string tenkhuvuc, string trangthai)
        {
            if (KhuVucDAO.Instance.AddKhuVuc(tenkhuvuc, trangthai))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }

            LoadKhuVuc();
        }

        void DeleteKhuVuc(string tenkhuvuc)
        {

            if (KhuVucDAO.Instance.DeleteKhuVuc(tenkhuvuc))
            {
                MessageBox.Show("Xóa Khu vực thành công");
            }
            else
            {
                MessageBox.Show("Xóa khu vực thất bại");
            }

            LoadKhuVuc();
        }

        void UpdateKhuVuc(string tenkhuvuc, int trangthai)
        {
            if (KhuVucDAO.Instance.UpdateKhuVuc(tenkhuvuc, trangthai))
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }

            LoadKhuVuc();
        }
        #endregion

        #region sự kiện của vị trí

        private void thaoTacViTri(String query)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            thaoTacViTri("INSERT INTO [dbo].[ViTri] ([TenViTri], [TrangThai], [MaKhuVuc]) VALUES ('"+ txtTenViTri.Text +"', N'"+ "Trống" +"','"+ Convert.ToInt32(cbbKhuVuc.SelectedValue.ToString()) +"')");
            LoadViTRi();
            dgvViTri.DataSource = listViTri;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            thaoTacViTri("DELETE FROM [dbo].[ViTri] WHERE idViTri = '"+ txtMaViTri.Text +"'");
            LoadViTRi();
            dgvViTri.DataSource = listViTri;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            thaoTacViTri("UPDATE [dbo].[ViTri] SET TenViTri = '"+ txtTenViTri.Text +"', MaKhuVuc = '"+ Convert.ToInt32(cbbKhuVuc.SelectedValue.ToString()) +"' WHERE idViTri = '"+ txtMaViTri.Text +"'");
            LoadViTRi();
            dgvViTri.DataSource = listViTri;
        }

        #endregion

        #region sự kiện của khu vực
        private void thaoTacKhuVuc(String query)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void buttonThemKhuVuc_Click(object sender, EventArgs e)
        {
            thaoTacKhuVuc("INSERT INTO [dbo].[KhuVuc] ([MaKhuVuc], [TenKhuVuc], [TrangThai]) VALUES ('" + dataGridViewKhuVuc.RowCount + "', '" + txtTenKhuVuc.Text + "', '" + comboBoxLoaiXe.Text + "')");
            LoadKhuVuc();
            dataGridViewKhuVuc.DataSource = listKhuVuc;
        }

        private void buttonXoaKhuVuc_Click(object sender, EventArgs e)
        {
            thaoTacKhuVuc("DELETE FROM KhuVuc WHERE MaKhuVuc = '" + txtMaKhuVuc.Text + "'");
            LoadKhuVuc();
            dataGridViewKhuVuc.DataSource = listKhuVuc;
        }

        private void buttonSuaKhuVuc_Click(object sender, EventArgs e)
        {
            thaoTacKhuVuc("UPDATE [dbo].[KhuVuc] SET [TenKhuVuc] = '"+ txtTenKhuVuc.Text +"', [TrangThai] = '"+ comboBoxLoaiXe.Text +"' WHERE MaKhuVuc = '"+ txtMaKhuVuc.Text +"'");
            LoadKhuVuc();
            dataGridViewKhuVuc.DataSource = listKhuVuc;
        }
        #endregion

        private void dataGridViewKhuVuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewKhuVuc.CurrentCell.Selected = true;
            txtMaKhuVuc.Text = dataGridViewKhuVuc.Rows[e.RowIndex].Cells["MaKhuVuc"].Value.ToString();
            txtTenKhuVuc.Text = dataGridViewKhuVuc.Rows[e.RowIndex].Cells["TenKhuVuc"].Value.ToString();
            txtTrangThai.Text = dataGridViewKhuVuc.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();
        }

        private void dgvViTri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvViTri.CurrentCell.Selected = true;
            txtMaViTri.Text = dgvViTri.Rows[e.RowIndex].Cells["idViTri"].Value.ToString();
            txtTenViTri.Text = dgvViTri.Rows[e.RowIndex].Cells["TenViTri"].Value.ToString();
            cbbKhuVuc.Text = dgvViTri.Rows[e.RowIndex].Cells["MaKhuVuc"].Value.ToString();
            txtTrangThai.Text = dgvViTri.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();
        }

        private void FormBaiDo_Load(object sender, EventArgs e)
        {
            dataGridViewKhuVuc.DataSource = listKhuVuc;
            dgvViTri.DataSource = listViTri;
            cbbKhuVuc.DataSource = KhuVucDAO.Instance.GetListKhuVuc();
            cbbKhuVuc.DisplayMember = "TenKhuVuc";
            cbbKhuVuc.ValueMember = "MaKhuVuc";
            comboBoxLoaiXe.DataSource = LoaiXeDAO.Instance.GetListLoaiXe();
            comboBoxLoaiXe.DisplayMember = "TenLoaiXe";
            comboBoxLoaiXe.ValueMember = "IdLoaiXe";
            LoadViTRi();
            LoadKhuVuc();
            dinhDangHeaderText();
        }
    }
}
