using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day27524.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public string EmpPhno { get; set; }
        [Required(ErrorMessage ="Select strong it must have one uppercase letter,Specialcharactesr")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool IsPermant { get; set; }
        public gender gen { get; set; } 

    }
    public enum gender
    {
        female,
        male,
        others
    }
}