using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiuXe.DTO
{
    class TaiKhoan
    {
        private int idnhanvien;
        private int idtaikhoan;
        private string tentk;
        private string matkhau;
        public TaiKhoan(DataRow row)
        {
            this.Idtaikhoan = (int)row["IdTaiKhoan"];
            this.Idnhanvien = (int)row["IdNhanVien"];
            this.Tentk = row["TaiKhoan"].ToString();
            this.Matkhau = row["MatKhau"].ToString();
        }

        public int Idnhanvien { get => idnhanvien; set => idnhanvien = value; }
        public int Idtaikhoan { get => idtaikhoan; set => idtaikhoan = value; }
        public string Tentk { get => tentk; set => tentk = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
    }
}
