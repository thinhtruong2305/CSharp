using System;

namespace CS_Generic
{
    class Program
    {
        static void Swap<T>(ref T a, ref T b){
            T t;
            t = a;
            a = b;
            b = t;
        }

        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Swap(ref a, ref b);                       // Hàm trên kiểu T = int
            System.Console.WriteLine($"a = {a}; b = {b}"); // a = 2; b = 1

            string a1 = "A";
            string b1 = "B";
            Swap(ref a1, ref b1); // Hàm trên kiểu T = string
            System.Console.WriteLine($"a1 = {a1}; b1 = {b1}"); // a1 = B; b1 = C

            Generic<string> g = new Generic<string>();
            g.ID = "1AB";
            g.Print();
        }
    }
}
