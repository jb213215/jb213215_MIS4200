using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jb213215_MIS4200.Models
{
    public class Instructors
    {
        [Key]
        public int instructorID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public DateTime startDate { get; set; }
        public ICollection<CourseDetails> courseDetails { get; set; }


    }
}