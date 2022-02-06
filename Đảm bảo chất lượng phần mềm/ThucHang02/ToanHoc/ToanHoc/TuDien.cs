using System;
using System.Collections.Generic;
using System.Text;

namespace ToanHoc
{
    public class TuDien
    {
        #region Khai báo biến
        private Diem3D A0, B0, C0, D0;
        #endregion

        #region Các hàm tạo
        public TuDien()
        {
            A0 = new Diem3D();
            B0 = new Diem3D();
            C0 = new Diem3D();
            D0 = new Diem3D();
        }
        public TuDien(Diem3D A, Diem3D B, Diem3D C, Diem3D D)
        {
            A0 = A;
            B0 = B;
            C0 = C;
            D0 = D;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="diemTuDien">Lưu ý chỉ lấy 4 phần tử đầu</param>
        public TuDien(Diem3D[] diemTuDien)
        {
            A0 = diemTuDien[0];
            B0 = diemTuDien[1];
            C0 = diemTuDien[2];
            D0 = diemTuDien[3];
        }
        public TuDien(TamGiac ABC, Diem3D D)
        {
            A0 = ABC.A;
            B0 = ABC.B;
            C0 = ABC.C;
            D0 = D;
        }
        #endregion

        #region Các đặc trưng
        public Diem3D A
        {
            set { A0 = value; }
            get { return A0; }
        }
        public Diem3D B
        {
            set { B0 = value; }
            get { return B0; }
        }
        public Diem3D C
        {
            set { C0 = value; }
            get { return C0; }
        }
        public Diem3D D
        {
            set { D0 = value; }
            get { return D0; }
        }
        #endregion

        #region Các phương thức
        public double DienTichABC()
        {
            TamGiac ABC = new TamGiac(A0, B0, C0);
            return ABC.DienTich();
        }
        public double DienTichABD()
        {
            TamGiac ABD = new TamGiac(A0, B0, D0);
            return ABD.DienTich();
        }
        public double DienTichACD()
        {
            TamGiac ACD = new TamGiac(A0, C0, D0);
            return ACD.DienTich();
        }
        public double DienTichBCD()
        {
            TamGiac BCD = new TamGiac(B0, C0, D0);
            return BCD.DienTich();
        }
        #endregion
    }
}
