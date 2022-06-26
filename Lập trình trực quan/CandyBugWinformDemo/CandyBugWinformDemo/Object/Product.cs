using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyBugWinformDemo.Object
{
    class Product
    {
        private int idPro;
        private string name;
        private string category;
        private float price;
        private byte[] image;
        public int IdPro { get => idPro; set => idPro = value; }
        public string Name { get => name; set => name = value; }

        public byte[] Image { get => image; set => image = value; }
        public float Price { get => price; set => price = value; }
        public string Category { get => category; set => category = value; }

        public Product(DataRow row)
        {
            this.idPro = (int)row["idPro"];
            this.name = row["name"].ToString();
            this.category = row["Category"].ToString();
            this.price = (float)Convert.ToDouble(row["price"].ToString());
            if ( string.IsNullOrEmpty(row["image"].ToString()))
            {
                this.image = null;
            }
            else
            {
                this.image = (byte[])row["image"];
            }
        }
    }
}
