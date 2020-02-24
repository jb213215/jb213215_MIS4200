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
        public DateTime courseStartDate { get; set; }

        [Display(Name = "Instructor Name")]
        [Required(ErrorMessage = "Instructor Name Required")]
        [StringLength(20)]
        public string instructorName { get; set; }

        
    }
}