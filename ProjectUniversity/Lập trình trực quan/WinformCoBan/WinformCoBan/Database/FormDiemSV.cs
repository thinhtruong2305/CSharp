using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinformCoBan
{
    public partial class FormDiemSV : Form
    {
        public FormDiemSV()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        String connectionString = "Data Source=DESKTOP-J98APIA;Initial Catalog=HocSinh;Integrated Security=True";
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        

        private void excutionHienThiDiemSV(String query)
        {
            DataTable table = new DataTable();
            connection = new SqlConnection(connectionString);
            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandText = query;
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }
        private void excutionHienThiTenSV(String query)
        {
            DataTable table = new DataTable();
            connection = new SqlConnection(connectionString);
            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandText = query;
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataGridView2.DataSource = table;
            connection.Close();
        }

        private void excutionHienThiMonHoc(String query)
        {
            DataTable table = new DataTable();
            connection = new SqlConnection(connectionString);
            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandText = query;
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataGridView3.DataSource = table;
            connection.Close();
        }

        private void FormDiemSV_Load(object sender, EventArgs e)
        {
            excutionHienThiDiemSV("select * from Diem_SV");
            excutionHienThiTenSV("select * from SinhVien");
            excutionHienThiMonHoc("select * from MonHoc");
        }
    }
}
