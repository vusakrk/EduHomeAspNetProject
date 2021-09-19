using EduHomeAspNetProject.Models;
using System.Collections.Generic;

namespace EduHomeAspNetProject.ViewModels
{
    public class CourseVM
    {
        public BgImage BgImage { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public ContactMessage ContactMessage { get; set; }
    }
}
