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
    public partial class FormDiem3D : Form
    {
        private static int Visit_Enter = 0;
        private static int Visit_Exit = 0;

        public FormDiem3D()
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

            Diem3D I = Diem3D.TrungDiem(A, B);
            Diem3D G = Diem3D.TrongTam(A, B, C);
            Diem3D TTTD = Diem3D.TrongTam(new Diem3D[] { A, B, C, D });

            textBoxTrungDiemABX.Text = I.x.ToString();
            textBoxTrungDiemABY.Text = I.y.ToString();
            textBoxTrungDiemABZ.Text = I.z.ToString();

            textBoxTrongTamABCX.Text = G.x.ToString();
            textBoxTrongTamABCY.Text = G.y.ToString();
            textBoxTrongTamABCZ.Text = G.z.ToString();

            textBoxTrongTamABCDX.Text = TTTD.x.ToString();
            textBoxTrongTamABCDY.Text = TTTD.y.ToString();
            textBoxTrongTamABCDZ.Text = TTTD.z.ToString();
        }

        private void FormDiem3D_Activated(object sender, EventArgs e)
        {
            if (Visit_Enter == 0)
            {
                Visit_Enter = FormTrucQuan.Entered_Diem3D;
                FormTrucQuan.Visit_Point += Visit_Enter;
                ((FormTrucQuan)this.MdiParent).TienDo_Refresh();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            double ax, ay, az, bx, by, bz, cx, cy, cz, dx, dy, dz;
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
                Visit_Exit = FormTrucQuan.Calculated_Diem3D;
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
