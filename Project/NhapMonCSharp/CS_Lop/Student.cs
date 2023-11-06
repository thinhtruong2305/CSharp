using System;

namespace CS_Lop
{
    /*
        public : không giới hạn phạm vi truy cập
        protected : chỉ truy cập trong nội bộ lớp hay các lớp kế thừa
        private : (mặc định) chỉ truy cập được từ các thành viên của lớp chứa nó
        internal : chỉ truy cập được trong cùng assembly (dll, exe)
        protected internal: truy cập được khi cùng assembly hoặc lớp kế thừa
        private protected: truy cập từ lớp chứa nó, lớp kế thừa nhưng phải cùng assembly
    */
    class Student
    {
        private string name;     // Đây là trường dữ liệu

        public string Name       // Đây là thuộc tính
        {
            // set thi hành khi gán, write
            // dữ liệu gán là value
            set
            {
                Console.WriteLine("Ghi dữ liệu <--" + value);
                name = value;
            }

            //get thi hành ghi đọc dữ liệu
            get {
                return "Tên là: " + name;
            }
        }
    }
}