using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeAnThapHaNoi
{
    public partial class FormThapHaNoiDonGian : Form
    {
        private static int Visit_Enter = 0;
        private static int Calc1_Done = 0, Calc2_Done = 0;

        private int SoBuoc = 0;
        private UserControlThapHaNoi[] Thap;
        private int XP = 0;
        private int ND = 2;
        private bool m_LoadXong = false;

        public FormThapHaNoiDonGian()
        {
            InitializeComponent();
        }

        private void NapThap(int n)
        {
            if (m_LoadXong)
            {
                Thap[XP].XoaSach();
                for (int i = n; i > 0; i--)
                    Thap[XP].Them(i);
            }
        }
        private void DiChuyenDia(int XP, int ND, int SoDia)
        {
            SoBuoc += 1;

            Thap[XP].Bot();
            Thap[ND].Them(SoDia);
            listBoxDiChuyen.Items.Add(SoBuoc + ". Đưa đĩa " + SoDia.ToString() + " từ tháp " + XP.ToString() + " đến tháp " + ND.ToString());
        }
        private void DiChuyenThap(int XP, int ND, int SoDia)
        {
            int TG = 3 - XP - ND;
            if (SoDia > 1)
            {
                DiChuyenThap(XP, TG, SoDia - 1);
                DiChuyenDia(XP, ND, SoDia);
                DiChuyenThap(TG, ND, SoDia - 1);
            }
            else
                DiChuyenDia(XP, ND, SoDia);
        }

        private void FormThapHaNoiDonGian_Load(object sender, EventArgs e)
        {
            Thap = new UserControlThapHaNoi[] { userControlThapHaNoi0, userControlThapHaNoi1, userControlThapHaNoi2 };
            m_LoadXong = true;
            NapThap((int)numericUpDownDoCao.Value);
        }

        private void FormThapHaNoiDonGian_Activated(object sender, EventArgs e)
        {
            if (Visit_Enter == 0)
            {
                Visit_Enter = FormDeAnThapHaNoi.Entered_DonGian;
                FormDeAnThapHaNoi.Visit_Point += Visit_Enter;
                ((FormDeAnThapHaNoi)this.MdiParent).TienDo_Refresh();
            }
        }

        private void buttonThucHien_Click(object sender, EventArgs e)
        {
            SoBuoc = 0;

            listBoxDiChuyen.Items.Clear();
            DiChuyenThap(XP, ND, (int)numericUpDownDoCao.Value);

            int TG = 3 - XP - ND;
            XP = ND;
            ND = TG;
            buttonThucHien.Text = "Thực hiện " + XP.ToString() + " -> " + ND.ToString();

            if (Calc2_Done == 0)
            {
                Calc2_Done = FormDeAnThapHaNoi.Calculated_DonGian / 2;
                FormDeAnThapHaNoi.Visit_Point += Calc2_Done;
                ((FormDeAnThapHaNoi)this.MdiParent).TienDo_Refresh();
            }
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDownDoCao_ValueChanged(object sender, EventArgs e)
        {
            NapThap((int)numericUpDownDoCao.Value);
            if (Calc1_Done == 0)
            {
                Calc1_Done = FormDeAnThapHaNoi.Calculated_DonGian / 2;
                FormDeAnThapHaNoi.Visit_Point += Calc1_Done;
                ((FormDeAnThapHaNoi)this.MdiParent).TienDo_Refresh();
            }
        }
    }
}
