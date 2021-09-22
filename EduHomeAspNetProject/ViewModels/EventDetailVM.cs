using EduHomeAspNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.ViewModels
{
    public class EventDetailVM
    {
        public ContactMessage ContactMessage { get; set; }
        public BgImage BgImage { get; set; }
        public Event Event { get; set; }
        public List<Speaker> Speakers { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Course> Courses { get; set; }
    }
}
