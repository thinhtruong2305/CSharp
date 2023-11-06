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

namespace WinformCoBan
{
    public partial class FormDBHocSinh : Form
    {
        public FormDBHocSinh()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        String connectionString = "Data Source=DESKTOP-J98APIA;Initial Catalog=HocSinh;Integrated Security=True";
        SqlCommand cmd;
        SqlDataReader reader;
        DataTable dataTable = new DataTable();

        public void load_Data()
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "Select * from Diem";
            reader = cmd.ExecuteReader();
            dataTable.Load(reader);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void FormDBHocSinh_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            //Mở kết nối
            connection.Open();
            load_Data();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {

        }
    }
}
