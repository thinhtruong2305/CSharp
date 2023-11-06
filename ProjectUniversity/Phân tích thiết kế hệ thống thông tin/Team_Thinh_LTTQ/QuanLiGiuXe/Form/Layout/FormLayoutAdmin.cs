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
    public partial class FormLayoutAdmin : Form
    {
        //Thuộc tính
        private Form currentForm;

        public FormLayoutAdmin()
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

        private void FormTrangChinh_Load(object sender, EventArgs e)
        {
            labelTenTeam.Text = "      BÃI GIỮ XE     " + "\n" + "  THỊNH VIỆT HÀ";
            OpenChildForm(new FormTrangChinh(), sender);
        }

        private void buttonTrangChinh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTrangChinh(), sender);
        }

        private void buttonQuanLy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLayoutQuanLy(), sender);
        }

        private void labelTenTeam_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTrangChinh(), sender);
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTrangChinh(), sender);
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
