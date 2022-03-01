using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeAnMaTran
{
    public class MaTranCap4
    {
        #region Khai báo biến
        private double[,] a;
        private const double epislon = 1E-6;
        #endregion

        #region Các hàm tạo
        public MaTranCap4()
        {
            a = new double[4, 4] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
        }
        public MaTranCap4(double a00, double a01, double a02, double a03,
                          double a10, double a11, double a12, double a13,
                          double a20, double a21, double a22, double a23,
                          double a30, double a31, double a32, double a33)
        {
            a = new double[4, 4];

            a[0, 0] = a00; a[0, 1] = a01; a[0, 2] = a02; a[0, 3] = a03;
            a[1, 0] = a10; a[1, 1] = a11; a[1, 2] = a12; a[1, 3] = a13;
            a[2, 0] = a20; a[2, 1] = a21; a[2, 2] = a22; a[2, 3] = a23;
            a[3, 0] = a30; a[3, 1] = a31; a[3, 2] = a32; a[3, 3] = a33;
        }
        #endregion

        #region Các đặc trưng
        public double DinhThuc
        {
            get
            {
                MaTranCap3 ba00 = new MaTranCap3(a[1, 1], a[1, 2], a[1, 3],
                a[2, 1], a[2, 2], a[2, 3],
               a[3, 1], a[3, 2], a[3, 3]);
                MaTranCap3 ba01 = new MaTranCap3(a[1, 0], a[1, 2], a[1, 3],
                a[2, 0], a[2, 2], a[2, 3],
               a[3, 0], a[3, 2], a[3, 3]);
                MaTranCap3 ba02 = new MaTranCap3(a[1, 0], a[1, 1], a[1, 3],
                a[2, 0], a[2, 1], a[2, 3],
               a[3, 0], a[3, 1], a[3, 3]);
                MaTranCap3 ba03 = new MaTranCap3(a[1, 0], a[1, 1], a[1, 2],
                a[2, 0], a[2, 1], a[2, 2],
                a[3, 0], a[3, 1], a[3, 2]);
                return a[0, 0] * ba00.DinhThuc - a[0, 1] * ba01.DinhThuc
                + a[0, 2] * ba02.DinhThuc - a[0, 3] * ba03.DinhThuc;
            }
        }
        public double this[int i, int j]
        { // Cách lấy móc vuông với 2 chỉ số
            set { a[i, j] = value; }
            get { return a[i, j]; }
        }
        #endregion

        #region Các phương thức
        public bool KhaNghich()
        {
            return Math.Abs(DinhThuc) > epislon;
        }
        public static MaTranCap4 operator +(MaTranCap4 mt1, MaTranCap4 mt2)
        {
            MaTranCap4 mt = new MaTranCap4();
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    mt[i, j] = mt1[i, j] + mt2[i, j];
            return mt;
        }

        public static MaTranCap4 operator -(MaTranCap4 mt1, MaTranCap4 mt2)
        {
            MaTranCap4 mt = new MaTranCap4();
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    mt[i, j] = mt1[i, j] - mt2[i, j];
            return mt;
        }
        public static MaTranCap4 operator *(MaTranCap4 mt1, MaTranCap4 mt2)
        {
            MaTranCap4 mt = new MaTranCap4();
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    for (int k = 0; k < 4; k++)
                        mt[i, j] += mt1[i, k] * mt2[k, j];
            return mt;
        }
        public MaTranCap4 NghichDao()
        {
            if (KhaNghich())
            {
                double dt = DinhThuc;

                MaTranCap4 cv = new MaTranCap4(a[0, 0], a[1, 0], a[2, 0], a[3, 0],
                                               a[0, 1], a[1, 1], a[2, 1], a[3, 1],
                                               a[0, 2], a[1, 2], a[2, 2], a[3, 2],
                                               a[0, 3], a[1, 3], a[2, 3], a[3, 3]);

                double dt00 = (new MaTranCap3(cv[1, 1], cv[1, 2], cv[1, 3],
                cv[2, 1], cv[2, 2], cv[2, 3],
                cv[3, 1], cv[3, 2], cv[3, 3])).DinhThuc;

                double dt01 = (new MaTranCap3(cv[1, 0], cv[1, 2], cv[1, 3],
                cv[2, 0], cv[2, 2], cv[2, 3],
                cv[3, 0], cv[3, 2], cv[3, 3])).DinhThuc;

                double dt02 = (new MaTranCap3(cv[1, 0], cv[1, 1], cv[1, 3],
                cv[2, 0], cv[2, 1], cv[2, 3],
                cv[3, 0], cv[3, 1], cv[3, 3])).DinhThuc;

                double dt03 = (new MaTranCap3(cv[1, 0], cv[1, 1], cv[1, 2],
                cv[2, 0], cv[2, 1], cv[2, 2],
                cv[3, 0], cv[3, 1], cv[3, 2])).DinhThuc;

                double dt10 = (new MaTranCap3(cv[0, 1], cv[0, 2], cv[0, 3],
                cv[2, 1], cv[2, 2], cv[2, 3],
                cv[3, 1], cv[3, 2], cv[3, 3])).DinhThuc;

                double dt11 = (new MaTranCap3(cv[0, 0], cv[0, 2], cv[0, 3],
                cv[2, 0], cv[2, 2], cv[2, 3],
                cv[3, 0], cv[3, 2], cv[3, 3])).DinhThuc;

                double dt12 = (new MaTranCap3(cv[0, 0], cv[0, 1], cv[0, 3],
                cv[2, 0], cv[2, 1], cv[2, 3],
                cv[3, 0], cv[3, 1], cv[3, 3])).DinhThuc;

                double dt13 = (new MaTranCap3(cv[0, 0], cv[01, 1], cv[0, 2],
                cv[2, 0], cv[2, 1], cv[2, 2],
                cv[3, 0], cv[3, 1], cv[3, 2])).DinhThuc;

                double dt20 = (new MaTranCap3(cv[0, 1], cv[0, 2], cv[0, 3],
                cv[1, 1], cv[1, 2], cv[1, 3],
                cv[3, 1], cv[3, 2], cv[3, 3])).DinhThuc;
                
                double dt21 = (new MaTranCap3(cv[0, 0], cv[0, 2], cv[0, 3],
                cv[1, 0], cv[1, 2], cv[1, 3],
                cv[3, 0], cv[3, 2], cv[3, 3])).DinhThuc;
                
                double dt22 = (new MaTranCap3(cv[0, 0], cv[0, 1], cv[0, 3],
                cv[1, 0], cv[1, 1], cv[1, 3],
                cv[3, 0], cv[3, 1], cv[3, 3])).DinhThuc;
                
                double dt23 = (new MaTranCap3(cv[0, 0], cv[0, 1], cv[0, 2],
                cv[1, 0], cv[1, 1], cv[1, 2],
                cv[3, 0], cv[3, 1], cv[3, 2])).DinhThuc;
                
                double dt30 = (new MaTranCap3(cv[0, 1], cv[0, 2], cv[0, 3],
                cv[1, 1], cv[1, 2], cv[1, 3],
                cv[2, 1], cv[2, 2], cv[2, 3])).DinhThuc;
                
                double dt31 = (new MaTranCap3(cv[0, 0], cv[0, 2], cv[0, 3],
                cv[1, 0], cv[1, 2], cv[1, 3],
                cv[2, 0], cv[2, 2], cv[2, 3])).DinhThuc;
                
                double dt32 = (new MaTranCap3(cv[0, 0], cv[0, 1], cv[0, 3],
                cv[1, 0], cv[1, 1], cv[1, 3],
                cv[2, 0], cv[2, 1], cv[2, 3])).DinhThuc;
                
                double dt33 = (new MaTranCap3(cv[0, 0], cv[0, 1], cv[0, 2],
                cv[1, 0], cv[1, 1], cv[1, 2],
                cv[2, 0], cv[2, 1], cv[2, 2])).DinhThuc;
                
                return new MaTranCap4(dt00 / dt, -dt01 / dt, dt02 / dt, dt03 / dt,
                                     -dt10 / dt, dt11 / dt, -dt12 / dt, dt13 / dt,
                                      dt20 / dt, -dt21 / dt, dt22 / dt, -dt23 / dt,
                                     -dt30 / dt, dt31 / dt, -dt32 / dt, dt33 / dt);
            }
            return null;
        }
        #endregion
    }
}
