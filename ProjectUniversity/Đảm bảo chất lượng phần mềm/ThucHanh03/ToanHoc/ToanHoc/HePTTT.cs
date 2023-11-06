using System;
using System.Collections.Generic;
using System.Text;

namespace ToanHoc
{
    public class HePTTT
    {
        #region Khai báo biến
        const double epsilon = 1E-6;
        private MatPhang[] mp0;
        #endregion

        #region Các hàm tạo
        public HePTTT()
        {
            mp0 = new MatPhang[3] { new MatPhang(), new MatPhang(), new MatPhang() };
        }
        public HePTTT(MatPhang mp1, MatPhang mp2, MatPhang mp3)
        {
            mp0 = new MatPhang[3];
            mp0[0] = mp1;
            mp0[1] = mp2;
            mp0[2] = mp3;
        }
        #endregion

        #region Các đặc trưng
        public MatPhang this[int i]
        {
            set { mp0[i] = value; }
            get { return mp0[i]; }
        }
        #endregion

        #region Các phương thức
        public double DinhThucCap2(double a, double b, double c, double d)
        {
            return a * d - b * c;
        }
        public double DinhThucCap3(double a1, double b1, double c1,
        double a2, double b2, double c2,
        double a3, double b3, double c3)
        {
            return a1 * DinhThucCap2(b2, c2, b3, c3)
            - b1 * DinhThucCap2(a2, c2, a3, c3)
            + c1 * DinhThucCap2(a2, b2, a3, b3);
        }
        public bool CoLoiGiai()
        {
            return Math.Abs(DinhThucCap3(mp0[0].A, mp0[0].B, mp0[0].C,
            mp0[1].A, mp0[1].B, mp0[1].C,
            mp0[2].A, mp0[2].B, mp0[2].C)) >= epsilon;
        }
        public bool CoVoSoLoiGiai()
        {
            return Math.Abs(DinhThucCap3(mp0[0].A, mp0[0].B, mp0[0].C,
            mp0[1].A, mp0[1].B, mp0[1].C,
            mp0[2].A, mp0[2].B, mp0[2].C)) < epsilon
            && Math.Abs(DinhThucCap3(mp0[0].D, mp0[0].B, mp0[0].C,
            mp0[1].D, mp0[1].B, mp0[1].C,
            mp0[2].D, mp0[2].B, mp0[2].C)) < epsilon
            && Math.Abs(DinhThucCap3(mp0[0].A, mp0[0].D, mp0[0].C,
            mp0[1].A, mp0[1].D, mp0[1].C,
            mp0[2].A, mp0[2].D, mp0[2].C)) < epsilon
            && Math.Abs(DinhThucCap3(mp0[0].A, mp0[0].B, mp0[0].D,
            mp0[1].A, mp0[1].B, mp0[1].D,
            mp0[2].A, mp0[2].B, mp0[2].D)) < epsilon;
        }
        public bool KhongCoSoLoiGiai()
        {
            return Math.Abs(DinhThucCap3(mp0[0].A, mp0[0].B, mp0[0].C,
            mp0[1].A, mp0[1].B, mp0[1].C,
            mp0[2].A, mp0[2].B, mp0[2].C)) < epsilon
            && (Math.Abs(DinhThucCap3(mp0[0].D, mp0[0].B, mp0[0].C,
            mp0[1].D, mp0[1].B, mp0[1].C,
            mp0[2].D, mp0[2].B, mp0[2].C)) >= epsilon
            || Math.Abs(DinhThucCap3(mp0[0].A, mp0[0].D, mp0[0].C,
            mp0[1].A, mp0[1].D, mp0[1].C,
            mp0[2].A, mp0[2].D, mp0[2].C)) >= epsilon
            || Math.Abs(DinhThucCap3(mp0[0].A, mp0[0].B, mp0[0].D,
            mp0[1].A, mp0[1].B, mp0[1].D,
            mp0[2].A, mp0[2].B, mp0[2].D)) >= epsilon);
        }
        public Diem3D LoiGiai()
        {
            if (CoLoiGiai())
            {
                double dt = DinhThucCap3(mp0[0].A, mp0[0].B, mp0[0].C,
                mp0[1].A, mp0[1].B, mp0[1].C,
                mp0[2].A, mp0[2].B, mp0[2].C);
                double dtx = DinhThucCap3(mp0[0].D, mp0[0].B, mp0[0].C,
                mp0[1].D, mp0[1].B, mp0[1].C,
                mp0[2].D, mp0[2].B, mp0[2].C);
                double dty = DinhThucCap3(mp0[0].A, mp0[0].D, mp0[0].C,
                mp0[1].A, mp0[1].D, mp0[1].C,
                mp0[2].A, mp0[2].D, mp0[2].C);
                double dtz = DinhThucCap3(mp0[0].A, mp0[0].B, mp0[0].D,
                mp0[1].A, mp0[1].B, mp0[1].D,
                mp0[2].A, mp0[2].B, mp0[2].D);
                return new Diem3D(dtx / dt, dty / dt, dtz / dt);
            }
            return null;
        }
        #endregion

    }
}
