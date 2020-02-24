using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jb213215_MIS4200.Models
{
    public class Student
    {
        public System.Guid SID { get; set; }
        public int studentId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Student First Name Required")]
        [StringLength(20)]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Student Last Name Required")]
        [StringLength(20)]
        public string lastName { get; set; }

        [Display(Name = "Email Address")]
        [Required]
        public string email { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [Required]
        [RegularExpression(@"^(\(\d{3}\)|\d{3}-)\d{3}-\d{4}$",
            ErrorMessage ="Phone number must be i the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phone { get; set; }

        [Display(Name = "Enrollment Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode =true)]
        public DateTime studentSince { get; set; }
        public ICollection<Student> student { get; set; }
    }
}