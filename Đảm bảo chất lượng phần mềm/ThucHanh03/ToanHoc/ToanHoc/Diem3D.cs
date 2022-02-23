using System;

namespace ToanHoc
{
    public class Diem3D
    {
        #region Khai báo biến
        private double x0, y0, z0;
        private static Random rndObj = new Random(DateTime.Now.Millisecond);
        private static double KichCo = 10;
        #endregion

        #region Các hàm tạo
        public Diem3D()
        {
            x0 = y0 = z0 = 0;
        }
        public Diem3D(double x, double y, double z)
        {
            x0 = x;
            y0 = y;
            z0 = z;
        }
        #endregion

        #region Các đặc trưng
        public double x
        {
            set { x0 = value; }
            get { return x0; }
        }

        public double y
        {
            set { y0 = value; }
            get { return y0; }
        }

        public double z
        {
            set { z0 = value; }
            get { return z0; }
        }
        #endregion

        #region Các phương thức
        public static Diem3D TrungDiem(Diem3D A, Diem3D B)
        {
            return new Diem3D((A.x0 + B.x0) / 2, (A.y0 + B.y0) / 2, (A.z0 + B.z0) / 2);
        }

        public static Diem3D TrongTam(Diem3D A, Diem3D B, Diem3D C)
        {
            return new Diem3D((A.x0 + B.x0 + C.x0) / 3, (A.y0 + B.y0 + C.y0) / 3, (A.z0 + B.z0 + C.z0) / 3);
        }

        public static Diem3D TrongTam(Diem3D[] diem)
        {
            int count = diem.Length;
            Diem3D d = new Diem3D();
            for (int i = 0; i < diem.Length; i++)
            {
                d.x0 += diem[i].x0;
                d.y0 += diem[i].y0;
                d.z0 += diem[i].z0;
            }
            return new Diem3D(d.x0 / count, d.y0 / count, d.z0 / count);
        }

        public static double KhoangCach(Diem3D d1, Diem3D d2)
        {
            return Math.Sqrt(Math.Pow(d1.x0 - d2.x0, 2) + Math.Pow(d1.y0 - d2.y0, 2) + Math.Pow(d1.z0 - d2.z0, 2));
        }
        public static Diem3D DiemNgauNhien()
        {
            return new Diem3D(rndObj.NextDouble() * KichCo, rndObj.NextDouble() * KichCo, rndObj.NextDouble() * KichCo);
        }

        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", x0, y0, z0);
        }

        public override bool Equals(object o)
        {
            if (o == null || !this.GetType().Equals(o.GetType()))
                return false;
            return x0 == ((Diem3D)o).x0 && y0 == ((Diem3D)o).y0 && z0 == ((Diem3D)o).z0;
        }

        public override int GetHashCode()
        {
            return (x0 == 0 && y0 == 0 && z0 == 0) ? 1 : 0;
        }

        public static bool operator ==(Diem3D d1, Diem3D d2)
        {
            return d1.x0 == d2.x0 && d1.y0 == d2.y0 && d1.z0 == d2.z0;
        }

        public static bool operator !=(Diem3D d1, Diem3D d2)
        {
            return d1.x0 != d2.x0 || d1.y0 != d2.y0 || d1.z0 != d2.z0;
        }
        #endregion
    }
}
