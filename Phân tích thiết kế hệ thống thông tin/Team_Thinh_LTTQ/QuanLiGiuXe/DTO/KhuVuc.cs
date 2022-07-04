using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiuXe.DTO
{
    public class KhuVuc
    {
        private int makhuvuc;
        private string tenkhuvuc;
        private String trangthai;

        public KhuVuc(DataRow row)
        {
            this.Makhuvuc = Convert.ToInt32(row["MAKHUVUC"]);
            this.Tenkhuvuc = row["TenKhuVuc"].ToString();
            this.Trangthai = row["TrangThai"].ToString();
        }

        public int Makhuvuc { get => makhuvuc; set => makhuvuc = value; }
        public string Tenkhuvuc { get => tenkhuvuc; set => tenkhuvuc = value; }
        public String Trangthai { get => trangthai; set => trangthai = value; }
    }
}
