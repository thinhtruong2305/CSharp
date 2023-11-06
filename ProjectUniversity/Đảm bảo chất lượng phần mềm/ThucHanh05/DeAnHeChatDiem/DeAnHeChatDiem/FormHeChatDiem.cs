using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeAnHeChatDiem
{
    public partial class FormHeChatDiem : Form
    {
        public FormHeChatDiem()
        {
            InitializeComponent();
        }

        private void textBoxChatDiem_TextChanged(object sender, EventArgs e)
        {
            double cd1m = 0, cd1x = 0, cd1y = 0, cd1z = 0,
                   cd2m = 0, cd2x = 0, cd2y = 0, cd2z = 0,
                   cd3m = 0, cd3x = 0, cd3y = 0, cd3z = 0;

            bool HopLe = double.TryParse(textBoxChatDiem1M.Text, out cd1m)
            && double.TryParse(textBoxChatDiem1X.Text, out cd1x)
            && double.TryParse(textBoxChatDiem1Y.Text, out cd1y)
            && double.TryParse(textBoxChatDiem1Z.Text, out cd1z)

            && double.TryParse(textBoxChatDiem2M.Text, out cd2m)
            && double.TryParse(textBoxChatDiem2X.Text, out cd2x)
            && double.TryParse(textBoxChatDiem2Y.Text, out cd2y)
            && double.TryParse(textBoxChatDiem2Z.Text, out cd2z)

            && double.TryParse(textBoxChatDiem3M.Text, out cd3m)
            && double.TryParse(textBoxChatDiem3X.Text, out cd3x)
            && double.TryParse(textBoxChatDiem3Y.Text, out cd3y)
            && double.TryParse(textBoxChatDiem3Z.Text, out cd3z);

            HopLe &= cd1m > 0 && cd2m > 0 && cd3m > 0;
            buttonTinhToan.Enabled = HopLe;
        }

        private void buttonTinhToan_Click(object sender, EventArgs e)
        {
            //Tab chất điểm
            double cd1m = double.Parse(textBoxChatDiem1M.Text);
            double cd1x = double.Parse(textBoxChatDiem1X.Text);
            double cd1y = double.Parse(textBoxChatDiem1Y.Text);
            double cd1z = double.Parse(textBoxChatDiem1Z.Text);

            double cd2m = double.Parse(textBoxChatDiem2M.Text);
            double cd2x = double.Parse(textBoxChatDiem2X.Text);
            double cd2y = double.Parse(textBoxChatDiem2Y.Text);
            double cd2z = double.Parse(textBoxChatDiem2Z.Text);

            double cd3m = double.Parse(textBoxChatDiem3M.Text);
            double cd3x = double.Parse(textBoxChatDiem3X.Text);
            double cd3y = double.Parse(textBoxChatDiem3Y.Text);
            double cd3z = double.Parse(textBoxChatDiem3Z.Text);

            ChatDiem cd1 = new ChatDiem(cd1m, cd1x, cd1y, cd1z);
            ChatDiem cd2 = new ChatDiem(cd2m, cd2x, cd2y, cd2z);
            ChatDiem cd3 = new ChatDiem(cd3m, cd3x, cd3y, cd3z);

            HeChatDiem hcd = new HeChatDiem();
            hcd.Them(cd1);
            hcd.Them(cd2);
            hcd.Them(cd3);

            //tab hệ chất điểm
            int ii = 0;
            dataGridViewHeChatDiem.Rows.Clear();
            foreach (ChatDiem cd in hcd)
            {
                ii++;
                dataGridViewHeChatDiem.Rows.Add("cd" + ii.ToString(), cd.KhoiLuong, cd.HoanhDo, cd.TungDo, cd.CaoDo)
               ;
            }

            ChatDiem ktHCD = hcd.KhoiTam();
            textBoxKhoiTamM.Text = ktHCD.KhoiLuong.ToString();
            textBoxKhoiTamX.Text = ktHCD.HoanhDo.ToString();
            textBoxKhoiTamY.Text = ktHCD.TungDo.ToString();
            textBoxKhoiTamZ.Text = ktHCD.CaoDo.ToString();

            //Tab tính chất
            // Khối tâm (chất điểm 1, chất điểm 2)
            HeChatDiem hcd12 = new HeChatDiem() { cd1, cd2 };
            ChatDiem ktHCD12 = hcd12.KhoiTam();
            textBoxCd1Cd2M.Text = ktHCD12.KhoiLuong.ToString();
            textBoxCd1Cd2X.Text = ktHCD12.HoanhDo.ToString();
            textBoxCd1Cd2Y.Text = ktHCD12.TungDo.ToString();
            textBoxCd1Cd2Z.Text = ktHCD12.CaoDo.ToString();

            // Khối tâm (chất điểm 2, chất điểm 3)
            HeChatDiem hcd23 = new HeChatDiem() { cd2, cd3 };
            ChatDiem ktHCD23 = hcd23.KhoiTam();
            textBoxCd2Cd3M.Text = ktHCD23.KhoiLuong.ToString();
            textBoxCd2Cd3X.Text = ktHCD23.HoanhDo.ToString();
            textBoxCd2Cd3Y.Text = ktHCD23.TungDo.ToString();
            textBoxCd2Cd3Z.Text = ktHCD23.CaoDo.ToString();

            //Khối tâm (Khối tâm (cd1, cd2), cd3)
            HeChatDiem hcd12cd3 = new HeChatDiem() { ktHCD12, cd3 };
            ChatDiem ktHCD12CD3 = hcd12cd3.KhoiTam();
            textBoxKTKTCd1Cd2Cd3M.Text = ktHCD12CD3.KhoiLuong.ToString();
            textBoxKTKTCd1Cd2Cd3X.Text = ktHCD12CD3.HoanhDo.ToString();
            textBoxKTKTCd1Cd2Cd3Y.Text = ktHCD12CD3.TungDo.ToString();
            textBoxKTKTCd1Cd2Cd3Z.Text = ktHCD12CD3.CaoDo.ToString();

            //Khối tâm (Cd1, Khối tâm (cd2, cd3))
            HeChatDiem hcd1cd23 = new HeChatDiem() { cd1, ktHCD23 };
            ChatDiem ktCD1HCD23 = hcd1cd23.KhoiTam();
            textBoxKTCd1KTCd2Cd3M.Text = ktCD1HCD23.KhoiLuong.ToString();
            textBoxKTCd1KTCd2Cd3X.Text = ktCD1HCD23.HoanhDo.ToString();
            textBoxKTCd1KTCd2Cd3Y.Text = ktCD1HCD23.TungDo.ToString();
            textBoxKTCd1KTCd2Cd3Z.Text = ktCD1HCD23.CaoDo.ToString();

            if (ktHCD12CD3 == ktCD1HCD23)
                textBoxKetLuan.Text = labelKTCd1KTCd2Cd3.Text + "==" + labelKTKTCd1Cd2Cd3.Text;
            else
                textBoxKetLuan.Text = labelKTCd1KTCd2Cd3.Text + "!=" + labelKTKTCd1Cd2Cd3.Text;
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
