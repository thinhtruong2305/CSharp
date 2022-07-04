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
    public partial class FormLayoutNhanVien : Form
    {
        //Thuộc tính
        private Form currentForm;

        public FormLayoutNhanVien()
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

        private void FormLayoutNhanVien_Load(object sender, EventArgs e)
        {
            labelTenTeam.Text = "      BÃI GIỮ XE    " + "\n" + "  THỊNH VIỆT HÀ";
            OpenChildForm(new FormXeVao(), sender);
        }

        private void buttonXeVao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormXeVao(), sender);
        }

        private void buttonXeRa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormXeRa(), sender);
        }

        private void buttonSuCo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLayoutSuCo(), sender);
        }

        private void labelDangXuat_Click(object sender, EventArgs e)
        {
            FormDangNhap form = new FormDangNhap();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}