using Day2524;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Security.Policy;
namespace Day2524
{

    /*  public interface IFirst
      {
          void Show();
      }

      public interface ISecond
      {
          void Show();
      }

      public class Example : IFirst, ISecond
      {
          void IFirst.Show()
          {
              Console.WriteLine("Show method from IFirst");
          }

          void ISecond.Show()
          {
              Console.WriteLine("Show method from ISecond");
          }

          public void Show()
          {
              Console.WriteLine("Public Show method in Example");
          }
      }




      internal class Program
      {
          static void Main(string[] args)
          {
              Example obj = new Example();
              obj.Show();  // Calls the public Show method

              ((IFirst)obj).Show();  // Calls IFirst.Show
              ((ISecond)obj).Show(); // Calls ISecond.Show
              Console.ReadLine();
          }
      }  



      


    


    class Program
    {
        static void Main()
        {
            int[] numbers = { 2, 3, 4, 5 };

            // Parallelize the computation of factorial for each number
            Parallel.For(0, numbers.Length, i =>
            {
                Console.WriteLine($"Factorial of {numbers[i]} is {Factorial(numbers[i])}");
            });
            Console.ReadLine();
        }

        // A method to compute factorial
        static int Factorial(int num)
        {
            int result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }






    







    class Program
    {
        static async Task P()
        {
  
            await Task.Delay(3000);  
            Console.WriteLine("Task is processing...");
            
        }
        static async Task Main()
        {
            Console.WriteLine("Starting a long-running task...");
            await P();
            Console.WriteLine("Long-running task completed.");
            Console.ReadLine();
        }

      
    }


    

    class Program
    {
       
        static async Task Main()
        {
            int s = 10;
            float b=(float)s;
            Console.WriteLine("Long-runnin "+b);
            float r = float.Parse(s.ToString());
            Console.WriteLine("Long-runnin " + r);
           var  k = Convert.ToDecimal(s);   
            Console.WriteLine("Long-runnin " + k);
            var c = (decimal)s;
            Console.WriteLine("Long-runnin " + c);
            Console.ReadLine();
        }


    }



    

    public enum T 
    {
        Freezing = 5,
        Cold = 14,
        Moderate = 2,
        Warm = 6,
        Hot = 4
    }
    class Program
    {

        static async Task Main()
        {
            var m = (int)(T.Hot);
            Console.WriteLine(m); //to find the id of element
            var methodId = 14;
            Console.WriteLine((T)(methodId));//to find the element with help of id

            Console.ReadLine();




        }
    }

    */

    class Program
    {

        static async Task Main()
        {

            int[][] jaggedA = new int[3][];
            jaggedA[0] = new int[] { 1, 2, 3 };
            jaggedA[1] = new int[] { 4, 5 };
            jaggedA[2] = new int[] { 6, 7, 8, 9 };


            int value1 = jaggedA[1][0];
            Console.WriteLine(value1);

            int value2 = jaggedA[2][2];
            Console.WriteLine(value2);
            Console.ReadLine();

        }
    }






}



