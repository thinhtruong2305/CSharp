using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShopWinform.Model;

namespace PetShopWinform.Forms
{
    public partial class Customers : Form
    {

        #region Khai báo biến
        PetshopWinformEntities db = new PetshopWinformEntities();
        #endregion

        #region Các hàm tạo
        public Customers()
        {
            InitializeComponent();
           
        }
        #endregion

        #region Các xử lý
        private void Customers_Load(object sender, EventArgs e)
        {
            LoadData();
            cbVip.DataSource = Vip.getVips().ToList();
            cbVip.DisplayMember = "vip";
            cbVip.ValueMember = "value";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
            LoadData();
        }
        private void dgvCustomerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvCustomerList.Rows[e.RowIndex].Cells[0].Value);
                Customer customer = db.Customers.First(c => c.Id == id);
                txtId.Text = Convert.ToString(customer.Id);
                txtName.Text = customer.Name;
                txtAddress.Text = customer.Address;
                txtPhone.Text = customer.Phone;
                cbVip.SelectedValue = customer.Vip;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            catch (Exception)
            {

            }

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn chỉnh sửa ?", "EF CRUP Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EditCustomer editCustomer = new EditCustomer(Convert.ToInt32(txtId.Text));
                editCustomer.ShowDialog();
                LoadData();
                Clear();
                db = new PetshopWinformEntities();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(txtId.Text)))
            {
                return;
            }
            if (xacNhan("Bạn có muốn Xóa khách hàng có Id: " + txtId.Text +"\n tên :"+txtName.Text+"\n cùng với những thứ liên quan ?") == false)
            {
                return;
            }
            int id = Convert.ToInt32(txtId.Text);
            Customer customer = db.Customers.SingleOrDefault(c => c.Id == id);
            IEnumerable<Oder> oders = db.Oders.Where(c => c.Customer == customer.Id).ToList();
            foreach (Oder item in oders)
            {
                IEnumerable<OrderInfo> orderInfos = db.OrderInfoes.Where(c => c.IdOrder == item.Id).ToList();
                foreach (OrderInfo info in orderInfos)
                {
                    db.OrderInfoes.Remove(info);
                    db.SaveChanges();
                }
                db.Oders.Remove(item);
                db.SaveChanges();
            }
            db.Customers.Remove(customer);
            db.SaveChanges();
            Clear();
            LoadData();
        }
        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadData();
            Clear();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                LoadData();
                return;
            }
            int id;
            if (Int32.TryParse(txtSearch.Text, out id))
            {
                dgvCustomerList.DataSource = (from c in db.Customers
                                              where c.Id == id
                                              select new
                                              {
                                                  Id = c.Id,
                                                  Name = c.Name,
                                                  Address = c.Address,
                                                  Phone = c.Phone,
                                                  Vip = c.Vip == true ? "Có" : "Không"
                                              }).ToList();
                return;
            }
            dgvCustomerList.DataSource = (from c in db.Customers
                                          where c.Name.Contains(txtSearch.Text)
                                          select new
                                          {
                                              Id = c.Id,
                                              Name = c.Name,
                                              Address = c.Address,
                                              Phone = c.Phone,
                                              Vip = c.Vip == true ? "Có" : "Không"
                                          }).ToList();
        }
        #endregion

        #region Các phương thức
        public void LoadData()
        {
            dgvCustomerList.DataSource = (from c in db.Customers select new { Id = c.Id, Name = c.Name, Address = c.Address, Phone = c.Phone, Vip = c.Vip == true ? "Có" : "Không" }).ToList();
        }

        void Clear()
        {
            txtId.Text = txtName.Text = txtAddress.Text = txtPhone.Text = "";
            cbVip.SelectedIndex = 0;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
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
