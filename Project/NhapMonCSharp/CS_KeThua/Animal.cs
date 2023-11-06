using System;

namespace CS_KeThua
{
    public class Animal
    {
        protected int Legs {get; set;}
        public float Weigh {get; set;}

        public Animal()
        {
            System.Console.WriteLine("Animal Init");
        }

        public Animal(string msg)
        {
            System.Console.WriteLine("Animal Init" + msg);
        }

        public void ShowLegs()
        {
            Console.WriteLine($"Legs: {Legs}");
        }
    }
}