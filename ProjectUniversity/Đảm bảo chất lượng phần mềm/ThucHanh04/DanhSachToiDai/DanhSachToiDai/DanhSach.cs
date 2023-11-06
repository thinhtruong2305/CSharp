using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSachToiDai
{
    class DanhSach
    {
        #region Khai báo biến
        private List<int> intList;
        #endregion

        #region Các hàm tạo
        public DanhSach()
        {
            intList = new List<int>();
        }

        public DanhSach(int n)
        {
            intList = new List<int>() { n };
        }

        public DanhSach(DanhSach t)
        {
            intList = new List<int>();
            foreach (int n in t.intList)
            {
                intList.Add(n);
            }
        }
        #endregion

        #region Các đặc trưng
        public List<int> CacPhanTu
        {
            set { intList = value; }
            get { return intList; }
        }

        public int Tong
        {
            get
            {
                int s = 0;
                foreach (int i in intList)
                    s += i;
                return s;
            }
        }
        #endregion

        #region Các phương thức
        public void Them(int i)
        {
            intList.Add(i);
        }

        public static DanhSach Hop(DanhSach t1, DanhSach t2)
        {
            DanhSach hop = new DanhSach(t1);
            foreach (int n in t2.intList)
            {
                hop.intList.Add(n);
            }
            return hop;
        }
        #endregion
    }
}
