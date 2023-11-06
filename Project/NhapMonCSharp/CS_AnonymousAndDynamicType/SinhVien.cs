using System;

namespace CS_AnonymousAndDynamicType
{
    class SinhVien
    {
        private string hoTen;
        private int namSinh;
        private string noiSinh;

        public SinhVien()
        {
            
        }

        public string HoTen
        {
            get{
                return hoTen;
            }
            set => hoTen = value;
        }
        public int NamSinh
        {
            get{
                return namSinh;
            }
            set => namSinh = value;
        }
        public string NoiSinh
        {
            get{
                return noiSinh;
            }
            set => noiSinh = value;
        }
        public void Hello() => System.Console.WriteLine("Hello " + HoTen);
    }
}