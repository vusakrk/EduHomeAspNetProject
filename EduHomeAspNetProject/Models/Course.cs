using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Name { get; set; }
        [Required,StringLength(300)]
        public string Description { get; set; }
        public int CourseDetailId { get; set; }
        public CourseDetail CourseDetail { get; set; }
        public int CourseFeatureId { get; set; }
        public CourseFeature CourseFeature { get; set; }
        public List<AppUser> AppUsers { get; set; }
        public int Count { get; set; }
        [Required,NotMapped]
        public IFormFile Photo { get; set; }
    }
}
