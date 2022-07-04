using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiuXe.DAO
{
    class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance; // Ctrl + R + E

        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return instance; }
            private set { instance = value; }
        }

        private TaiKhoanDAO() { }

        

        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @userName , @displayName , @password , @newPassword", new object[] { userName, displayName, pass, newPass });

            return result > 0;
        }

        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.TaiKhoan");
        }
        //lay account dua vao userName
       
        public bool Insert(string tentk, string matkhau, int idnhanvien)
        {
            string query = string.Format("INSERT dbo.TaiKhoan ( IdNhanVien, TaiKhoan, MatKhau )VALUES  ( N'{2}', N'{0}', N'{1}')", tentk, matkhau, idnhanvien);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool Update(int idtk, string tentk, string matkhau, int idnhanvien)
        {
            string query = string.Format("UPDATE dbo.TaiKhoan SET TaiKhoan = N'{1}', MatKhau = N'{2}', IdNhanVien = N'{3}' WHERE IdTaiKhoan = N'{0}'", idtk, tentk, matkhau,idnhanvien);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool Delete(string tentk)
        {
            string query = string.Format("Delete TaiKhoan where TaiKhoan = N'{0}'", tentk);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        
    }
}
