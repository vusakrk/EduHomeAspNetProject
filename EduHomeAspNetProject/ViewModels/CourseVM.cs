using EduHomeAspNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.ViewModels
{
    public class CourseVM
    {
        public BgImage BgImage { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}
