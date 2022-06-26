using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CandyBugWinformDemo.Control;
using CandyBugWinformDemo.Object;
using ComponentFactory.Krypton.Toolkit;

namespace CandyBugWinformDemo.NewFolder1
{
    public partial class FormAdmin : Form
    {

        BindingSource accountList = new BindingSource();
        public Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }




        //constructor
        public FormAdmin(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
            Load();
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Red;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;
        }

        void Load()
        {
            dataGridView1.DataSource = accountList;
            LoadAccount();
            AddAccountBinding();
        }

        void ChangeAccount(Account acc)
        {
            /*kryptonTextBox1.Text = LoginAccount.Username;
            kryptonTextBox2.Text = LoginAccount.Displayname;*/
        }

        public List<Account> SearchAccountByName(string name)
        {

            List<Account> listAccount = AccountDAO.Instance.SearchAccountByName(name);

            return listAccount;
        }

        
        void AddAccountBinding()
        {
            kryptonTextBox1.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            kryptonTextBox2.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            /*kryptonNumericUpDown1.DataBindings.Add(new Binding("Value", dataGridView1.DataSource, "Type", true, DataSourceUpdateMode.Never));*/
        }


        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }
        void AddAccount(string userName, string displayName, string passWord, int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, passWord, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }

            LoadAccount();
        }

        void EditAccount(string userName, string displayName, string passWord, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, passWord, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }

            LoadAccount();
        }

        void DeleteAccount(string userName)
        {
            
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            LoadAccount();
        }

        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
        }
        //xoa
        private void button2_Click(object sender, EventArgs e)
        {
            string userName = kryptonTextBox1.Text;

            DeleteAccount(userName);
        }

        //them 
        private void button1_Click(object sender, EventArgs e)
        {
            string userName = kryptonTextBox1.Text;
            string displayName = kryptonTextBox2.Text;
            string passWord = kryptonTextBox4.Text;
            int type = (int)kryptonNumericUpDown1.Value;

            AddAccount(userName, displayName, passWord, type);
            kryptonTextBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string userName = kryptonTextBox1.Text;
            string displayName = kryptonTextBox2.Text;
            string password = kryptonTextBox4.Text;
            int type = (int)kryptonNumericUpDown1.Value;

            EditAccount(userName, displayName, password, type);
            kryptonTextBox4.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            accountList.DataSource = SearchAccountByName(kryptonTextBox3.Text);
        }

        private void btbResetPassword_Click(object sender, EventArgs e)
        {
            string userName = kryptonTextBox1.Text;
            ResetPass(userName);
        }
    }
}
