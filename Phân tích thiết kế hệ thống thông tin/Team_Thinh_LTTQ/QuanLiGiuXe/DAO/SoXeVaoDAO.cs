using QuanLiGiuXe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiuXe.DAO
{
    class SoXeVaoDAO
    {
        private static SoXeVaoDAO instance;
        public static SoXeVaoDAO Instance {
            get { if (instance == null) instance = new SoXeVaoDAO(); return SoXeVaoDAO.instance; }
            private set { SoXeVaoDAO.instance = value; }
        }

        private SoXeVaoDAO() { }

        public List<SoXeVao> GetListXeVao()
        {
            List<SoXeVao> listXeVao = new List<SoXeVao>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM SoXeVao");
            foreach (DataRow item in data.Rows)
            {
                SoXeVao cate = new SoXeVao(item);
                listXeVao.Add(cate);
            }
            return listXeVao;
        }

    }
}
