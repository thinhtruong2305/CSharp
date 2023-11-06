using System;

namespace CS_Delegate
{
    /*
    Delegate (hàm ủy quyền) là một kiểu dữ liệu, nó dùng để tham chiếu (trỏ đến) đến các hàm (phương thức) 
    có tham số và kiểu trả về phù hợp với khai báo kiểu. Khi dùng đến delegate bạn có thể gán vào nó một, 
    nhiều hàm (phương thức) có sự tương thích về tham số, kiểu trả về, sau đó dùng nó để gọi hàm (giống con trỏ trong C++), 
    các event trong C# chính là các hàm được gọi thông qua delegate, 
    bạn cũng có thể dùng delegate để xây dựng các hàm callback, đặc biệt là các Event

    Delegate được dùng phổ biến khi gán các biểu thức lambda
    */

    /*
    Khi dùng delegate chạy một phương thức, cần đảm bảo biến delegate đó đã được gán phương thức (biến khác null), 
    có thể bạn kiểm tra trước khi gọi ví dụ: if (showLog != null) showLog("Mgs") hoặc gắn gọn hơn showLog?.Invoke("Mgs");
    */
    class Program
    {
        static void Main(string[] args)
        {
            Logs.TestShowLog();
            Function.TestFunc(5, 6); // In ra: 11
        }
    }
}
