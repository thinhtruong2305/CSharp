using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeAnMaTran
{
    public class MaTranCap3
    {
        #region Khai báo biến
        private double[,] a;
        private const double epislon = 1E-6;
        #endregion

        #region Các hàm tạo
        public MaTranCap3()
        {
            a = new double[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        }
        public MaTranCap3(double a00, double a01, double a02, double a10, double a11, double a12, double a20, double a21, double a22)
        {
            a = new double[3, 3];

            a[0, 0] = a00; a[0, 1] = a01; a[0, 2] = a02;
            a[1, 0] = a10; a[1, 1] = a11; a[1, 2] = a12;
            a[2, 0] = a20; a[2, 1] = a21; a[2, 2] = a22;
        }
        #endregion

        #region Các đặc trưng
        public double DinhThuc
        {
            get
            {
                MaTranCap2 ba00 = new MaTranCap2(a[1, 1], a[1, 2], a[2, 1], a[2, 2]);
                MaTranCap2 ba01 = new MaTranCap2(a[1, 0], a[1, 2], a[2, 0], a[2, 2]);
                MaTranCap2 ba02 = new MaTranCap2(a[1, 0], a[1, 1], a[2, 0], a[2, 1]);

                return a[0, 0] * ba00.DinhThuc - a[0, 1] * ba01.DinhThuc + a[0, 2] * ba02.DinhThuc;
            }
        }
        public double this[int i, int j]
        { // cách lấy móc vuông với 2 chỉ số
            set { a[i, j] = value; }
            get { return a[i, j]; }
        }
        #endregion

        #region Các phương thức
        public bool KhaNghich()
        {
            return Math.Abs(DinhThuc) > epislon;
        }
        public static MaTranCap3 operator +(MaTranCap3 mt1, MaTranCap3 mt2)
        {
            return new MaTranCap3(mt1[0, 0] + mt2[0, 0], mt1[0, 1] + mt2[0, 1], mt1[0, 2] + mt2[0, 2],
            mt1[1, 0] + mt2[1, 0], mt1[1, 1] + mt2[1, 1], mt1[1, 2] + mt2[1, 2],
            mt1[2, 0] + mt2[2, 0], mt1[2, 1] + mt2[2, 1], mt1[2, 2] + mt2[2, 2]);
        }
        public static MaTranCap3 operator -(MaTranCap3 mt1, MaTranCap3 mt2)
        {
            return new MaTranCap3(mt1[0, 0] - mt2[0, 0], mt1[0, 1] - mt2[0, 1], mt1[0, 2] - mt2[0, 2],
            mt1[1, 0] - mt2[1, 0], mt1[1, 1] - mt2[1, 1], mt1[1, 2] - mt2[1, 2],
            mt1[2, 0] - mt2[2, 0], mt1[2, 1] - mt2[2, 1], mt1[2, 2] - mt2[2, 2]);
        }
        public static MaTranCap3 operator *(MaTranCap3 mt1, MaTranCap3 mt2)
        {
            MaTranCap3 mt = new MaTranCap3();
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    for (int k = 0; k < 3; k++)
                        mt[i, j] += mt1[i, k] * mt2[k, j];
            return mt;
        }
        public MaTranCap3 NghichDao()
        {
            if (KhaNghich())
            {
                double dt = DinhThuc;
                MaTranCap3 cv = new MaTranCap3(a[0, 0], a[1, 0], a[2, 0], a[0, 1], a[1, 1], a[2, 1], a[0, 2], a[1, 2], a[2, 2]);

                double dt00 = (new MaTranCap2(cv[1, 1], cv[1, 2], cv[2, 1], cv[2, 2])).DinhThuc;
                double dt01 = (new MaTranCap2(cv[1, 0], cv[1, 2], cv[2, 0], cv[2, 2])).DinhThuc;
                double dt02 = (new MaTranCap2(cv[1, 0], cv[1, 1], cv[2, 0], cv[2, 1])).DinhThuc;

                double dt10 = (new MaTranCap2(cv[0, 1], cv[0, 2], cv[2, 1], cv[2, 2])).DinhThuc;
                double dt11 = (new MaTranCap2(cv[0, 0], cv[0, 2], cv[2, 0], cv[2, 2])).DinhThuc;
                double dt12 = (new MaTranCap2(cv[0, 0], cv[0, 1], cv[2, 0], cv[2, 1])).DinhThuc;

                double dt20 = (new MaTranCap2(cv[0, 1], cv[0, 2], cv[1, 1], cv[1, 2])).DinhThuc;
                double dt21 = (new MaTranCap2(cv[0, 0], cv[0, 2], cv[1, 0], cv[1, 2])).DinhThuc;
                double dt22 = (new MaTranCap2(cv[0, 0], cv[0, 1], cv[1, 0], cv[1, 1])).DinhThuc;

                return new MaTranCap3(dt00 / dt, -dt01 / dt, dt02 / dt, -dt10 / dt, dt11 / dt, -dt12 / dt, dt20 / dt, -dt21 / dt, dt22 / dt);
            }
            return null;
        }
        #endregion
    }
}
