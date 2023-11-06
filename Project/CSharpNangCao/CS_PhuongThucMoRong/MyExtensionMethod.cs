using System;

namespace CS_PhuongThucMoRong
{
    public static class MyExtensionMethod
    {
        public static void Print(this string s, ConsoleColor color = ConsoleColor.Yellow)
     {
         ConsoleColor lastColor = Console.ForegroundColor;
         Console.ForegroundColor = color;
         Console.WriteLine(s);
         Console.ForegroundColor = lastColor;
     }
    }
}