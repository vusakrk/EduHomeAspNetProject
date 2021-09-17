using EduHomeAspNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public BrandLogo BrandLogo { get; set; }
        public HeaderContact HeaderContact { get; set; }
        public ServiceArea ServiceArea { get; set; }
        public ViewCourse ViewCourse { get; set; }
        public List<Course> Courses { get; set; }
        public List<CourseDetail> CourseDetails { get; set; }
        public NoticeVideo NoticeVideo { get; set; }
        public List<NoticeBoard> NoticeBoards { get; set; }
    }
}
