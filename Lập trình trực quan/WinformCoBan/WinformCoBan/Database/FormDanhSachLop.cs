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
    public partial class FormDanhSachLop : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String connectionString = "Data Source=DESKTOP-J98APIA;Initial Catalog=Student;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable danhSachHocSinh = new DataTable();

        public FormDanhSachLop()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        private void load_data(String query)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            danhSachHocSinh.Clear();
            adapter.Fill(danhSachHocSinh);
            dataGridView1.DataSource = danhSachHocSinh;
            connection.Close();
        }

        private void load_data_combobox(String query)
        {
            DataTable tableLop = new DataTable();
            connection.Open();
            SqlCommand displayMenber = new SqlCommand(query, connection);
            adapter.SelectCommand = displayMenber;
            tableLop.Clear();
            adapter.Fill(tableLop);
            comboBox1.DisplayMember = "tenLop";
            comboBox1.ValueMember = "maLop";
            comboBox1.DataSource = tableLop;
            connection.Close();
        }

        private void FormDanhSachLop_Load(object sender, EventArgs e)
        {
            load_data("SELECT * FROM QLStudent");
            load_data_combobox("SELECT * FROM Lop");
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedValue.ToString();
        }
    }
}
