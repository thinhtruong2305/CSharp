using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopWinform.Model
{
    class Vip
    {

       public string vip { get; set; }
       public bool value { get; set; }

        public Vip(string vip, bool value)
        {
            this.vip = vip;
            this.value = value;
        }

        public static List<Vip> getVips()
        {
            Vip vip1 = new Vip("Có", true);
            Vip vip2 = new Vip("Không", false);
            List<Vip> Vips = new List<Vip>();
            Vips.Add(vip1);
            Vips.Add(vip2);
            return Vips;
        }


    }
}
