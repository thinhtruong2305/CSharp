using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformCoBan
{
    public partial class FormMẹnu : Form
    {
        public FormMẹnu()
        {
            InitializeComponent();
        }

        private void timeNewRomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Times New Roman", label1.Font.Size, label1.Font.Style);
        }

        private void tahomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Tahoma", label1.Font.Size, label1.Font.Style);
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Italic);
        }

        private void underStrikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Underline);
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Green;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void abortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abort này thấy không", "Thông báo", MessageBoxButtons.AbortRetryIgnore);
        }
    }
}
