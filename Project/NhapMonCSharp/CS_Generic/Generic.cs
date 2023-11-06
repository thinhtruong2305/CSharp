using System;

namespace CS_Generic
{
    class Generic<T>
    {
        private T iD;

        public Generic()
        {
            
        }

        public T ID
        {
            get{
                return iD;
            }
            set{
                iD = value;
            }
        }

        public void Print(){
            System.Console.WriteLine($"ID = {this.ID}");
        }
    }
}