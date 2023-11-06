using System;
using System.Text;
using System.Text.RegularExpressions;

namespace CS_ChuoiKyTu
{
    class Program
    {
        static void Main(string[] args)
        {
            string sExample = "Xin chào";       // Khai báo và khởi tạo chuỗi
            sExample += " các bạn";             // Nối chuỗi +=, trả về "Xin chào các bạn"
            sExample = sExample + "!";          // Nối chuỗi +, trả về "Xin chào các bạn!"
            char c = sExample[1];               // c= 'i'

            string s = "C:\\Abc\\xyz";
            // Nếu viết string s = "C:\Abc\xyz"; sẽ lỗi

            string s1 = @"Ký tự \ được dùng để chèn ký tự đặc biệt như \n, \r";

            string s2 = @"Anh ấy nói, ""Đây là C#"""; //~ Anh ấy nói "Đây là C#"

            string s3 = @"Xin chào các bạn
            Tôi đang học C#";

            int a = 10;
            int b = 2;
            string s4 = $"Kết quả {a}/{b} là {a/b}";  // "Kết quả 10/2 là 5"

            Console.WriteLine($"{"VòngLặp",10} {"Chẵn/Lẻ", -5}");
            for (int i = 8; i < 15; i++)
            {
                string chanle = (i%2 == 0) ? "Chẵn" : "Lẻ";
                Console.WriteLine($"{i,10} {chanle, -5}");
            }

            System.Console.WriteLine(s);
            System.Console.WriteLine(s1);
            System.Console.WriteLine(s2);
            System.Console.WriteLine(s3);

            string stringA =  "Xin chào,";
            string stringB = "các bạn!";

            string s5 = String.Concat(stringA, stringB);    // s = "Xin chào,các bạn!"

            string s6 = String.Format("Chào {0}, {0} ơi, hôm nay ngày {1} rồi!", "Nam", DateTime.Now.Day);
            // s = "Chào Nam, Nam hôm nay ngày 20 rồi!"

            var s7 = stringA.Insert(8, " tất cả"); // "Xin chào tất cả,"

            string s8 = "Abc";
            string s9 = s8.PadLeft(6);        //  "   Abc"
            string s10 = s8.PadLeft(6, '*');   //  "***Abc"

            var s11 = stringA.Replace("chào", "CHÀO");   // "Xin CHÀO,"

            var s12 = "Nguyễn Văn A".Split(' '); // s tương đương mảng {"Nguyễn","Văn", "A"}

            string s13 = stringA.Substring(4); // s = "chào,"
            string s14 = stringA.Substring(0, 3); // s = "Xin" (dài 3)

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Xin chào các bạn - xuanthulab.net");
            stringBuilder.Replace("Xin chào", "XIN CHÀO");
            Console.WriteLine(stringBuilder); // Out: XIN CHÀO các bạn - xuanthulab.net

            String text = @"Đây là địa chỉ
            email userabcguest@xuanthulab.net.vn và
            xyz@gmail.com cần trích xuất";
            String pattern = @"(([^\s.]+)@((.[^\s]+)(\..[^\s]+)))";

            Regex rx = new Regex(pattern);

            // Tìm kiếm.
            MatchCollection matches = rx.Matches(text);
            // In thông báo tìm kiếm.
            Console.WriteLine("Tìm thấy {0} email trong:\n\n  {1}\n\n",
                            matches.Count,
                            text);
            // Xuất kết quả email tìm được
            foreach (Match match in matches)
            {
                GroupCollection groups = match.Groups;
                Console.WriteLine("{0}", groups[0].Value);
            }
        }
    }
}
