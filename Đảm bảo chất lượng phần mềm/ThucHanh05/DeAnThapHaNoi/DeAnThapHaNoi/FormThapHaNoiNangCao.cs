using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DeAnThapHaNoi
{
    public partial class FormThapHaNoiNangCao : Form
    {
        private static int Visit_Enter = 0;
        private static int Calc1_Done = 0, Calc2_Done = 0, Calc3_Done = 0, Calc4_Done = 0;

        private static int DoCao = 5;
        private FormBaThapHaNoi FormXP = new FormBaThapHaNoi(DoCao, 0);
        private FormBaThapHaNoi FormDD = new FormBaThapHaNoi(DoCao, 2);
        private FormBaThapHaNoi FormTH = new FormBaThapHaNoi(DoCao, 1);
        private FormKetQua Form;

        private bool XuatPhat_Ready = false;
        private bool DichDen_Ready = false;
        private bool ThucHien_Ready = false;

        public static bool DangThoatRa = false;

        private List<String> dsTrangThai = new List<string>();

        public FormThapHaNoiNangCao()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DangThoatRa = true;

            if (Form != null)
                Form.Close();

            FormTH.Close();
            FormXP.Close();
            FormDD.Close();
            DangThoatRa = false;
        }

        public void ResetParam()
        {
            FormXP.nudEnabled = true;
            FormDD.nudEnabled = true;
            FormTH.nudEnabled = true;
            ThucHien_Ready = false;
            numericUpDownDoCaoThap.Enabled = true;
            FormTH.Hide();
        }
        private void numericUpDownDoCaoThap_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDownDoCaoThap.Value <= 12 && numericUpDownDoCaoThap.Value >= 1)
            {
                DoCao = (int)numericUpDownDoCaoThap.Value;
                numericUpDownSoBuocToiDa.Value = (1 << DoCao) - 1;
                FormXP.DoCao = FormTH.DoCao = FormDD.DoCao = DoCao;

                if (Calc1_Done == 0)
                {
                    Calc1_Done = FormDeAnThapHaNoi.Calculated_NangCao / 4;
                    FormDeAnThapHaNoi.Visit_Point += Calc1_Done;
                    ((FormDeAnThapHaNoi)this.MdiParent).TienDo_Refresh();
                }
            }
        }

        private void buttonXuatPhat_Click(object sender, EventArgs e)
        {
            XuatPhat_Ready = true;
            buttonThucHien.Enabled = XuatPhat_Ready && DichDen_Ready;
            FormXP.Focus();

            if (Calc2_Done == 0)
            {
                Calc2_Done = FormDeAnThapHaNoi.Calculated_NangCao / 4;
                FormDeAnThapHaNoi.Visit_Point += Calc2_Done;
                ((FormDeAnThapHaNoi)this.MdiParent).TienDo_Refresh();
            }
        }

        private void buttonDichDen_Click(object sender, EventArgs e)
        {
            DichDen_Ready = true;
            buttonThucHien.Enabled = XuatPhat_Ready && DichDen_Ready;
            FormDD.Focus();

            if (Calc3_Done == 0)
            {
                Calc3_Done = FormDeAnThapHaNoi.Calculated_NangCao / 4;
                FormDeAnThapHaNoi.Visit_Point += Calc3_Done;
                ((FormDeAnThapHaNoi)this.MdiParent).TienDo_Refresh();
            }
        }

        private void buttonThucHien_Click(object sender, EventArgs e)
        {
            if (!ThucHien_Ready)
            {
                ThucHien_Ready = true;
                DangThoatRa = false;

                Form = new FormKetQua();
                Form.MdiParent = this.ParentForm;
                Form.numericUpDownSoBuocThucHien.Maximum = (1 << DoCao) - 1;
                Form.frmRef = this;

                numericUpDownDoCaoThap.Enabled = false;

                dsTrangThai = new List<string>() { FormXP.TrangThai };
                BaiToanThapHaNoi btthn = new BaiToanThapHaNoi("", FormXP.TrangThai, FormDD.TrangThai, Form, dsTrangThai);

                FormTH.TrangThai = FormXP.TrangThai;
                FormXP.nudEnabled = false;
                FormDD.nudEnabled = false;
                FormTH.nudEnabled = false;
                FormTH.Focus();

                btthn.GiaiBaiToan();
                // MessageBox.Show(BaiToanThapHaNoi.KetQua, this.Text);
                Form.Show();
            }
            else
                FormTH.Focus();

            //Chạy tiến độ
            if (Calc4_Done == 0)
            {
                Calc4_Done = FormDeAnThapHaNoi.Calculated_NangCao / 4;
                FormDeAnThapHaNoi.Visit_Point += Calc4_Done;
                ((FormDeAnThapHaNoi)this.MdiParent).TienDo_Refresh();
            }

            //Xử lý trạng thái
            foreach (String tt in dsTrangThai)
            {
                FormTH.TrangThai = tt;
                if (FormTH.nudEnabled)
                    break;
                Application.DoEvents();
                Thread.Sleep(100);
            }
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormThapHaNoiNangCao_Activated(object sender, EventArgs e)
        {
            if (Visit_Enter == 0)
            {
                Visit_Enter = FormDeAnThapHaNoi.Entered_DonGian;
                FormDeAnThapHaNoi.Visit_Point += Visit_Enter;
                ((FormDeAnThapHaNoi)this.MdiParent).TienDo_Refresh();
            }

            FormXP.Title = "Xuất phát";
            FormXP.MdiParent = this.ParentForm;

            FormDD.Title = "Đích đến";
            FormDD.MdiParent = this.ParentForm;

            FormDD.TrangThai = MyLib.Replicate('2', DoCao);
            FormTH.Title = "Thực hiện";

            FormTH.MdiParent = this.ParentForm;
        }
    }
}
