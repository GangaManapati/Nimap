using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    /* public class MyGenericClass<T>
     {
         private T m;

         public MyGenericClass(T i)
         {
             m = i;
         }

         public void Display()
         {
             Console.WriteLine("Value of myField: {0}",m);
         }
     }

     class Program
     {
         static void Main()
         {

             MyGenericClass<int> x = new MyGenericClass<int>(10);
             x.Display(); 
             MyGenericClass<string> y = new MyGenericClass<string>("Hello");
             y.Display();

             Console.ReadLine();
         }
     } 



    
    class Program
    {
        static void Main()
        {
           
            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(101, "Alice");
            students.Add(102, "Bob");
            students.Add(103, "Charlie");


            Console.WriteLine("Name of student with ID 101: {0}", students[101]);
            if (students.ContainsKey(102))
            {
                Console.WriteLine("Student with ID 102 exists: {0}",students[102]); 
            }
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
            }

        
            students.Remove(103);
            Console.WriteLine($"Number of students in the dictionary: {students.Count}");
            students.Clear();

            Console.WriteLine($"Number of students after clearing the dictionary: {students.Count}");
            Console.ReadLine();
        }
    }








    

  

    class Program
    {
        static void Main()
        {
        
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            
            myDictionary.Add(1, "Apple");
            myDictionary.Add(2, "Banana");
            myDictionary.Add(3, "Orange");

          
            Console.WriteLine("Value for key 1: " + myDictionary[1]);

            
            myDictionary[2] = "Grapes";

           
            Console.WriteLine("All key-value pairs:");
            foreach (KeyValuePair<int, string> kvp in myDictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

           
            int searchKey = 2;
            if (myDictionary.ContainsKey(searchKey))
            {
                Console.WriteLine($"Value for key {searchKey}: {myDictionary[searchKey]}"); 
            }
            else
            {
                Console.WriteLine($"Key {searchKey} not found.");
            }
            Console.ReadLine();
        }
       
    }





    

    public class Person : IComparable<Person>
    {
        public int Name { get; set; }

        public Person(int name)
        {
            Name = name;
        }

        public int CompareTo(Person other)
        {
            if (other.Name == this.Name) return 0;
            else if (other.Name > this.Name) return -1;
            else return 1;
        }

        class Program
        {
            static void Main()
            {
                Person person1 = new Person(5);
                Person person2 = new Person(7);

                int result = person1.CompareTo(person2);
                if (result < 0)
                {
                    Console.WriteLine($"{person1.Name} comes before {person2.Name}");
                }
                else if (result > 0)
                {
                    Console.WriteLine($"{person1.Name} comes after {person2.Name}");
                }
                else
                {
                    Console.WriteLine($"{person1.Name} is the same as {person2.Name}");
                }
                Console.ReadLine();
            }

    






   


    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public class PersonAgeComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentException("Cannot compare null objects.");
            }
            return x.Age.CompareTo(y.Age);
        }
    }

    class Program
    {
        static void Main()
        {
            var people = new List<Person>
        {
            new Person("John", 30),
            new Person("Alice", 25),
            new Person("Bob", 35)
        };

           
            people.Sort(new PersonAgeComparer());

            Console.WriteLine("People sorted by age:");
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name}, Age: {person.Age}");
            }
            Console.ReadLine();
        }
    }






    







}
   







