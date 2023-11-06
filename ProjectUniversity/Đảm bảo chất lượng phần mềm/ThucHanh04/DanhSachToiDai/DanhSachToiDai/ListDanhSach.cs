using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSachToiDai
{
    class ListDanhSach
    {
        #region Khai báo biến
        private List<DanhSach> lstDanhSach;
        #endregion

        # region Các hàm tạo
        public ListDanhSach()
        {
            lstDanhSach = new List<DanhSach>();
        }
        #endregion

        #region Các đặc trưng
        public int Count
        {
            get { return lstDanhSach.Count; }
        }

        public DanhSach this[int i]
        { // Cách lấy móc vuông
            set { lstDanhSach[i] = value; }
            get { return lstDanhSach[i]; }
        }
        #endregion

        #region Các phương thức
        public void Add(DanhSach th)
        {
            lstDanhSach.Add(th);
        }
        public int SoPhanTuMax(int ts)
        {
            int SoPhanTu = 0;
            foreach (DanhSach th in lstDanhSach)
            {
                if (th.Tong == ts)
                    if (th.CacPhanTu.Count >= SoPhanTu)
                        SoPhanTu = th.CacPhanTu.Count;
            }
            return SoPhanTu;
        }
        public DanhSach TapToiDai(int ts)
        {
            int sptMax = SoPhanTuMax(ts);
            foreach (DanhSach th in lstDanhSach)
            {
                if (th.Tong == ts && th.CacPhanTu.Count == sptMax)
                    return th;
            }
            return null;
        }
        #endregion
    }
}
