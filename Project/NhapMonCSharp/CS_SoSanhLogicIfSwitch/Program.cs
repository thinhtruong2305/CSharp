using System;

namespace CS_SoSanhLogicIfSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Các toán tử so sánh
                int a = 5, b = 10;
                //== : so sánh bằng
                //> : so sánh lớn hơn
                //>= : so sánh lớn hơn hoặc bằng
                //< : so sánh nhỏ hơn
                //<= : so sánh nhỏ hơn hoặc bằng
                //!= ; so sánh khác
                var c = a == b;

            //Các toán tử logic
                //&& : và
                //||: hoặc
                //! : không

            //Câu lệnh If
                if (a > b)
                {
                    Console.WriteLine("Số a lớn hơn hoặc bằng số b");
                }
                else if (a < b)
                {
                    Console.WriteLine("Số a nhỏ hơn số b");
                }
                else
                {
                    Console.WriteLine("Hai số a, b bằng nhau");
                }

                //Câu lệnh if rút gọn
                var d = 2;
                var e = 3.5;
                var f = 2;
                var max = d >= e ?  d >= f ? d : f : e >= f ? e : f;
                // Viết tường minh hơn
                // max = (d >= e) ?  (d >= f ? d : f) : (e >= f ? e : f);
                Console.WriteLine(max);

            //Câu lệnh switch case
                int number = 2;
                switch (number)
                {
                    case 1:
                        Console.WriteLine("number có giá trị một");
                    break;
                    case 2:
                        Console.WriteLine("number có giá trị hai");
                    break;
                    default:
                        Console.WriteLine("number khác một và hai");
                    break;
                }
        }
    }
}
