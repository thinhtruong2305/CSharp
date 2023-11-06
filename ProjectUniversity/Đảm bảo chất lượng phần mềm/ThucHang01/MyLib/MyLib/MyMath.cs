using System;
using System.Diagnostics;

namespace MyLib
{
    public static class MyMath
    {
        private const double epsilon = 1E-10;
        public static double exp(double x)
        {
            double s = 1;
            const int n = 10;
            double a = 1;
            for (int i = 1; i <= n; i++)
            {
                a *= x;
                a /= i;
                s += a;

                //Dành cho lấy hết 10 phần tử i
                /*Debug.WriteLine("x = {0}, i = {1}, a = {2}, s = {3}", x, i, a, s);*/
                
                //Dành cho lấy một phần tử i cuối cùng
                if (i == n)
                {
                    Debug.WriteLine("x = {0}, i = {1}, a = {2}, s = {3}", x, i, a, s);
                }
            }
            return s;
        }

        //phần này áp dụng epsilon vào để tính toán
        public static double expEpsilon(double x)
        {
            double s = 1;
            int i = 0;
            double a = 1;
            while (Math.Abs(a) > epsilon)
            {
                i++;
                a *= x;
                a /= i;
                s += a;
            }
            Console.WriteLine("x={0}, i={1}, a={2}, s={3}", x, i, a, s);
            return s;
        }

        //Phần này chạy sin
        public static double sin(double x)
        {
            double s = x;
            int i = 1;
            double a = x;
            while (Math.Abs(a) > epsilon)
            {
                i += 2;
                a *= -x * x;
                a /= (i - 1) * i;
                s += a;
            }
            Console.WriteLine("x={0}, i={1}, a={2}, s={3}", x, i, a, s);
            return s;
        }

        //Phần này chạy cos
        public static double cos(double x)
        {
            double s = 1;
            int i = 0;
            double a = 1;
            while (Math.Abs(a) > epsilon)
            {
                i += 2;
                a *= -x * x;
                a /= (i - 1) * i;
                s += a;
            }
            Console.WriteLine("x={0}, i={1}, a={2}, s={3}", x, i, a, s);
            return s;
        }
    }
}
