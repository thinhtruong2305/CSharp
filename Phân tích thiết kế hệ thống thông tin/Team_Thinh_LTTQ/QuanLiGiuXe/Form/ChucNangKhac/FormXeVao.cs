using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiGiuXe.DTO;
using QuanLiGiuXe.DAO;

namespace QuanLiGiuXe
{
    public partial class FormXeVao : Form
    {
        private SqlConnection connection;
        private String connectionString = "Data Source=DESKTOP-J98APIA;Initial Catalog=DBCuoiKy;Integrated Security=True";
        private SqlCommand command;
        private SqlDataAdapter adapter = new SqlDataAdapter();

        public FormXeVao()
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

        private void add_baiDo()
        {
            List<KhuVuc> listKhuVuc = KhuVucDAO.Instance.getListKhuVuc();
            foreach(var itemKhuVuc in listKhuVuc)
            {
                TabPage tab = new TabPage(itemKhuVuc.Tenkhuvuc);
                tab.Name = itemKhuVuc.Tenkhuvuc;
                FlowLayoutPanel flow = new FlowLayoutPanel() { Width = 488, Height = 444 };
                flow.AutoScroll = true;
                List<ViTri> listViTri = ViTriDAO.Instance.getListViTriByIdKhuVuc(itemKhuVuc.Makhuvuc);
                foreach(var itemViTri in listViTri)
                {
                    if (itemViTri.Trangthai.Equals("Trống"))
                    {
                        Button btn = new Button() { Width = 100, Height = 100 };
                        btn.BackColor = Color.CadetBlue;
                        btn.Text = itemViTri.Tenvitri;
                        btn.Font = new Font(Font.FontFamily, 16);
                        btn.Tag = itemViTri;
                        btn.Click += Btn_Click;
                        flow.Controls.Add(btn);
                    }
                    else
                    {
                        Button btn = new Button() { Width = 100, Height = 100 };
                        btn.BackColor = Color.IndianRed;
                        btn.Text = itemViTri.Tenvitri;
                        btn.Font = new Font(Font.FontFamily, 16);
                        btn.Tag = itemViTri;
                        btn.Click += Btn_Click;
                        flow.Controls.Add(btn);
                    }
                }
                tab.Controls.Add(flow);
                tabControlBaiDo.Controls.Add(tab);
            }
        }

        private void load_baiDo()
        {
            tabControlBaiDo.Controls.Clear();
            List<KhuVuc> listKhuVuc = KhuVucDAO.Instance.getListKhuVuc();
            foreach (var itemKhuVuc in listKhuVuc)
            {
                TabPage tab = new TabPage(itemKhuVuc.Tenkhuvuc);
                tab.Name = itemKhuVuc.Tenkhuvuc;
                FlowLayoutPanel flow = new FlowLayoutPanel() { Width = 488, Height = 444 };
                flow.AutoScroll = true;
                List<ViTri> listViTri = ViTriDAO.Instance.getListViTriByIdKhuVuc(itemKhuVuc.Makhuvuc);
                foreach (var itemViTri in listViTri)
                {
                    if (itemViTri.Trangthai.Equals("Trống"))
                    {
                        Button btn = new Button() { Width = 100, Height = 100 };
                        btn.BackColor = Color.CadetBlue;
                        btn.Text = itemViTri.Tenvitri;
                        btn.Font = new Font(Font.FontFamily, 16);
                        btn.Tag = itemViTri;
                        btn.Click += Btn_Click;
                        flow.Controls.Add(btn);
                    }
                    else
                    {
                        Button btn = new Button() { Width = 100, Height = 100 };
                        btn.BackColor = Color.IndianRed;
                        btn.Text = itemViTri.Tenvitri;
                        btn.Font = new Font(Font.FontFamily, 16);
                        btn.Tag = itemViTri;
                        btn.Click += Btn_Click;
                        flow.Controls.Add(btn);
                    }
                }
                tab.Controls.Add(flow);
                tabControlBaiDo.Controls.Add(tab);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            ViTri viTri = (((sender) as Button).Tag) as ViTri;
            cbbViTri.Text = viTri.Tenvitri;
        }

        private void xoaDuLieuTheXe(String query)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void timTheXeChoXoa(String query)
        {
            DataTable table = new DataTable();
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            int idTheXe = Convert.ToInt32(table.Rows[0].ItemArray.First());
            xoaDuLieuSoXeVao(connection, "DELETE FROM SoXeVao WHERE IdTheXe = '" + idTheXe + "'");
            connection.Close();
        }

        private void xoaDuLieuSoXeVao(SqlConnection connection, String query)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            String bienSo = textBoxBienSoXe.Text;
            // xóa thẻ xe dựa trên id thẻ xe của số xe vào
            timTheXeChoXoa("SELECT IdTheXe FROM TheXe WHERE BienSo = '" + bienSo + "'");
            //xe thẻ xe dựa trên biển số
            xoaDuLieuTheXe("DELETE FROM TheXe WHERE BienSo = '"+ bienSo +"'");
            updateTrangThaiViTri("UPDATE ViTri SET TrangThai = N'" + "Trống" + "'WHERE TenViTri = '" + cbbViTri.Text + "'");
            load_baiDo();
            load_data_xe("SELECT TheXe.BienSo, ViTri.TenViTri, LoaiXe.TenLoaiXe, SoXeVao.NgayTao FROM TheXe INNER JOIN LoaiXe ON TheXe.IdLoaiXe = LoaiXe.IdLoaiXe INNER JOIN SoXeVao ON TheXe.IdTheXe = SoXeVao.IdTheXe INNER JOIN ViTri ON TheXe.IdViTri = ViTri.idViTri");
        }

        private void themDuLieuTheXe(String query)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void timTheXeChoThem(String query)
        {
            DataTable table = new DataTable();
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            int idTheXe = Convert.ToInt32(table.Rows[0].ItemArray.First());
            themDuLieuSoXeVao(connection, "INSERT INTO [dbo].[SoXeVao] ([IdTheXe], [NgayTao]) VALUES ('" + idTheXe + "', '" + DateTime.Now + "')");
            connection.Close();
        }

        private void themDuLieuSoXeVao(SqlConnection connection, String query)
        {
            command = connection.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();
        }


        private void updateTrangThaiViTri(String query)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            String bienSo = textBoxBienSoXe.Text;
            themDuLieuTheXe("INSERT INTO [dbo].[TheXe] ([BienSo], [IdViTri], [IdLoaiXe], [DonGia]) VALUES ('"+ bienSo +"', '"+ Convert.ToInt32(cbbViTri.SelectedValue.ToString()) +"', '"+ Convert.ToInt32(comboBoxLoaiXe.SelectedValue.ToString()) +"', '"+ 0 +"')");
            
            //id thẻ xe dùng để thêm vô sổ xe vào
            timTheXeChoThem("SELECT IdTheXe FROM TheXe WHERE BienSo = '" + bienSo + "'");
            updateTrangThaiViTri("UPDATE ViTri SET TrangThai = N'" + "Có xe" + "' WHERE TenViTri = '"+ cbbViTri.Text +"'");
            //dữ liệu
            load_baiDo();
            load_data_xe("SELECT TheXe.IdTheXe, TheXe.BienSo, ViTri.TenViTri, LoaiXe.TenLoaiXe, SoXeVao.NgayTao FROM TheXe INNER JOIN LoaiXe ON TheXe.IdLoaiXe = LoaiXe.IdLoaiXe INNER JOIN SoXeVao ON TheXe.IdTheXe = SoXeVao.IdTheXe INNER JOIN ViTri ON TheXe.IdViTri = ViTri.idViTri");

        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if (!txtTKxe.Text.Equals(null))
            {
                load_data_xe("SELECT TheXe.IdTheXe, TheXe.BienSo, ViTri.TenViTri, LoaiXe.TenLoaiXe, SoXeVao.NgayTao FROM TheXe INNER JOIN LoaiXe ON TheXe.IdLoaiXe = LoaiXe.IdLoaiXe INNER JOIN SoXeVao ON TheXe.IdTheXe = SoXeVao.IdTheXe INNER JOIN ViTri ON TheXe.IdViTri = ViTri.idViTri WHERE BienSo = '" + txtTKxe.Text + "'");
            }
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
             
        }

        private void FormXeVao_Load(object sender, EventArgs e)
        {
            //dữ liệu
            add_baiDo();
            load_data_xe("SELECT TheXe.IdTheXe, TheXe.BienSo, ViTri.TenViTri, LoaiXe.TenLoaiXe, SoXeVao.NgayTao FROM TheXe INNER JOIN LoaiXe ON TheXe.IdLoaiXe = LoaiXe.IdLoaiXe INNER JOIN SoXeVao ON TheXe.IdTheXe = SoXeVao.IdTheXe INNER JOIN ViTri ON TheXe.IdViTri = ViTri.idViTri");

            //Màu sắc
            labelChuThichChoTrong.BackColor = Color.CadetBlue;
            labelChuThichDaCoXe.BackColor = Color.IndianRed;
            
            //Dữ liệu comboBox
            //Vị trí
            cbbViTri.DataSource = ViTriDAO.Instance.GetListViTri();
            cbbViTri.DisplayMember = "TenViTri";
            cbbViTri.ValueMember = "idViTri";
            //Loại xe
            comboBoxLoaiXe.DataSource = LoaiXeDAO.Instance.GetListLoaiXe();
            comboBoxLoaiXe.DisplayMember = "TenLoaiXe";
            comboBoxLoaiXe.ValueMember = "IdLoaiXe";
        }

        private void dataGridViewXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxBienSoXe.Text = dataGridViewXe.CurrentRow.Cells[1].Value.ToString();
            cbbViTri.Text = dataGridViewXe.CurrentRow.Cells[2].Value.ToString();
            comboBoxLoaiXe.Text = dataGridViewXe.CurrentRow.Cells[3].Value.ToString();
            dateTimePickerThoiGianVao.Value = Convert.ToDateTime(dataGridViewXe.CurrentRow.Cells[4].Value.ToString());
        }
    }
}
