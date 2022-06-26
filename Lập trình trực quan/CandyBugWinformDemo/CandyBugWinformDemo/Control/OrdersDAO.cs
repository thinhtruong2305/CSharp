using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyBugWinformDemo.Control
{
    class OrdersDAO
    {
        private static OrdersDAO instance;

        internal static OrdersDAO Intance
        {
            get 
            { if (instance == null) 
              instance = new OrdersDAO(); 
                return instance;
            }
            private set { instance = value; }
        }

        public bool addOrder(DateTime DateCheckOut, int idProduct, int quantity, int status)
        {
            string query = "INSERT INTO Orders ( DateCheckOut, idProduct, quantity , status ) VALUES ( @DateCheckOut , @idProduct , @quantity , @status ) ";
            int resulf = DataProvider.Instance.ExecuteNonQuery(query,new object[] {DateCheckOut , idProduct, quantity, status });
            return resulf > 0;
        }

        public void deleteOrderbyidProduct(int id)
        {
            string query = "DELETE Orders WHERE idProduct = " + id;
            DataProvider.Instance.ExecuteQuery(query);
            
        }
    }
}
