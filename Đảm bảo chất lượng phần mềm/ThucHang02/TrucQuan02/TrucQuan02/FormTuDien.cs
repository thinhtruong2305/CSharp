using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrucQuan02
{
    public partial class FormTuDien : Form
    {
        private static int Visit_Enter = 0;
        private static int Visit_Exit = 0;

        public FormTuDien()
        {
            InitializeComponent();
        }

        private void FormTuDien_Activated(object sender, EventArgs e)
        {
            if (Visit_Enter == 0)
            {
                Visit_Enter = FormTrucQuan.Entered_TuDien;
                FormTrucQuan.Visit_Point += Visit_Enter;
                ((FormTrucQuan)this.MdiParent).TienDo_Refresh();
            }
        }
    }
}
