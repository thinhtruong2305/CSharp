using CandyBugWinformDemo.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyBugWinformDemo.Control
{
    class ProductDAO
    {
        private static ProductDAO instence;

        public static ProductDAO Intence 
        {
            get
            {
                if (instence == null)
                {
                   
                        if (instence == null)
                        {
                        instence = new ProductDAO();
                        }
                    
                }
                return ProductDAO.instence;
            }

            set => instence = value; 
        }

        private ProductDAO() { }
        public List<Product> getListProduct()
        {
            string query = "SELECT * FROM Product";
            DataTable resulf = DataProvider.Instance.ExecuteQuery(query);
            List<Product> list = new List<Product>();
            foreach (DataRow item in resulf.Rows)
            {
                Product product = new Product(item);
                list.Add(product);
            }
            return list;
        }
        public List<Product> getListProductByCategory(string cate)
        {
            string query = "SELECT * FROM Product WHERE Category = @cate ";
            DataTable resulf = DataProvider.Instance.ExecuteQuery(query,new object[] { cate });
            List<Product> list = new List<Product>();
            foreach (DataRow item in resulf.Rows)
            {
                Product product = new Product(item);
                list.Add(product);
            }
            return list;
        }
        public bool addProduct(string name,string Category, float price, byte[] image)
        {
            string query = "INSERT INTO Product ( name, Category, price , image ) VALUES ( @name , @Category , @price , @image )";
            
            int resulf = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name , Category , price , image });
            return resulf > 0;
        }
        public bool addProductNonImage(string name, string Category, float price)
        {
            string query = "INSERT INTO Product ( name, Category, price ) VALUES ( @name , @Category , @price )";
            int resulf = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, Category, price });
            return resulf > 0;
        }
        public bool removeProduct(int idPro)
        {
            OrdersDAO.Intance.deleteOrderbyidProduct(idPro);
            string query = string.Format("DELETE Product Where idPro = {0}",idPro);
            int resulf = DataProvider.Instance.ExecuteNonQuery(query);
            return resulf > 0;
        }
        public bool updateProduct(string name, string Category, float price, int idPro , byte[] image)
        {
            string query = "UPDATE Product SET name = @name , Category = @Category , price = @price , image = @image WHERE idPro = @idPro";
            int resulf = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, Category , price , image , idPro });
            return resulf > 0;
        }
        public bool updateProductNonImage(string name, string Category, float price, int idPro)
        {
            string query = "UPDATE Product SET name = @name , Category = @Category , price = @price  WHERE idPro = @idPro";
            int resulf = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, Category, price, idPro });
            return resulf > 0;
        }
        public  List<Product> findProduct(int idPro)
        {
            string query = "SELECT * FROM Product WHERE idPro = @idPro";
            DataTable resulf = DataProvider.Instance.ExecuteQuery(query,new object[] { idPro });
            List<Product> list = new List<Product>();
            foreach (DataRow item in resulf.Rows)
            {
                Product product = new Product(item);
                list.Add(product);
            }
            return list;
        }
        public List<Product> findProductByName(string name)
        {
            string query = string.Format("SELECT * FROM Product WHERE name LIKE '%{0}%'", name);
            DataTable resulf = DataProvider.Instance.ExecuteQuery(query);
            List<Product> list = new List<Product>();
            foreach (DataRow item in resulf.Rows)
            {
                Product product = new Product(item);
                list.Add(product);
            }
            return list;
        }
    }
}
