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
    public partial class AddProduct : Form
    {

        #region Khai báo biến
        PetshopWinformEntities db = new PetshopWinformEntities();
        #endregion

        #region Các hàm tạo
        public AddProduct()
        {
            InitializeComponent();
            cbCategory.DataSource = db.Categories.ToList();
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
        }
        #endregion

        #region Các xử lý
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                if (MessageBox.Show("Are you sure to Add?", "EF CRUP Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Product pr = new Product()
                    {
                        Name = txtName.Text,
                        Category = Convert.ToInt32(cbCategory.SelectedValue),
                        Quantity = Convert.ToInt32(txtQuantity.Text),
                        Price = Convert.ToDecimal(txtPrice.Text)
                    };
                    db.Products.Add(pr);
                    db.SaveChanges();
                    MessageBox.Show("Submit Successfully!");
                    this.Close();
                }

            }
        }
        #endregion

        #region Các phương thức
        
        bool CheckInput()
        {
            long result;
            String quantity = txtQuantity.Text;
            String price = txtPrice.Text;
            if (txtName.Text == "")
            {
                MessageBox.Show("Enter Name, please", "Notification");
                txtName.Focus();
                return false;
            }

            if (txtQuantity.Text == "")
            {
                MessageBox.Show("Enter Quantity, please", "Notification");
                txtQuantity.Focus();
                return false;
            }

            if (txtPrice.Text == "")
            {
                MessageBox.Show("Enter Price, please", "Notification");
                txtPrice.Focus();
                return false;
            }
            //SL ko được nhập chữ
            if (!(long.TryParse(quantity, out result)))
            {
                MessageBox.Show("Please enter the Quantity in correct format", "Notification");
                txtQuantity.Focus();
                return false;
            }
            //Số lượng ko được âm
            if (result < 0)
            {
                MessageBox.Show("Quantity cannot be negative value", "Notification");
                txtQuantity.Focus();
                return false;
            }
            //Giá tiền ko đc nhập chữ
            if (!(long.TryParse(price, out result)))
            {
                MessageBox.Show("Please enter the Price in correct format", "Notification");
                txtPrice.Focus();
                return false;
            }

            if (result < 0)
            {
                MessageBox.Show("Price cannot be negative value", "Notification");
                txtPrice.Focus();
                return false;
            }
            return true;
        }
        #endregion


    }
}
