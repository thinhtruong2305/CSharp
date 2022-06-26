using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopWinform.Model
{
    public class ItemOrder
    {
        private int idProduct;
        private string name;
        private decimal price;
        private int quantity = 1;
        private decimal total;
        

        public string Name { get => name; set => name = value; }
        public decimal Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public decimal Total { get { return price * quantity; } }
        public int IdProduct { get => idProduct; set => idProduct = value; }

        public ItemOrder(string name, decimal price, int quantity, int idProduct)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.idProduct = idProduct;
        }
        public ItemOrder()
        {

        }
    }
}
