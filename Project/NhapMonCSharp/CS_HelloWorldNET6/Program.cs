// See https://aka.ms/new-console-template for more information
//Ở .NET 6 thì ko thuộc namespace, không thuộc lớp => Đây là trình biên dịch TOP-level statement
//using thì ta viết ở đầu trang
//VD: using System.Text.Json

//Sau phần using là các top-level statement
Console.WriteLine("Hello, World!");

//Có thể truy cập lấy tham số truyền vào cho Main qua biên dịch
//Có sẵn arg
//VD: Console.WriteLine("Số tham số : " + agrs.Count());

//Có thể viết return, để thoát chương trình
//VD: return 1;

//Phần cuối file có thể khai báo gói và các lớp
/*
    namespace XYZ
{
    class Abc
    {
        public static void TestAbc() { }
    }
}
*/

//có thể tạo file với framework 5.
//VD: dotnet new console --framework net5.0


