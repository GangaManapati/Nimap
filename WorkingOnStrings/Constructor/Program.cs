using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    
    internal class Program
    {
        static void Main(string[] args) { 
            Constru x = new Constru(5);
            Console.WriteLine(x.id);
            Console.WriteLine(x.name);
            Console.ReadLine();
        
        }
    }
}
