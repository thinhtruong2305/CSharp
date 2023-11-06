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
    public partial class EditProduct : Form
    {



        #region Khai báo biến
        int productId;
        PetshopWinformEntities db = new PetshopWinformEntities();
        #endregion

        #region Các hàm tạo
        public EditProduct(int id)
        {
            InitializeComponent();
            this.productId = id;
            cbCategory.DataSource = db.Categories.ToList();
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
            loadEdit();
        }
        #endregion

        #region Các xử lý
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                if (MessageBox.Show("Are you sure to Edit?", "EF CRUP Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtId.Text);
                    Product pr = db.Products.Where(x => x.Id == id).First();

                    pr.Name = txtName.Text.Trim();
                    pr.Category = Convert.ToInt32(cbCategory.SelectedValue);
                    pr.Quantity = Convert.ToInt32(txtQuantity.Text);
                    pr.Price = Convert.ToDecimal(txtPrice.Text);


                    db.SaveChanges();

                    MessageBox.Show("Submit Successfully!");
                    this.Close();   
                }
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
        private void loadEdit()
        {
            Product pr = db.Products.Where(x => x.Id == productId).FirstOrDefault();
            txtId.Text = pr.Id.ToString();
            txtName.Text = pr.Name;
            cbCategory.SelectedValue = pr.Category;
            txtQuantity.Text = pr.Quantity.ToString();
            txtPrice.Text = pr.Price.ToString();
        }
        #endregion

       
    }
}
