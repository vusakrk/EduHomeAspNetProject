using EduHomeAspNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.ViewModels
{
    public class AboutVM
    {
        public BgImage BgImage { get; set; }
        public About About { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public NoticeVideo NoticeVideo { get; set; }
        public List<NoticeBoard> NoticeBoards { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
