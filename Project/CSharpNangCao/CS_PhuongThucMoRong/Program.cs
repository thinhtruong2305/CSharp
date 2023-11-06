using System;
using System.Collections.Generic;
using System.Linq;
using CS_PhuongThucMoRong;

namespace CS_PhuongThucMoRong
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ví dụ 1 về phương thức mở rộng
            List<int> ls = new List<int>(){1,2,3,4,5};

            //Lỗi vì List không có phương thức Where và để khắc phục điều đó ta chỉ cần nạp thư viện LinQ
            //Linq đã mở rộng thêm vào List phương thức Where
            var ps = ls.Where(i => i >= 3);

            //Ví dụ 2 về phương thức mở rộng
            /*
            Ta sẽ tạo lớp tĩnh với một phương thức tĩnh
            Chuyển khai báo Print trong một lớp tĩnh
            Đảm bảo Print là phương thức tĩnh
            Tham số đầu tiên của hàm là kiểu string 
            (lớp mà phương thức mở rộng sẽ thêm vào) cho thêm từ khóa this vào phía trước kiểu này - 
            để cho biết sẽ mở rộng lớp string với phương thức này.
            */
            string s = "Chuỗi kiểm tra";
            s.Print();                                   // Chuỗi kiểm tra  (có màu vàng)
            "Xin chào các bạn!".Print(ConsoleColor.Red); // in ra "Xin chào các bạn!" có màu đỏ
        }
    }
}
