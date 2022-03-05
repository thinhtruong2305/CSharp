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
    public partial class FormKetQua : Form
    {
        private static int SeqNo;
        public FormThapHaNoiNangCao frmRef;

        public FormKetQua()
        {
            InitializeComponent();
            SeqNo = 0;
        }

        public void Add(string s)
        {
            SeqNo++;
            listBoxKetQua.Items.Add(SeqNo.ToString() + ". " + s);
            numericUpDownSoBuocThucHien.Value = SeqNo;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            frmRef.ResetParam();
        }
    }
}
