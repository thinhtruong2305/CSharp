using System;
using CS_Lambda;
using System.Collections;
using System.Linq;

namespace CS_Lambda
{
    class Program
    {
        /*
        Biểu thức lambda còn gọi là biểu thức hàm nặc danh (Anonymous), 
        một biểu thức khai báo giống phương thức (hàm) nhưng thiếu tên. 
        Cú pháp để khai báo biểu thức lambda là sử dụng toán dử => như sau:

        (các_tham_số) => biểu_thức;
        Thậm chí là cả một cấu trúc lệnh sau toán tử =>

        (các_tham_số) =>
        {
        // các câu lệnh
            // Sử dụng return nếu có giá trị trả về
        }
        */
        static void Main(string[] args)
        {
            Lambda.SumDelegateLambda();
            Lambda.SumDelegateFuncActionLambda();

            //lambda trong một số thư viện
            int[] mang = {2,4,5,232,6,24,7,32,132,76};
            var kq = mang.Select((int x) => {
                return Math.Sqrt(x);
            });

            foreach (var item in kq)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
