using System;

namespace CS_ToanTu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Phép cộng trừ
            int a = 28;
            int b = 10;
            Console.WriteLine(a + b);  // In ra: 38
            Console.WriteLine(a - b);  // In ra: 18

            //Phép nhân chia và chia lấy dư
            float c = 1.2f;
            int d = 3;
            Console.WriteLine(c * d);  // In ra 3.6
            float e = 1.2f;
            int f = 3;
            Console.WriteLine(e / f);  // In ra 0.4
            int g = 8;
            int h = 3;
            Console.WriteLine(g % h);  // In ra 2

            // Thứ tự ưu tiên toán tử
            //1: trong ngoặc (), 2: số mũ - căn, 3: nhân hoặc chia, 4: cộng hoặc trừ
            // Nếu cùng cấp thì ưu tiên từ trái sang phải
            Console.WriteLine(5 + 3 * 2);         // 11
            Console.WriteLine(6 / 2 + 3 * 2);     // 9
            Console.WriteLine(6 / (2 + 3) * 2);   // 2

            //Toán tử liên quan đến phép gán
            int i = 10 + 12;
            int j = 10;
            j += 2;
            int k = 10;
            k -= 3;
            int l = 2;
            l *= 3;
            int m = 6;
            m /= 2;
            int n = 10;
            n %= 3;
            Console.WriteLine($"Toán tử gán: i = {i}, Toán tử cộng thêm(+=): j = {j}, Toán tử trừ bớt(-=): k = {k},"
                             +$"Toán tử nhân với(*=): l = {l}, Toán tử chia cho(/=): m = {m}, Toán tử gán module(%=): n = {n}");
            
            //Toán tử 1 ngôi
            //a++ hoặc ++a là thêm 1
            //a-- hoặc --a là bớt 1
            //Toán tử ++ phía sau thì thì thực hiện phép nhân trước rồi mới thực hiện ++
            int o = 5;
            int p = 2 * o++;  // p = 10; o = 6

            //Toán tử ++ phía trước thì thực hiện ++ trước rồi mới thực hiện phép nhân
            int q = 5;
            int r = 2 * ++q;  // r = 12; q = 6
        }
    }
}
