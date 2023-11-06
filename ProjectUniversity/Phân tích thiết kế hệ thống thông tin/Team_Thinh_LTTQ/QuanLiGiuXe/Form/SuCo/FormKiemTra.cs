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
    public partial class FormKiemTra : Form
    {
        private SqlConnection connection;
        private String connectionString = "Data Source=DESKTOP-J98APIA;Initial Catalog=DBCuoiKy;Integrated Security=True";
        private SqlCommand command;
        private SqlDataAdapter adapter = new SqlDataAdapter();

        public FormKiemTra()
        {
            InitializeComponent();
        }

        private void soXeVao(String query)
        {
            DataTable table = new DataTable();
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridViewSoXeVao.DataSource = table;
            connection.Close();
        }

        private void soXeRa(String query)
        {
            DataTable table = new DataTable();
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridViewSoXeRa.DataSource = table;
            connection.Close();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if (radioButtonTimBienSoVaBaiDo.Checked)
            {
                if (!textBoxBienSoXe.Text.Equals("") && !textBoxBaiDo.Text.Equals(""))
                {
                    soXeVao("SELECT SoXeVao.IdTheXe, SoXeVao.NgayTao, TheXe.BienSo, LoaiXe.TenLoaiXe, KhuVuc.TenKhuVuc, ViTri.TenViTri FROM SoXeVao INNER JOIN TheXe ON SoXeVao.IdTheXe = TheXe.IdTheXe INNER JOIN LoaiXe ON TheXe.IdLoaiXe = LoaiXe.IdLoaiXe INNER JOIN ViTri ON TheXe.IdViTri = ViTri.idViTri INNER JOIN KhuVuc ON ViTri.MaKhuVuc = KhuVuc.MaKhuVuc WHERE TheXe.BienSo = '" + textBoxBienSoXe.Text + "' AND ViTri.TenViTri = '" + textBoxBaiDo.Text + "'");
                    soXeRa("SELECT SoXeRa.IdTheXe, SoXeRa.NgayLay, TheXe.BienSo, LoaiXe.TenLoaiXe, KhuVuc.TenKhuVuc, ViTri.TenViTri FROM SoXeRa INNER JOIN TheXe ON SoXeRa.IdTheXe = TheXe.IdTheXe INNER JOIN ViTri ON TheXe.IdViTri = ViTri.idViTri INNER JOIN KhuVuc ON ViTri.MaKhuVuc = KhuVuc.MaKhuVuc INNER JOIN LoaiXe ON TheXe.IdLoaiXe = LoaiXe.IdLoaiXe WHERE TheXe.BienSo = '" + textBoxBienSoXe.Text + "' AND ViTri.TenViTri = '" + textBoxBaiDo.Text + "'");
                }
                else if (!textBoxBienSoXe.Text.Equals(""))
                {
                    soXeVao("SELECT SoXeVao.IdTheXe, SoXeVao.NgayTao, TheXe.BienSo, LoaiXe.TenLoaiXe, KhuVuc.TenKhuVuc, ViTri.TenViTri FROM SoXeVao INNER JOIN TheXe ON SoXeVao.IdTheXe = TheXe.IdTheXe INNER JOIN LoaiXe ON TheXe.IdLoaiXe = LoaiXe.IdLoaiXe INNER JOIN ViTri ON TheXe.IdViTri = ViTri.idViTri INNER JOIN KhuVuc ON ViTri.MaKhuVuc = KhuVuc.MaKhuVuc WHERE TheXe.BienSo = '" + textBoxBienSoXe.Text + "'");
                    soXeRa("SELECT SoXeRa.IdTheXe, SoXeRa.NgayLay, TheXe.BienSo, LoaiXe.TenLoaiXe, KhuVuc.TenKhuVuc, ViTri.TenViTri FROM SoXeRa INNER JOIN TheXe ON SoXeRa.IdTheXe = TheXe.IdTheXe INNER JOIN ViTri ON TheXe.IdViTri = ViTri.idViTri INNER JOIN KhuVuc ON ViTri.MaKhuVuc = KhuVuc.MaKhuVuc INNER JOIN LoaiXe ON TheXe.IdLoaiXe = LoaiXe.IdLoaiXe WHERE TheXe.BienSo = '" + textBoxBienSoXe.Text + "'");
                }
                else if (!textBoxBaiDo.Text.Equals(""))
                {
                    soXeVao("SELECT SoXeVao.IdTheXe, SoXeVao.NgayTao, TheXe.BienSo, LoaiXe.TenLoaiXe, KhuVuc.TenKhuVuc, ViTri.TenViTri FROM SoXeVao INNER JOIN TheXe ON SoXeVao.IdTheXe = TheXe.IdTheXe INNER JOIN LoaiXe ON TheXe.IdLoaiXe = LoaiXe.IdLoaiXe INNER JOIN ViTri ON TheXe.IdViTri = ViTri.idViTri INNER JOIN KhuVuc ON ViTri.MaKhuVuc = KhuVuc.MaKhuVuc WHERE ViTri.TenViTri = '" + textBoxBaiDo.Text + "'");
                    soXeRa("SELECT SoXeRa.IdTheXe, SoXeRa.NgayLay, TheXe.BienSo, LoaiXe.TenLoaiXe, KhuVuc.TenKhuVuc, ViTri.TenViTri FROM SoXeRa INNER JOIN TheXe ON SoXeRa.IdTheXe = TheXe.IdTheXe INNER JOIN ViTri ON TheXe.IdViTri = ViTri.idViTri INNER JOIN KhuVuc ON ViTri.MaKhuVuc = KhuVuc.MaKhuVuc INNER JOIN LoaiXe ON TheXe.IdLoaiXe = LoaiXe.IdLoaiXe WHERE ViTri.TenViTri = '" + textBoxBaiDo.Text + "'");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thông tin và vị trí hoặc biển số xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(radioButtonTheoNgay.Checked)
            {
                soXeVao("SELECT SoXeVao.IdTheXe, SoXeVao.NgayTao, TheXe.BienSo, LoaiXe.TenLoaiXe, KhuVuc.TenKhuVuc, ViTri.TenViTri FROM SoXeVao INNER JOIN TheXe ON SoXeVao.IdTheXe = TheXe.IdTheXe INNER JOIN LoaiXe ON TheXe.IdLoaiXe = LoaiXe.IdLoaiXe INNER JOIN ViTri ON TheXe.IdViTri = ViTri.idViTri INNER JOIN KhuVuc ON ViTri.MaKhuVuc = KhuVuc.MaKhuVuc WHERE SoXeVao.NgayTao >= '"+ dateTimePickerNgayVao.Value +"'");
                soXeRa("SELECT SoXeRa.IdTheXe, SoXeRa.NgayLay, TheXe.BienSo, LoaiXe.TenLoaiXe, KhuVuc.TenKhuVuc, ViTri.TenViTri FROM SoXeRa INNER JOIN TheXe ON SoXeRa.IdTheXe = TheXe.IdTheXe INNER JOIN ViTri ON TheXe.IdViTri = ViTri.idViTri INNER JOIN KhuVuc ON ViTri.MaKhuVuc = KhuVuc.MaKhuVuc INNER JOIN LoaiXe ON TheXe.IdLoaiXe = LoaiXe.IdLoaiXe WHERE SoXeRa.NgayLay <= '" + dateTimePickerNgayRa.Value + "'");
            }
        }

        private void FormKiemTra_Load(object sender, EventArgs e)
        {
            soXeVao("SELECT SoXeVao.IdTheXe, SoXeVao.NgayTao, TheXe.BienSo, LoaiXe.TenLoaiXe, KhuVuc.TenKhuVuc, ViTri.TenViTri FROM SoXeVao INNER JOIN TheXe ON SoXeVao.IdTheXe = TheXe.IdTheXe INNER JOIN LoaiXe ON TheXe.IdLoaiXe = LoaiXe.IdLoaiXe INNER JOIN ViTri ON TheXe.IdViTri = ViTri.idViTri INNER JOIN KhuVuc ON ViTri.MaKhuVuc = KhuVuc.MaKhuVuc");
            soXeRa("SELECT SoXeRa.IdTheXe, SoXeRa.NgayLay, TheXe.BienSo, LoaiXe.TenLoaiXe, KhuVuc.TenKhuVuc, ViTri.TenViTri FROM SoXeRa INNER JOIN TheXe ON SoXeRa.IdTheXe = TheXe.IdTheXe INNER JOIN ViTri ON TheXe.IdViTri = ViTri.idViTri INNER JOIN KhuVuc ON ViTri.MaKhuVuc = KhuVuc.MaKhuVuc INNER JOIN LoaiXe ON TheXe.IdLoaiXe = LoaiXe.IdLoaiXe");
            radioButtonTimBienSoVaBaiDo.Checked = true;
        }

        private void radioButtonTimBienSoVaBaiDo_CheckedChanged(object sender, EventArgs e)
        {
            textBoxBienSoXe.Enabled = true;
            textBoxBaiDo.Enabled = true;
            dateTimePickerNgayVao.Enabled = false;
            dateTimePickerNgayRa.Enabled = false;
        }

        private void radioButtonTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            textBoxBienSoXe.Enabled = false;
            textBoxBaiDo.Enabled = false;
            dateTimePickerNgayVao.Enabled = true;
            dateTimePickerNgayRa.Enabled = true;
        }
    }
}
