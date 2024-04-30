using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3, 4,55,33,332, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, };
            var x=from i in arr where i>9 orderby i select i;
            foreach(int i in x)
            {
                Console.WriteLine(i);   
            }
            Console.ReadLine();
        }
    }
}
