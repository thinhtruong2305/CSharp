using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanhSachToiDai
{
    public partial class UserControlTitle : UserControl
    {
        public UserControlTitle()
        {
            InitializeComponent();
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        public string TitleText
        {
            set { labelTitle.Text = value; }
            get { return labelTitle.Text; }
        }
    }
}
