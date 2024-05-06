using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6524
{
    /* public class Example
     {
         public const double Pi = 3.14159; // Const variable

         public readonly double Radius; // Readonly variable

         public Example(double radius)
         {
             Radius = radius;
         }
     }

     class Program
     {
         static void Main(string[] args)
         {

             Console.WriteLine("Value of Pi: " + Example.Pi);


             Example x1 = new Example(5.0);
             Example x2 = new Example(10.0);

             Console.WriteLine("Radius of example1: " + x1.Radius); // Output: 5.0
             Console.WriteLine("Radius of example2: " + x2.Radius); // Output: 10.0
             Console.ReadLine();

             }
     }

     
   

    class Program
    {
        static void Main(string[] args)
        {
            int m = int.MaxValue;
            Console.WriteLine("Maximum integer value: " + m);

            
            int result = m + 1;
            Console.WriteLine("Result of adding 1 to maxInt: " + result); // Output: -2147483648
            Console.ReadLine();
        }
    }

    

   
    public delegate void MyDe(string m);

    class Program
    {
        public void Print(string m)
        {
            Console.WriteLine("Message: " + m);
        }
        public void Pri(string m)
        {
            Console.WriteLine("Message: " + m);
        }

        static void Main(string[] args)
        {
            Program p=new Program();
            MyDe x = p.Print;
            x += p.Pri;

            // Invoke the delegate
            x("Hello, world!");
           // p.Pri("ganga bhavani");
            Console.ReadLine();
        }

      

       
        
    }




    //anonymous methods
    
    public delegate void MyDe(int m,int n);

    class Program
    {
        //public void Print(int m,int n)
        //{
        //    Console.WriteLine("Message: " + m+n);
        //}
       
        static void Main(string[] args)
        {
            Program p = new Program();
            MyDe x = delegate(int m,int n)
                {
                Console.WriteLine("sum is:"+(m+n)s);
            };
            x.Invoke(4, 7);
           
            Console.ReadLine();
        }





    }


    



    // lambda 


    public delegate void MyDe(int m, int n);

    class Program
    {
        //public void Print(int m,int n)
        //{
        //    Console.WriteLine("Message: " + m+n);
        //}

        static void Main(string[] args)
        {
            Program p = new Program();
            MyDe x = (int m,int n)=>
            {
                Console.WriteLine("sum is:" + (m + n));
            };
            x.Invoke(4, 7);

            Console.ReadLine();
        }





    }



    


    public class BaseClass
    {
        public int publicField;
        protected int protectedField;
        private int privateField;

        public void PublicMethod() {
            Console.WriteLine("gNABDH7635463BDAH");
        }
        protected void ProtectedMethod() {
            Console.WriteLine("gNABDHBD12345AH");
        }
        private void PrivateMethod() {
            Console.WriteLine("gNABDHBD0000000000000AH");
        }

        public BaseClass()
        {
            Console.WriteLine("gNABDHBDAH");
        }
    }

    public class DerivedClass : BaseClass
    {
       static  void AccessBaseMembers()
        {
            publicField = 10;       // Accessible
            protectedField = 20;    // Accessible
                                    // privateField = 30;   // Not accessible (private)
            PublicMethod();         // Accessible
            ProtectedMethod();      // Accessible
        }
        public DerivedClass() : base()
        {
            Console.WriteLine("Program starts here");
        }
        public static void Main(string[] args) {
                     
           }
        
        
    }


    


    

    public class Person
    {
        protected string name;

        public Person(string name)
        {
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {name}");
        }
    }

    public class Employee : Person
    {
        private string department;

        public Employee(string name, string department) : base(name)
        {
            this.department = department;
            base.name = "ganga";
        }

        public void Display()
        {

            base.Display();
            Console.WriteLine($"Department: {this.department}");
        }
    }
    public class P
    { 
        static void Main(string[] args)
        {
            Employee emp = new Employee("John Doe", "IT");
            emp.Display();
            Console.ReadLine();
        }
    }




    



    using System;

    // Base class
    public class Vehicle
    {
        public string Brand { get; }
        public string Model { get; }

        // Constructor
        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        // Method to display vehicle details
        public void DisplayDetails()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}");
        }
    }

    // Derived class inheriting from Vehicle
    public class Car : Vehicle
    {
        public string Color { get; }

        // Constructor
        public Car(string brand, string model, string color) : base(brand, model)
        {
            Color = color;
        }

        // Method to display car details including color
        public new void DisplayDetails()
        {
            base.DisplayDetails(); // Call base class method
            Console.WriteLine($"Color: {Color}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Car
            Car myCar = new Car("Toyota", "Camry", "Blue");

            // Display car details
            myCar.DisplayDetails();
            Console.ReadLine();
        }
    }

    */




    public class MathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();
            Console.WriteLine(math.Add(5, 3)); // Invokes int version
            Console.WriteLine(math.Add(2.5, 3.7)); // Invokes double version
            Console.ReadLine();
        }
    }



}
