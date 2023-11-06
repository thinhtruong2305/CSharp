using System;
using Abstract.CS_DaHinhInterfaceAbstract;

namespace CS_DaHinhInterfaceAbstract
{
    class Phone : Product
    {
        private string name;

        public Phone()
        {
        }

        public Phone(string name)
        {
            this.name = name;
        }

        public string Name{get => name;set => name = value;}

        public override void ProductInfo()
        {
            System.Console.WriteLine("Điện thoại tên là " + Name);
        }
    }
}