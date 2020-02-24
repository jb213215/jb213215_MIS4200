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

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Instructor First Name Required")]
        [StringLength(20)]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Student Last Name Required")]
        [StringLength(20)]
        public string lastName { get; set; }

        [Display(Name = "Email Address")]
        [Required]
 
        public string email { get; set; }


        [Display(Name = "Date of Employment")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime startDate { get; set; }
        public ICollection<CourseDetails> courseDetails { get; set; }


    }
}