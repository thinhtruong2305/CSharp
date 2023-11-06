﻿using System;
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
    public partial class FormMaTranCap3 : Form
    {
        private static int Visit_Enter = 0;
        private static int Calc1_Done = 0, Calc2_Done = 0, Calc3_Done = 0;

        public FormMaTranCap3()
        {
            InitializeComponent();
        }

        private void userControlMaTran_MaTranChanged(object sender, MaTranEventArgs e)
        {
            MaTranCap3 mtA, mtB;
            bool A_HopLe = UserControlMaTranCap3.TryParse(userControlMaTranA, out mtA);
            bool B_HopLe = UserControlMaTranCap3.TryParse(userControlMaTranB, out mtB);

            buttonTinhCongTruNhanChia.Enabled = A_HopLe && B_HopLe;
            buttonTinhNghichDaoA.Enabled = A_HopLe && mtA.KhaNghich();
            buttonTinhNghichDaoB.Enabled = B_HopLe && mtB.KhaNghich();

        }

        private void buttonTinhCongTruNhanChia_Click(object sender, EventArgs e)
        {
            MaTranCap3 A = UserControlMaTranCap3.Parse(userControlMaTranA);
            MaTranCap3 B = UserControlMaTranCap3.Parse(userControlMaTranB);

            MaTranCap3 Tong = A + B;
            userControlMaTranTongAB.WriteOut(Tong);

            MaTranCap3 Hieu = A - B;
            userControlMaTranHieuAB.WriteOut(Hieu);

            MaTranCap3 AB = A * B;
            userControlMaTranTichAB.WriteOut(AB);

            MaTranCap3 BA = B * A;
            userControlMaTranTichBA.WriteOut(BA);

            if (Calc1_Done == 0)
            {
                Calc1_Done = FormDeAnMaTran.Calculated_MaTranCap3 / 3;
                FormDeAnMaTran.Visit_Point += Calc1_Done;
                ((FormDeAnMaTran)this.MdiParent).TienDo_Refresh();
            }
        }

        private void buttonTinhNghichDaoA_Click(object sender, EventArgs e)
        {
            MaTranCap3 A = UserControlMaTranCap3.Parse(userControlMaTranA);
            MaTranCap3 NDA = A.NghichDao();
            userControlMaTranNghichDaoA.WriteOut(NDA);

            if (Calc2_Done == 0)
            {
                Calc2_Done = FormDeAnMaTran.Calculated_MaTranCap3 / 3;
                FormDeAnMaTran.Visit_Point += Calc2_Done;
                ((FormDeAnMaTran)this.MdiParent).TienDo_Refresh();
            }

        }

        private void buttonTinhNghichDaoB_Click(object sender, EventArgs e)
        {
            MaTranCap3 B = UserControlMaTranCap3.Parse(userControlMaTranB);
            MaTranCap3 NDB = B.NghichDao();
            userControlMaTranNghichDaoB.WriteOut(NDB);

            if (Calc3_Done == 0)
            {
                Calc3_Done = FormDeAnMaTran.Calculated_MaTranCap3 / 3;
                FormDeAnMaTran.Visit_Point += Calc3_Done;
                ((FormDeAnMaTran)this.MdiParent).TienDo_Refresh();
            }
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMaTranCap3_Activated(object sender, EventArgs e)
        {
            if (Visit_Enter == 0)
            {
                Visit_Enter = FormDeAnMaTran.Entered_MaTranCap3;
                FormDeAnMaTran.Visit_Point += Visit_Enter;
                ((FormDeAnMaTran)this.MdiParent).TienDo_Refresh();

            }
        }
    }
}
