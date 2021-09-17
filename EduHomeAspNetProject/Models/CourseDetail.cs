﻿using System;
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
        [Required]
        public string AboutCourse { get; set; }
        [Required]
        public string HowtoApply { get; set; }
        [Required]
        public string Certification { get; set; }
        public string CertificationDesc { get; set; }
        public virtual Course Course { get; set; }
    }
}
