using System;

namespace CS_PhuongThucKhoiTao
{
    class MyColorCode
    {
        public static string color_primary;
        public static string color_success;
        public static string color_danger;
        public static string color_warning;
        public static string color_info;

        // Phương thức khởi tạo tĩnh, được gọi khi lần đầu truy cập một thành viên tĩnh
        static MyColorCode()
        {
            Console.WriteLine("Static MyColorCode Contructor Call");
            color_danger = "Red";
            color_info = "Cyan";
            color_primary = "Navy";
            color_success = "Green";
            color_warning = "Yellow";
        }
    }
}