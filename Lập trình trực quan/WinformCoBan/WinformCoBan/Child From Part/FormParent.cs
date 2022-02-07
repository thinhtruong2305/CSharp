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
    public partial class FormParent : Form
    {
        public FormParent()
        {
            InitializeComponent();
        }

        private Form active = null;

        private void opening(Form child)
        {
            if(active != null)
                active.Close();
            active = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            tableLayoutPanel1.Controls.Add(child);
            child.BringToFront();
            child.Show();   
        }

        private void FormChildForm_Load(object sender, EventArgs e)
        {
            opening(new ChildForm.FormChild());
        }
    }
}
