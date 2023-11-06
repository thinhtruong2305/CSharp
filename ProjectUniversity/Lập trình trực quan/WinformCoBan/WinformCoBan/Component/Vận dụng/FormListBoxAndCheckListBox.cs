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
    public partial class FormListBoxAndCheckListBox : Form
    {
        public FormListBoxAndCheckListBox()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void FormListBoxAndCheckListBox_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Text = "Nhập ở đây";
            }
            else
            {

            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("Nhập ở đây"))
                textBox1.Text = null;
            listBox1.Items.Add(textBox1.Text);
            listBox1.Items.Remove("");
            textBox1.Text = "Nhập ở đây";
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(listBox1.SelectedIndex, textBox1.Text);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
