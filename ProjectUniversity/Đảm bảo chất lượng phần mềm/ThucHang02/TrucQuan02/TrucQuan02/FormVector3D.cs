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

namespace TrucQuan02
{
    public partial class FormVector3D : Form
    {
        private static int Visit_Enter = 0;
        private static int Visit_Exit = 0;

        public FormVector3D()
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

            Vector3D AB = new Vector3D(A, B);
            textBoxVectorABX.Text = AB.x.ToString();
            textBoxVectorABY.Text = AB.y.ToString();
            textBoxVectorABZ.Text = AB.z.ToString();

            Vector3D AC = new Vector3D(A, C);
            textBoxVectorACX.Text = AC.x.ToString();
            textBoxVectorACY.Text = AC.y.ToString();
            textBoxVectorACZ.Text = AC.z.ToString();

            Vector3D AD = new Vector3D(A, D);
            textBoxVectorADX.Text = AD.x.ToString();
            textBoxVectorADY.Text = AD.y.ToString();
            textBoxVectorADZ.Text = AD.z.ToString();

            Vector3D TCH_AB_AC = Vector3D.TichCoHuong(AB, AC);
            textBoxTichCoHuongABACX.Text = TCH_AB_AC.x.ToString();
            textBoxTichCoHuongABACY.Text = TCH_AB_AC.y.ToString();
            textBoxTichCoHuongABACZ.Text = TCH_AB_AC.z.ToString();

            double TVH_AB_AC = Vector3D.TichVoHuong(AB, AC);
            textBoxTichVoHuongABAC.Text = TVH_AB_AC.ToString();

            double THT_AB_AC_AD = Vector3D.TichHonTap(AB, AC, AD);
            textBoxTichHonTapABACAD.Text = THT_AB_AC_AD.ToString();
        }

        private void FormVector3D_Activated(object sender, EventArgs e)
        {
            if (Visit_Enter == 0)
            {
                Visit_Enter = FormTrucQuan.Entered_Vector3D;
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
            buttonTinhToan.Enabled = HopLe;
        }

        private void buttonTinhToan_Click(object sender, EventArgs e)
        {
            tinhToan();
            if (Visit_Exit == 0)
            {
                Visit_Exit = FormTrucQuan.Calculated_Vector3D;
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
