using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;
using CandyBugWinformDemo.Control;
using CandyBugWinformDemo.Object;

namespace CandyBugWinformDemo
{
    public partial class FormLogin : KryptonForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Logincs_Load(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (Login(username, password))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(username);
                Form2 f = new Form2(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("The User name or Password you is incrorrect, try again");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
            /*if (txtUsername.Text == "demo" && txtPassword.Text == "123")
            {
                this.Hide();
                new Form2().ShowDialog();
                
                
                
            }
            else
            {
                MessageBox.Show("The User name or Password you is incrorrect, try again ");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }*/
        }

        private bool Login()
        {
            throw new NotImplementedException();
        }

        private bool Login(String username, string password)
        {
            return AccountDAO.Instance.Login(username, password);

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
