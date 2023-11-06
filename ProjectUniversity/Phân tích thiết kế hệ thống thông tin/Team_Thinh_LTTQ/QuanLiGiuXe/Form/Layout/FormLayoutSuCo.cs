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
    public partial class FormLayoutSuCo : Form
    {
        private Form currentForm;

        public FormLayoutSuCo()
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

        private void buttonMucKiemTra_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormKiemTra(), sender);
        }

        private void buttonMucBienBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLapBienBan(), sender);
        }

        private void buttonMucBoiThuong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLapPhieuBoiThuong(), sender);
        }

        private void FormLayoutSuCo_Load(object sender, EventArgs e)
        {
            buttonMucKiemTra_Click(sender, e);
        }
    }
}
