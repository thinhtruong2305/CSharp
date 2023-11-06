using System;
using System.Text;
using XYZ = System.Text;
using static System.Console;
using CS_Nested;

namespace CS_NameSpacePartialNested
{
    class Program
    {
        static void Main(string[] args)
        {
            //Namespace
            Console.WriteLine("Hello World!");
            StringBuilder stringBuilder = new StringBuilder();
            // Không cần viết: System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            XYZ.StringBuilder stringBuilder1 = new XYZ.StringBuilder();
            WriteLine("hi");

            //Nested
            MobileProduct product = new MobileProduct();
            product.manufactory =  new MobileProduct.Manufactory("Abc ...");
            product.ProductInfo();
        }
    }
}
