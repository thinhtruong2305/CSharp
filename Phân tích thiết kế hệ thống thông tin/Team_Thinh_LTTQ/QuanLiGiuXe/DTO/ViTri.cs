using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiuXe.DTO
{
    class ViTri
    {
        private int idvitri;
        private string tenvitri;
        private string trangthai;
        private int makhuvuc;

        public ViTri(DataRow row)
        {
            this.Idvitri = (int)row["idViTri"];
            this.Tenvitri = row["TenViTri"].ToString();
            this.Trangthai = row["TrangThai"].ToString();        
            this.Makhuvuc = (int)row["MaKhuVuc"];
        }

        public int Idvitri { get => idvitri; set => idvitri = value; }
        public string Tenvitri { get => tenvitri; set => tenvitri = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public int Makhuvuc { get => makhuvuc; set => makhuvuc = value; }
    }
}
