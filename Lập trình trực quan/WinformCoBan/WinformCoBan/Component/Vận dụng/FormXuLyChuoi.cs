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
    public partial class FormXuLyChuoi : Form
    {
        public FormXuLyChuoi()
        {
            InitializeComponent();
        }

        private void buttonDemSoKyTuTrongChuoi_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxInput.Text.Length.ToString();
        }

        private void buttonChuyenThuongThanhHoa_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxInput.Text.ToUpper();
        }

        private void buttonChuyenHoaThanhThuong_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxInput.Text.ToLower();
        }

        private void buttonDemKyTuInThuong_Click(object sender, EventArgs e)
        {
            int dem = 0;
            String str = textBoxInput.Text.Trim();
            foreach (char c in str)
                if (char.IsLower(c)) dem++;
            textBoxOutput.Text = dem.ToString();
        }

        private void buttonDemKyTuInHoa_Click(object sender, EventArgs e)
        {
            int dem = 0;
            String str = textBoxInput.Text.Trim();
            foreach (char c in str)
                if (char.IsUpper(c)) dem++;
            textBoxOutput.Text = dem.ToString();
        }

        private void buttonDemKyTuSo_Click(object sender, EventArgs e)
        {
            int dem = 0;
            String str = textBoxInput.Text.Trim();
            foreach (char c in str)
                if (char.IsDigit(c)) dem++;
            textBoxOutput.Text = dem.ToString();
        }

        private void buttonDaoNguocChuoi_Click(object sender, EventArgs e)
        {
            char[] arr = textBoxInput.Text.Trim().ToCharArray();
            Array.Reverse(arr);
            textBoxOutput.Text = new string(arr);
        }

        private void buttonViTriXuatHienDauTien_Click(object sender, EventArgs e)
        {
            int vt = textBoxInput.Text.Trim().IndexOf(textBoxViTriXuatHienDauTien.Text.Trim());
            if (vt.Equals(-1))
                textBoxOutput.Text = "Không tìm thấy";
            else
                textBoxOutput.Text = vt.ToString();
        }

        private void buttonViTriXuatHienCuoiCung_Click(object sender, EventArgs e)
        {
            int vt = textBoxInput.Text.Trim().LastIndexOf(textBoxViTriXuatHienCuoiCung.Text.Trim());
            if (vt.Equals(-1))
                textBoxOutput.Text = "Không tìm thấy";
            else
                textBoxOutput.Text = vt.ToString();
        }

        private void buttonSoLanXuatHien_Click(object sender, EventArgs e)
        {
            int dem = 0, a = 0;
            String str = textBoxInput.Text.Trim();
            while ((a = str.IndexOf(textBoxSoLanXuatHien.Text.Trim(), a)) != -1)
            {
                a += textBoxSoLanXuatHien.Text.Trim().Length;
                dem++;
            }
            textBoxOutput.Text = dem.ToString();
        }

        private void buttonChenChuoi_Click(object sender, EventArgs e)
        {
            String str = textBoxInput.Text.Trim();
            textBoxOutput.Text = str.Insert(Convert.ToInt32(numericUpDownViTri.Value),textBoxChenChuoi.Text);
        }
    }
}
