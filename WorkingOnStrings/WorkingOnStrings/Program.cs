using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace WorkingOnStrings
{
    
    internal class Program
    {
       
        

        static void Main(string[] args)
        
        
       {
            String s= "Ganga bhavani manapati";
             var p = Decimal.Parse(s);
              Console.WriteLine(p);
              var q=Convert.ToDecimal(s);
              Console.WriteLine(q);
              var i=s.IndexOf(" ");
              Console.WriteLine(i);
              var array=s.Split(' ');
              Console.WriteLine(array[0] + '\n' + array[1] + '\n' + array[2]);
              String a=s.Substring(7);
              Console.WriteLine(a);
              String b = s.ToUpper();
              Console.WriteLine(b);
              var c = s.LastIndexOf('a');
              Console.WriteLine(c);
              String d = s.Trim();
              Console.WriteLine(a);
              String e = s.Replace('e','*');
              Console.WriteLine(e);
             if (String.IsNullOrWhiteSpace(" "))
             {
                 Console.WriteLine("fdgfgdfs"); 
             }










             //String builders

             var p = new StringBuilder();
             p.Append("hello");
             p.Insert(4, "ganga");
             Console.WriteLine(p);
             p.Replace('a', 'o');
             Console.WriteLine(p);
             p.Remove(0,5);
             Console.WriteLine(p);
             Console.WriteLine(p[0]);    






             // 1st program in summary
             String p=Console.ReadLine();
             var num = p.Split('-');
             var c = Convert.ToInt32(num[0]);
             int d = 0;
             foreach(var a in num)
             {
                 var q = int.Parse(a);
                 if (q == c)
                 {
                     d++;
                 }
                 c++;

             }
             Console.WriteLine(d);
             if(d==num.Length) {
                 Console.WriteLine("Consgative");
                     }
             else { Console.WriteLine("not");
             }


             








            //working with files

            var path = "C:\\Users\\Nimap\\Downloads\\down.jpg";
            var p = "C:\\Users\\Nimap\\Desktop\\down.jpg";
            File.Copy("C:\\Users\\Nimap\\Downloads\\down.jpg", "C:\\Users\\Nimap\\Desktop\\down.jpg", true);
            if(File.Exists(p))
            {
                Console.WriteLine("exist");
            }
            File.Delete(path);





            
            string filePath = "C:\\Users\\Nimap\\Desktop\\NIMAP\\map.txt"; // Specify the file path

            // Create a new file stream
            using (FileStream fs = File.Create(filePath))
            {
                // Do nothing, simply creating the file
            }

           Console.WriteLine("File created successfully using File.WriteAllText.");
            








            
            // Path to the text file
            string filePath = "C:\\Users\\Nimap\\Desktop\\NIMAP\\map.txt";

            // Read the entire text from the file
            string text = File.ReadAllText(filePath);

            // Split the text into words using space as the separator
            string[] words = text.Split(' ');

            // Count the number of words
            int wc = words.Length;
            Console.WriteLine(wc);

            string longestWord = "";
            int maxLength = 0;

            // Iterate through each word and find the longest one
            foreach (string word in words)
            {
                if (word.Length > maxLength)
                {
                    maxLength = word.Length;
                    longestWord = word;
                }
            }
            Console.WriteLine(longestWord);










            

           

            




























            Console.ReadLine();

        }



















       
        
    }
}
