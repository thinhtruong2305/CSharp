using System;

namespace DestructorStaticMemberIndexerOperatorOverloading
{
    class HamHuy
    {
        private string product_name;
        public HamHuy(string name)
        {
            this.product_name = name;
            Console.WriteLine("Tạo - " + product_name);
        }
        ~HamHuy() {
            Console.WriteLine("Hủy - " + product_name);
        }   
    }
}