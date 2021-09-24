using EduHomeAspNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.ViewModels
{
    public class BlogDetailVM
    {
        public ContactMessage ContactMessage { get; set; }
        public BgImage BgImage { get; set; }
        public Blog Blog { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Event> Events { get; set; }
        public List<Course> Courses { get; set; }
        public List<BlogComment> BlogComments { get; set; }
        public List<BlogCategory> BlogCategories { get; set; }

    }
}
