using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeAnMaTran
{
    public partial class FormDeAnMaTran : Form
    {
        public const int Entered_MaTranCap2 = 10;
        public const int Calculated_MaTranCap2 = 15;

        public const int Entered_MaTranCap3 = 10;
        public const int Calculated_MaTranCap3 = 15;

        public const int Entered_MaTranCap4 = 10;
        public const int Calculated_MaTranCap4 = 15;

        public const int Entered_About = 10;
        public const int Closed_About = 15;

        public static int Visit_Point = 0;

        public FormDeAnMaTran()
        {
            InitializeComponent();
        }

        public void TienDo_Refresh()
        {
            toolStripProgressBarTienDo.Value = Visit_Point;
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

        private void toolStripMenuItemMaTranCap2_Click(object sender, EventArgs e)
        {
            FormMaTranCap2 frm = (FormMaTranCap2)FormExist("FormMaTranCap2");
            if (frm == null)
            {
                frm = new FormMaTranCap2();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Activate();
        }

        private void toolStripMenuItemMaTranCap3_Click(object sender, EventArgs e)
        {
            FormMaTranCap3 frm = (FormMaTranCap3)FormExist("FormMaTranCap3");
            if (frm == null)
            {
                frm = new FormMaTranCap3();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Activate();
        }

        private void toolStripMenuItemMaTranCap4_Click(object sender, EventArgs e)
        {
            FormMaTranCap4 frm = (FormMaTranCap4)FormExist("FormMaTranCap4");
            if (frm == null)
            {
                frm = new FormMaTranCap4();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Activate();
        }

        private void toolStripMenuItemKetThuc_Click(object sender, EventArgs e)
        {
            if (Visit_Point >= 100)
                MessageBox.Show("Bạn đã học được cách sử dụng User Control,\n"
                + "thừa kế, và danh sách.\n"
                + "Đồng thời, bạn đã phối hợp hai phương pháp Top-Down và Bottom-Up.\n"
                + "Bạn đã hoàn thành bài thực hành Đề án Ma trận."
                , this.Text);
            Application.Exit();
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
    }
}
