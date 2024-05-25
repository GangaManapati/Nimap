using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day25524.Models
{
    public class BusinessLogic
    {
        public Student GET(int  id) 
        {
            Student s = new Student
            {
                Id = id,
                Name = "ganga",
                gender = "female",
                branch = "CSE",
                session = 1
            };

            return s;   

        }
    }
}