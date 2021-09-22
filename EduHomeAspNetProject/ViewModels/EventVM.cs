using EduHomeAspNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.ViewModels
{
    public class EventVM
    {
        public BgImage BgImage { get; set; }
        public List<Event> Event { get; set; }
        public List<Speaker> Speakers { get; set; }
        public List<EventSpeaker> EventSpeakers { get; set; }
        public List<Blog> Blogs { get; set; }
        
    }
}
