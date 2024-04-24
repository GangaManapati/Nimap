using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstCshap.math;
namespace FirstCshap
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Person x=new Person();
           string  fi = "ganga";
            string la = "manapati";
            x.m(fi,la);
            Clalcul y = new Clalcul();
           Console.WriteLine( y.Add(1, 2));
            Console.ReadLine();
        }
    }
}
