using System;

namespace CS_Exception
{
    class Program
    {
        public static double Thuong(double x, double y) 
        {
            if (y == 0) {
                // Khởi tạo ngoại lệ, tham số là thông báo lỗi
                Exception myexception = new Exception("Số chia không được bằng 0");

                // phát sinh ngoại lệ, code phía sau throw không được thực thi
                throw myexception;
            }
            return x / y;
        }
        static void Main(string[] args)
        {
            //bắt ngoại lệ
            try {
                // khối này được giám sát để bắt lỗi - khi nó phát sinh
                int[] mynumbers = new int[] {1,2,3};
                int i = mynumbers[10];                  // dòng này phát sinh lỗi
                Console.WriteLine(i);                   // dòng này không được thực thi vì lỗi trên
            }
            catch (Exception loi)
            {
                // khối này thực thi khi bắt được lỗi
                Console.WriteLine("Có lỗi rồi");
                Console.WriteLine(loi.Message);
            }

            //bắt nhiều ngoại lệ
            int z = 0;
            try {
                int x = 10;
                int y = 0;
                z = x / y;

            }
            catch (DivideByZeroException e1) {
                Console.WriteLine(e1.Message);
            }
            catch (Exception e2) {
                Console.WriteLine(e2.Message);
            }

            //Finally
            try {
                int x = 10;
                int y = 0;
                
                z = x / y;
            }
            catch (DivideByZeroException e1) {
                Console.WriteLine(e1.Message);
            }
            finally {
                // Luôn được thi hành dù có phát sinh ngoại lệ hay không
                Console.WriteLine(z);
            }


        }
    }
}
