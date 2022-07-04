using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShopWinform.Model;

namespace PetShopWinform.Forms
{
    public partial class Billing : Form
    {

        #region Khai báo biến

        PetshopWinformEntities db = new PetshopWinformEntities();
        List<ItemOrder> ItemOrders = new List<ItemOrder>();
        Account account;
        #endregion

        #region Các hàm tạo
        public Billing(Account account)
        {
            InitializeComponent();
            this.account = account;
            txtIdAcc.Text = Convert.ToString(account.Id);
            txtNameAcc.Text = account.DisplayName;
            txtRole.Text = account.Role == 1 ? "Admin" : "Employee";
        }
        public Billing()
        {
            InitializeComponent();
            this.account = db.Accounts.First();
            txtIdAcc.Text = account.Id.ToString();
            txtNameAcc.Text = account.DisplayName;
            txtRole.Text = account.Role == 1 ? "Admin" : "Employee";
        }
        #endregion

        #region Các xử lý
        private void Billing_Load(object sender, EventArgs e)
        {
            LoadTheme();
            LoadData();
            LoadProduct();
        }
        private void cbCustom_TextChanged(object sender, EventArgs e)
        {
            int id;
            if (Int32.TryParse(cbCustom.Text, out id) == false)
            {
                txtNameCus.Text = "";
                txtAddress.Text = "";
                txtPhone.Text = "";
                lbDiscount.Text = "0.0";
                sumToTal();
                return;
            }
            Customer customer = db.Customers.SingleOrDefault(c => c.Id == id);
            if (customer != null)
            {
                txtNameCus.Text = customer.Name;
                txtAddress.Text = customer.Address;
                txtPhone.Text = customer.Phone;
                lbDiscount.Text = customer.Vip == true ? "20%" : "0.0";
                sumToTal();
            }
            else
            {
                txtNameCus.Text = "";
                txtAddress.Text = "";
                txtPhone.Text = "";
                lbDiscount.Text = customer.Vip == true ? "20%" : "0.0";
                sumToTal();
            }

        }

        private void cbCate_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        public void addProductTab(IEnumerable<Product> list)
        {
            tabPage1.Controls.Clear();
            FlowLayoutPanel flow = new FlowLayoutPanel() { Width = 700, Height = 550 };
            foreach (Product itemPro in list)
            {
                Button btn = new Button() { Width = 100, Height = 100 };
                Label lbName = new Label();
                lbName.Text = itemPro.Name;
                lbName.Location = new Point(2, 2);
                lbName.BackColor = Color.FromArgb(255, 224, 192);
                lbName.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                lbName.MaximumSize = btn.Size;
                lbName.ForeColor = Color.Black;
                lbName.AutoSize = true;
                Label lbPrice = new Label();
                lbPrice.Text = itemPro.Price.ToString() + " ₫";
                lbPrice.Location = new Point(2, 75);
                lbPrice.ForeColor = Color.FromArgb(192, 64, 0);
                lbPrice.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
                lbPrice.BackColor = Color.LightGray;
                lbPrice.AutoSize = true;
                btn.Controls.Add(lbName);
                btn.Controls.Add(lbPrice);
                btn.Font = new Font(Font.FontFamily, 16);
                btn.Tag = itemPro;
                btn.Click += Btn_Click;
                flow.Controls.Add(btn);
            }
            tabPage1.Controls.Add(flow);
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Product itemPro = (((sender) as Button).Tag) as Product;
            txtIdPro.Text = itemPro.Id.ToString();
            txtPro.Text = itemPro.Name;
            txtPrice.Text = itemPro.Price.ToString();
            lbtal.Text = (Convert.ToDecimal(txtPrice.Text) * Convert.ToInt32(PriceUp.Value)).ToString("#,##") + " ₫";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(txtSearch.Text)))
            {
                LoadProduct();
                return;
            }
            IEnumerable<Product> products = db.Products.Where(c => c.Name.Contains(txtSearch.Text)).ToList();
            addProductTab(products);
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdPro.Text))
            {
                return;
            }
            ItemOrder temp = new ItemOrder(txtPro.Text, Convert.ToDecimal(txtPrice.Text), Convert.ToInt32(PriceUp.Value), Convert.ToInt32(txtIdPro.Text));
            Product product = db.Products.SingleOrDefault(c => c.Id == temp.IdProduct);
            if (Convert.ToInt32(PriceUp.Value) > product.Quantity)
            {
                MessageBox.Show("Hết hàng số lượng còn lại : " + product.Quantity, "EF CRUP Operation", MessageBoxButtons.OK);
                return;
            }
            bool containItem = ItemOrders.Any(c => c.IdProduct == temp.IdProduct);
            if (containItem == false)
            {
                ItemOrders.Add(temp);
                ClearData();
                showData();
            }
            else
            {
                ItemOrders.SingleOrDefault(c => c.IdProduct == temp.IdProduct).Quantity = Convert.ToInt32(PriceUp.Value);
                ClearData();
                showData();
            }

        }
        private void PriceUp_ValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                lbtal.Text = "Total";
                return;
            }
            lbtal.Text = (Convert.ToDecimal(txtPrice.Text) * Convert.ToInt32(PriceUp.Value)).ToString("#,##") + " đ";
        }

        private void dgvCurrentOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvCurrentOrder.Rows[e.RowIndex].Cells[4].Value);
                ItemOrder itemOrder = ItemOrders.SingleOrDefault(c => c.IdProduct == id);
                txtIdPro.Text = itemOrder.IdProduct.ToString();
                txtPro.Text = itemOrder.Name;
                txtPrice.Text = itemOrder.Price.ToString();
                PriceUp.Value = itemOrder.Quantity;
                lbtal.Text = (Convert.ToDecimal(txtPrice.Text) * Convert.ToInt32(PriceUp.Value)).ToString("#,##") + " ₫";
            }
            catch (Exception)
            {

            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ItemOrders.Clear();
            ClearData();
            showData();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdPro.Text))
            {
                return;
            }
            int id = Convert.ToInt32(txtIdPro.Text);
            ItemOrder item = ItemOrders.SingleOrDefault(c => c.IdProduct == id);
            ItemOrders.Remove(item);
            ClearData();
            showData();
        }

        private void btnSa_Click(object sender, EventArgs e)
        {
            if (ItemOrders.Count() <= 0)
            {
                return;
            }
            try
            {
                Oder oder = new Oder();
                oder.Account = Convert.ToInt32(txtIdAcc.Text);
                int idCus = Convert.ToInt32(cbCustom.SelectedValue);
                if (string.IsNullOrEmpty(cbCustom.Text) == false && db.Customers.SingleOrDefault(c => c.Id == idCus) != null)
                {
                    oder.Customer = idCus;
                }
                oder.DateCreate = DateTime.Now;
                oder.Status = "CHƯA DUYỆT";
                db.Oders.Add(oder);
                db.SaveChanges();
                foreach (ItemOrder item in ItemOrders)
                {
                    OrderInfo orderInfo = new OrderInfo();
                    orderInfo.IdOrder = oder.Id;
                    orderInfo.IdProduct = item.IdProduct;
                    orderInfo.Quantity = item.Quantity;
                    if (lbDiscount.Text.Equals("20%"))
                    {
                        orderInfo.Total = Convert.ToDouble(item.Total) - (Convert.ToDouble(item.Total) * 20 / 100);
                    }
                    else
                    {
                        orderInfo.Total = Convert.ToDouble(item.Total);
                    }
                    db.OrderInfoes.Add(orderInfo);
                    db.SaveChanges();
                }
                MessageBox.Show("Thanh toán hóa đơn thành công", "Thông báo", MessageBoxButtons.OK);
                ItemOrders.Clear();
                showData();
                ClearData();
            }
            catch (DbEntityValidationException)
            {
                Console.WriteLine(e);
            }
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            if (ItemOrders.Count() <= 0)
            {
                return;
            }
            decimal toTal;
            if (lbDiscount.Text.Equals("20%"))
            {
                toTal = ItemOrders.Sum(c => c.Total) - (ItemOrders.Sum(c => c.Total) * 20 / 100);
                using (Bill bill = new Bill(ItemOrders, txtNameCus.Text, txtPhone.Text, txtAddress.Text, DateTime.Now, toTal.ToString("#,##") + " ₫", "20%"))
                {
                    bill.ShowDialog();
                }
            }
            else
            {
                toTal = ItemOrders.Sum(c => c.Total);
                using (Bill bill = new Bill(ItemOrders, txtNameCus.Text, txtPhone.Text, txtAddress.Text, DateTime.Now, toTal.ToString("#,##") + " ₫"))
                {
                    bill.ShowDialog();
                }
            }

        }
        #endregion

        #region Các phương thức
        private void ClearData()
        {
            txtIdPro.Text = "";
            txtPro.Text = "";
            txtPrice.Text = "";
            PriceUp.Value = 1;
            lbtal.Text = "Total";
        }
        private void showData()
        {
            var binding = new BindingSource();
            binding.DataSource = ItemOrders;
            dgvCurrentOrder.DataSource = binding;
            sumToTal();
        }
        private void sumToTal()
        {
            if (ItemOrders != null)
            {
                if (lbDiscount.Text.Equals("20%"))
                {
                    decimal total = ItemOrders.Sum(c => c.Total) - (ItemOrders.Sum(c => c.Total) * 20 / 100);
                    lbtotal1.Text = total.ToString("#,##") + " ₫";
                    return;
                }
                lbtotal1.Text = ItemOrders.Sum(c => c.Total).ToString("#,##") + " ₫";
                return;
            }
            lbtotal1.Text = "0.0";
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label21.ForeColor = ThemeColor.SecondaryColor;

        }

        public void LoadData()
        {
            cbCustom.DataSource = db.Customers.ToList();
            cbCustom.DisplayMember = "Id";
            cbCustom.ValueMember = "Id";
            cbCate.DataSource = db.Categories.ToList();
            cbCate.DisplayMember = "Name";
            cbCate.ValueMember = "Id";
        }
        public void LoadProduct()
        {
            tabPage1.Text = cbCate.Text;
            int idCate;
            Int32.TryParse(cbCate.SelectedValue.ToString(), out idCate);
            IEnumerable<Product> products = db.Products.Where(c => c.Category == idCate).ToList();
            addProductTab(products);
        }
        #endregion

    }
}
