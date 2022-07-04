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
    public partial class EditCustomer : Form
    {
        #region Khai báo biến
        PetshopWinformEntities db = new PetshopWinformEntities();
        Customer customer;
        #endregion

        #region Các hàm tạo
        public EditCustomer(int idCustomer )
        {
            InitializeComponent();
            this.customer = db.Customers.SingleOrDefault(c=> c.Id == idCustomer );
            cbVip.DataSource = Vip.getVips().ToList();
            cbVip.DisplayMember = "vip";
            cbVip.ValueMember = "value";
            txtId.Text = Convert.ToString(customer.Id);
            txtName.Text = customer.Name;
            txtAddress.Text = customer.Address;
            txtPhone.Text = customer.Phone;
            cbVip.SelectedValue = customer.Vip;
            
            
        }
        #endregion

        #region Các xử lý
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(txtId.Text)))
            {
                return;
            }
            if (CheckInput())
            {
                if (xacNhan("Bạn có muốn Chỉnh sửa khách hàng có Id: " + txtId.Text) == false)
                {
                    return;
                }
                int id = Convert.ToInt32(txtId.Text);
                Customer customer = db.Customers.SingleOrDefault(c => c.Id == id);
                customer.Name = txtName.Text;
                customer.Address = txtAddress.Text;
                customer.Phone = txtPhone.Text;
                customer.Vip = Convert.ToBoolean(cbVip.SelectedValue);
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
