using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformCoBan.ThanhThaoCSharp
{
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm.FormCon frm = new ChildForm.FormCon();
            frm.MdiParent = this;
            frm.Text = "Subtitile";
            frm.Show();
        }

        private void arrangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void titleHorizalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void titleVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(sender, e);
        }
    }
}
