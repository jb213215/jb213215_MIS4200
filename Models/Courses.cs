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

        [Display(Name = "Course Name")]
        [Required(ErrorMessage = "Course Name Required")]
        
        public string courseName { get; set; }

        [Display(Name = "Course Description")]
        [Required(ErrorMessage = "Course Description Required")]
        
        public string courseDescription { get; set; }

        [Display(Name = "Course Start Date")]
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime startDate { get; set; }

        public ICollection<CourseDetails> CourseDetails { get; set; }
    }
}