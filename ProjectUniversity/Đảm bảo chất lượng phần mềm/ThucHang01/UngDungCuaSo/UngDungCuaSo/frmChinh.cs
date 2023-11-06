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
            tinhSinCos();
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

        private void tinhExpEpsilonAmDuong()
        {
            double x = new Random(DateTime.Now.Millisecond).NextDouble();
            double y = MyMath.expEpsilon(x);
            double z = MyMath.expEpsilon((-1) * x);
            double e = y * z;
            String str = "exp(" + x.ToString() + ") = " + y.ToString() + "\n" 
                + "exp(- " + x.ToString() + ") = " + z.ToString() + "\n"
                + "exp(" + x.ToString() + ") exp(- " + x.ToString() + ") = " + e.ToString();
            Console.WriteLine("exp(" + x.ToString() + ") exp(- " + x.ToString() + ") = " + e.ToString());
            MessageBox.Show(str, this.Text);
        }

        private void tinhSinCos()
        {
            double x = new Random(DateTime.Now.Millisecond).NextDouble();
            double y1 = MyMath.sin(x);
            double y2 = MyMath.cos(x);

            //Phần này hiển thị từng kết quả của sin cos
            /*MessageBox.Show("sin(" + x.ToString() + ")=" + y1.ToString(), this.Text);
            MessageBox.Show("cos(" + x.ToString() + ")=" + y2.ToString(), this.Text);*/

            //Phần này hiển thị sin cos và sin^2 + cos^2
            /*string s = "";
            s += string.Format("sin({0})={1}\n", x, y1);
            s += string.Format("cos({0})={1}\n", x, y2);
            s += string.Format("[sin({0})]^2+[cos({0})]^2={1}", x, y1 * y1 + y2 * y2);
            Console.WriteLine("[sin({0})]^2+[cos({0})]^2={1}", x, y1 * y1 + y2 * y2);
            MessageBox.Show(s, this.Text);*/

            //Phần này hiển thị sin cos x, -x, pi - x
            string s = "";
            s += "sin(" + x.ToString() + ")=" + y1.ToString() + "\n";
            s += "cos(" + x.ToString() + ")=" + y2.ToString() + "\n";
            s += string.Format("sin({0})={1}\n", -x, MyMath.sin(-x));
            s += string.Format("sin({0})={1}\n", Math.PI - x, MyMath.sin(Math.PI - x));
            s += string.Format("cos({0})={1}\n", -x, MyMath.cos(-x));
            s += string.Format("cos({0})={1}\n", Math.PI - x, MyMath.cos(Math.PI - x));
            MessageBox.Show(s, this.Text);
        }

        private void buttonGoiFormCon_Click(object sender, EventArgs e)
        {
            frmCon form = new frmCon();
            form.Show();
        }
    }
}
