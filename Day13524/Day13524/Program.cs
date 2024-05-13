using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Day13524
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public CourseLevel Level { get; set; }
        public float FullPrice { get; set; }
        public Author Author { get; set; }
        public IList<Tag> Tags { get; set; }
    }
    public class Author
    {
        public int id { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; }
    }
    public class Tag
    {
        public int id { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; }

    }
    public enum CourseLevel
    {
        beginner = 1,
        intermediate = 2,
        advance = 3
    }
    public class PlutoContex:DbContext
        {
        public DbSet<Course> Course { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { set; get; }


        public PlutoContex() : base("name=DefaultConnection")
        {

        }

    }
   
internal class Program
{
    static void Main(string[] args)
    {
    }
}
}