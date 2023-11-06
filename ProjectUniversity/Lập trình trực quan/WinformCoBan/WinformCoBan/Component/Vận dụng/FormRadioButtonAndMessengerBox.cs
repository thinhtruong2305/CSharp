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
    public partial class FormRadioButtonAndMessengerBox : Form
    {
        public FormRadioButtonAndMessengerBox()
        {
            InitializeComponent();
        }

        MessageBoxButtons messageBoxButtons(String name)
        {
            if (name.Equals("OK"))
                return MessageBoxButtons.OK;
            if (name.Equals("OK cancel"))
                return MessageBoxButtons.OKCancel;
            if (name.Equals("Yes No"))
                return MessageBoxButtons.YesNo;
            if (name.Equals("Yes No Cancel"))
                return MessageBoxButtons.YesNoCancel;
            if (name.Equals("Retry Cancel"))
                return MessageBoxButtons.RetryCancel;
            return MessageBoxButtons.AbortRetryIgnore;
        }

        MessageBoxIcon messageBoxIcon(String name)
        {
            if (name.Equals("Asterisk"))
                return MessageBoxIcon.Asterisk;
            if (name.Equals("Error"))
                return MessageBoxIcon.Error;
            if (name.Equals("Exclamation"))
                return MessageBoxIcon.Exclamation;
            if (name.Equals("Hand"))
                return MessageBoxIcon.Hand;
            if (name.Equals("Information"))
                return MessageBoxIcon.Information;
            if (name.Equals("None"))
                return MessageBoxIcon.None;
            if (name.Equals("Question"))
                return MessageBoxIcon.Question;
            if (name.Equals("Stop"))
                return MessageBoxIcon.Stop;
            return MessageBoxIcon.Warning;
        }

        String kiemTraRadionButtonMessagerButton(RadioButton[] check)
        {
            for (int i = 0; i < check.Length; i++)
            {
                if (check[i].Checked.Equals(false))
                    continue;
                return check[i].Text;
            }
            return null;
        }

        String kiemTraRadionButtonMessagerIcon(RadioButton[] check)
        {
            for (int i = 0; i < check.Length; i++)
            {
                if (check[i].Checked.Equals(false))
                    continue;
                return check[i].Text;
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RadioButton[] radionMessageButton = { radioButtonOK, radioButtonOKCancel, radioButtonYesNo, radioButtonYesNoCancel, radioButtonRetryCancel, radioButtonAbortRetryIgnore };
            RadioButton[] radionMessageIcon = { radioButtonAsterisk, radioButtonError, radioButtonExclamation, radioButtonHand, radioButtonInformation, radioButtonNone, radioButtonQuestion, radioButtonStop, radioButtonWarning };

            MessageBox.Show("Máy tính bạn đã bị hacked", "Thông báo", messageBoxButtons(kiemTraRadionButtonMessagerButton(radionMessageButton)), messageBoxIcon(kiemTraRadionButtonMessagerIcon(radionMessageIcon)));
        }
        
    }
}
