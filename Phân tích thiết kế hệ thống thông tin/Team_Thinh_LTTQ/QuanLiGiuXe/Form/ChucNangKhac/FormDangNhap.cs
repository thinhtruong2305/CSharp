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
    public partial class FormDangNhap : Form
    {
        private SqlConnection connection;
        private String connectionString = "Data Source=DESKTOP-J98APIA;Initial Catalog=DBCuoiKy;Integrated Security=True";
        private SqlCommand command;
        private SqlDataAdapter adapter = new SqlDataAdapter();

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private bool kiemTraTaiKhoanMatKhau(String query)
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

        private bool kiemTraKiTuDacBiec(String taiKhoan, String matKhau)
        {
            bool tk = true;
            bool mk = true;
            foreach(char item in matKhau)
            {
                if (!Char.IsLetterOrDigit(item))
                {
                    mk = false;
                }
            }
            foreach (char item in taiKhoan)
            {
                if (!Char.IsLetterOrDigit(item))
                {
                    tk = false;
                }
            }
            if(mk == true && tk == true)
                return true;
            return false;
        }

        private bool kiemTraVaiTro(String query)
        {
            DataTable table = new DataTable();
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            if (table.Rows[0].ItemArray.First().ToString().Equals("Quản lý"))
                return true;
            connection.Close();
            return false;
        }

        private void nhoMatKhau(String taiKhoan, String matKhau, bool check)
        {
            if (checkBoxNhoMatKhau.Checked)
            {
                Properties.Settings.Default.TaiKhoan = taiKhoan;
                Properties.Settings.Default.matKhau = matKhau;
                Properties.Settings.Default.check = check;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.TaiKhoan = "";
                Properties.Settings.Default.matKhau = "";
                Properties.Settings.Default.check = false;
                Properties.Settings.Default.Save();

            }
        }

        private void login(String taiKhoan, String matKhau)
        {
            if(kiemTraKiTuDacBiec(taiKhoan, matKhau))
            {
                if (kiemTraTaiKhoanMatKhau("SELECT * FROM TaiKhoan WHERE TaiKhoan.TaiKhoan = '"+ taiKhoan +"' AND TaiKhoan.MatKhau = '"+ matKhau +"'"))
                {
                    if (kiemTraVaiTro("SELECT NhanVien.ChucVu FROM TaiKhoan INNER JOIN NhanVien ON TaiKhoan.IdNhanVien = NhanVien.IdNhanVien WHERE TaiKhoan.TaiKhoan = '" + taiKhoan + "' AND TaiKhoan.MatKhau = '" + matKhau + "'"))
                    {
                        nhoMatKhau(taiKhoan, matKhau, checkBoxNhoMatKhau.Checked);
                        FormLayoutAdmin form = new FormLayoutAdmin();
                        this.Hide();
                        form.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        nhoMatKhau(taiKhoan, matKhau, checkBoxNhoMatKhau.Checked);
                        FormLayoutNhanVien form = new FormLayoutNhanVien();
                        this.Hide();
                        form.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn đăng nhập sai thông tin tài khoản và mật khẩu. \nXin vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Định hack đúng không :) \nHack hộ tao cái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            login(textBoxTaiKhoan.Text, textBoxMatKhau.Text);
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            textBoxTaiKhoan.Text = Properties.Settings.Default.TaiKhoan;
            textBoxMatKhau.Text = Properties.Settings.Default.matKhau;
            checkBoxNhoMatKhau.Checked = Properties.Settings.Default.check;
        }
    }
}
