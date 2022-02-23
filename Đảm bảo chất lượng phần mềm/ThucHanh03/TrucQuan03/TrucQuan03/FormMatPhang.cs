using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToanHoc;

namespace TrucQuan03
{
    public partial class FormMatPhang : Form
    {
        private static int Visit_Enter = 0;
        private static int Visit_Exit = 0;

        public FormMatPhang()
        {
            InitializeComponent();
        }

        private string TuongGiao(MatPhang mp1, MatPhang mp2)
        {
            if (MatPhang.SongSong(mp1, mp2))
                return "Song song";
            else if (MatPhang.TrungNhau(mp1, mp2))
                return "Trùng nhau";
            else if (MatPhang.CatNhau(mp1, mp2))
                return "Cắt nhau";
            else
                return "Có lỗi sai trong chương trình";
        }

        private void testMatPhang()
        {
            double alphaA = double.Parse(textBoxAlphaA.Text);
            double alphaB = double.Parse(textBoxAlphaB.Text);
            double alphaC = double.Parse(textBoxAlphaC.Text);
            double alphaD = double.Parse(textBoxAlphaD.Text);

            double betaA = double.Parse(textBoxBetaA.Text);
            double betaB = double.Parse(textBoxBetaB.Text);
            double betaC = double.Parse(textBoxBetaC.Text);
            double betaD = double.Parse(textBoxBetaD.Text);

            double gammaA = double.Parse(textBoxGammaA.Text);
            double gammaB = double.Parse(textBoxGammaB.Text);
            double gammaC = double.Parse(textBoxGammaC.Text);
            double gammaD = double.Parse(textBoxGammaD.Text);

            MatPhang alpha = new MatPhang(alphaA, alphaB, alphaC, alphaD);
            MatPhang beta = new MatPhang(betaA, betaB, betaC, betaD);
            MatPhang gamma = new MatPhang(gammaA, gammaB, gammaC, gammaD);

            textBoxAlphaVaBeta.Text = TuongGiao(alpha, beta);
            textBoxAlphaVaGamma.Text = TuongGiao(alpha, gamma);
            textBoxBetaVaGamma.Text = TuongGiao(beta, gamma);
        }

        private void FormMatPhang_Activated(object sender, EventArgs e)
        {
            if (Visit_Enter == 0)
            {
                Visit_Enter = FormTrucQuan.Entered_MatPhang;
                FormTrucQuan.Visit_Point += Visit_Enter;
                ((FormTrucQuan)this.MdiParent).TienDo_Refresh();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            double alphaA = 0, alphaB = 0, alphaC = 0, alphaD = 0,
            betaA = 0, betaB = 0, betaC = 0, betaD = 0,
            gammaA = 0, gammaB = 0, gammaC = 0, gammaD = 0;
            bool HopLe = double.TryParse(textBoxAlphaA.Text, out alphaA)
            && double.TryParse(textBoxAlphaB.Text, out alphaB)
            && double.TryParse(textBoxAlphaC.Text, out alphaC)
            && double.TryParse(textBoxAlphaD.Text, out alphaD)
            && double.TryParse(textBoxBetaA.Text, out betaA)
            && double.TryParse(textBoxBetaB.Text, out betaB)
            && double.TryParse(textBoxBetaC.Text, out betaC)
            && double.TryParse(textBoxBetaD.Text, out betaD)
            && double.TryParse(textBoxGammaA.Text, out gammaA)
            && double.TryParse(textBoxGammaB.Text, out gammaB)
            && double.TryParse(textBoxGammaC.Text, out gammaC)
            && double.TryParse(textBoxGammaD.Text, out gammaD);
            if (HopLe)
            {
                HopLe &= MatPhang.LaMatPhang(alphaA, alphaB, alphaC, alphaD);
                HopLe &= MatPhang.LaMatPhang(betaA, betaB, betaC, betaD);
                HopLe &= MatPhang.LaMatPhang(gammaA, gammaB, gammaC, gammaD);
            }
            buttonTinhToan.Enabled = HopLe;
        }

        private void buttonTinhToan_Click(object sender, EventArgs e)
        {
            testMatPhang();

            if (Visit_Exit == 0)
            {
                Visit_Exit = FormTrucQuan.Calculated_MatPhang;
                FormTrucQuan.Visit_Point += Visit_Exit;
                ((FormTrucQuan)this.MdiParent).TienDo_Refresh();
            }
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
