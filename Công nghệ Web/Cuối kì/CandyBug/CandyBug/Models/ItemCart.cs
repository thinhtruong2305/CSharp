using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CandyBug.Models
{
    public class ItemCart
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public string Image { get; set; }

        public decimal Total { get; set; }
        
        public ItemCart(int Id)
        {
            using (CandybugOnlineEntities db = new CandybugOnlineEntities())
            {
                this.Id = Id;
                Product product = db.Products.SingleOrDefault(c=>c.Id==Id);
                this.Name = product.Name;
                this.Price = ((decimal)(product.Price-(product.Price*product.Discount/100)));
                this.Image = product.Image;
                this.Quantity = 1;
                this.Total = Price * Quantity;
            }
        }

        public ItemCart(int Id, int Quantity)
        {
            using (CandybugOnlineEntities db = new CandybugOnlineEntities())
            {
                this.Id = Id;
                Product product = db.Products.SingleOrDefault(c => c.Id == Id);
                this.Name = product.Name;
                this.Price = ((decimal)(product.Price - (product.Price * product.Discount / 100)));
                this.Image = product.Image;
                this.Quantity = Quantity;
                this.Total = Price * this.Quantity;
            }
        }
    }
}