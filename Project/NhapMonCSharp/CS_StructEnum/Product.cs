using System;

namespace CS_StructEnum
{
    public struct Product
    {
        public string name;   // trường tên sản phẩm
        public decimal price; // trường giá sản phẩm

        public Product(string _name)
        {
            // trong cấu trúc có bao nhiêu trường dữ liệu, thuộc tính
            // phải khởi tạo hết trong hàm tạo (thiếu sẽ lỗi)
            name = _name;
            price = 100;
            Description = "Mô tả về sản phẩm {name}";
        }

        // Thuộc tính Name
        public string Name {set => name = value; get => name;}
        // Thuộc tính Description
        public string Description {set; get;}

        // Phương thức sinh ra chuỗi thông tin
        public override string ToString() => $"{name} : {price}$";
    }
}