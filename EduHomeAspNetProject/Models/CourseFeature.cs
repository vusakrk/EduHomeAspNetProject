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
        public DateTime StartingDate { get; set; }
        [Required]
        public decimal Duration { get; set; }
        [Required]
        public decimal ClassDuration { get; set; }
        [Required, MaxLength(17)]
        public string SkillLevel { get; set; }
        [Required]
        public string Language { get; set; }
        [Required]
        public int Students { get; set; }
        [Required]
        public string Assesments { get; set; }
        [Required]
        public decimal Fee { get; set; }
        public virtual Course Course { get; set; }
    }
}
