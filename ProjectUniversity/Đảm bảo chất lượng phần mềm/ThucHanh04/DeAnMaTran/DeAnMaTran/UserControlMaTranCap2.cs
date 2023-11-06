using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeAnMaTran
{
    public partial class UserControlMaTranCap2 : UserControl
    {
        public event EventHandler<MaTranEventArgs> MaTranChanged;

        public UserControlMaTranCap2()
        {
            InitializeComponent();
        }

        public bool ReadOnly
        {
            set { textBox00.ReadOnly = textBox01.ReadOnly = textBox10.ReadOnly = textBox11.ReadOnly = value; }
            get { return textBox00.ReadOnly; }
        }

        protected virtual void OnMaTranChanged(MaTranEventArgs e)
        {
            EventHandler<MaTranEventArgs> handler = MaTranChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public static bool TryParse(UserControlMaTranCap2 uc, out MaTranCap2 mt)
        {
            double mt00 = 0, mt01 = 0, mt10 = 0, mt11 = 0;
            bool hopLe = double.TryParse(uc.textBox00.Text, out mt00)
            && double.TryParse(uc.textBox01.Text, out mt01)
            && double.TryParse(uc.textBox10.Text, out mt10)
            && double.TryParse(uc.textBox11.Text, out mt11);
            mt = new MaTranCap2(mt00, mt01, mt10, mt11);
            return hopLe;
        }
        public static MaTranCap2 Parse(UserControlMaTranCap2 uc)
        {
            double mt00 = double.Parse(uc.textBox00.Text);
            double mt01 = double.Parse(uc.textBox01.Text);
            double mt10 = double.Parse(uc.textBox10.Text);
            double mt11 = double.Parse(uc.textBox11.Text);
            return new MaTranCap2(mt00, mt01, mt10, mt11);
        }
        public void WriteOut(MaTranCap2 mt)
        {
            textBox00.Text = mt[0, 0].ToString();
            textBox01.Text = mt[0, 1].ToString();
            textBox10.Text = mt[1, 0].ToString();
            textBox11.Text = mt[1, 1].ToString();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            MaTranEventArgs e1 = new MaTranEventArgs();
            OnMaTranChanged(e1);
        }
    }
}
