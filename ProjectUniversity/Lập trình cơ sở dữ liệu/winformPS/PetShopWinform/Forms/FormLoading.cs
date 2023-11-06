using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PetShopWinform
{
    public partial class FormLoading : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int RightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );

        public FormLoading()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            progressbar1.Value = 0;
        }

        private void progressbar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressbar1.Value += 1;
            progressbar1.Text = progressbar1.Value.ToString() + "%";

            if (progressbar1.Value == 100)
            {
                timer1.Enabled = false;
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                this.Hide();
            }
        }
    }
}
