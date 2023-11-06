using System;

//namespace là một gói, khu vực được chỉ định khi ta dùng using để sử dụng tài nguyên trong khu vực và gói
namespace CS_HelloWorld
{
    class Program
    {
        //Không được phép sử dụng hai main vì chương trình sẽ không biết ta muốn chạy hàm main nào
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
        }
    }

    class MyProgram{
        static void Mainxxx(string[] args)
        {
            
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Tong(int a, int b){
            return 0;
        }
    }
}
