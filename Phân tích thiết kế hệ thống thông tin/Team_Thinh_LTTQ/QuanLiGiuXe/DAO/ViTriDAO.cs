using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiGiuXe.DTO;

namespace QuanLiGiuXe.DAO
{
    class ViTriDAO
    {
        private static ViTriDAO instance;
        public static ViTriDAO Instance
        {
            get { if (instance == null) instance = new ViTriDAO(); return ViTriDAO.instance; }
            private set { ViTriDAO.instance = value; }
        }

        private ViTriDAO() { }

        public DataTable GetListViTri()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.ViTri");
        }

        public List<ViTri> getListViTriByIdKhuVuc(int idKhuVuc)
        {
            string query = "SELECT * FROM dbo.ViTri WHERE ViTri.MaKhuVuc = @idKhuVuc ";
            DataTable resulf = DataProvider.Instance.ExecuteQuery(query, new object[] { idKhuVuc });
            List<ViTri> list = new List<ViTri>();
            foreach (DataRow item in resulf.Rows)
            {
                ViTri viTri = new ViTri(item);
                list.Add(viTri);
            }
            return list;
        }

        public bool AddViTri(string tenvitri, int makhuvuc, int trangthai)
        {
            string query = string.Format("INSERT dbo.ViTri ( TenViTri, MaKhuVuc, TrangThai)VALUES  ( N'{0}', N'{1}','{2}')", tenvitri, makhuvuc, trangthai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteViTri(string tenvitri)
        {
            string query = "delete ViTri Where TenViTri = @tenvitri and TrangThai = 0";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenvitri });

            return result > 0;
        }

        public bool UpdateViTri(int mavt ,string tenvitri, int makhuvuc, int trangthai)
        {
            string query = string.Format("UPDATE dbo.ViTri SET TenViTri = N'{1}', MaKhuVuc = '{3}' , TrangThai = '{2}' where idViTri = N'{0}'",mavt, tenvitri, trangthai,makhuvuc);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
