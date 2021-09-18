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
        public List<Service> Services { get; set; }
        public About About { get; set; }
        public List<NoticeBoard> NoticeBoards { get; set; }
        public NoticeVideo NoticeVideo { get; set; }
        public List<Event> Events { get; set; }
    }
}
