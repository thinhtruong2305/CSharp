using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrucQuan02
{
    public partial class FormTrucQuan : Form
    {
        public FormTrucQuan()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemDiem3D_Click(object sender, EventArgs e)
        {
            FormDiem3D frmDiem3D = new FormDiem3D();
            frmDiem3D.MdiParent = this;
            frmDiem3D.Show();
        }

        private void toolStripMenuItemTamGiac_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemVector3D_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemTuDien_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemKetThuc_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {

        }
    }
}
