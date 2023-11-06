using System;

namespace CS_PhuongThucKhoiTao
{
    class CategoryMobile : Category
    {
        private string description;
        // Khi phương thức khởi tạo này được gọi, nó gọi phương thức khởi tạo có
        // một tham số của lớp cơ sở (Category) trước, rồi mới thi hành các code
        // trong thân của phương thức khởi tạo này
        public CategoryMobile(string nameofCategory, string mota) : base(nameofCategory)
        {
            description = mota;
        }

        public string Description
        {
            set => description = value;
            get => description;
        }
    }
}