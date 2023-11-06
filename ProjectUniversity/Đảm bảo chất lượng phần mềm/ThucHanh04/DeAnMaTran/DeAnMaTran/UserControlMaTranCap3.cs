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
    public partial class UserControlMaTranCap3 : UserControl
    {
        public event EventHandler<MaTranEventArgs> MaTranChanged;

        public UserControlMaTranCap3()
        {
            InitializeComponent();
        }

        public bool ReadOnly
        {
            set
            {
                foreach (TextBox textBox in new TextBox[] { textBox00, textBox01, textBox02, textBox10, textBox11, textBox12, textBox20, textBox21, textBox22 })
                    textBox.ReadOnly = value;
            }
            get { return textBox00.ReadOnly; }
        }

        protected virtual void OnMaTranChanged(MaTranEventArgs e)
        {
            EventHandler<MaTranEventArgs> handler = MaTranChanged;
            if (handler != null)
                handler(this, e);
        }
        public static bool TryParse(UserControlMaTranCap3 uc, out MaTranCap3 mt)
        {
            double mt00 = 0, mt01 = 0, mt02 = 0, mt10 = 0, mt11 = 0, mt12 = 0, mt20 = 0, mt21 = 0, mt22 = 0;
            bool hopLe = double.TryParse(uc.textBox00.Text, out mt00)
            && double.TryParse(uc.textBox01.Text, out mt01)
            && double.TryParse(uc.textBox02.Text, out mt02)

            && double.TryParse(uc.textBox10.Text, out mt10)
            && double.TryParse(uc.textBox11.Text, out mt11)
            && double.TryParse(uc.textBox12.Text, out mt12)

            && double.TryParse(uc.textBox20.Text, out mt20)
            && double.TryParse(uc.textBox21.Text, out mt21)
            && double.TryParse(uc.textBox22.Text, out mt22);
            mt = new MaTranCap3(mt00, mt01, mt02, mt10, mt11, mt12, mt20, mt21, mt22);
            return hopLe;
        }
        public static MaTranCap3 Parse(UserControlMaTranCap3 uc)
        {
            double mt00 = double.Parse(uc.textBox00.Text);
            double mt01 = double.Parse(uc.textBox01.Text);
            double mt02 = double.Parse(uc.textBox02.Text);

            double mt10 = double.Parse(uc.textBox10.Text);
            double mt11 = double.Parse(uc.textBox11.Text);
            double mt12 = double.Parse(uc.textBox12.Text);

            double mt20 = double.Parse(uc.textBox20.Text);
            double mt21 = double.Parse(uc.textBox21.Text);
            double mt22 = double.Parse(uc.textBox22.Text);
            return new MaTranCap3(mt00, mt01, mt02, mt10, mt11, mt12, mt20, mt21, mt22);
        }
        public void WriteOut(MaTranCap3 mt)
        {
            textBox00.Text = mt[0, 0].ToString();
            textBox01.Text = mt[0, 1].ToString();
            textBox02.Text = mt[0, 2].ToString();

            textBox10.Text = mt[1, 0].ToString();
            textBox11.Text = mt[1, 1].ToString();
            textBox12.Text = mt[1, 2].ToString();

            textBox20.Text = mt[2, 0].ToString();
            textBox21.Text = mt[2, 1].ToString();
            textBox22.Text = mt[2, 2].ToString();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            MaTranEventArgs e1 = new MaTranEventArgs();
            OnMaTranChanged(e1);
        }
    }
}
