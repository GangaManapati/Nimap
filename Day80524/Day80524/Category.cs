using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Day80524
{
    internal partial class Program
    {
        [Table("tablCategories")]
        public class Category
        {
            [Key]
            public int categId { get; set; }
            public string categName { get; set; }
        }
    }
}
