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
    public partial class FormTrangChinh : Form
    {
        private SqlConnection connection;
        private String connectionString = "Data Source=DESKTOP-J98APIA;Initial Catalog=DBCuoiKy;Integrated Security=True";
        private SqlCommand command;
        private SqlDataAdapter adapter = new SqlDataAdapter();

        public FormTrangChinh()
        {
            InitializeComponent();
        }

        private void load_data_chart(String query)
        {
            DataTable table = new DataTable();
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            chartDoanhThu.DataSource = table;
            chartDoanhThu.Series["DoanhThu"].XValueMember = "Tháng";
            chartDoanhThu.Series["DoanhThu"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartDoanhThu.Series["DoanhThu"].YValueMembers = "Tổng tiền";
            chartDoanhThu.Series["DoanhThu"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            connection.Close();
        }

        private void load_data_combobox(String query)
        {
            DataTable table = new DataTable();
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            comboBoxNam.DataSource = table;
            comboBoxNam.ValueMember = "Năm";
            connection.Close();
        }

        private void load_data_label(String query)
        {
            DataTable table = new DataTable();
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            labelSoTienTongDoanhThu.Text = table.Rows[0].ItemArray.First().ToString();
            connection.Close();
        }

        private void load_data_labelByYear(String query)
        {
            DataTable table = new DataTable();
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            labelSoTienDoanhThuNam.Text = table.Rows[0].ItemArray.First().ToString();
            connection.Close();
        }

        private void FormTrangChinh_Load(object sender, EventArgs e)
        {
            load_data_combobox("SELECT YEAR(NgayThanhToan) 'Năm' FROM HoaDon GROUP BY YEAR(NgayThanhToan) ORDER BY YEAR(NgayThanhToan)");
            load_data_chart("SELECT SUM(TongTien) 'Tổng tiền', MONTH(NgayThanhToan) 'Tháng' FROM HoaDon WHERE YEAR(NgayThanhToan) = '" + DateTime.Now.Year.ToString() + "' GROUP BY MONTH(NgayThanhToan)"); ;
            load_data_label("SELECT SUM(TongTien)'total' FROM HoaDon WHERE YEAR(NgayThanhToan) >= '"+ DateTime.MinValue.Year.ToString() +"' AND YEAR(NgayThanhToan) <= '"+ DateTime.MaxValue.Year.ToString() +"'");
            load_data_labelByYear("SELECT SUM(TongTien)'total' FROM HoaDon WHERE YEAR(NgayThanhToan) = '" + DateTime.Now.Year.ToString() + "'");
        }

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            load_data_chart("SELECT SUM(TongTien) 'Tổng tiền', MONTH(NgayThanhToan) 'Tháng' FROM HoaDon WHERE YEAR(NgayThanhToan) = '" + comboBoxNam.SelectedValue.ToString() + "' GROUP BY MONTH(NgayThanhToan)");
            load_data_labelByYear("SELECT SUM(TongTien) 'total' FROM HoaDon WHERE YEAR(NgayThanhToan) = '"+ comboBoxNam.SelectedValue.ToString() +"'");
        }
    }
}
