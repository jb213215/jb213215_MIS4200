using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jb213215_MIS4200.Models
{
    public class Student
    {
        public int studentId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime studentSince { get; set; }
        public ICollection<Student> student { get; set; }
    }
}