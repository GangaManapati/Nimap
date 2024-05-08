using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Day80524
{
    internal partial class Program
    {
        [Table("tblProduct")]
        public class Product
        {
            [Key]
            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }

        }
    }
}
