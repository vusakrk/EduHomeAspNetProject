using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class CourseDetail
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        [Required,StringLength(300)]
        public string AboutCourse { get; set; }
        [Required]
        public string HowToApply { get; set; }
        [Required]
        public string Certification { get; set; }
        public Course Course { get; set; }
    }
}
