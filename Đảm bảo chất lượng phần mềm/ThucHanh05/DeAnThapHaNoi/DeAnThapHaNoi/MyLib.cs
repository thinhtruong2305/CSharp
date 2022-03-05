using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeAnThapHaNoi
{
    public static class MyLib
    {
        public static string Replicate(char c, int n)
        {
            string s = "";
            for (int i = 0; i < n; i++)
                s += c;
            return s;
        }

        public static string Replicate(string c, int n)
        {
            string s = "";
            for (int i = 0; i < n; i++)
                s += c;
            return s;
        }
    }
}
