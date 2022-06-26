using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CandyBugWinformDemo.Control;

namespace CandyBugWinformDemo.UI
{
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu", "Thông báo");
            if(result == DialogResult.OK)
            {
                if (CategoryDAO.Instence.addCategory(txtCategory.Text))
                {
                    MessageBox.Show("Bạn đã lưu thành công", "Thông báo");
                    FormCategory.ActiveForm.Close();
                }
                else
                {
                    MessageBox.Show("Bạn đã lưu thất bại", "Thông báo");
                }
            }
        }

        private void btnCancelCategory_Click(object sender, EventArgs e)
        {
            FormCategory.ActiveForm.Close();
        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {
            if (!txtCategory.Text.Equals(null))
            {
                btnCancelCategory.Enabled = true;
                btnSaveCategory.Enabled = true;
            }
        }

        private void FormNhapKhiChonOthersCuaCategory_Load(object sender, EventArgs e)
        {

        }
    }
}
