using System;

namespace CS_KeThua
{
    public class Cat : Animal
    {
        public string food;      // thuộc tính mới thêm

        public Cat()
        {
            System.Console.WriteLine("Cat Init");
            Legs = 4;           // Thuộc tính Legs có sẵn - vì nó kế thừa từ Animal
            food = "Mouse";
        }

        public Cat(string msg) : base (msg)
        {
            System.Console.WriteLine("Cat Init");
        }

        public void Eat()
        {
            Console.WriteLine("meal");
        }
    }
}