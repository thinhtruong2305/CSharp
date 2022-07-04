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
    public partial class Admin : Form
    {

        #region Khai báo biến
        private PetshopWinformEntities db = new PetshopWinformEntities();
        #endregion

        #region Các hàm tạo
        public Admin()
        {
            InitializeComponent();
            loadData();
        }
        #endregion

        #region Các xử lý
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Account ac = new Account();
                ac.UserName = txtUsername.Text;
                ac.PassWord = txtPassword.Text;
                ac.Role = Convert.ToInt32(cbRole.Text);
                ac.DisplayName = txtDisplayname.Text;
                db.Accounts.Add(ac);
                db.SaveChanges();
                loadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn sửa", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                int maAccount = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Account ac = db.Accounts.Where(c => c.Id == maAccount).First();
                ac.UserName = txtUsername.Text;
                ac.PassWord = txtPassword.Text;
                ac.Role = Convert.ToInt32(cbRole.Text);
                ac.DisplayName = txtDisplayname.Text;
                db.SaveChanges();
                loadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure to Delete?", "EF CRUP Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Account ac = db.Accounts.Where(x => x.Id == id).First();

                IEnumerable<Oder> oder = db.Oders.Where(c => c.Account == ac.Id).ToList();

                foreach (Oder item in oder)
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
                db.Accounts.Remove(ac);
                db.SaveChanges();
                loadData();

                MessageBox.Show("Submit Successfully!");
            }

        }


        private void Admin_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        #endregion

        #region Các phương thức
        private void LoadTheme()
        {
            loadData();
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
            label5.ForeColor = ThemeColor.SecondaryColor;

        }
        public void loadData()
        {
            dataGridView1.DataSource = (from u in db.Accounts select new { id = u.Id, Name = u.DisplayName, password = u.PassWord, role = u.Role }).ToList();
        }
        #endregion
    }

}
