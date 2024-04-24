using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
   /* public enum ship
    {
        Regular=4,
        real=2,
        exp=3
    }*/
   public class sum
    {
       public int age=22;
    }
    public class Program
    {
       
        public static void m(sum x)
        {
            x.age += 10;
        }
        static void Main(string[] args)
        {

            sum x = new sum();
            m(x);
            Console.WriteLine(x.age);
            /*   var Arry = new int[6] { 1, 2, 3, 4, 5, 6 };
             var Arry2 = Arry;
             Arry2[0] = 9;

                System.Console.WriteLine("first {0} secons {1}", Arry[0], Arry2[0]);
                 System.Console.WriteLine(Arry[1]);

             string s = "Ganga";
             string b = "manapati";
             string p= s +" " +b;
             string q=string.Format("My name is {0} {1} im from andhra",s,b);
             string a=string.Join("*",Arry);
             Console.WriteLine(a);
             Console.WriteLine(s[2]);
             Console.WriteLine(p);
             Console.WriteLine(q);   




             var n=ship.Regular;
             Console.WriteLine((int)n);
             var mid = 3;
             Console.WriteLine((ship)mid); */
             Console.ReadLine(); 
            
        }
           
            
        
    }
}
