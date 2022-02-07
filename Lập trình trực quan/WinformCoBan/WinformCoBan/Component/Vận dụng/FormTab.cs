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
    public partial class FormTab : Form
    {
        public FormTab()
        {
            InitializeComponent();
        }

        private void buttonTinhToan_Click(object sender, EventArgs e)
        {
            double ketQua = Convert.ToDouble(numericUpDownB.Value) / Convert.ToDouble(numericUpDownA.Value);
            textBoxKetQua.Text = Convert.ToString(ketQua);
        }

        private void buttonTinhToanPhuongTrinhBac2_Click(object sender, EventArgs e)
        {
            int delta = Convert.ToInt32(numericUpDownBPhuongTrinhBac2.Value) * Convert.ToInt32(numericUpDownBPhuongTrinhBac2.Value) - (4 * Convert.ToInt32(numericUpDownAPhuongTrinhBac2.Value) * Convert.ToInt32(numericUpDownCPhuongTrinhBac2.Value));
            if(delta > 0)
            {
                double X1 = (-Convert.ToDouble(numericUpDownBPhuongTrinhBac2) + Math.Sqrt(delta)) / (2 * Convert.ToDouble(numericUpDownAPhuongTrinhBac2));
                double X2 = (-Convert.ToDouble(numericUpDownBPhuongTrinhBac2) - Math.Sqrt(delta)) / (2 * Convert.ToDouble(numericUpDownAPhuongTrinhBac2));
            }
        }
    }
}
