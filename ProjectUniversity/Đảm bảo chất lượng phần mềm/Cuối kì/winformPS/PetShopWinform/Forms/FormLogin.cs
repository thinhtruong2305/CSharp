using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShopWinform.BUS;
using PetShopWinform.DAO;
using PetShopWinform.Model;

namespace PetShopWinform
{
    public partial class FormLogin : Form
    {

        #region Khai báo biến
        private PetshopWinformEntities DBPetShop = new PetshopWinformEntities();
        #endregion

        #region Các hàm tạo
        public FormLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region Các xử lý
        private void labelClearAll_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            Login(username, password);
            txtPassword.Clear();
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
        #endregion

        #region Các phương thức
        private void Login(String username, string password)
        {
            /*var accCount = DBPetShop.Accounts.Where(a => a.UserName == username && a.PassWord == password).Count();
            if (accCount > 0)
            {
                FormMainMenu f = new FormMainMenu();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("The User name or Password you is incrorrect, try again");
            }*/

            Account acc = DBPetShop.Accounts.SingleOrDefault(a => a.UserName.Equals(username) && a.PassWord == password);
            if (acc != null)
            {

                FormMainMenu f = new FormMainMenu(acc);
                this.Hide();
                f.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("The User name or Password you is incrorrect, try again");
            }
        }


        #endregion


    }
}
