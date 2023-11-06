using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeAnThapHaNoi
{
    public partial class FormBaThapHaNoi : Form
    {
        private static int _DoCao = 0;
        private int defaultThap = 0;
        private bool nud_enabled = true;

        private NumericUpDown[] nudThap = new NumericUpDown[_DoCao];
        private string _TrangThai = "";

        public FormBaThapHaNoi()
        {
            InitializeComponent();
        }
        public FormBaThapHaNoi(int m_DoCao, int SoThap)
        {
            InitializeComponent();
            DoCao = m_DoCao;
            defaultThap = SoThap;
            TrangThai = MyLib.Replicate(SoThap.ToString(), DoCao);
        }

        public int DoCao
        {
            set
            {
                XoaTatCaNudThap();
                numericUpDownDoCao.Value = _DoCao = value;

                nudThap = new NumericUpDown[_DoCao];
                string trangThai = "";

                for (int i = 0; i < _DoCao; i++)
                {
                    this.nudThap[i] = new System.Windows.Forms.NumericUpDown();
                    this.panelBottom.Controls.Add(this.nudThap[i]);
                    this.nudThap[i].Location = new System.Drawing.Point(6 + i * 40, 8);
                    this.nudThap[i].Maximum = new decimal(new int[] { 2, 0, 0, 0 });
                    this.nudThap[i].Minimum = new decimal(new int[] { 0, 0, 0, 0 });
                    this.nudThap[i].Name = "nudThap" + i.ToString("##");
                    this.nudThap[i].ReadOnly = true;
                    this.nudThap[i].Size = new System.Drawing.Size(31, 20);
                    this.nudThap[i].TabIndex = 2;
                    this.nudThap[i].Value = new decimal(new int[] { defaultThap, 0, 0, 0 });
                    this.nudThap[i].ValueChanged += new System.EventHandler(this.nudThap_ValueChanged);
                    trangThai += this.nudThap[i].Value.ToString();
                }

                if (nud_enabled)
                    TrangThai = trangThai;
                else
                    _TrangThai = trangThai;
            }
            get { return _DoCao; }
        }

        public string TrangThai
        {
            set
            {
                userControlBaThapHaNoi.XoaSach();
                _TrangThai = value;
                int vtDia = 0;
                foreach (char c in _TrangThai)
                {
                    int SoThap = (int)c - 48;
                    int SoDia = _DoCao - vtDia;

                    if (!vtDia.Equals(SoDia))
                        SoDia = vtDia;

                    if (FormThapHaNoiNangCao.DangThoatRa)
                        break;

                    userControlBaThapHaNoi.Them(SoThap, SoDia);
                    nudThap[vtDia].Value = SoThap;
                    vtDia++;
                }
            }
            get { return _TrangThai; }
        }

        public bool nudEnabled
        {
            set
            {
                nud_enabled = value;
                foreach (NumericUpDown nud in nudThap)
                    nud.Enabled = nud_enabled;
            }
            get { return nud_enabled; }
        }

        public string Title
        {
            set
            {
                labelTitle.Text = value;
                this.Text = "Ba Tháp Hà Nội " + value;
            }
            get { return labelTitle.Text; }
        }

        public void XoaTatCaNudThap()
        {
            for (int i = nudThap.Length - 1; i >= 0; i--)
            {
                this.panelBottom.Controls.Remove(this.nudThap[i]);
                this.nudThap[i] = null;
            }
        }

        private void nudThap_ValueChanged(object sender, EventArgs e)
        {
            string trangThai = "";

            for (int vtDia = 0; vtDia < _DoCao; vtDia++)
            {
                int SoThap = (int)nudThap[vtDia].Value;
                int SoDia = _DoCao - vtDia;
                trangThai += nudThap[vtDia].Value.ToString();
            }
            TrangThai = trangThai;
        }
    }
}
