using System;

namespace DestructorStaticMemberIndexerOperatorOverloading
{
    class Student
    {
         // khai báo biến readonly
        public readonly string name;
        public Student(string name)
        {
            // khởi tạo biến readonly ở hàm tạo (bắt buộc nếu biến khai báo mà chưa khởi tạo)
            this.name = name;
        }
    }
}