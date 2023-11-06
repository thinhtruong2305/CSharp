using System;

namespace CS_PhuongThucKhoiTao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng, không truyền tham số nên
            // nó gọi phương thức khởi tạo không tham số
            Product product1 = new Product();
            Console.WriteLine(product1.Name); // Không tên

            Product product2 = new Product("Laptop", 123);
            Console.WriteLine(product2.Name); // Laptop

            CategoryMobile cat1 = new CategoryMobile("Điện thoại", "Danh mục các loại điện thoại");
            Console.WriteLine(cat1.Name);
            Console.WriteLine(cat1.Description);

            // In ra
            // Điện thoại
            // Danh mục các loại điện thoại

            Console.WriteLine(MyColorCode.color_danger);
            Console.WriteLine(MyColorCode.color_info);
        }
    }
}
