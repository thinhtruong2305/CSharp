using System;

namespace CS_Lop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                // Khai báo và khởi tạo đối tượng luôn
                var ob1 = new ClassName();

                // Khai báo, sau đó khởi tạo
                ClassName ob2;
                ob2 = new ClassName();
            */
            var sungluc = new VuKhi();              // Khai báo và khởi tạo
            sungluc.name = "SÚNG LỤC";              // Truy cập và gán thuộc tính
            sungluc.SetDoSatThuong(5);             // Truy cập (gọi) phương thức

            VuKhi sungtruong = new VuKhi();
            sungtruong.name = "SÚNG TRƯỜNG";
            sungtruong.SetDoSatThuong(20);

            sungluc.TanCong();                      // Gọi phương thức
            sungtruong.TanCong();                   // Gọi phương thức

            //Kết quả chạy
            //SÚNG LỤC:        *  *  *  *  *
            //SÚNG TRƯỜNG:     *  *  *  *  *  *  *  *  *  *  *  *  *  *  *  *  *  *  *  *

            System.Console.WriteLine(OverloadingExample.Sum(123, 123));
            System.Console.WriteLine(OverloadingExample.Sum(123.0, 123.0));

            var s = new Student();
            s.Name = "XYZ";                                             // set thi hành
            // In ra: Ghi dữ liệu <--XYZ
            // Và trường name giờ bằng XYZ

            Console.WriteLine(s.Name);                                  // get được thi hành
            // In ra: Tên là: XYZ
        }
    }
}
