using System;

namespace CS_KeThua
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            // KẾT QUẢ
            // Animal Init
            // Cat Init

            Cat cat1 = new Cat("Hi");
            // KẾT QUẢ
            // Animal InitHi
            //Cat Init

            cat.ShowLegs();             // Phương thức này kế thừa từ lớp cơ sở
            cat.Eat();                  // phương thức của riêng Cat

            // Legs: 4
            // Mouse

            //cat.leg ko thể truy cập khi thuộc tính lớp cha được đặc tả truy cập protected

            Tiger tiger = new Tiger();
            Animal a = (Animal)tiger;       // Tigerhuyển kiểu tường minh
            Animal a1 = tiger;          // ngầm định
            Animal a2 = new Tiger();    // ngầm định

            Cat c = tiger;        // ngầm định

            //Tiger t = new Animal();    // lỗi - không thể chuyển kiểu thuận cây kế thừa -  Lớp Tiger không chuyển thành Animal được
        }
    }
}
