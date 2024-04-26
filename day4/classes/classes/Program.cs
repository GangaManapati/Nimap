using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace classes
{
    public class Program
    {
        /* public  string s;
         public  int r;
         public Program()

         {
             Console.WriteLine("hgdhhj");
         }
         public Program(String s)
             :this() 
         {
             Console.WriteLine(s+"Uhbhbh");
         }
         public Program(String s,int r) 
             :this(s) 
         {
             Console.WriteLine(s);
             Console.WriteLine(r+"hguyguyv");
         }

         static void Main(string[] args)
         {

             var v=new Program("ganga",22);

             //var v = new Program
             //{
             //    s = "ganga",
             //    r = 10
             //};


         */

        public int a;

       public static  void Method(ref int a)
        {

            a =a+ 2;
            Console.WriteLine(a);
        }


        static void Main(string[] args)
        {


            //    foreach (var number in numbers)
            //    {
            //        Console.Write(number + " ");
            //    }
            //    Console.WriteLine();
            //}
            //static void Main(string[] args)
            //{
            //    var Program=new Program();
            //    Program.Add( 1, 2, 3, 4 );
            //    Console.WriteLine("numbers");
            var a = 1;
            Method(ref a);
            Console.WriteLine(a);




            Console.ReadLine();
        }
    }
}
