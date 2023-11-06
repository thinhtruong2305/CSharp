using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiGiuXe
{
    public partial class FormLayoutQuanLy : Form
    {
        private Form currentForm;

        public FormLayoutQuanLy()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (currentForm != null)
                currentForm.Close();
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelTrangCon.Controls.Add(childForm);
            this.panelTrangCon.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonBaiDo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBaiDo(), sender);
        }

        private void buttonNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhanVien(), sender);
        }

        private void buttonTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTaiKhoan(), sender);
        }

        private void buttonLoaiXe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLoaiXe(), sender);
        }

        private void FormLayoutQuanLy_Load(object sender, EventArgs e)
        {
            buttonBaiDo_Click(sender, e);
        }
    }
}
