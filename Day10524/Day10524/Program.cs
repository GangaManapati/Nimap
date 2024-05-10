using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Http;
using System.CodeDom.Compiler;
namespace Day10524
{
    /* class Program
      {


          static void M()
          {
              // Simulate some work
              for (int i = 0; i < 5; i++)
              {
                  Console.WriteLine($"Thread is running. Iteration: {i}");
                  Thread.Sleep(1000); // Sleep for 1 second
              }
          }
          static void Main(string[] args)
          {

              Thread T = new Thread(M);
              T.Name = "MyThread";    // Set the name of the thread
              T.Priority = ThreadPriority.Normal; // Set the priority of the thread
              T.Start();




              // Get information about the current thread
              Thread CT = Thread.CurrentThread;
              Console.WriteLine($"Current Thread Name: {T.Name}");
              Console.WriteLine($"Current Thread Priority: {T.Priority}");


              // Check if the thread is alive
              if (T.IsAlive)
              {
                  Console.WriteLine($"{T.Name} is still running.");
              }
              else
              {
                  Console.WriteLine($"{T.Name} has finished.");
              }

              // Wait for the thread to finish
              T.Join();

              Console.WriteLine("Main thread exiting.");
              Console.ReadLine();
          }


      }
    


   

    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(MyThreadFunction);
            myThread.Start();

            // Sleep to ensure the thread has started
            Thread.Sleep(1000);

            // Interrupt the thread
            myThread.Interrupt();

            Console.WriteLine("Main Thread: Interrupted the worker thread.");
        }

        static void MyThreadFunction()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Worker Thread: Running...");
                    Thread.Sleep(1000); // Simulate some work
                }
            }
            catch (ThreadInterruptedException)
            {
                Console.WriteLine("Worker Thread: Interrupted!");
            }
            Console.ReadLine();
        }
    }

    


    class Program
    {
        static void Main(string[] args)
        {

            //var x = "ganga";
            //x = 66;
            dynamic x = "ganga";
            x = 66;
            Console.WriteLine(x);
            Console.ReadLine();

        }
    }

    


    public class Employee
     {
        public string Name { get; set; }    
        public int ID { get; set; }
        public int sal { get; set; }
    }
   
    class Program
    {
        static async void M()
        {
            Console.WriteLine("asynce method is strted...!");

            Employee e=await Get();
            Console.WriteLine($"id is{e.ID} name is {e.Name}  her salary is {e.sal}");
            Console.WriteLine("method cm[leted");
        }
        public static  async Task<Employee>  Get()
        {
            Task.Delay(10000);
            Employee e = new Employee()
            { 
                ID=1,
                Name="ganga",
                sal=20000

            };
            return e;
            //await Task.Delay(10000);
        }
        //static async void M2()
        //{
        //    Console.WriteLine("2nd asynce method is strted...!");

            
        //    Console.WriteLine("2nd method cm[leted");
        //}
        //static async void M3()
        //{
        //    Console.WriteLine("3dasynce method is strted...!");

            
        //    Console.WriteLine("3rdmethod cm[leted");
        //}
        static void Main(string[] args)
        {
            Console.WriteLine("call asyn method");
            M();
            //M2();
            //M3();
            Console.WriteLine("hii ganga");

            Console.ReadLine();
        }

       
    }

    




    

    class Program
    {
        static void Main(string[] args)
        {
            //   List<int> Li = Enumerable.Range(3, 10).ToList();//edi use cheste Parellel.ForEach(Li,codition rayali

        

            //   Parallel.For(Li, number =>
            Parallel.For(10,20, number =>
            {
                int square = C(number);
                Console.WriteLine($"Square of {number} is {square}");
            });

            Console.ReadLine();
        }

        static int C(int number)
        {
            // Simulating a CPU-bound operation
           // Task.Delay(100); // Simulating a delay
           // if delay to return the output then it take next number and clalculate the next next number square
            return number * number;
        }
    }

    */


    class Program
    {
        static void Main(string[] args)
        {


        }
    }
}

