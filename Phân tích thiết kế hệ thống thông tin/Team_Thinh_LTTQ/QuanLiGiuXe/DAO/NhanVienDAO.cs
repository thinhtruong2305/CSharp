using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiuXe.DAO
{
    class NhanVienDAO
    {
        private static NhanVienDAO instance;
        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return NhanVienDAO.instance; }
            private set { NhanVienDAO.instance = value; }
        }

        private NhanVienDAO() { }

        public DataTable GetListNhanVien()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.NhanVien");
        }


        public bool AddNhanVien(string hoten, string chucvu, DateTime ngaysinh)
        {
            string query = string.Format("INSERT dbo.NhanVien ( HoTen, ChucVu, NgaySinh)VALUES  ( N'{0}', N'{1}','{2}')", hoten, chucvu, ngaysinh);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }


        public bool DeleteNhanVien(string tennhanvien)
        {
            string query = "delete NhanVien Where HoTen = @tennhanvien";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tennhanvien });

            return result > 0;
        }

        public bool UpdateNhanVien(int manv, string hoten, string chucvu, DateTime ngaysinh)
        {
            string query = string.Format("UPDATE dbo.NhanVien SET HoTen = N'{1}', NgaySinh = '{3}' , ChucVu = '{2}' where IdNhanVien = N'{0}'", manv, hoten, chucvu, ngaysinh);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
