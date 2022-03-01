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
    public partial class UserControlMaTranCap4 : UserControl
    {
        public event EventHandler<MaTranEventArgs> MaTranChanged;

        public UserControlMaTranCap4()
        {
            InitializeComponent();
        }

        public bool ReadOnly
        {
            set
            {
                foreach (TextBox textBox in new TextBox[]
                { 
                    textBox00, textBox01, textBox02, textBox03, textBox10, textBox11, textBox12, textBox13,
                    textBox20, textBox21, textBox22, textBox23, textBox30, textBox31, textBox32, textBox33})
                    textBox.ReadOnly = value;
            }
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
        public static bool TryParse(UserControlMaTranCap4 uc, out MaTranCap4 mt)
        {
            double mt00 = 0, mt01 = 0, mt02 = 0, mt03 = 0, mt10 = 0, mt11 = 0, mt12 = 0, mt13 = 0,
                   mt20 = 0, mt21 = 0, mt22 = 0, mt23 = 0, mt30 = 0, mt31 = 0, mt32 = 0, mt33 = 0;

            bool hopLe = double.TryParse(uc.textBox00.Text, out mt00)
            && double.TryParse(uc.textBox01.Text, out mt01)
            && double.TryParse(uc.textBox02.Text, out mt02)
            && double.TryParse(uc.textBox03.Text, out mt03)

            && double.TryParse(uc.textBox10.Text, out mt10)
            && double.TryParse(uc.textBox11.Text, out mt11)
            && double.TryParse(uc.textBox12.Text, out mt12)
            && double.TryParse(uc.textBox13.Text, out mt13)

            && double.TryParse(uc.textBox20.Text, out mt20)
            && double.TryParse(uc.textBox21.Text, out mt21)
            && double.TryParse(uc.textBox22.Text, out mt22)
            && double.TryParse(uc.textBox23.Text, out mt23)

            && double.TryParse(uc.textBox30.Text, out mt30)
            && double.TryParse(uc.textBox31.Text, out mt31)
            && double.TryParse(uc.textBox32.Text, out mt32)
            && double.TryParse(uc.textBox33.Text, out mt33);

            mt = new MaTranCap4(mt00, mt01, mt02, mt03,
                                mt10, mt11, mt12, mt13,
                                mt20, mt21, mt22, mt23,
                                mt30, mt31, mt32, mt33);
            return hopLe;
        }

        public static MaTranCap4 Parse(UserControlMaTranCap4 uc)
        {
            double mt00 = double.Parse(uc.textBox00.Text);
            double mt01 = double.Parse(uc.textBox01.Text);
            double mt02 = double.Parse(uc.textBox02.Text);
            double mt03 = double.Parse(uc.textBox03.Text);

            double mt10 = double.Parse(uc.textBox10.Text);
            double mt11 = double.Parse(uc.textBox11.Text);
            double mt12 = double.Parse(uc.textBox12.Text);
            double mt13 = double.Parse(uc.textBox13.Text);

            double mt20 = double.Parse(uc.textBox20.Text);
            double mt21 = double.Parse(uc.textBox21.Text);
            double mt22 = double.Parse(uc.textBox22.Text);
            double mt23 = double.Parse(uc.textBox23.Text);

            double mt30 = double.Parse(uc.textBox30.Text);
            double mt31 = double.Parse(uc.textBox31.Text);
            double mt32 = double.Parse(uc.textBox32.Text);
            double mt33 = double.Parse(uc.textBox33.Text);

            return new MaTranCap4(mt00, mt01, mt02, mt03,
                                  mt10, mt11, mt12, mt13,
                                  mt20, mt21, mt22, mt23,
                                  mt30, mt31, mt32, mt33);
        }

        public void WriteOut(MaTranCap4 mt)
        {
            textBox00.Text = mt[0, 0].ToString();
            textBox01.Text = mt[0, 1].ToString();
            textBox02.Text = mt[0, 2].ToString();
            textBox03.Text = mt[0, 3].ToString();

            textBox10.Text = mt[1, 0].ToString();
            textBox11.Text = mt[1, 1].ToString();
            textBox12.Text = mt[1, 2].ToString();
            textBox13.Text = mt[1, 3].ToString();

            textBox20.Text = mt[2, 0].ToString();
            textBox21.Text = mt[2, 1].ToString();
            textBox22.Text = mt[2, 2].ToString();
            textBox23.Text = mt[2, 3].ToString();

            textBox30.Text = mt[3, 0].ToString();
            textBox31.Text = mt[3, 1].ToString();
            textBox32.Text = mt[3, 2].ToString();
            textBox33.Text = mt[3, 3].ToString();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            MaTranEventArgs e1 = new MaTranEventArgs();
            OnMaTranChanged(e1);
        }
    }
}
