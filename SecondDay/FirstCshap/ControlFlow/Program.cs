using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int workingHours = 4;
             string s = (workingHours >= 9) ? "good" : "Please maintain";
             Console.WriteLine(s);



              if(n >= 0 && n<+10)
              {
                  Console.WriteLine("Valid");
              }
              else
              {
                  Console.WriteLine("Invalid");
              } 
             switch (n)
             {
                 case 0:
                     Console.WriteLine("zero");
                     break;
                  case 1:
                     Console.WriteLine("one");
                     break;
                 case 2:
                  case 3:
                     Console.WriteLine("two or three");
                     break;
                 default:
                     Console.WriteLine("other");
                     break;
             }
            int n = Convert.ToInt32(Console.ReadLine());
            int q = Convert.ToInt32(Console.ReadLine());
            //int s=(n>q)?n:q;
            //Console.WriteLine(s);   
            if(n>q)
            {
                Console.WriteLine("biggest is {0}",n);
            }
            else
            {
                Console.WriteLine("biggest is {0}",q);
            }
            






            var t = new char[26];
            //string s=Console.ReadLine();
            for (var i = 0; i < 26; i++)
            {
                t[i] = (char)(i + 65);
            }
            string p=String.Join(",",t);
            Console.WriteLine(p);

            


            

            int n = Convert.ToInt32(Console.ReadLine());
            for (var i = 1; i < n; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }

            }






            
            var sum = 0;
            while (sum>=0)
            {
                Console.WriteLine("Please enter a number or OK to see a sum of entered numbers");
                var input = Console.ReadLine();
                if (input.ToLower() == "ok")
                {
                    Console.WriteLine("Sum of entered numbers is " + sum);
                    break;
                }
                else
                    sum = sum + Convert.ToInt32(input);
                Console.WriteLine("Total: " + sum);
            }








            
            int sum = 1;
            int n = Convert.ToInt32(Console.ReadLine());
            for (var i = n; i >0;i--)
            {
                sum=sum*i;
            }
            Console.WriteLine(sum);





            




            var r = (new Random()).Next(10);
            Console.WriteLine("Random number: {0}", r);
            for (var i = 1; i <= 4; i++)
            {
                Console.Write("Guess my number between 1 and 10: ");
                var input = Convert.ToInt32(Console.ReadLine());
                if (input == r)
                {
                    Console.WriteLine("Yow won");
                    break;
                }
                else if (i == 4)
                {
                    Console.WriteLine("Yow lost");
                }
            }








            




            var m = Console.ReadLine();

            var arr = m.Split(',');

            var max = Convert.ToInt32(arr[0]);

            foreach (var str in arr)
            {
                var p = Convert.ToInt32(str);
                if (p > max)
                    max = p;
            }

            Console.WriteLine("Max is " + max);







            // facebook activity

            var list = new List<String>();

            while (list.Count>=0)
            {
                Console.WriteLine("Write a name:");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                else
                    list.Add(input);

            }

            switch (list.Count)
            {
                case 0:
                    Console.WriteLine("Nobody likes your post");
                    break;
                case 1:
                    Console.WriteLine("{0} likes your post", list[0]);
                    break;
                case 2:
                    Console.WriteLine("{0} and {1} liked your post", list[0], list[1]);
                    break;
                default:
                    Console.WriteLine("{0} and {1} and {2} other people liked your post", list[0], list[1], (list.Count - 2));
                    break;
            }





            */




            //reverse of string

            Console.WriteLine("Enter Name:");
            var n = Console.ReadLine();
            var a = new char[n.Length];
            for (var i = n.Length; i > 0; i--)
            {
                a[n.Length - i] = n[i-1];
            }
            Console.WriteLine("Reversed Name:");
            var r = string.Join("",a);
            Console.WriteLine(r);
            




            Console.ReadLine();
        }
    }
}
