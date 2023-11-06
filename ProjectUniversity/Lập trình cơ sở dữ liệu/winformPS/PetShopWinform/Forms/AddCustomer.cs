using PetShopWinform.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopWinform.Forms
{
    public partial class AddCustomer : Form
    {

        #region Khai báo biến
        PetshopWinformEntities db = new PetshopWinformEntities();
        #endregion

        #region Các hàm tạo
        public AddCustomer()
        {
            InitializeComponent();
            cbVip.DataSource = Vip.getVips().ToList();
            cbVip.DisplayMember = "vip";
            cbVip.ValueMember = "value";
        }
        #endregion

        #region Các xử lý
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                if (xacNhan("Bạn có muốn thêm") == false)
                {
                    return;
                }
                Customer customer = new Customer();
                customer.Name = txtName.Text;
                customer.Address = txtAddress.Text;
                customer.Phone = txtPhone.Text;
                customer.Vip = Convert.ToBoolean(cbVip.SelectedValue);
                db.Customers.Add(customer);
                db.SaveChanges();
                this.Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Các phương thức
        bool CheckInput()
        {
            long result;
            String phone = txtPhone.Text;
            if (txtName.Text == "")
            {
                MessageBox.Show("Enter Name, please", "Notification");
                txtName.Focus();
                return false;
            }

            if (txtAddress.Text == "")
            {
                MessageBox.Show("Enter Address, please", "Notification");
                txtAddress.Focus();
                return false;
            }

            //SL ko được nhập chữ
            if (!(long.TryParse(phone, out result)))
            {
                MessageBox.Show("Please enter the Phone in correct format", "Notification");
                txtPhone.Focus();
                return false;
            }
            return true;
        }
        public bool xacNhan(string Message)
        {
            if (MessageBox.Show(Message, "EF CRUP Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
        #endregion


    }
}
