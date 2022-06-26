using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyBugWinformDemo.Object
{
    public class ifOrder
    {
        private string name;
        private float price;
        private int quantity = 1;
        private float total;
        private int idProduct;

        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public float Total { get { return price * quantity; } }
        public int IdProduct { get => idProduct; set => idProduct = value; }

        public ifOrder(string name,float price,int quantity,int idProduct)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.idProduct = idProduct;
        }
  
    }
}
