using System;

namespace CS_PhuongThucKhoiTao
{
    class Product
    {
        private string name;
        private decimal price;

        // Khai báo phương thức khởi tạo với 2 tham số
        public Product(string nameproduct, decimal priceproduct)
        {
            name = nameproduct;
            price = priceproduct;
        }

        // Khai báo phương thức khởi tạo không tham số
        public Product()
        {
            name = "Không tên";
            price = 0;
        }

        // Thuộc tính Name lấy hoặc thiết lập tên sản phẩm
        public string Name
        {
            set { name = value;}
            get { return name;}
        }
    }
}