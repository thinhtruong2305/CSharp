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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void btnThucThi_Click(object sender, EventArgs e)
        {
            tinhExpRandomEpsilon();
        }

        //Dùng để thêm số đơn trong hàm
        private void tinhExpChuyenSo()
        {
            double x = 2;
            double y = MyMath.exp(x);
            MessageBox.Show("exp(" + x.ToString() + ") = " + y.ToString(), this.Text);
        }

        private void tinhExpRandom()
        {
            double x = new Random(DateTime.Now.Millisecond).NextDouble();
            double y = MyMath.exp(x);
            MessageBox.Show("exp(" + x.ToString() + ") = " + y.ToString(), this.Text);
        }

        private void tinhExpRandomEpsilon()
        {
            double x = new Random(DateTime.Now.Millisecond).NextDouble();
            double y = MyMath.expEpsilon(x);
            MessageBox.Show("exp(" + x.ToString() + ") = " + y.ToString(), this.Text);
        }

        private void tinhExpAmDuong()
        {
            double x = new Random(DateTime.Now.Millisecond).NextDouble();
            double y = MyMath.expEpsilon(x);
            double z = MyMath.expEpsilon((-1) * x);
            double e = y * z;
            MessageBox.Show("exp(" + x.ToString() + ") = " + y.ToString(), this.Text);
        }
    }
}
