
using System.Runtime.Remoting.Contexts;
using System.Linq;
using System;
using System.Data.Entity.ModelConfiguration.Configuration;
namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new PlutoContext();
            /*    // LINQ method
              select c;





                var p = x.Courses
                    .Where(c => c.Name.Contains("C#"))
                    .OrderByDescending(c => c.Name)
                    .Select(c => new
                    {
                        c.AuthorId,
                        c.Name
                    });


                foreach (var course in p)
                {
                    Console.WriteLine($"AuthorId: {course.AuthorId}, Name: {course.Name}");
                }
    


            // for grouping 
            var p =

                   from c in x.Courses
                   group c by c.Level
                   into g
                   select g;


            foreach (var s in p)
            {
                Console.WriteLine(s.Key);

                foreach (var course in s)
                {
                    Console.WriteLine("\t{0}", course.Name);
                   //Console.WriteLine("{0} +{1}",s.Key, s.Count()); 
                }
            }



            // inner join
            var query = from c in x.Courses
                        join a in x.Authors on c.AuthorId equals a.Id
                        select new
                        {
                            CourseName = c.Name,
                            AuthorName = a.Name,
                            Id=a.Id
                        };

            var results = query.ToList();

            foreach (var i in results)
            {
                Console.WriteLine($"Course Name: {i.CourseName}, Author Name: {i.AuthorName},ID:{i.Id}");
            }


            
            // Group Join 
            var query = from a in x.Authors
                        join c in x.Courses on a.Id equals c.AuthorId into g
                        select new
                        {

                            AuthorName = a.Name,
                            Count = g.Count()
                        };

            

            foreach (var i in query)
            {
                Console.WriteLine($"Course Name: {i.AuthorName},count :{i.Count}");
            }


*/

            // cross join


            var query = from a in x.Authors
                        from c in x.Courses
                        select new
                        {
                            AuthorName = a.Name,
                            CourseName = c.Name
                        };

           // var results = query.ToList();

            foreach (var result in query)
            {
                Console.WriteLine($"Author Name: {result.AuthorName}, Course Name: {result.CourseName}");
            }




        }
    }



}






// another way by lambda expressions
/* var p = x.courses
      .where(c => c.name.contains("c#"))
      .orderby(c => c.name);

  foreach (var c in p)
  {
      console.writeline(c.name);
  }

  var authors = x.authors
      .where(a => a.name.contains("eric wise"))
      .orderby(a => a.name);


  foreach (var author in authors)
  {
      console.writeline($"id: {author.id}, name: {author.name}");
  } 


            */

