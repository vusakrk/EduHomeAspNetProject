using EduHomeAspNetProject.Models;
using System.Collections.Generic;

namespace EduHomeAspNetProject.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Service> Services { get; set; }
        public About About { get; set; }
        public List<NoticeBoard> NoticeBoards { get; set; }
        public NoticeVideo NoticeVideo { get; set; }
        public List<Event> Events { get; set; }
        public List<Course> Courses { get; set; }
        public IEnumerable<Testimonial> Testimonials { get; set; }
    }
}
