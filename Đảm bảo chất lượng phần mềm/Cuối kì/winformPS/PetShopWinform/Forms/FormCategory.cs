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
using PetShopWinform.Model;

namespace PetShopWinform.Forms
{
    public partial class FormCategory : Form
    {
        #region Khai báo biến
        private Category_BUS category_BUS;
        #endregion

        #region Các hàm tạo
        public FormCategory()
        {
            InitializeComponent();
            category_BUS = new Category_BUS();
        }
        #endregion

        #region Các xử lý
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!textBoxTenKho.Text.Equals(""))
            {
                if (MessageBox.Show("Bạn có muốn thêm kho này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).Equals(DialogResult.OK))
                {
                    Category category = new Category();
                    category.Name = textBoxTenKho.Text;

                    if (category_BUS.addCategory(category))
                        MessageBox.Show("Bạn đã thêm thành công", "Thông báo");
                    else
                        MessageBox.Show("Bạn đã thêm thất bại", "Thông báo");
                }
            }

            FormCategory_Load(sender, e);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!textBoxTenKho.Text.Equals("") || !textBoxMaKho.Text.Equals(""))
            {
                if (MessageBox.Show("Bạn có muốn cập nhật kho này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).Equals(DialogResult.OK))
                {
                    Category category = new Category();
                    category.Id = Convert.ToInt32(textBoxMaKho.Text);
                    category.Name = textBoxTenKho.Text;

                    if (category_BUS.editCategory(category))
                        MessageBox.Show("Bạn đã cập nhật thành công", "Thông báo");
                    else
                        MessageBox.Show("Bạn đã cập nhật thất bại", "Thông báo");
                }

                FormCategory_Load(sender, e);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!textBoxMaKho.Text.Equals(""))
            {
                if (MessageBox.Show("Bạn có muốn xóa kho này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).Equals(DialogResult.OK))
                {
                    Category category = new Category();
                    category.Id = Convert.ToInt32(textBoxMaKho.Text);

                    if (category_BUS.deleteCategory(category))
                        MessageBox.Show("Bạn đã xóa thành công", "Thông báo");
                    else
                        MessageBox.Show("Bạn đã xóa thất bại", "Thông báo");
                }
            }

            FormCategory_Load(sender, e);
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            category_BUS.truyenDanhSachCategory(dataGridViewCategory);
            dinhDangKhung();
            clearTextBox();
        }

        private void dataGridViewCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaKho.Text = dataGridViewCategory.CurrentRow.Cells[0].Value.ToString();
            textBoxTenKho.Text = dataGridViewCategory.CurrentRow.Cells[1].Value.ToString();
        }

        private void FormCategory_SizeChanged(object sender, EventArgs e)
        {
            if (dataGridViewCategory.RowCount > 0)
                dinhDangKhung();
        }
        #endregion

        #region Các phương thức
        private void dinhDangKhung()
        {
            dataGridViewCategory.Columns[0].Width = (int)(dataGridViewCategory.Width * 0.35);
            dataGridViewCategory.Columns[1].Width = (int)(dataGridViewCategory.Width * 0.5);
        }

        private void clearTextBox()
        {
            textBoxTenKho.Clear();
            textBoxMaKho.Clear();
        }
        #endregion
    }
}
