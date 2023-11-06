using System;

namespace DestructorStaticMemberIndexerOperatorOverloading
{
    class StaticMember
    {
        //Thuộc tính static
        public static int num = 0;
        public void count() {
            num++;
        }
        public int getNum() {
            return num;
        }

        //Method static
        public static int  Sum(int a, int b)
        {
            return a + b;
        }
    }
}