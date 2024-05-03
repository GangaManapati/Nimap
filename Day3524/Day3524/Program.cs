using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day3524
{
    /* internal class Program
     {
        static int i;
        static string s;
         bool p;
         public Program(int a, int j)
         {
             i = a;
             Console.WriteLine(i);
             Console.WriteLine(j);   
             i = 10;
             s = "ganga";
             p = true;
         }


             static Program()
             {
                 i = 12234555;
             Console.WriteLine(i);   
             }



         static void Main(string[] args)
         {
             Program x=new Program(10,34);
             Program y = x.Program();
             Console.WriteLine(i);   
             Console.WriteLine(s);
             Console.WriteLine(x.p);
             Console.ReadLine();

         }
     } 

    
    



    class Person
    {
        public string Name;
        public int Age;

        // Copy method
        //public Person C()
        //{
        //    return new Person(Name, Age);
        //}

        public Person(Person x)
        {
            Age = x.Age;
            Console.WriteLine(x.Name);
        }

        public Person(string name, int age)
        {

            Name = name;
            Age = age;
        }


        static void Main(string[] args)
        {

            Person person1 = new Person("John", 30);
            // Person person2 = person1.C(); // Creates a copy of person1
            Person person2 = new Person(person1);
            Console.WriteLine(person2);
            Console.WriteLine(person1.Name);
            Console.WriteLine(person1.Age);
            Console.ReadLine();
        }




    }

    



    public class A
    {
        private void M1()
        {
            Console.WriteLine("for Private");
        }
        protected void M2()
        {
            Console.WriteLine("for Prottected");
        }
        internal void M3()
        {
            Console.WriteLine("for internal");
        }
        internal protected void M4()
        {
            Console.WriteLine("for internal Protected");
        }
        public void M5()
        {
            Console.WriteLine("for Prublic");
        }
        //static void Main(string[] args)
        //{

        //    A p = new A();
        //    p.M1();
        //    p.M2();
        //    p.M3();
        //    p.M4();
        //    p.M5();
        //    Console.ReadLine();
        //}







    }
    





    

    class Program
    {
        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            int[] numbers = { 5, 2, 8, 1, 9, 3, 7 };
            Console.WriteLine("Original array:");
            PrintArray(numbers);

  
            Array.Sort(numbers);
            Console.WriteLine("\nSorted array:");
            PrintArray(numbers);

        
            Array.Reverse(numbers);
            Console.WriteLine("\nReversed array:");
            PrintArray(numbers);

         
            int index = Array.IndexOf(numbers, 8);
            Console.WriteLine("\nIndex of element 8: " + index);

            
            Array.Resize(ref numbers, 10);
            Console.WriteLine("\nResized array:");
            PrintArray(numbers);


            Array.Clear(numbers, 0,2);
            Console.WriteLine("\n remover the elements 0,1:");
            PrintArray(numbers);
            Console.WriteLine(numbers.Length);


            var a2=new int[numbers.Length];
            Array.Copy(numbers, a2,6);
            Console.WriteLine(a2);
            foreach (int num in a2)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();


            Console.ReadLine();
        }

     
       
    }



    



   
    class Program
    {
        static void PrintList(List<string> list)
        {
            foreach (string color in list)
            {
                Console.Write(color + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
       
            List<string> colors = new List<string>() { "Red", "Blue", "Green" };

           
            Console.WriteLine("Original list:");
            PrintList(colors);

            
            colors.Add("Yellow");

            colors.AddRange(new List<String> { "cayan", "pink","Red", "orange" });

            colors.Insert(1, "Orange");

            Console.WriteLine("\nList after adding elements:");
            PrintList(colors);

           
            colors.Remove("Blue");
            colors.RemoveAt(0);
            Console.WriteLine("\nList after removing elements:");
            PrintList(colors);

       
            bool containsGreen = colors.Contains("Green");
            Console.WriteLine("\nDoes the list contain 'Green'? " + containsGreen);

            Console.WriteLine(colors.IndexOf("Orange"));
            Console.WriteLine(colors.LastIndexOf("Red"));
            Console.WriteLine(colors.Count);



            colors.Clear();
            Console.WriteLine("\nList after clearing no of elements are:"+colors.Count);
            PrintList(colors);


           


            Console.ReadLine();

        }

        
    }






    

    class Program
    {
        static void Main(string[] args)
        {

            var now = DateTime.Now;//current date
            Console.WriteLine("Current Date and Time: " + now);

            Console.WriteLine(now.Day);
            Console.WriteLine(now.Hour);    
            Console.WriteLine(now.Minute);
           var x= now.AddDays(2);
            Console.WriteLine("Current Date +2 days: " + x);
            var y=now.AddDays(-1);
            Console.WriteLine("Current Date -1 days: " + y);


            DateTime today = DateTime.Today;//// Date only (without time)
            Console.WriteLine("Today's Date: " + today);

           

            // Adding and subtracting days
            DateTime tomorrow = now.AddDays(1);
            DateTime yesterday = now.AddDays(-1);
            Console.WriteLine("Tomorrow's Date: " + tomorrow);
            Console.WriteLine("Yesterday's Date: " + yesterday);

            
            string formattedDate = now.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine("Formatted Date and Time: " + formattedDate);

           
            int year = now.Year;
            int month = now.Month;
            int day = now.Day;
            int hour = now.Hour;
            int minute = now.Minute;
            int second = now.Second;
            Console.WriteLine("Year: {year}, Month: {month}, Day: {day}, Hour: {hour}, Minute: {minute}, Second: {second}");

            
            DateTime futureDate = now.AddHours(2);
            DateTime pastDate = now.AddHours(-2);
            Console.WriteLine("Is futureDate after now? " + (futureDate));
            Console.WriteLine("Is pastDate before now? " + pastDate);


            TimeSpan duration = new TimeSpan(3, 30, 0); // Represents 3 hours and 30 minutes

            // Displaying the TimeSpan
            Console.WriteLine("TimeSpan: " + duration);

            Console.ReadLine();

        }
    }
    */



    
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, World!";

            
            Console.WriteLine("Length of the string: " + text.Length);

          
            Console.WriteLine("Uppercase: " + text.ToUpper());
            Console.WriteLine("Lowercase: " + text.ToLower());

            
            Console.WriteLine("Starts with 'Hello': " + text.StartsWith("Hello"));
            Console.WriteLine("Ends with 'World!': " + text.EndsWith("World!"));

            
            Console.WriteLine("Index of 'World': " + text.IndexOf("e"));
            Console.WriteLine("Index of 'World': " + text.LastIndexOf("l"));

            string sub = text.Substring(4);
            Console.WriteLine("Substring: " + sub);
            string substring = text.Substring(7, 5); 
            Console.WriteLine("Substring: " + substring);

          
            string replacedText = text.Replace("Hello", "Hi");
            Console.WriteLine("After replacement: " + replacedText);

           
            string stringWithWhitespace = "   Trim me!   ";
            string trimmedText = stringWithWhitespace.Trim();
            Console.WriteLine("After trimming whitespace: '" + trimmedText + "'");

            
            string fruits = "Apple,Orange,Banana";
            string[] fruitArray = fruits.Split(',');
            Console.WriteLine("Fruits:");
            foreach (string fruit in fruitArray)
            {
                Console.WriteLine(fruit);
            }

            
            string firstName = "ganga";
            string lastName = "bhavani";
            string fullName = string.Concat(firstName, " ", lastName);
            Console.WriteLine("Full name: " + fullName);

            
            int age = 22;
            string formattedString = string.Format("My name is {0} and I am {1} years old.", fullName, age);
            Console.WriteLine("Formatted string: " + formattedString);

            Console.ReadLine();
        }
    }



}
