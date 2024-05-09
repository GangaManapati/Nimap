using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day9524
{

    //anonymous expressions
    /* public class Program
     {
         public delegate void MyDelegate(string m);

         public static void NamedMethod(string me)
         {
             Console.WriteLine("Named Method: " + me);
         }
         public static void Main(string[] args)
         {
             // Using an anonymous method
             MyDelegate x = delegate (string e)
             {
                 Console.WriteLine("Anonymous Method: " + e);
             };

             // Invoking the delegate with help of object of delegate
            x("Hello from anonymous method!");

             // normal delegate invocation
             MyDelegate m = NamedMethod;

             // Invoking the delegate
             m("Hello from named method!");

             Console.ReadLine();
         }



     }




   // LAMBDA expressions

    public class Program
    {
        public delegate void MyDelegate(int m);
        
        public static void NamedMethod(int na)
        {
            Console.WriteLine("Named is: my age is:"+na);
        }
        public static void Main(string[] args)
        {
            // only difference is delegate keyword and use => symbol
            MyDelegate x = (m) =>
            {
                var s = m * m;
                Console.WriteLine("Lambda Expression: " + s);
            };

            // Invoking the delegate
            x(2);

            // Using a named method
            //MyDelegate myNamedDelegate = NamedMethod;

            // Invoking the delegate
            //myNamedDelegate("Hello from named method!",21);
            Console.ReadLine();
        }

       
    }

    




    // EVENTS AND DELEGATES
    public delegate string MDel(String p);//1.delegate declaration
    public class ebvents
    {
        event MDel E;//2.event declaration
        public String m(String s)
        {

            //Console.WriteLine($"WhatsApp Message from {s} ");
            return "WhatsApp Message from"+s;
        }
        public ebvents()
        {
            this.E +=new MDel(this.m);//event call
            //E=new MDEl(m);
        }
        static void Main(string[] args) { 
        ebvents e = new ebvents();
        var r = e.E("ganga");
            Console.WriteLine(r);

            Console.ReadLine();

        }
    }




    




   

    // Base class
    public class MyBaseClass
    {
        public void BaseMethod1()
        {
            Console.WriteLine("Base Method 1");
        }

        public void BaseMethod2()
        {
            Console.WriteLine("Base Method 2");
        }
    }

    // Extended class with extension methods
    public static class MyExtendedClass
    {
        // Extension method 1
        public static void ExtendedMethod1( this MyBaseClass s,int x,string p)
        {
            Console.WriteLine("Extended Method 1"+x+p);
        }

        // Extension method 2
        public static void ExtendedMethod2(this MyBaseClass baseClass)
        {
            Console.WriteLine("Extended Method 2");
        }

        // Extension method 3
        public static void ExtendedMethod3(this MyBaseClass baseClass)
        {
            Console.WriteLine("Extended Method 3");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyBaseClass myObject = new MyBaseClass();

            // Calling methods from base class
            myObject.BaseMethod1();  // Output: Base Method 1
            myObject.BaseMethod2();  // Output: Base Method 2

            // Calling extension methods
            myObject.ExtendedMethod1(4,"ganga"); // Output: Extended Method 1
            myObject.ExtendedMethod2(); // Output: Extended Method 2
            myObject.ExtendedMethod3(); // Output: Extended Method 3

            Console.ReadLine();
        }
    }


    
    //public delegate string del(int w);
    public class A
    {
        public string m1(int x)
        {
            var q = "area of square is: " + (x * x);
            return q;
        }
    }
    public static class C
    {
        static int y;
        public static string m2( A a,int x)
        {
            var o = "area of cube is: " + (x * x * x);
            return o;
        }
        public static String m3( A a,int x)
        {
            y = x + 1;
            var q = "area of tringle is: " + ((1.0 / 2) * y * x);
            return q;
        }
        public static string m4( A a,int x)
        {
            y = x + 1;
            var q = "area of rectangle is: " + (y * x);
            return q;
        }

    }

        public class B
    {
        static int x;
        static void Main(string[] args)
        {
            A a = new A();
            int p = int.Parse(Console.ReadLine());
            var z = a.m1(p);
            Console.WriteLine(z);
                var b = C.m2(a,p);
                Console.WriteLine(b);
                var c = C.m3(a, p);
                Console.WriteLine(c);
                var d = C.m4(a, p);
                Console.WriteLine(d);
                Console.ReadLine();
        }
    }
    */



    public class B
    {

        static void Main(string[] args)
        {

            int[] n = new int[4] { 3, 5, 2, 1 };
            //string[] n = new string[3] { "ganga", "bhvgdsv", "hvdg" };
            //var m = n.Aggregate((a, b) => a + b);
            //Console.WriteLine(m);

            //IEnumerable<int> r= n.Where((i)=>i%2 == 0);
            // IEnumerable<int> r =from i in n where i %2==0 select i;

            //var r = n.Select(x => x * x);

            //var r = Enumerable.Range(1, 3);

           // var r = n.Take(2);
            var r = n.Skip(2);

            Console.WriteLine("Squared numbers:");
            foreach (var num in r)
            {
                Console.WriteLine(num);
            }
             

            Console.ReadLine();
        }



    }


    }