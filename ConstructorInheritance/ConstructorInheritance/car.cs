using System;

namespace ConstructorInheritance
{
    public class car:vech
    {
        public car(String number):base(number)
        {
            Console.Write("this is car class  {0}",number);  
        }
    }
}
