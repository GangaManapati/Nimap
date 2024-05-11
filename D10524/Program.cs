using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D10524
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new FirstDATABEntities();
            var Product = new List<Product>
            {
                new Product
                {
                    ProductID = 3,
                    Name = "gaa",
                    Description = "grnong",
                    Price = 364.5M,
                    StockQuantity = 45
                },
                new Product
                {
                    ProductID = 4,
                    Name = "river",
                    Description = "afternoon",
                    Price = 7646.2M,
                    StockQuantity = 20
                },
                new Product
                {
                    ProductID = 5,
                    Name = "ravi",
                    Description = "afrnoon",
                    Price = 6.2M,
                    StockQuantity = 33
                }

            };
            c.Products.AddRange(Product);
            c.SaveChanges();
            Console.ReadLine();
        }
    }
}
