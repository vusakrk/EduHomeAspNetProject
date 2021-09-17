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
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<CourseDetail> CourseDetails { get; set; }
        public NoticeVideo NoticeVideo { get; set; }
        public IEnumerable<NoticeBoard> NoticeBoards { get; set; }
        public IEnumerable<Event> Events { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<BlogDetail> BlogDetails { get; set; }
        public IEnumerable<Testimonial> Testimonials { get; set; }
        public About About { get; set; }


    }
}
