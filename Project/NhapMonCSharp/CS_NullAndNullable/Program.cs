using System;
using CS_NullAndNullable;

namespace CS_NullAndNullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Null
            Student student = null;

            //NullAble - muốn nullable thì cú pháp là kiểu dữ liệu + ?
            Student student1 = new Student();
            student1.NamSinh = null;

            if(student1.NamSinh.HasValue)
                System.Console.WriteLine(student1.NamSinh);
        }
    }
}
