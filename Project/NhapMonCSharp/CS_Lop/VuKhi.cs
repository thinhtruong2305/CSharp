using System;

namespace CS_Lop
{
    // khai báo các thành viên dữ  liệu (thuộc tính, biến trường dữ liệu)
    // khai báo các thành viên  hàm (phương thức)

    class VuKhi
    {
        /// Tên của vũ khí: Súng Lục, Súng Trường, Dao ...
        public string name = "Tên Vũ Khí";

        /// Độ sát thương 10 cấp độ
        int doSatThuong = 0;

        /// Phương thức khởi tạo (được gọi khi toán tử new tạo đối tượng)
        /// tên phương thức trùng tên lớp, trường hợp này không tham số
        public VuKhi()
        {
            this.doSatThuong = 1;
        }

        /// Phương thức khởi tạo (được gọi khi toán tử new tạo đối tượng)
        /// tên phương thức trùng tên lớp, trường hợp này có tham số
        public VuKhi(string name, int doSatThuong)
        {
            this.name  = name;
            SetDoSatThuong(doSatThuong);
        }

        /// Hàm này thiết lập  độ sát thương
        public void SetDoSatThuong(int doSatThuong)
        {
            this.doSatThuong = doSatThuong;
        }
        
        // In ra: Tên vu khí: * * * * * * * * (bằng độ sát thương)
        public void TanCong()
        {
            Console.Write(name + ": \t");
            for (int i = 0; i < doSatThuong; i++)
            {
                Console.Write(" * ");
            }
            Console.WriteLine();
        }
    }
}