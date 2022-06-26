using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShopThoiTrang.Models
{
    public class ShopThoiTrangDBContext:DbContext
    {
        public ShopThoiTrangDBContext():base("name=ChuoiKN"){}
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}