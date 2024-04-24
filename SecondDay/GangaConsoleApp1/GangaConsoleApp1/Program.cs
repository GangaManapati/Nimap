using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangaConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*var num = new int[3] {2,4,5};
            //num[0] = 1;
            Console.WriteLine("Hello");
            Console.WriteLine(num[0]);
            Console.WriteLine(num[1]);
            Console.WriteLine(num[2]);   */
            
            for (int i = 0;i<10;i++) {
                int d = 0;
                for(int j = 2;j<i;j++)
                {
                    if(i%j==0)
                    {
                        d++;
                    }
              
                }
                if(d==0 && i!=0 &&i!=1)
                {
                    Console.WriteLine(i);
                }
                
            }
            Console.ReadLine();
        }
    }
}
