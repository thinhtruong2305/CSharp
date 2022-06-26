using CandyBugWinformDemo.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyBugWinformDemo.Control
{
    class CategoryDAO
    {
        private static CategoryDAO instence;

        public static CategoryDAO Instence 
        {
            get
            {
                if (instence == null)
                {

                    if (instence == null)
                    {
                        instence = new CategoryDAO();
                    }

                }
                return CategoryDAO.instence;
            }

            set => instence = value;
        }

        private CategoryDAO() { }
        public List<Category> getListCategory()
        {
            List<Category> list = new List<Category>();
            string query = "SELECT * FROM Category";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Category cate = new Category(item);
                list.Add(cate);
            }
            return list;
        }
        public bool addCategory( string name)
        {
            string query = string.Format("INSERT Category (name) VALUES (N'{0}')", name);
            int resulf = DataProvider.Instance.ExecuteNonQuery(query);
            return resulf > 0;
        }
        public void removeCategory()
        {

        }
        public void updateCategory()
        {

        }
        public string getCategory(string name)
        {
            string query = "SELECT * FROM Category WHERE name = '" + name +"'";
            string nameCategory = DataProvider.Instance.ExecuteScarlar(query).ToString();
            return nameCategory;
        }
    }
}

