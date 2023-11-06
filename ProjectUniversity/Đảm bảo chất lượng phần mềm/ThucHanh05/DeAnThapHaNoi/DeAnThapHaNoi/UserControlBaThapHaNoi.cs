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
    public partial class UserControlBaThapHaNoi : UserControl
    {
        const int CellHeight = 20;
        const int UnitWidth = 10;
        const int SoThapToiDa = 3;
        private List<UserControlThapHaNoi> uc_Thap_list;

        public UserControlBaThapHaNoi()
        {
            InitializeComponent();
            uc_Thap_list = new List<UserControlThapHaNoi>() { userControlThapHaNoi0, userControlThapHaNoi1, userControlThapHaNoi2 };
        }

        public void XoaSach()
        {
            for (int i = 0; i < SoThapToiDa; i++)
            {
                uc_Thap_list[i].XoaSach();
            }
        }
        public void Them(int soThap, int a)
        {
            uc_Thap_list[soThap].Them(a);
        }
        public void Bot(int soThap)
        {
            uc_Thap_list[soThap].Bot();
        }

        private void UserControlBaThapHaNoi_Paint(object sender, PaintEventArgs e)
        {
            for (int SoThap = 0; SoThap < SoThapToiDa; SoThap++)
                uc_Thap_list[SoThap].Refresh();
            Application.DoEvents();
        }
    }
}
