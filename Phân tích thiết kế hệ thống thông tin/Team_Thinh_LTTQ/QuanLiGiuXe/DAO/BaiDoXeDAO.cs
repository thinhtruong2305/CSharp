using QuanLiGiuXe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiuXe.DAO
{
    class BaiDoXeDAO
    {
        private static BaiDoXeDAO instance;

        internal static BaiDoXeDAO Instance {
                get { if (instance == null) instance = new BaiDoXeDAO(); return BaiDoXeDAO.instance; }
                private set { BaiDoXeDAO.instance = value; }
        }

        public List<BaiDoXe> GetListBaiDoXe(int id)
        {
            List<BaiDoXe> listBaiDoXe = new List<BaiDoXe>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM BaiDoXe");
            foreach (DataRow item in data.Rows)
            {
                BaiDoXe cate = new BaiDoXe(item);
                listBaiDoXe.Add(cate);
            }
            return listBaiDoXe;
        }
    }
}
