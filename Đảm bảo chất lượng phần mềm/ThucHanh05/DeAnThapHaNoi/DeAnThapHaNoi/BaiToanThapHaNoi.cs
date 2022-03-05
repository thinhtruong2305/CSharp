using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeAnThapHaNoi
{
    public class BaiToanThapHaNoi
    {
        #region Khai báo biến
        private string PhanDau;
        private string ttXuatPhat;
        private string ttDichDen;
        private FormKetQua frmKQ;

        private List<string> dsTT;
        #endregion

        #region Hàm tạo
        public BaiToanThapHaNoi()
        {
            PhanDau = "";
            ttXuatPhat = "";
            ttDichDen = "";
            frmKQ = new FormKetQua();
        }
        public BaiToanThapHaNoi(string PD, string ttXP, string ttDD, FormKetQua frm, List<String> ds)
        {
            PhanDau = PD;
            ttXuatPhat = ttXP;
            ttDichDen = ttDD;
            frmKQ = frm;
            dsTT = ds;
        }
        #endregion

        #region Phương thức
        public void GiaiBaiToan()
        {
            string c1 = ttXuatPhat.Substring(0, 1);
            string c2 = ttDichDen.Substring(0, 1);

            if (c1 == c2)
            {
                if (ttXuatPhat.Length > 1)
                {
                    BaiToanThapHaNoi btmoi = new BaiToanThapHaNoi(PhanDau + c1, ttXuatPhat.Substring(1), ttDichDen.Substring(1), frmKQ, dsTT);
                    btmoi.GiaiBaiToan();
                }
            }
            else
            {
                int thapXP = int.Parse(c1);
                int thapDD = int.Parse(c2);
                int thapTG = 3 - thapXP - thapDD;
                string ttTG = MyLib.Replicate(thapTG.ToString(), ttXuatPhat.Length - 1);

                if (ttXuatPhat.Length > 1)
                {
                    BaiToanThapHaNoi btmoi1 = new BaiToanThapHaNoi(PhanDau + c1, ttXuatPhat.Substring(1), ttDichDen.Substring(1), frmKQ, dsTT);
                    btmoi1.GiaiBaiToan();
                }
                // MessageBox.Show("Đưa đĩa số " + (ttTG.Length + 1) + " từ tháp " + thapXP + " sang tháp " + thapTG);
                // KetQua += "Đưa đĩa số " + (ttTG.Length + 1) + " từ tháp " + thapXP + " sang tháp " + thapTG + "\n";

                frmKQ.Add("Đưa đĩa số " + (ttTG.Length + 1) + " từ tháp " + thapXP + " sang tháp " + thapTG);
                dsTT.Add(PhanDau + c2 + ttTG);

                if (ttXuatPhat.Length > 1)
                {
                    BaiToanThapHaNoi btmoi2 = new BaiToanThapHaNoi(PhanDau + c1, ttXuatPhat.Substring(1), ttDichDen.Substring(1), frmKQ, dsTT);
                    btmoi2.GiaiBaiToan();
                }
            }
        }
        #endregion
    }
}
