using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiuXe.DTO
{
    class BaiDoXe
    {
        private int id;
        private string khu;
        private string diachi;
        private bool tinhtrang;
        public BaiDoXe(DataRow row)
        {
            this.id = (int)row["id"];
            this.khu = row["khu"].ToString();
            this.diachi = row["diaChi"].ToString();
            this.Tinhtrang = (bool)row["tinhTrang"];
        }

        public int Id { get => id; set => id = value; }
        public string Khu { get => khu; set => khu = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public bool Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
    }
}
