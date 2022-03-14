using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrganizationWeb.Models
{
    public class Products
    {
        public long productID { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public string decription { get; set; }
        public decimal price { get; set; }
    }
}