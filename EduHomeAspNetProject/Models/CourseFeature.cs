using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class CourseFeature
    {
        public int Id { get; set; }
        [Required]
        public DateTime Starts { get; set; }
        public decimal Duration { get; set; }
        public string ClassDuration { get; set; }
        public string SkillLevel { get; set; }
        public string Language { get; set; }
        public int Strudents { get; set; }
        public string Assesments { get; set; }
        [Required]
        public decimal Fee { get; set; }
        public virtual Course Course { get; set; }
    }
}
