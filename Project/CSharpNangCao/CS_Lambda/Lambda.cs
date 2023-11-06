using System;

namespace CS_Lambda
{
    class Lambda
    {
        public delegate int TinhToan (int a, int b);

        //Có thể gán biểu thức này cho biến delegate.
        public static void SumDelegateLambda () {

            // Gán biểu thức lambda cho delegate
            TinhToan tinhtong = (int x, int y) => {
                return x + y;
            };

            int kq = tinhtong (5, 1); // kq = 6;
            Console.WriteLine(kq);
        }

        public static void SumDelegateFuncActionLambda () {

            //Gán lambda cho Func
            Func<int, int, int> tinhtong = (int x, int y) => {
                return x + y;
            };
            // Gán lambda cho Action
            Action<int> thongbao = (int vl) => {
                Console.WriteLine (vl);
            };

            int kq1 = tinhtong (5, 3); // kq1 = 8
            int kq2 = tinhtong (5, 5); // kq2 = 10
            thongbao (kq1); // In ra: 8
            thongbao (kq2); // In ra: 10

        }
        /*
        Bạn có thể sử dụng toán tử => sau khai báo tên phương thức (loại phương thức có kiểu trả về khác void) của lớp, 
        rồi đến ngay một biểu thức có kết quả trả về (không dùng {}), biểu thức này như là định nghĩ thân của phương thức.
        */
        //Ví dụ, khai báo phương thức:
        int Tong(int x, int y) => x + y;

        //Nó tương đương với dạng đầy đủ đã biết
        int Tong1(int x, int y)
        {
            return x + y;
        }
    }
}