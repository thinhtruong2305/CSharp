using System;
using System.Collections.Generic;
using System.Text;

namespace ToanHoc
{
    public class TamGiac
    {
        #region Khai báo biến
        private Diem3D A0, B0, C0;
        #endregion

        #region Các hàm tạo
        public TamGiac()
        {
            A0 = new Diem3D();
            B0 = new Diem3D();
            C0 = new Diem3D();
        }
        public TamGiac(Diem3D A, Diem3D B, Diem3D C)
        {
            A0 = A;
            B0 = B;
            C0 = C;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="diemTamGiac">Lưu ý chỉ lấy 3 phần tử đầu</param>
        public TamGiac(Diem3D[] diemTamGiac)
        {
            A0 = diemTamGiac[0];
            B0 = diemTamGiac[1];
            C0 = diemTamGiac[2];
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
        #endregion

        #region Các phương thức
        public double AB()
        {
            return Diem3D.KhoangCach(A0, B0);
        }
        public double AC()
        {
            return Diem3D.KhoangCach(A0, C0);
        }
        public double BC()
        {
            return Diem3D.KhoangCach(B0, C0);
        }
        public double ChuVi()
        {
            return AB() + BC() + AC();
        }
        public double DienTich()
        {
            double chuVi = ChuVi() / 2;
            return Math.Sqrt(chuVi * (chuVi - AB()) * (chuVi - AC()) * (chuVi - BC()));
        }
        public static bool isTamGiac(Diem3D A1, Diem3D B1, Diem3D C1)
        {
            //return A1 != B1 && A1 != C1 && B1 != C1;

            const double Epsilon = 1e-10;
            bool HopLe = A1 != B1 && A1 != C1 && B1 != C1;
            HopLe &= Vector3D.TichCoHuong(new Vector3D(A1, B1), new Vector3D(A1, C1)).Module() > Epsilon;
            return HopLe;
        }
        #endregion
    }
}
