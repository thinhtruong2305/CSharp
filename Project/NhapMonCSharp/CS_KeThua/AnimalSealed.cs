using System;

namespace CS_KeThua
{
    //Nó sẽ ko đc kế thừa vì có từ khóa sealed
    public sealed class AnimalSealed
    {
        public int Legs {get; set;}
        public float Weigh {get; set;}


        public void ShowLegs()
        {
            Console.WriteLine($"Legs: {Legs}");
        }
    }
}