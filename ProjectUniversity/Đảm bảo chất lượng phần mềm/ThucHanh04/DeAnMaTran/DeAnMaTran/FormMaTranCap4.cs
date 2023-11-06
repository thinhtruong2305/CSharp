using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeAnMaTran
{
    public partial class FormMaTranCap4 : Form
    {
        private static int Visit_Enter = 0;
        private static int Calc1_Done = 0, Calc2_Done = 0, Calc3_Done = 0;

        public FormMaTranCap4()
        {
            InitializeComponent();
        }

        private void userControlMaTran_MaTranChanged(object sender, MaTranEventArgs e)
        {
            MaTranCap4 mtA, mtB;
            bool A_HopLe = UserControlMaTranCap4.TryParse(userControlMaTranA, out mtA);
            bool B_HopLe = UserControlMaTranCap4.TryParse(userControlMaTranB, out mtB);

            buttonTinhCongTruNhanChia.Enabled = A_HopLe && B_HopLe;
            buttonTinhNghichDaoA.Enabled = A_HopLe && mtA.KhaNghich();
            buttonTinhNghichDaoB.Enabled = B_HopLe && mtB.KhaNghich();
        }

        private void buttonTinhCongTruNhanChia_Click(object sender, EventArgs e)
        {
            MaTranCap4 A = UserControlMaTranCap4.Parse(userControlMaTranA);
            MaTranCap4 B = UserControlMaTranCap4.Parse(userControlMaTranB);

            MaTranCap4 Tong = A + B;
            userControlMaTranTongAB.WriteOut(Tong);

            MaTranCap4 Hieu = A - B;
            userControlMaTranHieuAB.WriteOut(Hieu);

            MaTranCap4 AB = A * B;
            userControlMaTranTichAB.WriteOut(AB);

            MaTranCap4 BA = B * A;
            userControlMaTranTichBA.WriteOut(BA);

            if (Calc1_Done == 0)
            {
                Calc1_Done = FormDeAnMaTran.Calculated_MaTranCap4 / 3;
                FormDeAnMaTran.Visit_Point += Calc1_Done;
                ((FormDeAnMaTran)this.MdiParent).TienDo_Refresh();
            }
        }

        private void buttonTinhNghichDaoA_Click(object sender, EventArgs e)
        {
            MaTranCap4 A = UserControlMaTranCap4.Parse(userControlMaTranA);
            MaTranCap4 NDA = A.NghichDao();
            userControlMaTranNghichDaoA.WriteOut(NDA);

            if (Calc2_Done == 0)
            {
                Calc2_Done = FormDeAnMaTran.Calculated_MaTranCap4 / 3;
                FormDeAnMaTran.Visit_Point += Calc2_Done;
                ((FormDeAnMaTran)this.MdiParent).TienDo_Refresh();
            }
        }

        private void buttonTinhNghichDaoB_Click(object sender, EventArgs e)
        {
            MaTranCap4 B = UserControlMaTranCap4.Parse(userControlMaTranB);
            MaTranCap4 NDB = B.NghichDao();
            userControlMaTranNghichDaoB.WriteOut(NDB);

            if (Calc3_Done == 0)
            {
                Calc3_Done = FormDeAnMaTran.Calculated_MaTranCap4 / 3;
                FormDeAnMaTran.Visit_Point += Calc3_Done;
                ((FormDeAnMaTran)this.MdiParent).TienDo_Refresh();
            }
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMaTranCap4_Activated(object sender, EventArgs e)
        {
            if (Visit_Enter == 0)
            {
                Visit_Enter = FormDeAnMaTran.Entered_MaTranCap4;
                FormDeAnMaTran.Visit_Point += Visit_Enter;
                ((FormDeAnMaTran)this.MdiParent).TienDo_Refresh();
            }
        }
    }
}
