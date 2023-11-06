using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToanHoc;

namespace TrucQuan03
{
    public partial class FormHePTTT : Form
    {
        private static int Visit_Enter = 0;
        private static int Visit_Exit = 0;

        public FormHePTTT()
        {
            InitializeComponent();
        }

        private void testHePTTT()
        {
            double abc_a = double.Parse(textBoxABC_A.Text);
            double abc_b = double.Parse(textBoxABC_B.Text);
            double abc_c = double.Parse(textBoxABC_C.Text);
            double abc_d = double.Parse(textBoxABC_D.Text);

            double abd_a = double.Parse(textBoxABD_A.Text);
            double abd_b = double.Parse(textBoxABD_B.Text);
            double abd_c = double.Parse(textBoxABD_C.Text);
            double abd_d = double.Parse(textBoxABD_D.Text);

            double acd_a = double.Parse(textBoxACD_A.Text);
            double acd_b = double.Parse(textBoxACD_B.Text);
            double acd_c = double.Parse(textBoxACD_C.Text);
            double acd_d = double.Parse(textBoxACD_D.Text);

            double bcd_a = double.Parse(textBoxBCD_A.Text);
            double bcd_b = double.Parse(textBoxBCD_B.Text);
            double bcd_c = double.Parse(textBoxBCD_C.Text);
            double bcd_d = double.Parse(textBoxBCD_D.Text);

            MatPhang ABC = new MatPhang(abc_a, abc_b, abc_c, abc_d);
            MatPhang ABD = new MatPhang(abd_a, abd_b, abd_c, abd_d);
            MatPhang ACD = new MatPhang(acd_a, acd_b, acd_c, acd_d);
            MatPhang BCD = new MatPhang(bcd_a, bcd_b, bcd_c, bcd_d);

            string s = "";

            HePTTT heA = new HePTTT(ABC, ABD, ACD);
            HePTTT heB = new HePTTT(ABC, ABD, BCD);
            HePTTT heC = new HePTTT(ABC, ACD, BCD);
            HePTTT heD = new HePTTT(ABD, ACD, BCD);

            bool kq1 = heA.CoLoiGiai();
            bool kq2 = heB.CoLoiGiai();
            bool kq3 = heC.CoLoiGiai();
            bool kq4 = heD.CoLoiGiai();

            bool CoLoiGiai = kq1 && kq2 & kq3 && kq4;
            if (kq1)
            {
                Diem3D A = heA.LoiGiai();
                textBoxAX.Text = A.x.ToString();
                textBoxAY.Text = A.y.ToString();
                textBoxAZ.Text = A.z.ToString();
            }
            else
                textBoxAX.Text = textBoxAY.Text = textBoxAZ.Text = "";
            if (kq2)
            {
                Diem3D B = heB.LoiGiai();
                textBoxBX.Text = B.x.ToString();
                textBoxBY.Text = B.y.ToString();
                textBoxBZ.Text = B.z.ToString();
            }
            else
                textBoxBX.Text = textBoxBY.Text = textBoxBZ.Text = "";
            if (kq3)
            {
                Diem3D C = heC.LoiGiai();
                textBoxCX.Text = C.x.ToString();
                textBoxCY.Text = C.y.ToString();
                textBoxCZ.Text = C.z.ToString();
            }
            else
                textBoxCX.Text = textBoxCY.Text = textBoxCZ.Text = "";
            if (kq4)
            {
                Diem3D D = heD.LoiGiai();
                textBoxDX.Text = D.x.ToString();
                textBoxDY.Text = D.y.ToString();
                textBoxDZ.Text = D.z.ToString();
            }
            else
                textBoxDX.Text = textBoxDY.Text = textBoxDZ.Text = "";
            if (CoLoiGiai)
            {
                s += "Đã giải được 4 đỉnh A, B, C, D";
            }
            else
            {
                s += "Không thể giải đầy đủ các đỉnh A, B, C, D được";
            }
            MessageBox.Show(s, this.Text);
        }

        private void FormHePTTT_Activated(object sender, EventArgs e)
        {
            if (Visit_Enter == 0)
            {
                Visit_Enter = FormTrucQuan.Entered_MatPhang;
                FormTrucQuan.Visit_Point += Visit_Enter;
                ((FormTrucQuan)this.MdiParent).TienDo_Refresh();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            double abc_a = 0, abc_b = 0, abc_c = 0, abc_d = 0,
            abd_a = 0, abd_b = 0, abd_c = 0, abd_d = 0,
            acd_a = 0, acd_b = 0, acd_c = 0, acd_d = 0,
            bcd_a = 0, bcd_b = 0, bcd_c = 0, bcd_d = 0;

            bool HopLe = double.TryParse(textBoxABC_A.Text, out abc_a)
            && double.TryParse(textBoxABC_B.Text, out abc_b)
            && double.TryParse(textBoxABC_C.Text, out abc_c)
            && double.TryParse(textBoxABC_D.Text, out abc_d)
            && double.TryParse(textBoxABD_A.Text, out abd_a)
            && double.TryParse(textBoxABD_B.Text, out abd_b)
            && double.TryParse(textBoxABD_C.Text, out abd_c)
            && double.TryParse(textBoxABD_D.Text, out abd_d)
            && double.TryParse(textBoxACD_A.Text, out acd_a)
            && double.TryParse(textBoxACD_B.Text, out acd_b)
            && double.TryParse(textBoxACD_C.Text, out acd_c)
            && double.TryParse(textBoxACD_D.Text, out acd_d)
            && double.TryParse(textBoxBCD_A.Text, out bcd_a)
            && double.TryParse(textBoxBCD_B.Text, out bcd_b)
            && double.TryParse(textBoxBCD_C.Text, out bcd_c)
            && double.TryParse(textBoxBCD_D.Text, out bcd_d);

            if (HopLe)
            {
                HopLe &= MatPhang.LaMatPhang(abc_a, abc_b, abc_c, abc_d);
                HopLe &= MatPhang.LaMatPhang(abd_a, abd_b, abc_c, abc_d);
                HopLe &= MatPhang.LaMatPhang(acd_a, acd_b, acd_c, acd_d);
                HopLe &= MatPhang.LaMatPhang(bcd_a, bcd_b, bcd_c, bcd_d);
            }

            buttonTinhToan.Enabled = HopLe;
        }

        private void buttonTinhToan_Click(object sender, EventArgs e)
        {
            testHePTTT();
            if (Visit_Exit == 0)
            {
                Visit_Exit = FormTrucQuan.Calculated_HePTTT;
                FormTrucQuan.Visit_Point += Visit_Exit;
                ((FormTrucQuan)this.MdiParent).TienDo_Refresh();
            }
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
