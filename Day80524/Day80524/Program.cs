using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations;
//using System.Data.Entity;
//using System.Linq;
//using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Day80524
{

   
    interface IA
    {
        void MethodA();
    }

    interface IB : IA
    {
        void MethodB();
    }

    interface IC : IA
    {
        void MethodC();
    }

    class MyClass : IB, IC
    {
        public void MethodA()
        {
            Console.WriteLine("Implementation of MethodA");
        }

        public void MethodB()
        {
            Console.WriteLine("Implementation of MethodB");
        }

        public void MethodC()
        {
            Console.WriteLine("Implementation of MethodC");
        }
        class Program
        {
            static void Main(string[] args)
            {
                MyClass obj = new MyClass();
                obj.MethodA(); 
                obj.MethodB();
                obj.MethodC();
                Console.ReadLine();
            }
        }
    }

  

    /*class Program
    {
        static async Task<int> SumAsync(int a, int b)
        {
            
            await Task.Delay(1000); 
            return a + b;
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting the asynchronous operation...");

            int result = await SumAsync(5, 10);

            Console.WriteLine($"The result of the asynchronous operation is: {result}");

            Console.WriteLine("End of the program.");
            Console.ReadLine();
        }
    }



     class Program
     {
         static void Main(string[] args)
         {

             Task task1 = Task.Run(() => PrintNumbers("Task 1", 5));
             Task task2 = Task.Run(() => PrintNumbers("Task 2", 5));

             // Waiting for both tasks to complete
             Task.WaitAll(task1, task2);

             Console.WriteLine("All tasks completed.");
         }

         static void PrintNumbers(string taskName, int count)
         {
             for (int i = 1; i <= count; i++)
             {
                 Console.WriteLine($"{taskName} - Number: {i}");
                 // Simulate some work by sleeping for a short duration
                 Task.Delay(100).Wait();

             }
             Console.ReadLine();
         }
     }



     class Program
     {

         static void Swap<T>(ref T a, ref T b)
         {
             T temp = a;
             a = b;
             b = temp;
         }

         static void Main(string[] args)
         {
             // Example with integers
             int x = 5;
             int y = 10;
             Console.WriteLine($"Before swapping: x = {x}, y = {y}");
             Swap(ref x, ref y);
             Console.WriteLine($"After swapping: x = {x}, y = {y}");

             // Example with strings
             string str1 = "hello";
             string str2 = "world";
             Console.WriteLine($"Before swapping: str1 = {str1}, str2 = {str2}");
             Swap(ref str1, ref str2);
             Console.WriteLine($"After swapping: str1 = {str1}, str2 = {str2}");
             Console.ReadLine();
         }
     }


     internal partial class Program
     {
       public  class Post
         {
             public int Id { get; set; }
             public string Name { get; set; }
             public DateTime DOb { get; set; }
             public float sal { get; set; }

         }
         public class BlogDbContext : DbContext
         {
             public DbSet<Post> Posts { get; set; }
         }
             static void Main(string[] args)
         {
         }


     }



     [Table("tablCategories")]
     public class Category
     {
         [Key]
         public int categId { get; set; }
         public string categName { get; set; }
     }
     [Table("tblProduct")]
     public class Product
     {
         [Key]
         public int Id { get; set; }
         public string Name { get; set; }
         public double Price { get; set; }


     public class NortwindContext : DbContext
         {
             public NortwindContext()
                 : base("name=NortwindConnection")
             {

             }

             public DbSet<Category> CategoriesTable { get; set; }
             public DbSet<Product> ProductTable { get; set; }
         }
         static void Main(string[] args)
         {
         }

     }
     */
}
