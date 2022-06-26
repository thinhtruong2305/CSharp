using CandyBugWinformDemo.Control;
using CandyBugWinformDemo.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandyBugWinformDemo.NewFolder1
{
    public partial class FormProducts : Form
    {
        //dung account de phan quen product
        public Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }

        void ChangeAccount(Account acc)
        {
            
        }

        private ContextMenuStrip _contextMenuAutoFill;

        
        public FormProducts(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
            this.dataGridViewformProducts.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridViewformProducts.DefaultCellStyle.SelectionForeColor = Color.Red;
            this.dataGridViewformProducts.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            this.dataGridViewformProducts.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;
        }

       

        //
        //FUNTION CLEAR
        //
        public void ClearTxt()
        {
            txtIDProduct.Clear();
            txtItemProduct.Clear();
            dropdownCategoty.Text = " ";
            updownPrice.Text = " ";
            pictureBox1.Image = null;
        }

        //-------------------------------------------------------------//
        //FUNTION DROP DOWN LOAD BUTTON
        //
        //FUNTION LOAD CATEGORY
        //
        public void loadCategory()
        {
            _contextMenuAutoFill = new ContextMenuStrip();
            List<Category> list = CategoryDAO.Instence.getListCategory();
            foreach (Category item in list)
            {
                _contextMenuAutoFill.Items.Add(item.Name);
            }

            foreach (ToolStripMenuItem mItem in _contextMenuAutoFill.Items)
            {
                mItem.Click +=
                new System.EventHandler(this.AutoFillToolStripMenuItem_Click);
                if (mItem.Text.Equals("Others"))
                {

                }
                else
                {
                    ToolStripMenuItem remove = new ToolStripMenuItem();
                    remove.Text = "Remove";
                    remove.Click += Remove_Click;
                    remove.Tag = mItem.Text;
                    mItem.DropDownItems.Add(remove);
                }
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            string nameCate = (((sender) as ToolStripMenuItem).Tag).ToString();

        }

        //
        //
        private void dropdownCategoty_DropDown(object sender, ComponentFactory.Krypton.Toolkit.ContextPositionMenuArgs e)
        {
            dropdownCategoty.ContextMenuStrip = _contextMenuAutoFill;
            dropdownCategoty.ContextMenuStrip.Show(dropdownCategoty, new System.Drawing.Point(0, dropdownCategoty.Height));
        }
        private void AutoFillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string m = ((ToolStripMenuItem)sender).Text;
            dropdownCategoty.ContextMenuStrip.Hide();
            dropdownCategoty.Text = m;
        }

        //
        public void loadGridData()
        {
            dataGridViewformProducts.DataSource = ProductDAO.Intence.getListProduct();
        }
        //
        //----------------------------------------------------------//
        //FORM LOAD
        //
        private void FormProducts_Load(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.qLBKDataSet.Product);
            // TODO: This line of code loads data into the 'qLBKDataSet1.Product' table. You can move, or remove it, as needed.
            loadCategory();
            loadGridData();
        }
        //----------------------------------------------------------------//
        //
        //--------------------------------------------------------------//
        //CLICK ON DATAGRIDVIEW
        //
        private void dataGridViewformProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIDProduct.Text = dataGridViewformProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtItemProduct.Text = dataGridViewformProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
                dropdownCategoty.Text = dataGridViewformProducts.Rows[e.RowIndex].Cells[3].Value.ToString();
                updownPrice.Text = dataGridViewformProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (string.IsNullOrEmpty(Convert.ToString(dataGridViewformProducts.Rows[e.RowIndex].Cells[4].Value)))
                {
                    pictureBox1.Image = null;
                }
                else
                {
                    byte[] b = (byte[])dataGridViewformProducts.Rows[e.RowIndex].Cells[4].Value;
                    pictureBox1.Image = ByteArrayToImage(b);
                }
            }
            catch (Exception)
            {

            }
        }
        //---------------------------------------------------------------//
        //
        //----------------------------------------------------------------//
        //CELL CLICK IS NOT VALUE
        //

        //-------------------------------------------------------------//
        //
        //--------------------------BUTTON-----------------------------//
        //
        //CLICK ADD PRODUCT
        //
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                string name = txtItemProduct.Text;
                string idCate = CategoryDAO.Instence.getCategory(dropdownCategoty.Text);
                float price = (float)Convert.ToDouble(updownPrice.Text);
                DialogResult result = MessageBox.Show("Do you want to Add ?", "Ting Ting", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    if (testImage(pictureBox1.Image))
                    {
                        byte[] b = ImageTobyArray(pictureBox1.Image);
                        if (ProductDAO.Intence.addProduct(name, idCate, price, b))
                        {
                            MessageBox.Show("Add successfull");
                            loadGridData();
                            ClearTxt();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi", "Thông báo");
                        }
                    }
                    else
                    {
                        if (ProductDAO.Intence.addProductNonImage(name, idCate, price))
                        {
                            MessageBox.Show("Add successfull");
                            loadGridData();
                            ClearTxt();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi", "Thông báo");
                        }
                    }
                }
            }
        }
        //
        //DELETE BUTTON
        //
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {

            int idPro;
            if (Int32.TryParse(txtIDProduct.Text, out idPro))
            {
                DialogResult result = MessageBox.Show("Do you want to Delete ?", "Ting Ting", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    if (ProductDAO.Intence.removeProduct(idPro))
                    {
                        MessageBox.Show("Delete successfull");
                        loadGridData();
                        ClearTxt();
                    }
                    else
                    {
                        MessageBox.Show("Thông báo", "Lỗi");
                    }
                }
            }
            else
            {
                MessageBox.Show("Pleace choose a product", "Lỗi");
            }
        }
        //
        //UPDATE PRODUCT
        //
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                string name = txtItemProduct.Text;
                string idCate = CategoryDAO.Instence.getCategory(dropdownCategoty.Text);
                float price = (float)Convert.ToDouble(updownPrice.Text);
                int idPro = Convert.ToInt32(txtIDProduct.Text);
                DialogResult result = MessageBox.Show("Do you want to Update ?", "Ting Ting", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    if (testImage(pictureBox1.Image))
                    {
                        byte[] b = ImageTobyArray(pictureBox1.Image);
                        if (ProductDAO.Intence.updateProduct(name, idCate, price, idPro, b))
                        {
                            MessageBox.Show("Update Successfull ");
                            loadGridData();
                            ClearTxt();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi", "Thông báo");
                        }
                    }
                    else
                    {
                        if (ProductDAO.Intence.updateProductNonImage(name, idCate, price, idPro))
                        {
                            MessageBox.Show("Update Successfull ");
                            loadGridData();
                            ClearTxt();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi", "Thông báo");
                        }
                    }
                }
            }
        }
        //----------------------------------------------------------
        //---------------------CHECK INPUT VALUE--------------------//
        public bool checkInput()
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                return true;
            }
            return false;
        }

        private void txtItemProduct_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemProduct.Text))
            {
                e.Cancel = true;
                txtIDProduct.Focus();
                errorProvider.SetError(txtItemProduct, "Please enter name");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtItemProduct, null);
            }
        }

        private void updownPrice_Validating(object sender, CancelEventArgs e)
        {
            Double a;
            if (Double.TryParse(updownPrice.Text, out a) == false)
            {
                e.Cancel = true;
                updownPrice.Focus();
                errorProvider.SetError(updownPrice, "Please enter true");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(updownPrice, null);
            }
        }

        private void dropdownCategoty_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(dropdownCategoty.Text))
            {
                e.Cancel = true;
                txtIDProduct.Focus();
                errorProvider.SetError(dropdownCategoty, "Please choose a Category");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(dropdownCategoty, null);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files() | *.jpg; *.jpeg; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
            }
        }

        public byte[] ImageTobyArray(Image image)
        {
            MemoryStream m = new MemoryStream();
            image.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }

        public Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }

        public bool testImage(Image image)
        {
            if (image != null)
            {
                return true;
            }
            return false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int idPro;
            if (Int32.TryParse(txtFindProduct.Text, out idPro))
            {
                List<Product> list = ProductDAO.Intence.findProduct(idPro);
                dataGridViewformProducts.DataSource = list;
            }
            else
            {
                List<Product> list = ProductDAO.Intence.findProductByName(txtFindProduct.Text);
                dataGridViewformProducts.DataSource = list;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewformProducts.DataSource = ProductDAO.Intence.getListProduct();
            loadCategory();
        }

        public void load_FormNhapCategory()
        {
            UI.FormCategory formNhap = new UI.FormCategory();
            formNhap.Show();
        }

        //Chỉ cần đổi text button thành others sẽ kích hoạt form nhập category
        private void dropdownCategoty_TextChanged(object sender, EventArgs e)
        {
            if (dropdownCategoty.Values.Text.Equals("Others"))
            {
                load_FormNhapCategory();
            }
        }
    }
}
