using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeAnHeChatDiem
{
    public class ChatDiem
    {
        #region Khai báo biến
        private double m;
        private double x, y, z;
        #endregion

        #region Các hàm tạo
        public ChatDiem()
        {
            m = 1;
            x = y = z = 0;
        }
        public ChatDiem(double _m, double _x, double _y, double _z)
        {
            m = _m;
            x = _x;
            y = _y;
            z = _z;
        }
        #endregion

        #region Các đặc trưng
        public double KhoiLuong
        {
            set { m = value; }
            get { return m; }
        }
        public double HoanhDo
        {
            set { x = value; }
            get { return x; }
        }
        public double TungDo
        {
            set { y = value; }
            get { return y; }
        }
        public double CaoDo
        {
            set { z = value; }
            get { return z; }
        }
        #endregion

        #region Các phương thức
        public static ChatDiem KhoiTam(ChatDiem cd1, ChatDiem cd2)
        {
            double m = cd1.m + cd2.m;
            double x = cd1.m * cd1.x + cd2.m * cd2.x;
            double y = cd1.m * cd1.y + cd2.m * cd2.y;
            double z = cd1.m * cd1.z + cd2.m * cd2.z;
            return new ChatDiem(m, x / m, y / m, z / m);
        }
        public static ChatDiem KhoiTam(ChatDiem[] cd)
        {
            double m = 0;
            double x = 0, y = 0, z = 0;
            for (int i = 0; i < cd.Length; i++)
            {
                m += cd[i].m;
                x += cd[i].m * cd[i].x;
                y += cd[i].m * cd[i].y;
                z += cd[i].m * cd[i].z;
            }
            return new ChatDiem(m, x / m, y / m, z / m);
        }
        public static bool operator ==(ChatDiem cd1, ChatDiem cd2)
        {
            return cd1.m == cd2.m && cd1.x == cd2.x && cd1.y == cd2.y && cd1.z == cd2.z;
        }
        public static bool operator !=(ChatDiem cd1, ChatDiem cd2)
        {
            return cd1.m != cd2.m || cd1.x != cd2.x || cd1.y != cd2.y || cd1.z != cd2.z;
        }
        #endregion
    }
}
