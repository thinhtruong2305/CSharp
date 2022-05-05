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
            if (txtUsername.Text == "demo" && txtPassword.Text == "123")
            {
              
                new Form2().ShowDialog();
                this.Hide();
                
                
            }
            else
            {
                MessageBox.Show("The User name or Password you is incrorrect, try again ");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
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
