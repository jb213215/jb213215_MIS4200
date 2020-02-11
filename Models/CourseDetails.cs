using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jb213215_MIS4200.Models
{
    public class CourseDetails
    {
        [Key]
        public int detailId { get; set; }
        public string courseName { get; set; }
        public string courseDescription { get; set; }
        public DateTime courseStartDate { get; set; }
        public string instructorName { get; set; }

        
    }
}