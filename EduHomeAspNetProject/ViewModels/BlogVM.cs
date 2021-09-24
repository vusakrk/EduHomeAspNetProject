using EduHomeAspNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.ViewModels
{
    public class BlogVM
    {
        public BgImage BgImage { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Event> Events { get; set; }
        public int PageCount { get; set; }
        public int CurrentPage { get; set; }
        public List<BlogComment> BlogComments { get; set; }

    }
}
