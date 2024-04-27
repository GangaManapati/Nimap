using System;

namespace ConstructorInheritance
{
    public class vech
    {
        private readonly string _number;
        //public vech()
        //{
        //    Console.WriteLine("this is vechicalclass");

        //}
        public vech(String num)
        {
            _number= num;
            Console.WriteLine("this is vechicalclass" + _number);


        }
    }
}

