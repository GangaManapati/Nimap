using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extenclass
{
    internal class Program
    {
        public void m1()
        {
            Console.WriteLine("Metod111111");

        }
        public void m2()
        {
            Console.WriteLine("Metod22221");

        }
       public  void m3()
        {
            Console.WriteLine("Metod33331111");

        }
        public void m4()
        {
            Console.WriteLine("Metod4444111");

        }
        static void Main(string[] args)
        {
            Program p= new Program();
            p.m1();
            p.m2();
                p.m3();
            p.m4();
            p.M5();
            Console.ReadLine();
        }
    }
}
