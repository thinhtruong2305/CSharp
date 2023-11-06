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
    public partial class FormTamGiac : Form
    {
        private static int Visit_Enter = 0;
        private static int Visit_Exit = 0;

        public FormTamGiac()
        {
            InitializeComponent();
        }

        private void tinhToan()
        {
            double ax = double.Parse(textBoxAX.Text);
            double ay = double.Parse(textBoxAY.Text);
            double az = double.Parse(textBoxAZ.Text);
            double bx = double.Parse(textBoxBX.Text);
            double by = double.Parse(textBoxBY.Text);
            double bz = double.Parse(textBoxBZ.Text);
            double cx = double.Parse(textBoxCX.Text);
            double cy = double.Parse(textBoxCY.Text);
            double cz = double.Parse(textBoxCZ.Text);
            double dx = double.Parse(textBoxDX.Text);
            double dy = double.Parse(textBoxDY.Text);
            double dz = double.Parse(textBoxDZ.Text);

            Diem3D A = new Diem3D(ax, ay, az);
            Diem3D B = new Diem3D(bx, by, bz);
            Diem3D C = new Diem3D(cx, cy, cz);
            Diem3D D = new Diem3D(dx, dy, dz);
            Diem3D G_ABC = Diem3D.TrongTam(A, B, C);

            textBoxTrongTamABCX.Text = G_ABC.x.ToString();
            textBoxTrongTamABCY.Text = G_ABC.y.ToString();
            textBoxTrongTamABCZ.Text = G_ABC.z.ToString();

            TamGiac ABC = new TamGiac(A, B, C);
            textBoxDoDaiAB.Text = ABC.AB().ToString();
            textBoxDoDaiBC.Text = ABC.BC().ToString();
            textBoxDoDaiAC.Text = ABC.AC().ToString();

            textBoxChuViABC.Text = ABC.ChuVi().ToString();
            textBoxDienTichABC.Text = ABC.DienTich().ToString();

            TamGiac ABD = new TamGiac(A, B, D);
            textBoxChuViABD.Text = ABD.ChuVi().ToString();
            textBoxDienTichABD.Text = ABD.DienTich().ToString();

            TamGiac ACD = new TamGiac(A, C, D);
            textBoxChuViACD.Text = ACD.ChuVi().ToString();
            textBoxDienTichACD.Text = ACD.DienTich().ToString();

            TamGiac BCD = new TamGiac(B, C, D);
            textBoxChuViBCD.Text = BCD.ChuVi().ToString();
            textBoxDienTichBCD.Text = BCD.DienTich().ToString();
        }

        private void FormTamGiac_Activated(object sender, EventArgs e)
        {
            if (Visit_Enter == 0)
            {
                Visit_Enter = FormTrucQuan.Entered_TamGiac;
                FormTrucQuan.Visit_Point += Visit_Enter;
                ((FormTrucQuan)this.MdiParent).TienDo_Refresh();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            double ax = 0, ay = 0, az = 0, bx = 0, by = 0, bz = 0, cx = 0, cy = 0, cz = 0, dx = 0, dy = 0, dz = 0;
            bool HopLe = double.TryParse(textBoxAX.Text, out ax)
            && double.TryParse(textBoxAY.Text, out ay)
            && double.TryParse(textBoxAZ.Text, out az)
            && double.TryParse(textBoxBX.Text, out bx)
            && double.TryParse(textBoxBY.Text, out by)
            && double.TryParse(textBoxBZ.Text, out bz)
            && double.TryParse(textBoxCX.Text, out cx)
            && double.TryParse(textBoxCY.Text, out cy)
            && double.TryParse(textBoxCZ.Text, out cz)
            && double.TryParse(textBoxDX.Text, out dx)
            && double.TryParse(textBoxDY.Text, out dy)
            && double.TryParse(textBoxDZ.Text, out dz);
            if (HopLe)
            {
                Diem3D A = new Diem3D(ax, ay, az);
                Diem3D B = new Diem3D(bx, by, bz);
                Diem3D C = new Diem3D(cx, cy, cz);
                Diem3D D = new Diem3D(dx, dy, dz);

                HopLe &= TamGiac.isTamGiac(A, B, C) & TamGiac.isTamGiac(A, B, D) & TamGiac.isTamGiac(A, C, D) & TamGiac.isTamGiac(B, C, D);
            }
            buttonTinhToan.Enabled = HopLe;
        }

        private void buttonTinhToan_Click(object sender, EventArgs e)
        {
            tinhToan();
            if (Visit_Exit == 0)
            {
                Visit_Exit = FormTrucQuan.Calculated_TamGiac;
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
