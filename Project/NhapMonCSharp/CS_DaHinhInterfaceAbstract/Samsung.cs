using System;
using Interface.CS_DaHinhInterfaceAbstract;

namespace CS_DaHinhInterfaceAbstract
{
    class Samsung : Phone, IAndroid
    {
        private string hinhSamSung;
        public Samsung()
        {
        }

        public Samsung(string name) : base(name)
        {
        }

        public Samsung(string name, string hinhSamSung) : base(name)
        {
            HinhSamSung = hinhSamSung;
        }

        public string HinhSamSung{get => hinhSamSung; set => hinhSamSung = value;}

        public override void ProductInfo()
        {
            System.Console.WriteLine("Điện thoại samsung này tên là " + Name);
        }
        
        void IFeaturePhone.Calling()
        {
            System.Console.WriteLine("Open screen android calling");
        }

        void IAndroid.CHPlay()
        {
            System.Console.WriteLine("Open screen CHPlay");
        }

        void IFeaturePhone.Message()
        {
            System.Console.WriteLine("Open screen android Message");
        }
    }
}