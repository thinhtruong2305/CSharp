using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyBugWinformDemo.Object
{
    class Orders
    {
        private int id;
        private DateTime DateCheckOut;
        private int idProduct;
        private int quantity;
        private int status;

        public int Id { get => id; set => id = value; }
        public DateTime DateCheckOut1 { get => DateCheckOut; set => DateCheckOut = value; }
        public int IdProduct { get => idProduct; set => idProduct = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Status { get => status; set => status = value; }
    }
}
