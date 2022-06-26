using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShopThoiTrang.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string ProductId { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int Amount { get; set; }
    }
}