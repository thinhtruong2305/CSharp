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
    public partial class FormCheckBoxAndRadioButton : Form
    {
        public FormCheckBoxAndRadioButton()
        {
            InitializeComponent();
        }

        private void checkBoxItalic_CheckedChanged(object sender, EventArgs e)
        {
            labelShow.Font = new Font(labelShow.Font, labelShow.Font.Style ^ FontStyle.Italic);
        }

        private void checkBoxBlod_CheckedChanged(object sender, EventArgs e)
        {
            labelShow.Font = new Font(labelShow.Font, labelShow.Font.Style ^ FontStyle.Bold);
        }

        private void radioButtonRED_CheckedChanged(object sender, EventArgs e)
        {
            labelShow.ForeColor = Color.Red;
        }

        private void radioButtonGreen_CheckedChanged(object sender, EventArgs e)
        {
            labelShow.ForeColor = Color.Green;
        }
    }
}
