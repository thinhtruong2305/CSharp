using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeAnMaTran
{
    public class MaTranCap2
    {
        #region Khai báo biến
        private double[,] a;
        private const double epislon = 1E-6;
        #endregion

        #region Các hàm tạo
        public MaTranCap2()
        {
            a = new double[2, 2] { { 0, 0 }, { 0, 0 } };
        }
        public MaTranCap2(double a00, double a01, double a10, double a11)
        {
            a = new double[2, 2];
            a[0, 0] = a00;
            a[0, 1] = a01;
            a[1, 0] = a10;
            a[1, 1] = a11;
        }
        #endregion

        #region Các đặc trưng
        public double DinhThuc
        {
            get { return a[0, 0] * a[1, 1] - a[0, 1] * a[1, 0]; }
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

        public static MaTranCap2 operator +(MaTranCap2 mt1, MaTranCap2 mt2)
        {
            return new MaTranCap2(mt1[0, 0] + mt2[0, 0], mt1[0, 1] + mt2[0, 1],
            mt1[1, 0] + mt2[1, 0], mt1[1, 1] + mt2[1, 1]);
        }

        public static MaTranCap2 operator -(MaTranCap2 mt1, MaTranCap2 mt2)
        {
            return new MaTranCap2(mt1[0, 0] - mt2[0, 0], mt1[0, 1] - mt2[0, 1], mt1[1, 0] - mt2[1, 0], mt1[1, 1] - mt2[1, 1]);
        }

        public static MaTranCap2 operator *(MaTranCap2 mt1, MaTranCap2 mt2)
        {
            MaTranCap2 mt = new MaTranCap2();
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    for (int k = 0; k < 2; k++)
                        mt[i, j] += mt1[i, k] * mt2[k, j];
            return mt;
        }

        public MaTranCap2 NghichDao()
        {
            if (KhaNghich())
            {
                double dt = DinhThuc;
                return new MaTranCap2(a[1, 1] / dt, -a[0, 1] / dt, -a[1, 0] / dt, a[0, 0] / dt);
            }
            return null;
        }
        #endregion
    }
}
