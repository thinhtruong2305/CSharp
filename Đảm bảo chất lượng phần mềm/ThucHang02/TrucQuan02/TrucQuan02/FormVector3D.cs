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
    public partial class FormVector3D : Form
    {
        private static int Visit_Enter = 0;
        private static int Visit_Exit = 0;

        public FormVector3D()
        {
            InitializeComponent();
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
    }
}
