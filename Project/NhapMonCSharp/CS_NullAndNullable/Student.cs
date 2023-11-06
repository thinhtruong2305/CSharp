using System;

namespace CS_NullAndNullable
{
    class Student
    {
        private string hoTen;
        private int? namSinh;

        public Student()
        {
            
        }

        public string HoTen{get => hoTen;set => hoTen = value;}
        public int? NamSinh{get => namSinh;set => namSinh = value;}
    }
}