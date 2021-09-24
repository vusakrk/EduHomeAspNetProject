using EduHomeAspNetProject.Models;
using System.Collections.Generic;

namespace EduHomeAspNetProject.ViewModels
{
    public class CourseVM
    {
        public BgImage BgImage { get; set; }
        public List<Course> Courses { get; set; }
        public List<CourseDetail> CourseDetails { get; set; }
        public List<CourseFeature> CourseFeatures { get; set; }
        public List<CourseCategory> CourseCategories { get; set; }
    }
}
