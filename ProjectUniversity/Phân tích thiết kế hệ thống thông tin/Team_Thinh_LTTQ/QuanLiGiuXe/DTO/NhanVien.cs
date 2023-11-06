using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiuXe.DTO
{
    public class NhanVien
    {
        private int idnhanvien;
        private string tennhanvien;
        private string chucvu;
        private DateTime ngaysinh;

        public NhanVien(DataRow row)
        {
            this.Idnhanvien = (int)row["IdNhanVien"];
            this.Tennhanvien = row["HoTen"].ToString();
            this.chucvu = row["ChucVu"].ToString();
            this.ngaysinh = (DateTime)row["NgaySinh"];
        }
        public int Idnhanvien { get => idnhanvien; set => idnhanvien = value; }
        public string Tennhanvien { get => tennhanvien; set => tennhanvien = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public DateTime Ngaysing { get => ngaysinh; set => ngaysinh = value; }
    }
}
