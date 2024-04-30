using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Func<int, int,int> square = (x,y) => x * y;
            //Console.WriteLine(square(5,2));




            //lambda exp with Statement block

            Func<int, int, int> factorial = (n, c) =>
            {
                int result = 1;
                for (int i = 5; i > 0; i--)
                {
                    result = result * i;
                }
                return result * c;
            };
            Console.WriteLine(factorial(5, 1));
            Console.ReadLine();


        }
    }
}
