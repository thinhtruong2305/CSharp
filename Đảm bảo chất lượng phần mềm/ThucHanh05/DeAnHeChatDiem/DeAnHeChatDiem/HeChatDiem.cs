using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeAnHeChatDiem
{
    public class HeChatDiem : List<ChatDiem>
    {
        public int SoPhanTu
        {
            get { return this.Count; }
        }

        public void Them(ChatDiem cd)
        {
            this.Add(cd);
        }
        public void Xoa(ChatDiem cd)
        {
            this.Remove(cd);
        }
        public void XoaViTri(int i)
        {
            this.RemoveAt(i);
        }
        public ChatDiem KhoiTam()
        {
            double m = 0;
            double x = 0, y = 0, z = 0;
            foreach (ChatDiem cd in this)
            {
                m += cd.KhoiLuong;
                x += cd.KhoiLuong * cd.HoanhDo;
                y += cd.KhoiLuong * cd.TungDo;
                z += cd.KhoiLuong * cd.CaoDo;
            }
            return new ChatDiem(m, x / m, y / m, z / m);
        }
    }
}
