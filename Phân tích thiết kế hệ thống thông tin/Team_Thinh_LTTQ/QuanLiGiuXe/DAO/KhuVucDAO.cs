using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiGiuXe.DTO;

namespace QuanLiGiuXe.DAO
{
    class KhuVucDAO
    {
        private static KhuVucDAO instance;
        public static KhuVucDAO Instance
        {
            get { if (instance == null) instance = new KhuVucDAO(); return KhuVucDAO.instance; }
            private set { KhuVucDAO.instance = value; }
        }

        private KhuVucDAO() { }

        public DataTable GetListKhuVuc()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.KhuVuc");
        }

        public List<KhuVuc> getListKhuVuc()
        {
            List<KhuVuc> list = new List<KhuVuc>();
            string query = "SELECT * FROM KhuVuc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                KhuVuc khuVuc = new KhuVuc(item);
                list.Add(khuVuc);
            }
            return list;
        }

        public bool AddKhuVuc(string tenkhuvuc, string trangthai)
        {
            string query = string.Format("INSERT dbo.KhuVuc (TenKhuVuc,TrangThai)VALUES  ( N'{0}', N'{1}')",tenkhuvuc,trangthai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteKhuVuc(string tenkhuvuc)
        {
            string query = "DELETE KhuVuc Where TenKhuVuc = @tenkhuvuc and TrangThai = 0";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenkhuvuc });
       
            return result > 0;
        }

        public bool UpdateKhuVuc(string tenkhuvuc, int trangthai)
        {
            string query = string.Format("UPDATE dbo.KhuVuc SET TenKhuVuc = N'{0}', TrangThai = N'{1}' ", tenkhuvuc, trangthai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

    }
}
