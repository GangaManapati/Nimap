using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7524
{
    /* internal class Program
     { }
        / class MathOperations
         {
             public double Add(int a, double b)
             {
                 return a + b;
             }

             public double Add(double a, double b)
             {
                 var x= this.Add(7,6.5);
                 Console.WriteLine(x);
                 return a + b;
             }
         }
         static void Main(string[] args)
         {
             MathOperations math = new MathOperations();
             // int sum1 = math.Add(5, 3); // Invokes the int Add method
             double sum2 = math.Add(2.5, 3.7); // Invokes the double Add method
             //Console.WriteLine(sum1);
             Console.WriteLine(sum2);    
             Console.ReadLine();

         }
     }



     


    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Dog barks");
        }
        static void Main(string[] args)
        {

            Animal myDog = new Dog();
            myDog.MakeSound(); // Outputs: "Dog barks"

            Console.ReadLine();
        }
    }

    


    

    class BaseClass
    {
        public void Display()
        {
            Console.WriteLine("This is the BaseClass display method.");
        }
    }

    class DerivedClass : BaseClass
    {
       
        public new void Display()
        {
            Console.WriteLine("This is the DerivedClass display method.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseObj = new BaseClass();
            baseObj.Display(); 

            DerivedClass derivedObj = new DerivedClass();
            derivedObj.Display(); 
            
            BaseClass derivedAsBase = new DerivedClass();
            derivedAsBase.Display(); // Output: "This is the BaseClass display method."

            Console.ReadLine();
        }
    }


    

    public class BankAccount
    {
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            private set
            {
                if (value >= 0)
                    balance = value;
                else
                    throw new ArgumentException("Balance cannot be negative.");
            }
        }

        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
                throw new InvalidOperationException("Insufficient funds.");

            Balance -= amount;
        }
    }
    





   
    public interface IShape
    {
        double Area(); // Method to calculate the area of the shape
    }

    // Implement the interface in a class
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Rectangle : IShape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double Area()
        {
            return length * width;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create objects of classes implementing the interface
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);

            // Use the interface to call the Area method
            Console.WriteLine("Area of Circle: " + circle.Area());
            Console.WriteLine("Area of Rectangle: " + rectangle.Area());
            Console.ReadLine
        }
    }

    */


}
