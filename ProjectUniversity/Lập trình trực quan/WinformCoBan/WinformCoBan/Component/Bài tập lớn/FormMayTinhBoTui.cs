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
    public partial class FormMayTinhBoTui : Form
    {
        private int num1Int, num2Int;
        private double num1Double, num2Double;
        private String toanTu = "";

        public FormMayTinhBoTui()
        {
            InitializeComponent();
        }

        private void FormMayTinhBoTui_Load(object sender, EventArgs e)
        {
            textBoxBangSo.Text = "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBoxBangSo.Text.Equals("0") && !textBoxBangSo.Equals(null))
                textBoxBangSo.Text = "9";
            else
                textBoxBangSo.Text += "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBoxBangSo.Text.Equals("0") && !textBoxBangSo.Equals(null))
                textBoxBangSo.Text = "8";
            else
                textBoxBangSo.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBoxBangSo.Text.Equals("0") && !textBoxBangSo.Equals(null))
                textBoxBangSo.Text = "7";
            else
                textBoxBangSo.Text += "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxBangSo.Text.Equals("0") && !textBoxBangSo.Equals(null))
                textBoxBangSo.Text = "6";
            else
                textBoxBangSo.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBoxBangSo.Text.Equals("0") && !textBoxBangSo.Equals(null))
                textBoxBangSo.Text = "5";
            else
                textBoxBangSo.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxBangSo.Text.Equals("0") && !textBoxBangSo.Equals(null))
                textBoxBangSo.Text = "4";
            else
                textBoxBangSo.Text += "4";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxBangSo.Text.Equals("0") && !textBoxBangSo.Equals(null))
                textBoxBangSo.Text = "3";
            else
                textBoxBangSo.Text += "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxBangSo.Text.Equals("0") && !textBoxBangSo.Equals(null))
                textBoxBangSo.Text = "2";
            else
                textBoxBangSo.Text += "2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxBangSo.Text.Equals("0") && !textBoxBangSo.Equals(null))
                textBoxBangSo.Text = "1";
            else
                textBoxBangSo.Text += "1";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBoxBangSo.Text.Equals("0") && !textBoxBangSo.Equals(null))
                textBoxBangSo.Text = "0";
            else
                textBoxBangSo.Text += "0";
        }

        private bool kiemTraSoLanCham(String text)
        {
            int dem = 0;
            foreach(char item in text)
            {
                if (item == 46)
                    dem++;
            }
            if (dem > 0)
                return false;
            return true;
        }

        private void buttonCham_Click(object sender, EventArgs e)
        {
            if (textBoxBangSo.Text.Equals("0") && !textBoxBangSo.Equals(null))
                textBoxBangSo.Text = ".";
            else {
                if (kiemTraSoLanCham(textBoxBangSo.Text))
                    textBoxBangSo.Text += ".";
                else { }
             }       
        }

        private void buttonOFF_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            num1Int = num2Int = 0;
            num1Double = num2Double = 0;
            toanTu = "";
            textBoxBangSo.Text = "0";
        }

        private void buttonCong_Click(object sender, EventArgs e)
        {
            if (!kiemTraSoLanCham(textBoxBangSo.Text))
                num1Double = Convert.ToDouble(textBoxBangSo.Text);
            else
                num1Int = Convert.ToInt32(textBoxBangSo.Text);
            toanTu = "+";
            textBoxBangSo.Text = "0";
        }

        private void buttonTru_Click(object sender, EventArgs e)
        {
            if (!kiemTraSoLanCham(textBoxBangSo.Text))
                num1Double = Convert.ToDouble(textBoxBangSo.Text);
            else
                num1Int = Convert.ToInt32(textBoxBangSo.Text);
            toanTu = "-";
        }

        private void buttonNhan_Click(object sender, EventArgs e)
        {
            if (!kiemTraSoLanCham(textBoxBangSo.Text))
                num1Double = Convert.ToDouble(textBoxBangSo.Text);
            else
                num1Int = Convert.ToInt32(textBoxBangSo.Text);
            toanTu = "X";
            textBoxBangSo.Text = "0";
        }

        private void buttonChia_Click(object sender, EventArgs e)
        {
            if (!kiemTraSoLanCham(textBoxBangSo.Text))
                num1Double = Convert.ToDouble(textBoxBangSo.Text);
            else
                num1Int = Convert.ToInt32(textBoxBangSo.Text);
            toanTu = "/";
            textBoxBangSo.Text = "0";
        }
        
        private double thucHienPhepTinhDouble(double num1, double num2, object sender, EventArgs e)
        {
            if (toanTu.Equals("+"))
                return num1 + num2;
            if (toanTu.Equals("-"))
                return num1 - num2;
            if (toanTu.Equals("X"))
                return num1 * num2;
            if (toanTu.Equals("/"))
            {
                if (num2 != 0)
                {
                    return num1 / num2;
                }
                else
                {
                    buttonClear_Click(sender, e);
                }
            }
            return 0.0;
        }

        private int thucHienPhepTinhInt(int num1, int num2, object sender, EventArgs e)
        {
            if (toanTu.Equals("+"))
                return num1 + num2;
            if (toanTu.Equals("-"))
                return num1 - num2;
            if (toanTu.Equals("X"))
                return num1 * num2;
            if (toanTu.Equals("/"))
            {
                if (num2 != 0)
                {
                    return num1 / num2;
                }
                else
                {
                    buttonClear_Click(sender, e);
                }
            }
            return 0;
        }

        private void buttonBang_Click(object sender, EventArgs e)
        {
            if (!kiemTraSoLanCham(textBoxBangSo.Text))
            {
                num2Double = Convert.ToDouble(textBoxBangSo.Text);
                textBoxBangSo.Text = thucHienPhepTinhDouble(num1Double, num2Double, sender, e).ToString();
            }
            else
            {
                num2Int = Convert.ToInt32(textBoxBangSo.Text);
                textBoxBangSo.Text = thucHienPhepTinhInt(num1Int, num2Int, sender, e).ToString();
            }
        }
    }
}
