using System;
using Interface.CS_DaHinhInterfaceAbstract;

namespace CS_DaHinhInterfaceAbstract
{
    class IPhone : Phone, IIOS, IFeaturePhone
    {
        private string hinhTraiTao;

        public IPhone()
        {
            
        }
        

        public IPhone(string name) : base(name)
        {
            
        }

        public IPhone(string name, string hinhTraiTao) : base(name)
        {
            this.hinhTraiTao = hinhTraiTao;
        }

        public string HinhTraiTao{get => hinhTraiTao; set => hinhTraiTao = value;}

        public void AppStore()
        {
            System.Console.WriteLine("Open Appstore");
        }

        public void Calling()
        {
            System.Console.WriteLine("Open screen calling");
        }

        public void Message()
        {
            System.Console.WriteLine("Open screen message");
        }

        public override void ProductInfo()
        {
            System.Console.WriteLine("Điện thoại IPhone này tên là " + Name);
        }
    }
}