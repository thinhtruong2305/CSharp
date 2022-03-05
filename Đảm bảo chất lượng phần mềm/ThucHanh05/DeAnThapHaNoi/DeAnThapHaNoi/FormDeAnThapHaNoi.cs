using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeAnThapHaNoi
{
    public partial class FormDeAnThapHaNoi : Form
    {
        public const int Entered_DonGian = 10;
        public const int Calculated_DonGian = 20;

        public const int Entered_NangCao = 10;
        public const int Calculated_NangCao = 40;

        public const int Entered_About = 10;
        public const int Closed_About = 10;

        public static int Visit_Point = 0;

        public FormDeAnThapHaNoi()
        {
            InitializeComponent();
        }

        public Form FormExist(string formName)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.Name == formName)
                    return frm;
            }
            return null;
        }

        public void TienDo_Refresh()
        {
            toolStripProgressBarTienDo.Value = Visit_Point;
        }

        private void toolStripMenuItemDonGian_Click(object sender, EventArgs e)
        {
            FormThapHaNoiDonGian frm = (FormThapHaNoiDonGian)FormExist("FormThapHaNoiDonGian");
            if (frm == null)
            {
                frm = new FormThapHaNoiDonGian();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Activate();
        }

        private void toolStripMenuItemNangCao_Click(object sender, EventArgs e)
        {
            FormThapHaNoiNangCao frm = (FormThapHaNoiNangCao)FormExist("FormThapHaNoiNangCao");
            if (frm == null)
            {
                frm = new FormThapHaNoiNangCao();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Activate();
            frm.BringToFront();
        }

        private void toolStripMenuItemThongTin_Click(object sender, EventArgs e)
        {
            FormAbout frm = (FormAbout)FormExist("FormAbout");
            if (frm == null)
            {
                frm = new FormAbout();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Activate();
        }

        private void toolStripMenuItemKetThuc_Click(object sender, EventArgs e)
        {
            if(Visit_Point >= 100)
            {
                MessageBox.Show("Bạn đã hoàn tất toàn bộ yêu cầu của đề án Tháp Hà Nội\n"
                + "- Tháp Hà Nội đơn giản\n"
                + "- Thap Hà Nội nâng cao\n"
                + "Ngoài ra, bạn đã biết cách phát triển chương trình theo dạng xoắn ốc,\n"
                + "cách lập trình hướng đối tượng.\n"
                + "Đặc biệt, bạn đã thuần thục cách sử dụng danh sách.",
                this.Text);
            }
            Application.Exit();
        }
    }
}
