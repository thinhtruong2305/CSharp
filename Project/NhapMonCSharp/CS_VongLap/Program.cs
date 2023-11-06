using System;

namespace CS_VongLap
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vòng lặp for
            //for(Khởi tạo giá trị; điều kiện lặp; bước nhảy)
            for (int i = 8; i <=10; i++)
            {
                Console.WriteLine("Số i = " + i);
            }

            //Vòng lặp while
            //while(điều kiệu)
            //Cần lưu ý, viết vòng lặp đảm bảo lặp số lần hữu hạn (điều_kiện bằng false sau số lần lặp mong muốn), trong ví dụ trên đó chính là i++
            int j = 8;
            while (j <= 10)
            {
                Console.WriteLine("Số j = " + j);
                j++;
            }

            //Vòng lặp do while
            //do
            //{
            //        khối lệnh
            //}
            //while(điều kiện);
            //Vòng lặp này khác while ở chỗ, nó thi hành khối lệnh trước, sau đó mới kiểm tra điều_kiện, kiểm tra thấy điều_kiện vẫn true thì lặp tiếp.
            int k = 10;
            do
            {
                Console.WriteLine("Số k = " + k);
                k += 2;
            }
            while (k <=20);

            //break; continue
            //Trong vòng lặp, nếu gặp break vòng lặp sẽ thoát ngay lập tức - và chuyển đến các câu lệnh sau vòng lặp.
            int m = 0;
            while (true)
            {
                Console.Write(" " + ++m);
                if (m == 10)
                    break;  // Thoát lặp
            }

            //Trong vòng lặp, nếu gặp continue thì tương đương việc đến cuối khối lệnh của lần lặp đó (gặp continue là bỏ qua hẳn các câu lệnh phía sau và tiến hành bước nhảy nếu có).
            for (int i = 10; i <= 20; i ++ )
            {
                if (i % 3 != 0)
                    continue;  // Chạy ngay vòng lặp tiếp
                Console.WriteLine("Số i = " + i);
            }
        }
    }
}
