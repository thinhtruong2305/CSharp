using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib;

namespace UngDungCuaSo
{
    public partial class frmCon : Form
    {
        public frmCon()
        {
            InitializeComponent();
        }

        private void buttonTinhToan_Click(object sender, EventArgs e)
        {
            double x;
            x = double.Parse(textBoxX.Text);
            textBoxExp.Text = MyMath.exp(x).ToString();
            textBoxSin.Text = MyMath.sin(x).ToString();
            textBoxCos.Text = MyMath.cos(x).ToString();
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxX_TextChanged(object sender, EventArgs e)
        {
            double x;
            buttonTinhToan.Enabled = double.TryParse(textBoxX.Text, out x);
        }
    }
}
