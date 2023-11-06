using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiuXe.DAO
{
    class LoaiXeDAO
    {
        private static LoaiXeDAO instance;
        public static LoaiXeDAO Instance
        {
            get { if (instance == null) instance = new LoaiXeDAO(); return LoaiXeDAO.instance; }
            private set { LoaiXeDAO.instance = value; }
        }

        private LoaiXeDAO() { }

        public DataTable GetListLoaiXe()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.LoaiXe");
        }

        public bool AddLoaiXe(string tenloaixe, decimal dongia)
        {
            string query = string.Format("INSERT dbo.LoaiXe ( TenLoaiXe, DonGia)VALUES  ( N'{0}', N'{1}')", tenloaixe, dongia);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }


        public bool UpdateLoaiXe(int maloaixe, string tenloaixe, decimal gia)
        {
            string query = string.Format("UPDATE dbo.LoaiXe SET TenLoaiXe = N'{1}', DonGia = '{2}' where IdLoaiXe = N'{0}' ", maloaixe, tenloaixe, gia);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
