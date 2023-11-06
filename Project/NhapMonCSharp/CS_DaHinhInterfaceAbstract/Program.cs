using System;
using Abstract.CS_DaHinhInterfaceAbstract;
using Interface.CS_DaHinhInterfaceAbstract;

namespace CS_DaHinhInterfaceAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //Đa hình - Abstract - Interface
            Product iP12 = new IPhone("IPhone 12");
            iP12.ProductInfo();

            Phone iP14 = new IPhone();
            iP14.Name = "IPhone 14";
            iP14.ProductInfo();

            IAndroid GalaxyUltra = new Samsung();
            GalaxyUltra.Calling();
        }
    }
}
