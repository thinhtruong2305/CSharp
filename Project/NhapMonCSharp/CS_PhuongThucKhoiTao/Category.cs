using System;

namespace CS_PhuongThucKhoiTao
{
    class Category
    {
        private string categoryname;

        // Dùng thân biểu thức cho phương thức khởi tạo
        public Category(string nameofCategory) => categoryname = nameofCategory;
        public String Name
        {
            // Dùng thân biểu thức cho setter, getter
            set => categoryname = value;
            get => categoryname;
        }
    }
}