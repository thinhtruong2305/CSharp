using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrucQuan03
{
    public partial class FormTrucQuan : Form
    {
        public const int Entered_Diem3D = 10;
        public const int Calculated_Diem3D = 10;

        public const int Entered_TamGiac = 10;
        public const int Calculated_TamGiac = 10;

        public const int Entered_Vector3D = 10;
        public const int Calculated_Vector3D = 10;

        //Phục vụ bản 1.0
        /*public const int Entered_TuDien = 10;
        public const int Calculated_TuDien = 10;*/

        public const int Entered_TuDien = 5;
        public const int Calculated_TuDien = 5;

        public const int Entered_MatPhang = 5;
        public const int Calculated_MatPhang = 5;

        public const int Entered_HePTTT = 5;
        public const int Calculated_HePTTT = 5;

        //Phục vụ bản 1.0
        /*public const int Entered_About = 10;
        public const int Closed_About = 10;*/

        public const int Entered_About = 5;
        public const int Closed_About = 5;

        public static int Visit_Point = 0;

        public FormTrucQuan()
        {
            InitializeComponent();
        }

        public void TienDo_Refresh()
        {
            toolStripProgressBarTienDo.Value = Visit_Point;
        }

        public Form FormExist(string FormName)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.Name == FormName)
                    return frm;
            }
            return null;
        }
        private void toolStripMenuItemDiem3D_Click(object sender, EventArgs e)
        {
            FormDiem3D frm = (FormDiem3D)FormExist("FormDiem3D");
            if (frm == null)
            {
                frm = new FormDiem3D();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Activate();
        }

        private void toolStripMenuItemTamGiac_Click(object sender, EventArgs e)
        {
            FormTamGiac frm = (FormTamGiac)FormExist("FormTamGiac");
            if (frm == null)
            {
                frm = new FormTamGiac();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Activate();
        }

        private void toolStripMenuItemVector3D_Click(object sender, EventArgs e)
        {
            FormVector3D frm = (FormVector3D)FormExist("FormVector3D");
            if (frm == null)
            {
                frm = new FormVector3D();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Activate();
        }

        private void toolStripMenuItemTuDien_Click(object sender, EventArgs e)
        {
            FormTuDien frm = (FormTuDien)FormExist("FormTuDien");
            if (frm == null)
            {
                frm = new FormTuDien();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Activate();
        }

        private void toolStripMenuItemKetThuc_Click(object sender, EventArgs e)
        {
            if (Visit_Point >= 100)
                MessageBox.Show("Bạn đã học được cách thử nghiệm hộp đen,\n"
                + "cách triển khai TopDown,\n"
                + "cách nâng cấp phiên bản\n"
                + "và cách thêm chức năng vào thư viện đang có sẵn", this.Text);

            Application.Exit();
        }

        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
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

        private void toolStripMenuItemMatPhang_Click(object sender, EventArgs e)
        {
            FormMatPhang frm = (FormMatPhang)FormExist("FormAbout");
            if (frm == null)
            {
                frm = new FormMatPhang();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Activate();
        }

        private void toolStripMenuItemHePTTT_Click(object sender, EventArgs e)
        {
            FormHePTTT frm = (FormHePTTT)FormExist("FormAbout");
            if (frm == null)
            {
                frm = new FormHePTTT();
                frm.MdiParent = this;
                frm.Show();
            }
            frm.Activate();
        }
    }
}
