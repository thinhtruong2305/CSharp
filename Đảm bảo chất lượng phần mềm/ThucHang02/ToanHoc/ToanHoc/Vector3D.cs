using System;
using System.Collections.Generic;
using System.Text;

namespace ToanHoc
{
    public class Vector3D : Diem3D
    {
        #region Khai báo biến
        #endregion
        #region Các hàm tạo
        public Vector3D() : base()
        {
        }
        public Vector3D(double x, double y, double z) : base(x, y, z)
        {
        }
        public Vector3D(Diem3D D)
        {
            x = D.x;
            y = D.y;
            z = D.z;
        }
        public Vector3D(Diem3D A, Diem3D B)
        {
            x = B.x - A.x;
            y = B.y - A.y;
            z = B.z - A.z;
        }
        #endregion
        #region Các đặc trưng
        #endregion
        #region Các phương thức
        public double Module()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
        public static double TichVoHuong(Vector3D v1, Vector3D v2)
        {
            return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
        }
        public static Vector3D TichCoHuong(Vector3D v1, Vector3D v2)
        {
            double x0 = v1.y * v2.z - v2.y * v1.z;
            double y0 = v1.z * v2.x - v2.z * v1.x;
            double z0 = v1.x * v2.y - v2.x * v1.y;
            return new Vector3D(x0, y0, z0);
        }
        public static double TichHonTap(Vector3D v1, Vector3D v2, Vector3D v3)
        {
            return TichVoHuong(TichCoHuong(v1, v2), v3);
        }
        public static double DinhThuc(double a, double b, double c, double d)
        {
            return a * d - b * c;
        }
        #endregion
    }
}
