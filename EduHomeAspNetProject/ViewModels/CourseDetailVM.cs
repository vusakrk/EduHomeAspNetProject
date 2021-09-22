using EduHomeAspNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.ViewModels
{
    public class CourseDetailVM
    {
        public BgImage BgImage { get; set; }
        public Course Course { get; set; }
        public ContactMessage ContactMessage { get; set; }
        public List<CourseDetail> CourseDetails { get; set; }
        public List<CourseFeature> CourseFeatures { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
