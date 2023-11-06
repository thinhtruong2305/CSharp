using System;

//1 Namespace có thể có nhiều lớp và các namespace có thể lồng nhau
//Cách 1
namespace CS_NameSpace
{
    class NameSpace
    {
        
    }
    namespace CS_NameSpace1
    {
        struct NameSpace1
        {
            
        }
        class NameSpace2
        {
            
        }
        class NameSpace3
        {
            
        }
    }
}

//Cách 2
namespace CS_NameSpace2
{
    struct NameSpace4
    {
        
    }
}

namespace CS_NameSpace2.CS_NameSpace3
{
    struct NameSpace5
    {
        
    }
}

//Cả hai cách khai báo đều giống nhau về cách lồng