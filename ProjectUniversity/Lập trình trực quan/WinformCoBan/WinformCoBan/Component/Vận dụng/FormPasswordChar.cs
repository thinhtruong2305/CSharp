using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformCoBan
{
    public partial class FormPasswordChar : Form
    {
        public FormPasswordChar()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            textBoxShow.Text = "<3 "+textBoxPaswordChar.Text+ " <3";
        }
    }
}
