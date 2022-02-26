using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanhSachToiDai
{
    public partial class FormDanhSachToiDai : Form
    {
        public FormDanhSachToiDai()
        {
            InitializeComponent();
        }

        #region Phương thức
        private void CheckTinhToanEnabled()
        {
            buttonTimDanhSachToiDai.Enabled = listBoxDanhSachBanDau.Items.Count > 0;
        }

        private ListDanhSach CacTong(ListBox lb)
        {
            ListDanhSach B = new ListDanhSach();
            for (int i = 0; i < lb.Items.Count; i++)
            {
                int So = int.Parse(lb.Items[i].ToString());
                int SoPhanTu1 = B.Count;

                if (i == 0)
                    B.Add(new DanhSach(So));

                else
                {
                    B.Add(new DanhSach(So));

                    for (int i1 = 0; i1 < SoPhanTu1; i1++)
                    {
                        DanhSach t1 = new DanhSach(B[i1]);
                        t1.Them(So);
                        B.Add(t1);
                    }
                }
            }
            return B;
        }

        public int SortByAscending(int n1, int n2)
        {
            return n1.CompareTo(n2);
        }

        public int SortByDescending(int n1, int n2)
        {
            return n2.CompareTo(n1);
        }

        private void BieuDienDanhSach(ListBox lb, ListDanhSach lstTH, bool ascending)
        {
            lb.Items.Clear();
            List<int> lstTong = new List<int>();

            for (int i = 0; i < lstTH.Count; i++)
                lstTong.Add(lstTH[i].Tong);

            if (ascending)
                lstTong.Sort(SortByAscending);
            else
                lstTong.Sort(SortByDescending);

            foreach (int n in lstTong)
                lb.Items.Add(n.ToString());
        }

        private void BieuDienDanhSach(ListBox lb, DanhSach ds)
        { // Khác chữ ký
            lb.Items.Clear();
            List<int> lst = new List<int>();

            for (int i = 0; i < ds.CacPhanTu.Count; i++)
                lst.Add(ds.CacPhanTu[i]);

            lst.Sort(SortByAscending);

            foreach (int n in lst)
                lb.Items.Add(n.ToString());
        }

        private int KiemCoLoiGiai()
        {
            foreach (String s1 in listBoxCacTongSoDuong.Items)
            {
                int tong1 = int.Parse(s1);

                foreach (String s2 in listBoxCacTongSoAm.Items)
                {
                    int tong2 = int.Parse(s2);

                    if (tong1 ==-tong2)
                        return tong1;
                }
            }
            return 0; // Không có lời giải
        }

        private int DemSo0(ListBox lb)
        {
            int counter = 0;
            foreach (String s in lb.Items)
                if (s == "0") counter++;
            return counter;
        }

        private void ThemCacSo0(DanhSach ds, int n)
        {
            if (n > 0)
                for (int i = 0; i < n; i++)
                    ds.Them(0);
        }

        private void TinhToan()
        {
            ListDanhSach B1 = CacTong(listBoxDanhSachCacSoDuong);
            ListDanhSach B2 = CacTong(listBoxDanhSachCacSoAm);

            BieuDienDanhSach(listBoxCacTongSoDuong, B1, false);
            BieuDienDanhSach(listBoxCacTongSoAm, B2, true);

            int tong = KiemCoLoiGiai();

            if (tong > 0)
            {
                listBoxDanhSachToiDaiCanTim.Items.Clear();

                DanhSach dsDuongToiDai = B1.TapToiDai(tong);
                DanhSach dsAmToiDai = B2.TapToiDai(-tong);
                DanhSach dsToiDai = DanhSach.Hop(dsDuongToiDai, dsAmToiDai);

                int SoDem0 = DemSo0(listBoxDanhSachBanDau);

                ThemCacSo0(dsToiDai, SoDem0);
                BieuDienDanhSach(listBoxDanhSachToiDaiCanTim, dsToiDai);
            }
            else
            {
                int SoDem0 = DemSo0(listBoxDanhSachBanDau);
                if (SoDem0 > 0)
                {
                    DanhSach dsToiDai = new DanhSach();
                    ThemCacSo0(dsToiDai, SoDem0);
                    BieuDienDanhSach(listBoxDanhSachToiDaiCanTim, dsToiDai);
                }
                else
                {
                    listBoxDanhSachToiDaiCanTim.Items.Clear();
                    MessageBox.Show("Bài toán không có lời giải", "Danh sách tối đại");
                }
            }
        }
        #endregion

        #region Sự kiện
        private void buttonThem_Click(object sender, EventArgs e)
        {
            int So = int.Parse(textBoxSo.Text);
            listBoxDanhSachBanDau.Items.Add(So.ToString());
            CheckTinhToanEnabled();
            textBoxSo.Clear();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            int So = int.Parse(textBoxSo.Text);
            foreach (String s in listBoxDanhSachBanDau.Items)
            {
                if (s == So.ToString())
                {
                    listBoxDanhSachBanDau.Items.Remove(s);
                    buttonXoa.Enabled = false;
                    textBoxSo.Clear();
                    break;
                }
            }
            CheckTinhToanEnabled();
            textBoxSo.Clear();
        }

        private void buttonTimDanhSachToiDai_Click(object sender, EventArgs e)
        {
            listBoxDanhSachCacSoDuong.Items.Clear();
            listBoxDanhSachCacSoAm.Items.Clear();
            foreach (String s in listBoxDanhSachBanDau.Items)
            {
                int So = int.Parse(s);
                if (So > 0) listBoxDanhSachCacSoDuong.Items.Add(s);
                if (So < 0) listBoxDanhSachCacSoAm.Items.Add(s);
            }
            TinhToan();
        }

        private void textBoxSo_TextChanged(object sender, EventArgs e)
        {
            int So = 0;
            if (int.TryParse(textBoxSo.Text, out So))
                buttonThem.Enabled = true; // !lbDanhSachSoNguyen.Items.Contains(So.ToString());
            else
                buttonThem.Enabled = false;
            CheckTinhToanEnabled();
        }

        private void listBoxDanhSachBanDau_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDanhSachBanDau.SelectedItem != null)
            {
                textBoxSo.Text = listBoxDanhSachBanDau.SelectedItem.ToString();
                buttonXoa.Enabled = true;
            }
            CheckTinhToanEnabled();
        }
        #endregion
    }
}
