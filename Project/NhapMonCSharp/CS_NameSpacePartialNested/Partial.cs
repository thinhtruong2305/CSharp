using System;

namespace ClassUnPartial
{
    //Đây là lớp hoàn chỉnh
    public class Product
    {
        public string Name { set; get;}

        public bool Order(int number = 0)
        {
            return true;
        }

        public int numberBrought()
        {
            return 100;
        }
    }
}

namespace ClassPartial
{
    //Đây là lớp product phần 1
    public partial class Product1
    {
        public string Name { set; get;}

        public bool Order(int number = 0)
        {
            return true;
        }
    }

    //Đây là lớp product phần 2
    public partial class Product2
    {
        public int numberBrought()
        {
            return 100;
        }
    }
}

/*
    Bạn cũng có thể dùng từ khóa partial trong khai báo các phương thức, tuy nhiên mục đích chỉ là chia chia làm hai nơi, 
    một nơi như là khai báo một nơi là triển khai code, và phương thức phải trả về kiểu void. Ví dụ:
    // file1.cs
    partial void myMethod();

    // file2.cs
    partial void myMethod()
    {
    // code triển khai
    }
*/