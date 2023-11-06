using System;

namespace CS_Delegate
{
    class Logs
    {
         // Khai báo một delegate
        public delegate void ShowLog(string message);

        // Phương thức tương đồng với ShowLog (tham số, kiểu trả về)
        static public void Info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Format("Info: {0}", s));
            Console.ResetColor();
        }

        // Phương thức tương đồng với ShowLog (tham số, kiểu trả về)
        static public void Warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Format("Waring: {0}", s));
            Console.ResetColor();
        }

        public static void TestShowLog()
        {
            ShowLog showLog;

            showLog = Info;         // showLog gán bằng phương thức Info
            showLog("Thông báo");   // Thi hành delegate chính là thi hành Info

            showLog = Warning;      // showLog gán bằng phương thức Warning
            showLog("Thông báo");   // Thi hành delegate chính là thi hành Info

            //Gán nhiều phương thức vào delegate
            showLog = null;
            showLog += Warning;         // Nối thêm Warning vào delegate
            showLog += Info;            // Nối thêm Info vào delegate
            showLog += Warning;         // Nối thêm Warning vào delegate

            //Một lần gọi thi hành tất cả các phương thức trong chuỗi delegate
            showLog?.Invoke("TestLog");         //Hoặc an toàn: showLog?.Invoke("TestLog");

            //Ngoài cách gán cho delegate một hàm có tên cụ thể như trên, bạn cũng có thể gán một phương thức Anonymous
            showLog += (x) => Console.WriteLine(string.Format("===>{0}<===", x));
            showLog("xin chào");

            //Các delegate cùng kiểu có thể kết hợp lại với nhau bằng toán tử +
            ShowLog showLog1 = (x)=> {Console.WriteLine($"-----{x}-----");};
            ShowLog showLog2 = Warning;
            ShowLog showLog3 = Info;

            var all = showLog1 + showLog2 + showLog3 + showLog1;

            all("Xin Chào");
        }

        public static void TestAction(string s)
        {
            /*
            Action tương tự như Func, điều khác duy nhất là nó không có kiểu trả về, khai báo cơ bản như sau:

            Action<kiểu_tham_số_1, kiểu_tham_số_2, ... > var_delegate;
            Nghĩa là biến kiểu Action có thể gán bằng các hàm có kiểu trả về void
            */
            Action<string> showLog = null;

            showLog += Logs.Warning;         // Nối thêm Warning vào delegate
            showLog += Logs.Info;            // Nối thêm Info vào delegate
            showLog += Logs.Warning;         // Nối thêm Warning vào delegate

            // Một lần gọi thi hành tất cả các phương thức trong chuỗi delegate
            showLog("TestLog");
        }
    }

    class Function{
        static int Sum(int x, int y)
        {
            return x + y;
        }

        public static void TestFunc(int x, int y)
        {
            /*
            Func là mẫu delegate có kiểu trả về. Để khai báo biến delegate dùng cú pháp như sau:

            Func<kiểu_tham_số_1, kiểu_tham_số_2, ..., kiểu_trả_về> var_delegate;
            Kiểu cuối cùng trong khai báo Func là kiểu trả về của hàm, 
            có thể thiếu tham số nhưng không được thiếu kiểu trả về
            */
            Func<int,int,int> tinhtong;         // biến tinhtong phù hợp với các hàm trả về kiểu int, có 2 tham số kiểu int
            tinhtong = Sum;                     // Hàm Sum phù hợp nên có thể gán cho biến

            var ketqua = tinhtong(x, y);
            Console.WriteLine(ketqua);
        }

        // Sử dụng Delegate làm tham số phương thức, truyền callback
        static void TinhTongCallBack(int a, int b, Action<string> callback)
        {
            int c = a + b;
            // Gọi callback
            callback(c.ToString());
        }

        public static void TestCallBack()
        {
            TinhTongCallBack(5,6, (x) => Console.WriteLine($"Tổng hai số là: {x}"));
            TinhTongCallBack(1,3, Logs.Info);
        }
    }
}