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
using QuanLiGiuXe.DAO;

namespace QuanLiGiuXe
{
    public partial class FormXeRa : Form
    {
        private SqlConnection connection;
        private String connectionString = "Data Source=DESKTOP-J98APIA;Initial Catalog=DBCuoiKy;Integrated Security=True";
        private SqlCommand command;
        private SqlDataAdapter adapter = new SqlDataAdapter();

        private int idTheXe = 0;
        private int idViTri = 0;

        public FormXeRa()
        {
            InitializeComponent();
        }

        private void load_data_xe(String query)
        {
            DataTable table = new DataTable();
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridViewXe.DataSource = table;
            connection.Close();
        }

        private void load_data_thongTinThe(String query)
        {
            DataTable table = new DataTable();
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridViewThongTinThe.DataSource = table;
            connection.Close();
        }

        private void themDuLieuSoXeVao(String query)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();
            connection.Close();
        }


        private void updateTrangThaiViTri(SqlConnection connection, String query)
        {
            command = connection.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();
        }

        private void timTheXeChoTrangThai(String query)
        {
            DataTable table = new DataTable();
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            String tenViTri = Convert.ToString(table.Rows[0].ItemArray.First());
            updateTrangThaiViTri(connection, "UPDATE ViTri SET TrangThai = N'" + "Trống" + "' WHERE TenViTri = '" + tenViTri + "'");
            connection.Close();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            themDuLieuSoXeVao("INSERT INTO [dbo].[SoXeRa] ([IdTheXe], [NgayLay]) VALUES ('" + Convert.ToInt32(txtTuKhoa.Text) + "', '" + DateTime.Now + "')");
            timTheXeChoTrangThai("SELECT ViTri.TenViTri FROM TheXe INNER JOIN ViTri ON TheXe.IdViTri = ViTri.idViTri WHERE TheXe.IdTheXe = '" + Convert.ToInt32(txtTuKhoa.Text) + "'");
            load_data_xe("SELECT TheXe.BienSo, ViTri.TenViTri, LoaiXe.TenLoaiXe, SoXeRa.NgayLay FROM TheXe INNER JOIN LoaiXe ON TheXe.IdLoaiXe = LoaiXe.IdLoaiXe INNER JOIN SoXeRa ON TheXe.IdTheXe = SoXeRa.IdTheXe INNER JOIN ViTri ON TheXe.IdViTri = ViTri.idViTri");
        }

        private bool timTheXeChoKiemTra(String query)
        {
            DataTable table = new DataTable();
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            connection.Close();
            return false;
        }

        private bool kiemTraKiTuDacBiec(String tuKhoa)
        {
            bool tk = true;
            foreach (char item in tuKhoa)
            {
                if (!Char.IsLetterOrDigit(item))
                {
                    tk = false;
                }
            }
            if (tk == true)
                return true;
            return false;
        }

        private void buttonKiemTraThe_Click(object sender, EventArgs e)
        {
            if (kiemTraKiTuDacBiec(txtTuKhoa.Text))
            {
                if (timTheXeChoKiemTra("SELECT * FROM TheXe WHERE IdTheXe = '"+ txtTuKhoa.Text + "'"))
                {
                    labelTinhTrang.Text = "Có tồn tại";
                    labelTinhTrang.BackColor = Color.Green;
                    labelTinhTrang.ForeColor = Color.White;
                    load_data_thongTinThe("SELECT TheXe.IdTheXe, TheXe.BienSo, TheXe.idViTri, ViTri.TenViTri FROM TheXe INNER JOIN ViTri ON TheXe.IdViTri = ViTri.idViTri WHERE TheXe.IdTheXe = '" + txtTuKhoa.Text + "'");
                    idTheXe = Convert.ToInt32(txtTuKhoa.Text);
                    idViTri = Convert.ToInt32(dataGridViewThongTinThe.Rows[0].Cells[2].Value.ToString());
                    btnThanhToan.Enabled = true;
                    buttonThem.Enabled = true;
                }
                else
                {
                    labelTinhTrang.Text = "Không tồn tồn tại";
                    labelTinhTrang.BackColor = Color.Red;
                    labelTinhTrang.ForeColor = Color.White;
                    load_data_thongTinThe("SELECT TheXe.IdTheXe, TheXe.BienSo, TheXe.idViTri, ViTri.TenViTri FROM TheXe INNER JOIN ViTri ON TheXe.IdViTri = ViTri.idViTri WHERE TheXe.IdTheXe = '" + txtTuKhoa.Text + "'");
                    buttonThem.Enabled = false;
                    btnThanhToan.Enabled = false;
                }
            }
        }

        private void tinhTienChoThanhToan()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            DateTime ngayTao = layNgayTao(connection, "SELECT SoXeVao.NgayTao FROM SoXeVao WHERE SoXeVao.IdTheXe = '"+ idTheXe +"'");
            decimal donGia = layDonGia(connection, "SELECT LoaiXe.DonGia FROM TheXe INNER JOIN LoaiXe ON TheXe.IdLoaiXe = LoaiXe.IdLoaiXe WHERE TheXe.IdTheXe = '" + idTheXe.ToString() + "'");
            //vấn đề em chưa gặp nên sẽ tiếp tục tương lai cái thẻ xe đầu tiên không chung 1 ngày
            decimal tongTien = (DateTime.Now.Hour - ngayTao.Hour) * donGia;
            MessageBox.Show("Số tiền thanh toán: " + tongTien.ToString(), "Thông báo");
            int idLoaiXe = layIdLoaiXe(connection, "SELECT LoaiXe.IdLoaiXe FROM TheXe INNER JOIN LoaiXe ON TheXe.IdLoaiXe = LoaiXe.IdLoaiXe WHERE TheXe.IdTheXe = '" + idTheXe + "'");
            themDuLieuHoaDon(connection, "INSERT INTO [dbo].[HoaDon] ([IdTheXe], [IdLoaiXe], [TongTien], [IdVitri], [NgayThanhToan]) VALUES ('"+ idTheXe +"', '"+ idLoaiXe +"', '"+ tongTien +"', '"+ idViTri +"', '"+ DateTime.Now +"')");
            connection.Close();
        }

        private DateTime layNgayTao(SqlConnection connection, String query)
        {
            DataTable table = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DateTime ngayTao = Convert.ToDateTime(table.Rows[0].ItemArray.First());
            return ngayTao;
        }

        private decimal layDonGia(SqlConnection connection, String query)
        {
            DataTable table = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            decimal donGia = Convert.ToDecimal(table.Rows[0].ItemArray.First());
            return donGia;
        }

        private int layIdLoaiXe(SqlConnection connection, String query)
        {
            DataTable table = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            int IdLoaiXe = Convert.ToInt32(table.Rows[0].ItemArray.First());
            return IdLoaiXe;
        }

        private void themDuLieuHoaDon(SqlConnection connection, String query)
        {
            command = connection.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            tinhTienChoThanhToan();
        }

        private void FormXeRa_Load(object sender, EventArgs e)
        {
            load_data_xe("SELECT TheXe.BienSo, ViTri.TenViTri, LoaiXe.TenLoaiXe, SoXeRa.NgayLay FROM TheXe INNER JOIN LoaiXe ON TheXe.IdLoaiXe = LoaiXe.IdLoaiXe INNER JOIN SoXeRa ON TheXe.IdTheXe = SoXeRa.IdTheXe INNER JOIN ViTri ON TheXe.IdViTri = ViTri.idViTri");
            buttonThem.Enabled = false;
            btnThanhToan.Enabled = false;
        }
    }
}
