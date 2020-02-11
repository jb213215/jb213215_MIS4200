using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jb213215_MIS4200.Models
{
    public class Courses
    {
        [Key]
        public int courseId { get; set; }
        public string courseName { get; set; }
        public string courseDescription { get; set; }
        public DateTime startDate { get; set; }
        public ICollection<CourseDetails> CourseDetails { get; set; }
    }
}