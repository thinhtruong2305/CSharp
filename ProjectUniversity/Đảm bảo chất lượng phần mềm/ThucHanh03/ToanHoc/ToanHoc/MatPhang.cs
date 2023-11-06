using System;
using System.Collections.Generic;
using System.Text;

namespace ToanHoc
{
    public class MatPhang
    {
        #region Khai báo biến
        const double epsilon = 1E-6;
        private double A0, B0, C0, D0;
        #endregion

        #region Các hàm tạo
        public MatPhang()
        {
            A0 = B0 = C0 = D0 = 0;
        }
        public MatPhang(double a, double b, double c, double d)
        {
            A0 = a;
            B0 = b;
            C0 = c;
            D0 = d;
        }
        #endregion

        #region Các đặc trưng
        public double A
        {
            set { A0 = value; }
            get { return A0; }
        }
        public double B
        {
            set { B0 = value; }
            get { return B0; }
        }
        public double C
        {
            set { C0 = value; }
            get { return C0; }
        }
        public double D
        {
            set { D0 = value; }
            get { return D0; }
        }
        #endregion

        #region Các phương thức
        public static bool LaMatPhang(double A1, double B1, double C1, double D1)
        {
            return Math.Abs(A1 * A1 + B1 * B1 + C1 * C1) > epsilon;
        }
        public static bool SongSong(MatPhang mp1, MatPhang mp2)
        {
            return Math.Abs(mp1.A0 * mp2.B0 - mp1.B0 * mp2.A0) < epsilon
            && Math.Abs(mp1.B0 * mp2.C0 - mp1.C0 * mp2.B0) < epsilon
            && Math.Abs(mp1.C0 * mp2.A0 - mp1.A0 * mp2.C0) < epsilon
            && (Math.Abs(mp1.A0 * mp2.D0 - mp1.D0 * mp2.A0) >= epsilon
            || Math.Abs(mp1.B0 * mp2.D0 - mp1.D0 * mp2.B0) >= epsilon
            || Math.Abs(mp1.C0 * mp2.D0 - mp1.D0 * mp2.C0) >= epsilon);
        }
        public static bool TrungNhau(MatPhang mp1, MatPhang mp2)
        {
            return Math.Abs(mp1.A0 * mp2.B0 - mp1.B0 * mp2.A0) < epsilon
            && Math.Abs(mp1.B0 * mp2.C0 - mp1.C0 * mp2.B0) < epsilon
            && Math.Abs(mp1.C0 * mp2.A0 - mp1.A0 * mp2.C0) < epsilon
            && Math.Abs(mp1.A0 * mp2.D0 - mp1.D0 * mp2.A0) < epsilon
            && Math.Abs(mp1.B0 * mp2.D0 - mp1.D0 * mp2.B0) < epsilon
            && Math.Abs(mp1.C0 * mp2.D0 - mp1.D0 * mp2.C0) < epsilon;
        }
        public static bool CatNhau(MatPhang mp1, MatPhang mp2)
        {
            return Math.Abs(mp1.A0 * mp2.B0 - mp1.B0 * mp2.A0) >= epsilon
            || Math.Abs(mp1.B0 * mp2.C0 - mp1.C0 * mp2.B0) >= epsilon
            || Math.Abs(mp1.C0 * mp2.A0 - mp1.A0 * mp2.C0) >= epsilon;
        }
        #endregion
    }
    }
